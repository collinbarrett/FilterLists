#!/usr/bin/bash
set localdir=/home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/
set ftpdir=/var/www/api.filterlists

setlocal enableDelayedExpansion

for /F %%x in ('dir /B/D %localdir%') do (
  set FILENAME=%localdir%\%%x
  curl -T !FILENAME! sftp://$FTP_HOST/%ftpdir%/ --user $FTP_USER:$FTP_PASSWORD
)