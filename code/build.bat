@echo off
rem —борка дл€ eMaxToole
call env.bat
msbuild.exe Emera3Drv.csproj /t:Rebuild /p:Client=None /p:OS=Win /verbosity:d 
