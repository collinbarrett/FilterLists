# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1-alpine AS base
WORKDIR /app
EXPOSE 80
ENTRYPOINT ./FilterLists.Directory.Api

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build

# restore
WORKDIR /src
COPY src/FilterLists.Directory.Domain/FilterLists.Directory.Domain.csproj FilterLists.Directory.Domain/
COPY src/FilterLists.Directory.Application/FilterLists.Directory.Application.csproj FilterLists.Directory.Application/
COPY src/FilterLists.Directory.Infrastructure.Migrations/FilterLists.Directory.Infrastructure.Migrations.csproj FilterLists.Directory.Infrastructure.Migrations/
COPY src/FilterLists.Directory.Infrastructure/FilterLists.Directory.Infrastructure.csproj FilterLists.Directory.Infrastructure/
WORKDIR /src/FilterLists.Directory.Api
COPY src/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj .
RUN dotnet restore

# build
WORKDIR /src
COPY src/FilterLists.Directory.Domain/. FilterLists.Directory.Domain/
COPY src/FilterLists.Directory.Application/. FilterLists.Directory.Application/
COPY src/FilterLists.Directory.Infrastructure.Migrations/. FilterLists.Directory.Infrastructure.Migrations/
COPY src/FilterLists.Directory.Infrastructure/. FilterLists.Directory.Infrastructure/
WORKDIR /src/FilterLists.Directory.Api
COPY src/FilterLists.Directory.Api/. .
RUN dotnet publish --no-restore -c Release -o /app/publish -r linux-musl-x64 -p:PublishSingleFile=true

# package final
FROM base AS final
COPY --from=build /app/publish .