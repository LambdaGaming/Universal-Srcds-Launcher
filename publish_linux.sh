#!/bin/bash
cd src
dotnet publish -r linux-x64 -c Release
cp Assets/logo.ico bin/Release/net10.0/linux-x64/publish/logo.ico
cp ../LICENSE bin/Release/net10.0/linux-x64/publish/LICENSE
tar -C bin/Release/net10.0/linux-x64/publish -czvf usl-linux.tar.gz .
echo Finished
