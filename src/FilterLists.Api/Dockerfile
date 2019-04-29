# Context: .
# Command: docker build -f src/FilterLists.Api/Dockerfile .

# prep runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine as runtime
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
ENV DataDirectory__Path "data"
ENV ASPNETCORE_URLS "http://*:5000"
EXPOSE 5000

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build

# restore
WORKDIR /src/
COPY src/FilterLists.Data/FilterLists.Data.csproj ./FilterLists.Data/
COPY src/FilterLists.Services/FilterLists.Services.csproj ./FilterLists.Services/
WORKDIR /src/FilterLists.Api/
COPY src/FilterLists.Api/FilterLists.Api.csproj ./
RUN dotnet restore

# publish
WORKDIR /src/
COPY src/FilterLists.Data/. ./FilterLists.Data/
COPY src/FilterLists.Services/. ./FilterLists.Services/
WORKDIR /src/FilterLists.Api/
COPY src/FilterLists.Api/. ./
RUN dotnet publish -c Release -o out --no-restore

# build data tests
FROM build AS test-data
WORKDIR /tests/FilterLists.Data.Tests/
COPY tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj ./
RUN dotnet restore
COPY tests/FilterLists.Data.Tests/. ./
RUN dotnet build -c Release --no-restore
ENTRYPOINT ["dotnet", "test"]

# build services tests
FROM build AS test-services
WORKDIR /tests/FilterLists.Services.Tests/
COPY tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj ./
RUN dotnet restore
COPY tests/FilterLists.Services.Tests/. ./
RUN dotnet build -c Release --no-restore
ENTRYPOINT ["dotnet", "test"]

# run
FROM runtime as final
COPY --from=build /src/FilterLists.Api/out ./
COPY data/. ./data/
