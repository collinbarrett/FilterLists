FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY FilterLists.Api/FilterLists.Api.csproj src/FilterLists.Api/
COPY FilterLists.Services/FilterLists.Services.csproj src/FilterLists.Services/
COPY FilterLists.Data/FilterLists.Data.csproj src/FilterLists.Data/
RUN dotnet restore src/FilterLists.Api/FilterLists.Api.csproj
COPY . .
WORKDIR FilterLists.Api
RUN dotnet build FilterLists.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FilterLists.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
