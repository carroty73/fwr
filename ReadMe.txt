나를 읽어줘
carroty_terminal_v2\CarrotyApplication\bin\Debug안에 있는WindowsApplication2를 실행하면 됩니다.
개발시에는 VisualStudio가 있으시다면 폴더를 열자마자 CarrotyApplication.sln을 실행합니다만, 개발할일이 없을터이니 이 파일을 열 필요는 없겠죠.

화면이 뜨면 Baudrate는 9600으로 맞추시고 Port는 해당 컴퓨터의 포트로 맞춥니다.
포트나 통신속도가 안맞으면 통신 안되니 정확하게 맞춰주세요.

그리고 포트는 컴퓨터마다 바뀝니다. 꼭 유념해 주세요.
여기서 COM3이라고 해서 다른 컴퓨터에서도 COM3이 아닙니다.
이는 장치관리자에서 포트(COM&LPT) 메뉴를 클릭해서 포트 번호를 확인하면 됩니다.

그리고 Open하게 되면 Connected가 되는데 아마 화면에 이상한 문자가 나올때도 있고 정상적으로 나올때도 있습니다.
이것은 ASCII로 출력해서 그런거니까, 가운데쯤 있는 ASCII Combobox를 HEX로 바꾸어주면 제대로 나옵니다.

ADD CR/LF는 캐리지 리턴이니가 클릭하면 한줄식 보기좋게 나옵니다.
클릭 안하면 한줄에 계속 이어져 나옵니다.

이후 그래프 탭을 고르시면 화면에 역시 아무것도 안나올텐데
그래프 안에서 마우스 오른쪽 클릭하면 "Set Scale to Default"라는 것을 고르면 그래프가 나옵니다.


어쩌구 저쩌구