@echo off
cd src
dotnet publish -r win-x64 -c Release
copy "Assets\logo.ico" "bin\Release\net10.0\win-x64\publish\logo.ico"
copy "..\LICENSE" "bin\Release\net10.0\win-x64\publish\LICENSE"
cd "bin/Release/net10.0/win-x64/publish"
del /S *.pdb
tar acvf "../usl-windows.zip" *
copy "..\usl-windows.zip" "../../../../../"
del "..\usl-windows.zip"
echo Finished
pause
