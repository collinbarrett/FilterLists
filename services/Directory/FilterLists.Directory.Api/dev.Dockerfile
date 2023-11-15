# init base for Visual Studio debugging
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS base
WORKDIR /app
EXPOSE 80

# init build
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ENV DOTNET_CLI_TELEMETRY_OPTOUT=true

# restore API
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/FilterLists.SharedKernel.Domain.SeedWork.csproj SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/
COPY SharedKernel/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Domain/FilterLists.Directory.Domain.csproj Directory/FilterLists.Directory.Domain/
COPY Directory/FilterLists.Directory.Infrastructure/FilterLists.Directory.Infrastructure.csproj Directory/FilterLists.Directory.Infrastructure/
COPY Directory/FilterLists.Directory.Infrastructure.Migrations/FilterLists.Directory.Infrastructure.Migrations.csproj Directory/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/FilterLists.Directory.Api.Contracts/FilterLists.Directory.Api.Contracts.csproj Directory/FilterLists.Directory.Api.Contracts/
COPY Directory/FilterLists.Directory.Application/FilterLists.Directory.Application.csproj Directory/FilterLists.Directory.Application/
WORKDIR /app/Directory/FilterLists.Directory.Api
COPY Directory/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj .
RUN dotnet restore

# build API
WORKDIR /app
COPY /.editorconfig .
COPY SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/. SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/
COPY SharedKernel/FilterLists.SharedKernel.Logging/. SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Domain/. Directory/FilterLists.Directory.Domain/
COPY Directory/FilterLists.Directory.Infrastructure/. Directory/FilterLists.Directory.Infrastructure/
COPY Directory/FilterLists.Directory.Infrastructure.Migrations/. Directory/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/FilterLists.Directory.Api.Contracts/. Directory/FilterLists.Directory.Api.Contracts/
COPY Directory/FilterLists.Directory.Application/. Directory/FilterLists.Directory.Application/
WORKDIR /app/Directory/FilterLists.Directory.Api
COPY Directory/FilterLists.Directory.Api/. .
RUN dotnet publish --no-restore -o /app/publish -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Directory.Api