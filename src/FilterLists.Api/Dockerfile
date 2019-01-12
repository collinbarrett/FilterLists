FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY src/FilterLists.Api/FilterLists.Api.csproj src/FilterLists.Api/
COPY src/FilterLists.Services/FilterLists.Services.csproj src/FilterLists.Services/
COPY src/FilterLists.Data/FilterLists.Data.csproj src/FilterLists.Data/
RUN dotnet restore src/FilterLists.Api/FilterLists.Api.csproj
COPY . .
WORKDIR /src/src/FilterLists.Api
RUN dotnet build FilterLists.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FilterLists.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
