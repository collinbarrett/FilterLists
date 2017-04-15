 #!/usr/bin/env bash
for file in /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/*
do
   curl -T ${file} sftp://$FTP_HOST%/var/www/api.filterlists/${file} --user $FTP_USER:$FTP_PASSWORD
done
