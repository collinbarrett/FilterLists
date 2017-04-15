 #!/usr/bin/env bash
sftp --password=$FTP_PASSWORD $FTP_USER@$FTP_HOST:$FTP_DIR
for file in /home/travis/build/collinbarrett/FilterLists/src/FilterLists.Api/bin/Release/netcoreapp1.1/*
do
  echo "Uploading $file"
  put ${file}
done
