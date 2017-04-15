 #!/usr/bin/env bash
sshpass -p $FTP_PASSWORD scp -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/* $FTP_USER@$FTP_HOST:$FTP_DIR