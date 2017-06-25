#!/usr/bin/env bash
dotnet restore
dotnet publish -c release -r ubuntu.16.04-x64