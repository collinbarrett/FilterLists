# Context: .
# Command: docker build -f src/FilterLists.Api/Dockerfile .

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build

# restore
COPY FilterLists.Api.sln ./
WORKDIR /src/
COPY src/FilterLists.Data/FilterLists.Data.csproj ./FilterLists.Data/
COPY src/FilterLists.Services/FilterLists.Services.csproj ./FilterLists.Services/
COPY src/FilterLists.Api/FilterLists.Api.csproj ./FilterLists.Api/
WORKDIR /tests/
COPY tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj ./FilterLists.Data.Tests/
COPY tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj ./FilterLists.Services.Tests/
WORKDIR /
RUN dotnet restore

# publish
WORKDIR /src/
COPY src/FilterLists.Data/. ./FilterLists.Data/
COPY src/FilterLists.Services/. ./FilterLists.Services/
COPY src/FilterLists.Api/. ./FilterLists.Api/
WORKDIR /src/FilterLists.Api/
RUN dotnet publish -c Release -o out --no-restore

# build data tests
FROM build AS test-data
WORKDIR /tests/FilterLists.Data.Tests/
COPY tests/FilterLists.Data.Tests/. ./
RUN dotnet build -c Release --no-restore
ENTRYPOINT ["dotnet", "test"]

# build services tests
FROM build AS test-services
WORKDIR /tests/FilterLists.Services.Tests/
COPY tests/FilterLists.Services.Tests/. ./
RUN dotnet build -c Release --no-restore
ENTRYPOINT ["dotnet", "test"]

# run
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine as runtime
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
ENV DataDirectory__Path "data"
ENV ASPNETCORE_URLS "http://*:5000"
EXPOSE 5000
COPY --from=build /src/FilterLists.Api/out ./
COPY data/. ./data/
