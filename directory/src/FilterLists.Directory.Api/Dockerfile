#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["directory/src/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj", "directory/src/FilterLists.Directory.Api/"]
RUN dotnet restore "directory/src/FilterLists.Directory.Api/FilterLists.Directory.Api.csproj"
COPY . .
WORKDIR "/src/directory/src/FilterLists.Directory.Api"
RUN dotnet build "FilterLists.Directory.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FilterLists.Directory.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FilterLists.Directory.Api.dll"]
