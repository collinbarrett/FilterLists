# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1.7-alpine AS base
WORKDIR /app

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine AS build

# restore API
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj SharedKernel/FilterLists.SharedKernel.Logging/
COPY Archival/FilterLists.Archival.Infrastructure/FilterLists.Archival.Infrastructure.csproj Archival/FilterLists.Archival.Infrastructure/
COPY Archival/FilterLists.Archival.Application/FilterLists.Archival.Application.csproj Archival/FilterLists.Archival.Application/
WORKDIR /app/Archival/FilterLists.Archival.Api
COPY Archival/FilterLists.Archival.Api/FilterLists.Archival.Api.csproj .
RUN dotnet restore

# build API
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Logging/. SharedKernel/FilterLists.SharedKernel.Logging/
COPY Archival/FilterLists.Archival.Infrastructure/. Archival/FilterLists.Archival.Infrastructure/
COPY Archival/FilterLists.Archival.Application/. Archival/FilterLists.Archival.Application/
WORKDIR /app/Archival/FilterLists.Archival.Api
COPY Archival/FilterLists.Archival.Api/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Archival.Api