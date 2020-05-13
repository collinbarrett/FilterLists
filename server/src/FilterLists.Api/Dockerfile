# Context: .
# Command: docker build -f server/src/FilterLists.Api/Dockerfile .

# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:3.1.4-alpine as base
ENTRYPOINT ["./FilterLists.Api"]
EXPOSE 80
WORKDIR /app

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build

# restore
WORKDIR /app/src
COPY server/src/FilterLists.Data/FilterLists.Data.csproj FilterLists.Data/
COPY server/src/FilterLists.Data.Migrations/FilterLists.Data.Migrations.csproj FilterLists.Data.Migrations/
COPY server/src/FilterLists.Services/FilterLists.Services.csproj FilterLists.Services/
WORKDIR /app/src/FilterLists.Api
COPY server/src/FilterLists.Api/FilterLists.Api.csproj .
RUN dotnet restore

# build
WORKDIR /app/src
COPY server/src/FilterLists.Data/. FilterLists.Data/
COPY server/src/FilterLists.Data.Migrations/. FilterLists.Data.Migrations/
COPY server/src/FilterLists.Services/. FilterLists.Services/
WORKDIR /app/src/FilterLists.Api
COPY server/src/FilterLists.Api/. .
RUN dotnet build -c Release -r linux-musl-x64 --no-restore

# init Data.Tests
FROM build AS test-data
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# restore Data.Tests
WORKDIR /app/tests/FilterLists.Data.Tests
COPY server/tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj .
RUN dotnet restore

# build Data.Tests
COPY server/tests/FilterLists.Data.Tests/. .
RUN dotnet build -c Release --no-restore
COPY data/. data/

# init Services.Tests
FROM build AS test-services
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# restore Services.Tests
WORKDIR /app/tests/FilterLists.Services.Tests
COPY server/tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj .
RUN dotnet restore

# build Services.Tests
COPY server/tests/FilterLists.Services.Tests/. .
RUN dotnet build -c Release --no-restore

# publish
FROM build AS publish
RUN dotnet publish -c Release -r linux-musl-x64 -o out --no-restore --no-build

# final
FROM base as final
COPY --from=publish /app/src/FilterLists.Api/out .
