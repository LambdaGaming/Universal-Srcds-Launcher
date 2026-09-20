#!/bin/bash
cd src
dotnet publish -r linux-x64 -c Release
cp Assets/logo.ico bin/Release/net10.0/linux-x64/publish/logo.ico
cp ../LICENSE bin/Release/net10.0/linux-x64/publish/LICENSE
cp ../LICENSE-Avalonia bin/Release/net10.0/linux-x64/publish/LICENSE-Avalonia
cd bin/Release/net10.0/linux-x64/publish
rm *.dbg
tar -zcvf usl-linux.tar.gz *
cp "usl-linux.tar.gz" "../../../../../"
rm "usl-linux.tar.gz"
echo Finished
