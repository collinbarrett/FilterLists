# Context: .
# Command: docker build -f src/FilterLists.Web/Dockerfile .

# prep runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine as runtime
ENTRYPOINT ["dotnet", "FilterLists.Web.dll"]
ENV ASPNETCORE_URLS "http://*:5000"
EXPOSE 5000

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build
RUN apk add --update nodejs nodejs-npm

# restore
COPY src/FilterLists.Web/FilterLists.Web.csproj ./
RUN dotnet restore

# publish
COPY src/FilterLists.Web/. ./
RUN dotnet publish -c Release -o out --no-restore

# run
FROM runtime
COPY --from=build /out ./
