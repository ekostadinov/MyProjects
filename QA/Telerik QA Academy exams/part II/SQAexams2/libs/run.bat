echo on
@set hour=%time:~0,2%
@if "%hour:~0,1%"==" " set hour=0%time:~1,1%
@set bdTimeStamp=%date%_%hour%-%time:~3,2%_%COMPUTERNAME%

REM where the sikuli launch file is
set bdTestRunner="C:\Program Files (x86)\Sikuli X\Sikuli-IDE.bat"
REM where is the parent folder of the automated tests
set bdTestList="C:\Academy\Tests Win 7\\%1.sikuli"
echo on
call %bdTestRunner% -r %bdTestList%

set bdResultTempDir=c:\Academy\Logs
set bdResultDir=c:\Academy\Logs\%1-%bdTimeStamp%
set bdSendFrom=asya.georgieva@telerik.com
set bdSendTo=asya.georgieva@telerik.com

rem blat.exe -server <mail server name> -t %bdSendTo% -f asya.georgieva@telerik.com -s "%1 %bdTimeStamp%" -bodyf %bdResultTempDir%\Report.html -attach %bdResultTempDir%\Report.html
blat.exe -server <mail server name> -t %bdSendTo% -f %bdSendFrom% -s "%1 %bdTimeStamp%" -bodyf %bdResultTempDir%\Report.html -attach %bdResultTempDir%\Report.html

