@echo off
rem Arguments: Visual Studio installation directory, temporary test directory.
call "%~1\VC\Auxiliary\Build\vcvars64.bat" >nul
if errorlevel 1 exit /b 1
cl /nologo /std:c++20 /EHsc /W4 /utf-8 "%~dp0OutputTests.cpp" /Fe:"%~2\OutputTests.exe" /Fo:"%~2\OutputTests.obj" /link user32.lib
if errorlevel 1 exit /b 1
pushd "%~2"
OutputTests.exe > console-utf16.txt 2> errors-utf16.txt
set "testExit=%errorlevel%"
popd
exit /b %testExit%
