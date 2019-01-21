FROM microsoft/dotnet:2.2-sdk-alpine AS publish
RUN apk add --update nodejs-npm

WORKDIR /app
COPY FilterLists.Web.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine
WORKDIR /app
COPY --from=publish /out .
ENV ASPNETCORE_URLS http://+:80
ENTRYPOINT ["dotnet", "FilterLists.Web.dll"]