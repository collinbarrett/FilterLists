 #!/usr/bin/env bash
 #TODO: use ssh keys rather than pw
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/* $FTP_USER@$FTP_HOST:$FTP_DIR