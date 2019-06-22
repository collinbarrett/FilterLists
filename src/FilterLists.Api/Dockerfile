# Context: .
# Command: docker build -f src/FilterLists.Api/Dockerfile .

# init base
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine as base
WORKDIR /app
ENV DataDirectory__Path "data"
EXPOSE 80
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build

# restore
WORKDIR /app/src
COPY src/FilterLists.Data/FilterLists.Data.csproj FilterLists.Data/
COPY src/FilterLists.Services/FilterLists.Services.csproj FilterLists.Services/
WORKDIR /app/src/FilterLists.Api
COPY src/FilterLists.Api/FilterLists.Api.csproj .
RUN dotnet restore

# build
WORKDIR /app/src
COPY src/FilterLists.Data/. FilterLists.Data/
COPY src/FilterLists.Services/. FilterLists.Services/
WORKDIR /app/src/FilterLists.Api
COPY src/FilterLists.Api/. .
RUN dotnet build -c Release --no-restore

# init Data.Tests
FROM build AS test-data
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# restore Data.Tests
WORKDIR /app/tests/FilterLists.Data.Tests
COPY tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj .
RUN dotnet restore

# build Data.Tests
COPY tests/FilterLists.Data.Tests/. .
RUN dotnet build -c Release --no-restore
COPY data/. data/

# init Services.Tests
FROM build AS test-services
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# restore Services.Tests
WORKDIR /app/tests/FilterLists.Services.Tests
COPY tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj .
RUN dotnet restore

# build Services.Tests
COPY tests/FilterLists.Services.Tests/. .
RUN dotnet build -c Release --no-restore

# publish
FROM build AS publish
RUN dotnet publish -c Release -o out --no-restore --no-build

# final
FROM base as final
COPY --from=publish /app/src/FilterLists.Api/out .
COPY data/. data/
