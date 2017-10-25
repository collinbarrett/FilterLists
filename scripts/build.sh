#!/usr/bin/bash -x
dotnet restore
dotnet publish -c release -r ubuntu.16.04-x64