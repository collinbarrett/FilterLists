#!/usr/bin/env bash
dotnet restore
dotnet publish -c release -r ubuntu.18.04-x64