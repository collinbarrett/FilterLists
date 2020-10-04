# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1-alpine3.12 AS base
LABEL org.opencontainers.image.description="filterlists.com | github.com/collinbarrett/filterlists | An ASP.NET Core app archiving and serving copies of FilterLists for mirrors and analysis."
WORKDIR /app
EXPOSE 80

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine3.12 AS build
ENV DOTNET_CLI_TELEMETRY_OPTOUT=true

# restore API
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Api.Contracts/FilterLists.Directory.Api.Contracts.csproj Directory/FilterLists.Directory.Api.Contracts/
COPY Archival/FilterLists.Archival.Domain/FilterLists.Archival.Domain.csproj Archival/FilterLists.Archival.Domain/
COPY Archival/FilterLists.Archival.Infrastructure/FilterLists.Archival.Infrastructure.csproj Archival/FilterLists.Archival.Infrastructure/
COPY Archival/FilterLists.Archival.Application/FilterLists.Archival.Application.csproj Archival/FilterLists.Archival.Application/
WORKDIR /app/Archival/FilterLists.Archival.Api
COPY Archival/FilterLists.Archival.Api/FilterLists.Archival.Api.csproj .
RUN dotnet restore

# build API
WORKDIR /app
COPY /.editorconfig .
COPY SharedKernel/FilterLists.SharedKernel.Logging/. SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Api.Contracts/. Directory/FilterLists.Directory.Api.Contracts/
COPY Archival/FilterLists.Archival.Domain/. Archival/FilterLists.Archival.Domain/
COPY Archival/FilterLists.Archival.Infrastructure/. Archival/FilterLists.Archival.Infrastructure/
COPY Archival/FilterLists.Archival.Application/. Archival/FilterLists.Archival.Application/
WORKDIR /app/Archival/FilterLists.Archival.Api
COPY Archival/FilterLists.Archival.Api/. .
RUN dotnet publish -c Release --no-restore -o /app/publish -p:TreatWarningsAsErrors=true -p:DebugType=None -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true -r alpine.3.12-x64

# package final
FROM base AS final
COPY --from=build /app/publish .
ENTRYPOINT ./FilterLists.Archival.Api