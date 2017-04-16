 #!/usr/bin/env bash
 #TODO: use ssh keys rather than pw
 sudo chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/ubuntu.16.04-x64/FilterLists.Api.dll
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/ubuntu.16.04-x64/* $FTP_USER@$FTP_HOST:$FTP_DIR