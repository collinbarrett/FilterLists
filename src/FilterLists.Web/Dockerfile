FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY FilterLists.Web/FilterLists.Web.csproj src/FilterLists.Web/
RUN dotnet restore src/FilterLists.Web/FilterLists.Web.csproj
COPY . .
WORKDIR FilterLists.Web
RUN dotnet build FilterLists.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FilterLists.Web.csproj -c Release -o /app

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS final
WORKDIR /app
COPY --from=publish /app .
EXPOSE 5001
ENTRYPOINT ["dotnet", "FilterLists.Web.dll"]
