FROM microsoft/dotnet:2.2-sdk-alpine AS publish
COPY FilterLists.Api /FilterLists.Api
COPY FilterLists.Data /FilterLists.Data
COPY FilterLists.Services /FilterLists.Services
RUN dotnet publish FilterLists.Api/FilterLists.Api.csproj -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine AS final
COPY --from=publish /out .
ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]