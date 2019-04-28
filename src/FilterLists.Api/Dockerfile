# Context: .
# Command: docker build -f src/FilterLists.Api/Dockerfile .

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build

# restore
WORKDIR /src/
COPY src/FilterLists.Data/FilterLists.Data.csproj ./FilterLists.Data/
COPY src/FilterLists.Services/FilterLists.Services.csproj ./FilterLists.Services/
COPY src/FilterLists.Api/FilterLists.Api.csproj ./FilterLists.Api/
WORKDIR /src/FilterLists.Api/
RUN dotnet restore

# publish
WORKDIR /src/
COPY src/FilterLists.Data/. ./FilterLists.Data/
COPY src/FilterLists.Services/. ./FilterLists.Services/
COPY src/FilterLists.Api/. ./FilterLists.Api/
WORKDIR /src/FilterLists.Api/
RUN dotnet publish -c Release -o out --no-restore

# restore data tests
# FROM build AS test-data
# COPY tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj ./tests/FilterLists.Data.Tests/
# RUN dotnet restore tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj

# build data tests
# COPY tests/FilterLists.Data.Tests/. ./tests/FilterLists.Data.Tests/
# RUN dotnet build tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj -c Release --no-restore
# ENTRYPOINT ["dotnet", "test", "./tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj"]

# restore services tests
# FROM build AS test-services
# COPY tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj ./tests/FilterLists.Services.Tests/
# RUN dotnet restore tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj

# build services tests
# COPY tests/FilterLists.Services.Tests/. ./tests/FilterLists.Services.Tests/
# RUN dotnet build tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj -c Release --no-restore
# ENTRYPOINT ["dotnet", "test", "./tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj"]

# run
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine as runtime
EXPOSE 5000
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
COPY --from=build /src/FilterLists.Api/out ./
COPY data/. ./data/
