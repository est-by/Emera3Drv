@echo off
rem ������ ��� eMaxToole
call env.bat
msbuild.exe Emera3Drv.csproj /t:Rebuild /p:Client=None /p:OS=Win /verbosity:d 
