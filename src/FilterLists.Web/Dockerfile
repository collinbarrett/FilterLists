FROM microsoft/dotnet:2.2-sdk AS publish
COPY FilterLists.Web /FilterLists.Web
RUN curl -sL https://deb.nodesource.com/setup_10.x | bash - \
	&& apt-get install -y nodejs \
	&& dotnet publish FilterLists.Web/FilterLists.Web.csproj -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS final
COPY --from=publish /out .
ENV ASPNETCORE_URLS http://+:5001
EXPOSE 5001
ENTRYPOINT ["dotnet", "FilterLists.Web.dll"]
