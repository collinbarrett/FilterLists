FROM microsoft/dotnet:2.2-sdk AS publish
COPY FilterLists.Api /FilterLists.Api
COPY FilterLists.Data /FilterLists.Data
COPY FilterLists.Services /FilterLists.Services
RUN dotnet publish FilterLists.Api/FilterLists.Api.csproj -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS final
COPY --from=publish /out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "FilterLists.Api.dll"]
