@ECHO OFF
SETLOCAL ENABLEDELAYEDEXPANSION

REM =======MAKE SURE TO ADJUST THESE PARAMETERS TO YOUR BUILD=======
set unrealPath="C:\Program Files\Epic Games\UE_5.3\Engine\Binaries\Win64\UnrealEditor.exe"

set myProject="D:\MarketPlace\MarketPlaceDemo-5.3\EosSessionDemo\EosSessionDemo.uproject"

set map=/Game/ThirdPerson/Maps/Login

REM=================================================================

set LF=^


REM Two empty lines above are necessary

REM =====================NOTES====================================
REM can add -server to boot as a server (instead of a game)
REM can add -game to boot as a game
REM can add -log
REM can add a map via: /Game/<PathAfterContentFolder>ExampleMapName -game -log
REM can add an IP address instead of the map
REM can add ?listen directly after ExampleMapName for Host machines (e.g., Play and Host) (without the -server tag)
REM =============================================================

REM Set myIP and port to blank (uncomment the bottom lines, comment the top lines) to use user-prompted values
set myIP=192.168.31.31
REM set "myIP="

set port=7777
REM set "port="
REM =============================================================

set "launched="
set /a clients=0
set /a servers=0
set /a hosts=0
set /a standalones=0

if "!myIP!"=="" (
	set /p myIP="Enter a custom IP:!LF!"
)

if "!port!"=="" (
	echo.
	set /p port="Enter a custom port:!LF!"
)

:LAUNCH

echo.
echo 	Local IP: "!myIP!"
echo.
echo 	Local Port: "!port!"
echo.

if not "!launched!"=="" (
	echo 	Launched: !launched!
) else (
	echo 	Launched: none
)
echo.

set "launchType="
set /p launchType="AiShow Launch as standalone (blank), server (s), host (h), or client (c)?!LF!"

echo.

if "!launchType!"=="" (
	set launched=!launched!Standalone, 

	set launchParams=!map! -game -log

	set /a standalones=!standalones!+1
	set launchType=standalone!standalones!
)

if /I "!launchType!"=="c" (
	set launched=!launched!Client, 

	set launchParams=!myIP!:!port! -game -log -ResX=800 -ResY=1000 -WinX=0 -WinY=20

	set /a clients=!clients!+1
	set launchType=client !clients!
)

if /I "!launchType!"=="s" (
	set launched=!launched!Server, 

	set launchParams=!map! -server -log
	
	set /a servers=!servers!+1
	set launchType=server !servers!
)

if /I "!launchType!"=="h" (
	set launched=!launched!Host, 

	set launchParams=!map!?listen -game -log -ResX=800 -ResY=1000 -WinX=0 -WinY=20
	
	set /a hosts=!hosts!+1
	set launchType=host !hosts!
)

set launch="UnrealEngine !launchType!" !unrealPath! !myProject! !launchParams!

echo start !launch!
Start !launch!
echo.

cls

GOTO LAUNCH