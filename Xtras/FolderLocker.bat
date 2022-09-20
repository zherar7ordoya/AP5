CLS
@ECHO OFF
TITLE Folder Locker

IF EXIST "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" GOTO UNLOCK
IF NOT EXIST Locker GOTO MDLOCKER

:CONFIRM
    ECHO Lock the folder? (Y/N)
    set/p "cho=>"
    IF %cho%==Y GOTO LOCK
    IF %cho%==y GOTO LOCK
    IF %cho%==n GOTO END
    IF %cho%==N GOTO END

    ECHO Invalid choice
    GOTO CONFIRM

:LOCK
    REN     Locker "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    ATTRIB  +h +s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    ECHO    Folder locked
    GOTO    END

:UNLOCK
    ECHO    Enter unlocker password: 
    set/p   "pass=>"
    IF NOT  %pass%==CSharp GOTO FAIL
    ATTRIB  -h -s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    REN     "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" Locker
    ECHO    Folder unlocked successfully
    CD      Locker
    ECHO    You can now close this window
            brave-portable
    GOTO    END

:FAIL
    ECHO Invalid password
    GOTO END

:MDLOCKER
    MD   Locker
    ECHO Locker created successfully
    GOTO END

:END