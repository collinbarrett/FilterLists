# Context: .
# Command: docker build -f src/FilterLists.Api/Dockerfile .

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build
WORKDIR /app

COPY src/FilterLists.Data/. ./FilterLists.Data/
COPY src/FilterLists.Services/. ./FilterLists.Services/
COPY src/FilterLists.Api/. ./FilterLists.Api/
RUN dotnet publish FilterLists.Api/FilterLists.Api.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine
WORKDIR /app
COPY --from=build /app/FilterLists.Api/out ./
COPY data/. ./data/
ENV DataDirectory:Path="data"
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]