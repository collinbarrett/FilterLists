# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1.7-alpine AS base
LABEL org.opencontainers.image.description="filterlists.com | github.com/collinbarrett/filterlists | An ASP.NET Core API CRUD-ing with a Postgres instance via EF Core."
WORKDIR /app
EXPOSE 80

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine AS build
ENV DOTNET_CLI_TELEMETRY_OPTOUT=true

# restore API
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Domain/FilterLists.Directory.Domain.csproj Directory/FilterLists.Directory.Domain/
COPY Directory/FilterLists.Directory.Infrastructure/FilterLists.Directory.Infrastructure.csproj Directory/FilterLists.Directory.Infrastructure/
COPY Directory/FilterLists.Directory.Infrastructure.Migrations/FilterLists.Directory.Infrastructure.Migrations.csproj Directory/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/FilterLists.Directory.Application/FilterLists.Directory.Application.csproj Directory/FilterLists.Directory.Application/
WORKDIR /app/Directory/FilterLists.Directory.Api
COPY Directory/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj .
RUN dotnet restore

# build API
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Logging/. SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Domain/. Directory/FilterLists.Directory.Domain/
COPY Directory/FilterLists.Directory.Infrastructure/. Directory/FilterLists.Directory.Infrastructure/
COPY Directory/FilterLists.Directory.Infrastructure.Migrations/. Directory/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/FilterLists.Directory.Application/. Directory/FilterLists.Directory.Application/
WORKDIR /app/Directory/FilterLists.Directory.Api
COPY Directory/FilterLists.Directory.Api/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Directory.Api