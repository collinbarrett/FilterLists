# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1.7-alpine AS base
WORKDIR /app

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine AS build

# restore
WORKDIR /src/FilterLists.Archival.Api
COPY archival/src/FilterLists.Archival.Api/FilterLists.Archival.Api.csproj .
RUN dotnet restore

# build
COPY archival/src/FilterLists.Archival.Api/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Archival.Api