 #!/usr/bin/env bash
sudo dotnet restore && sudo dotnet publish -c Release -r ubuntu.16.04-x64 -f netcoreapp1.1