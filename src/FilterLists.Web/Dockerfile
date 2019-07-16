# Context: .
# Command: docker build -f src/FilterLists.Web/Dockerfile .

# init base
FROM mcr.microsoft.com/dotnet/core/runtime-deps:2.2-alpine as base
EXPOSE 80
ENTRYPOINT ["./FilterLists.Web"]
WORKDIR /app

# init build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build
WORKDIR /app
RUN apk add --update nodejs nodejs-npm

# restore
COPY FilterLists.Web.sln ./
WORKDIR /app/src/FilterLists.Web/
COPY src/FilterLists.Web/FilterLists.Web.csproj ./
WORKDIR /app
RUN dotnet restore

# publish
WORKDIR /app/src/FilterLists.Web/
COPY src/FilterLists.Web/. ./
RUN dotnet publish -c Release -r linux-musl-x64 -o out --no-restore

# run
FROM base as final
COPY --from=build /app/src/FilterLists.Web/out ./
