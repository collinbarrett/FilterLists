#!/usr/bin/env bash
set -x
chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp2.0/ubuntu.16.04-x64/publish/FilterLists.Api.dll
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp2.0/ubuntu.16.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR
sshpass -p $FTP_PASSWORD ssh -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST 'sudo systemctl restart filterlists.api.service'
chmod a+x /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Web/bin/Release/netcoreapp2.0/ubuntu.16.04-x64/publish/FilterLists.Web.dll
sshpass -p $FTP_PASSWORD scp -o StrictHostKeyChecking=no -r /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Web/bin/Release/netcoreapp2.0/ubuntu.16.04-x64/publish/* $FTP_USER@$FTP_HOST:$FTP_DIR
sshpass -p $FTP_PASSWORD ssh -o StrictHostKeyChecking=no $FTP_USER@$FTP_HOST 'sudo systemctl restart filterlists.web.service'
curl -X DELETE "https://api.cloudflare.com/client/v4/zones/$CF_FILTERLISTS_ZONE/purge_cache" -H "X-Auth-Email: $CF_EMAIL" -H "X-Auth-Key: $CF_GLOBAL_API_KEY" -H "Content-Type: application/json" --data '{"purge_everything":true}'