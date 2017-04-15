 #!/usr/bin/env bash
export SSHPASS=$FTP_PASSWORD
sshpass -e sftp -oBatchMode=no -b - $FTP_USER@$FTP_HOST:$FTP_DIR << !
   put -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/*
   bye