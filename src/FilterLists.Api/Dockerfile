FROM microsoft/dotnet:2.2-sdk-alpine AS publish
WORKDIR /app
COPY src/FilterLists.Data/FilterLists.Data.csproj ./FilterLists.Data/
COPY src/FilterLists.Services/FilterLists.Services.csproj ./FilterLists.Services/
COPY src/FilterLists.Api/FilterLists.Api.csproj ./FilterLists.Api/
WORKDIR /app/FilterLists.Api
RUN dotnet restore

WORKDIR /app
COPY src/FilterLists.Data/. ./FilterLists.Data/
COPY src/FilterLists.Services/. ./FilterLists.Services/
COPY src/FilterLists.Api/. ./FilterLists.Api/
WORKDIR /app/FilterLists.Api
RUN dotnet publish -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine
WORKDIR /app
COPY --from=publish /out .
COPY data ./data/
ENV ASPNETCORE_URLS http://+:80
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]