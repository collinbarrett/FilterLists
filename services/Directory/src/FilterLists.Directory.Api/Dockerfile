# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1.7-alpine AS base
WORKDIR /app
EXPOSE 80

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine AS build

# restore API
WORKDIR /app
COPY SharedKernel/src/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj SharedKernel/src/FilterLists.SharedKernel.Logging/
COPY Directory/src/FilterLists.Directory.Domain/FilterLists.Directory.Domain.csproj Directory/src/FilterLists.Directory.Domain/
COPY Directory/src/FilterLists.Directory.Infrastructure/FilterLists.Directory.Infrastructure.csproj Directory/src/FilterLists.Directory.Infrastructure/
COPY Directory/src/FilterLists.Directory.Infrastructure.Migrations/FilterLists.Directory.Infrastructure.Migrations.csproj Directory/src/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/src/FilterLists.Directory.Application/FilterLists.Directory.Application.csproj Directory/src/FilterLists.Directory.Application/
WORKDIR /app/Directory/src/FilterLists.Directory.Api
COPY Directory/src/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj .
RUN dotnet restore

# build API
WORKDIR /app
COPY SharedKernel/src/FilterLists.SharedKernel.Logging/. SharedKernel/src/FilterLists.SharedKernel.Logging/
COPY Directory/src/FilterLists.Directory.Domain/. Directory/src/FilterLists.Directory.Domain/
COPY Directory/src/FilterLists.Directory.Infrastructure/. Directory/src/FilterLists.Directory.Infrastructure/
COPY Directory/src/FilterLists.Directory.Infrastructure.Migrations/. Directory/src/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/src/FilterLists.Directory.Application/. Directory/src/FilterLists.Directory.Application/
WORKDIR /app/Directory/src/FilterLists.Directory.Api
COPY Directory/src/FilterLists.Directory.Api/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Directory.Api