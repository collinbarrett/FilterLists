# Context: src
# Command: docker build -f FilterLists.Api/Dockerfile .

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build
WORKDIR /app

COPY FilterLists.Data/. ./FilterLists.Data/
COPY FilterLists.Services/. ./FilterLists.Services/
COPY FilterLists.Api/. ./FilterLists.Api/
RUN dotnet publish FilterLists.Api/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine
WORKDIR /app
COPY --from=build /app/FilterLists.Api/out ./
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]