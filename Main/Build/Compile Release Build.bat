@ECHO OFF

"%SystemRoot%\Microsoft.NET\Framework\v3.5\MSBuild.exe" /nologo /t:Compile /p:Configuration=Release

PAUSE