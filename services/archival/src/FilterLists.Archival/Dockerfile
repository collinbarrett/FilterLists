# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1-alpine AS base
WORKDIR /app

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine AS build

# restore
WORKDIR /src/FilterLists.Archival
COPY archival/src/FilterLists.Archival/FilterLists.Archival.csproj .
RUN dotnet restore

# build
COPY archival/src/FilterLists.Archival/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Archival