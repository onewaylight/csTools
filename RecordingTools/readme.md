
EBS 반디 레코딩 Tools

ffmpeg.exe가 필요합니다.

[이곳에서](https://www.ffmpeg.org/) 다운로드 받으실 수 있습니다.

```shell
recRun.bat 7200 
```

두시간 동안 녹음을 진행한 후 자동으로 종료합니다.

숫자는 초를 의미합니다.

- 10분은 600
- 1시간은 3600
- 2시간은 7200 입니다

현재 작업 디렉토리는 ```D:\Record\ffmpeg\bin\``` 입니다.

녹음 파일의 저장위치는 MP3_FILE_NAME의 내용을 수정하시면 됩니다.

```
SET MP3_FILE_NAME="D:\Record\REC_%fullstamp%.mp3"
```

ffmpeg 파일의 정확한 위치를 알려주어야 합니다.

```
D:\Record\ffmpeg\bin\ffmpeg -t %RECORDING_SECS% -y -f dshow -i audio=%DEVICE_NAME% %MP3_FILE_NAME%
```

파이어폭스 실행후 EBS 반디 홈페이지로 이동해서 재생합니다.

사용자 개입없이 자동으로 오디오가 재생됩니다.

안될 경우 파이어폭스의 옵션중 실행후 자동으로 Audio로 재생하도록 하는 옵션이 있습니다.

> EBS의 본방 라디오와 재방송인 반디의 재생 주소가 다릅니다.

> 조금 귀찮아서 실행파일을 별도로 만들어 두었는데 본방일 경우 반디일 경우 샐행파일을 달리하시면 됩니다.

> 저는 작업스케쥴러에 등록해서 매일 녹음을 해두었다가 다시 듣곤 합니다.

? 작업스케쥴러 등록은 간단하게 하실 수 있습니다. 


```shell
runBandiFirefox.exe 7200
```

뒤에 숫자는 재생할 시간입니다. 위와 동일합니다.

레코딩을위해서 "Stereo Mix"가 Enable되어 있어야 합니다.

![Stereo Mix](stereoMix.jpg)

"Stereo Mix"가 없을 경우 사운도카드의 드라이버를 설치하게 되면 나타납니다.

ASUS 나 GigaByte 메인보드의 Audio Driver설치이후 나타남을 확인했습니다.

Stereo Mix가 나타나지 않는 경우 검색해 보시면 많은 자료들이 있으니 적절한 자료를 찾아서 시도해보세요~ ^^


