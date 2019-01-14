FROM microsoft/dotnet:2.2-sdk-alpine AS publish
COPY FilterLists.Web /FilterLists.Web
RUN apk add --update nodejs-npm \
	&& dotnet publish FilterLists.Web/FilterLists.Web.csproj -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine AS final
COPY --from=publish /out .
ENV ASPNETCORE_URLS http://+:5001
EXPOSE 5001
ENTRYPOINT ["dotnet", "FilterLists.Web.dll"]