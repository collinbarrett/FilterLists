 #!/usr/bin/env bash
set localdir=/home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/
set ftpdir=/var/www/api.filterlists

for file in %localdir%*
do
   curl -T ${file} sftp://$FTP_HOST%ftpdir%/${file} --user $FTP_USER:$FTP_PASSWORD
done
