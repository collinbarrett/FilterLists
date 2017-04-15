@echo off 
set localdir=/home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/
set ftphost=$FTP_HOST
set ftpuser=$FTP_USER
set ftppass=$FTP_PASSWORD
set ftpdir=/var/www/api.filterlists

setlocal enableDelayedExpansion

for /F %%x in ('dir /B/D %localdir%') do (
  set FILENAME=%localdir%\%%x
  curl -T !FILENAME! sftp://%ftphost%/%ftpdir%/ --user %ftpuser%:%ftppass%
)