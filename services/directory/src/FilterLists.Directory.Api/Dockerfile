# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1.7-alpine AS base
WORKDIR /app
EXPOSE 80

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1.401-alpine AS build

# restore API
WORKDIR /app
COPY sharedKernel/src/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj sharedKernel/src/FilterLists.SharedKernel.Logging/
COPY directory/src/FilterLists.Directory.Domain/FilterLists.Directory.Domain.csproj directory/src/FilterLists.Directory.Domain/
COPY directory/src/FilterLists.Directory.Infrastructure/FilterLists.Directory.Infrastructure.csproj directory/src/FilterLists.Directory.Infrastructure/
COPY directory/src/FilterLists.Directory.Infrastructure.Migrations/FilterLists.Directory.Infrastructure.Migrations.csproj directory/src/FilterLists.Directory.Infrastructure.Migrations/
COPY directory/src/FilterLists.Directory.Application/FilterLists.Directory.Application.csproj directory/src/FilterLists.Directory.Application/
WORKDIR /app/directory/src/FilterLists.Directory.Api
COPY directory/src/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj .
RUN dotnet restore

# build API
WORKDIR /app
COPY sharedKernel/src/FilterLists.SharedKernel.Logging/. sharedKernel/src/FilterLists.SharedKernel.Logging/
COPY directory/src/FilterLists.Directory.Domain/. directory/src/FilterLists.Directory.Domain/
COPY directory/src/FilterLists.Directory.Infrastructure/. directory/src/FilterLists.Directory.Infrastructure/
COPY directory/src/FilterLists.Directory.Infrastructure.Migrations/. directory/src/FilterLists.Directory.Infrastructure.Migrations/
COPY directory/src/FilterLists.Directory.Application/. directory/src/FilterLists.Directory.Application/
WORKDIR /app/directory/src/FilterLists.Directory.Api
COPY directory/src/FilterLists.Directory.Api/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r linux-musl-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Directory.Api