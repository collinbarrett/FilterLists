# init test-migrations
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS test-migrations
ENV DOTNET_CLI_TELEMETRY_OPTOUT=true
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# restore
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/FilterLists.SharedKernel.Domain.SeedWork.csproj SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/
COPY SharedKernel/FilterLists.SharedKernel.Logging/FilterLists.SharedKernel.Logging.csproj SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Domain/FilterLists.Directory.Domain.csproj Directory/FilterLists.Directory.Domain/
COPY Directory/FilterLists.Directory.Infrastructure/FilterLists.Directory.Infrastructure.csproj Directory/FilterLists.Directory.Infrastructure/
COPY Directory/FilterLists.Directory.Infrastructure.Migrations/FilterLists.Directory.Infrastructure.Migrations.csproj Directory/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/FilterLists.Directory.Api.Contracts/FilterLists.Directory.Api.Contracts.csproj Directory/FilterLists.Directory.Api.Contracts/
COPY Directory/FilterLists.Directory.Application/FilterLists.Directory.Application.csproj Directory/FilterLists.Directory.Application/
COPY Directory/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj Directory/FilterLists.Directory.Api/
WORKDIR /app/Directory/FilterLists.Directory.Infrastructure.Migrations.Tests
COPY Directory/FilterLists.Directory.Infrastructure.Migrations.Tests/FilterLists.Directory.Infrastructure.Migrations.Tests.csproj .
RUN dotnet restore

# build
WORKDIR /app
COPY SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/. SharedKernel/FilterLists.SharedKernel.Domain.SeedWork/
COPY SharedKernel/FilterLists.SharedKernel.Logging/. SharedKernel/FilterLists.SharedKernel.Logging/
COPY Directory/FilterLists.Directory.Domain/. Directory/FilterLists.Directory.Domain/
COPY Directory/FilterLists.Directory.Infrastructure/. Directory/FilterLists.Directory.Infrastructure/
COPY Directory/FilterLists.Directory.Infrastructure.Migrations/. Directory/FilterLists.Directory.Infrastructure.Migrations/
COPY Directory/FilterLists.Directory.Api.Contracts/. Directory/FilterLists.Directory.Api.Contracts/
COPY Directory/FilterLists.Directory.Application/. Directory/FilterLists.Directory.Application/
COPY Directory/FilterLists.Directory.Api/. Directory/FilterLists.Directory.Api/
WORKDIR /app/Directory/FilterLists.Directory.Infrastructure.Migrations.Tests
COPY Directory/FilterLists.Directory.Infrastructure.Migrations.Tests/. .
RUN dotnet build -c Release --no-restore -p:TreatWarningsAsErrors=true -r linux-musl-x64 --self-contained true