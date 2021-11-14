@echo off
for /f "tokens=2 delims==" %%a in ('wmic OS Get localdatetime /value') do set "dt=%%a"
set "YY=%dt:~2,2%" & set "YYYY=%dt:~0,4%" & set "MM=%dt:~4,2%" & set "DD=%dt:~6,2%"
set "HH=%dt:~8,2%" & set "Min=%dt:~10,2%" & set "Sec=%dt:~12,2%"

set "datestamp=%YYYY%%MM%%DD%" & set "timestamp=%HH%%Min%%Sec%"
set "fullstamp=%YYYY%-%MM%-%DD%_%HH%-%Min%-%Sec%"
echo datestamp: "%datestamp%"
echo timestamp: "%timestamp%"
echo fullstamp: "%fullstamp%"

SET MP3_FILE_NAME="D:\Studies\REC_%fullstamp%.mp3"
SET DEVICE_NAME="Stereo Mix (3- Realtek High Definition Audio)"
SET RECORDING_SECS=600
D:\Studies\ffmpeg\bin\ffmpeg -t %RECORDING_SECS% -y -f dshow -i audio=%DEVICE_NAME% %MP3_FILE_NAME%