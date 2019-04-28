# Context: .
# Command: docker build -f src/FilterLists.Api/Dockerfile .

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build

# restore
COPY ./FilterLists.Api.sln ./
COPY src/*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p src/${file%.*}/ && mv $file src/${file%.*}/; done
COPY tests/*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p tests/${file%.*}/ && mv $file tests/${file%.*}/; done
RUN dotnet restore

# build
COPY src/FilterLists.Data/. ./FilterLists.Data/
COPY src/FilterLists.Services/. ./FilterLists.Services/
COPY src/FilterLists.Api/. ./FilterLists.Api/
COPY tests/FilterLists.Data.Tests/. ./tests/FilterLists.Data.Tests/
COPY tests/FilterLists.Services.Tests/. ./tests/FilterLists.Services.Tests/
RUN dotnet build -c Release --no-restore

# test
RUN dotnet test "./tests/FilterLists.Data.Tests/FilterLists.Data.Tests.csproj" -c Release --no-build --no-restore
RUN dotnet test "./tests/FilterLists.Services.Tests/FilterLists.Services.Tests.csproj" -c Release --no-build --no-restore

# publish
RUN dotnet publish FilterLists.Api/FilterLists.Api.csproj -c Release -o out --no-build --no-restore

# run
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine
ENV DataDirectory:Path="data"
ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
COPY --from=build /FilterLists.Api/out ./
