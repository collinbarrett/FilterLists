# Context: .
# Command: docker build -f server/src/FilterLists.Agent/debug.Dockerfile .

# init base debug (for VS)
FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app
