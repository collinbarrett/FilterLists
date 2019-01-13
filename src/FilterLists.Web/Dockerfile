FROM microsoft/dotnet:2.2-sdk AS publish
COPY FilterLists.Web /FilterLists.Web
RUN dotnet publish FilterLists.Web/FilterLists.Web.csproj -c Release -o /out

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS final
COPY --from=publish /out .
EXPOSE 5001
ENTRYPOINT ["dotnet", "FilterLists.Web.dll"]
