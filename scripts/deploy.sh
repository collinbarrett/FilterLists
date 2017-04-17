#!/usr/bin/env bash
#TODO: use ssh keys rather than pw
chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netstandard1.6/ubuntu.16.04-x64/publish/FilterLists.Api.dll
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netstandard1.6/ubuntu.16.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR