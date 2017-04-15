 #!/usr/bin/env bash
sshpass -p $FTP_PASSWORD ssh -tt -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST << !
   cd $FTP_DIR
   put -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/*
   bye