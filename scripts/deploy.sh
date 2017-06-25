#!/usr/bin/env bash
#TODO: use ssh keys rather than pw
chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/ubuntu.16.04-x64/publish/FilterLists.Api.dll
chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/ubuntu.16.04-x64/publish/FilterLists.DataLoad
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/ubuntu.16.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.DataLoad/bin/Release/netcoreapp1.1/ubuntu.16.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR