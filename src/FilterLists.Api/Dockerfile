FROM microsoft/dotnet:2.2-sdk-alpine AS publish
COPY src/FilterLists.Api /FilterLists.Api
COPY src/FilterLists.Data /FilterLists.Data
COPY src/FilterLists.Services /FilterLists.Services
RUN dotnet publish FilterLists.Api/FilterLists.Api.csproj -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine
COPY --from=publish /out .
COPY data /data
ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]