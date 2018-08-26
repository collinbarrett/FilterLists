#!/usr/bin/env bash

#deploy seed data
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/data/ $FTP_USER@$FTP_HOST:$FTP_DIR

#deploy API
sshpass -p $FTP_PASSWORD ssh -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST 'sudo systemctl stop filterlists.api.service'
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp2.1/ubuntu.18.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR
sshpass -p $FTP_PASSWORD ssh -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST 'sudo systemctl start filterlists.api.service'

#deploy Web
sshpass -p $FTP_PASSWORD ssh -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST 'sudo systemctl stop filterlists.web.service'
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Web/bin/Release/netcoreapp2.1/ubuntu.18.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR
sshpass -p $FTP_PASSWORD ssh -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST 'sudo systemctl start filterlists.web.service'

#deploy Agent
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Agent/bin/Release/netcoreapp2.1/ubuntu.18.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR

#purge CDN
#curl -X DELETE "https://api.cloudflare.com/client/v4/zones/$CF_FILTERLISTS_ZONE/purge_cache" -H "X-Auth-Email: $CF_EMAIL" -H "X-Auth-Key: $CF_GLOBAL_API_KEY" -H "Content-Type: application/json" --data '{"purge_everything":true}'