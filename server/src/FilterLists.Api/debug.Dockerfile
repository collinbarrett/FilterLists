# Context: .
# Command: docker build -f server/src/FilterLists.Api/debug.Dockerfile .

# init base debug (for VS)
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
EXPOSE 80
COPY data/. data/
WORKDIR /app
