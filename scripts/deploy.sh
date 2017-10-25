#!/usr/bin/env bash
sshpass -p $FTP_PASSWORD ssh $FTP_USER@$FTP_HOST 'cd $FTP_DIR && rm -rf *'
chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp2.0/ubuntu.16.04-x64/publish/FilterLists.Api.dll
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp2.0/ubuntu.16.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR