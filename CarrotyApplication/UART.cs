using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;

namespace CarrotyApplication {

    #region 
    /*
    UART 클래스는 
    1. SerialPort 객체를 생성하되
    2. ini 파일로부터 속성값을 읽어들여 생성하고 (ini 파일이 없으면 디폴트값으로 생성, 있으면 읽어들인다.)
    3. open할때 속성값을 저장하고
    4. 데이터를 보내고
    5. 스레드를 써서 읽어들인다.
     */
    #endregion

    class UART : System.IO.Ports.SerialPort {

        // UART 설정 기본값 : 9600-8-N-1
        #region         
        public const int DEFAULT_BAUD_RATE = 9600;
        public const int DEFAULT_DATA_BITS = 8;
        public const string DEFAULT_STOP_BITS = "1";
        public const string DEFAULT_PARITY = "None";
        public const string DEFAULT_PORT_NAME = "COM3";
        #endregion

        // display 설정값 : ASCII? HEX? DEC?
        #region
        public const int ASCII_MODE = 0x0;
        public const int HEX_MODE = 0x1;
        public const int DEC_MODE = 0x2;
        public const int BIN_MODE = 0x3;
        #endregion

        // uart.ini 파일에 저장하기위한 string 변수
        #region
        private string baudRateString="";
        private string dataBitsString = "";
        private string stopBitsString = "";
        private string parityBitsString = "";
        private string comPortString = "";
        #endregion

        // ini 파일 메세지모음 : 파일을 못찾겠다등..
        #region
        public const string FILE_NOT_EXSIT_MSG = "uart.ini file not exit. create uart.ini file.";
        #endregion

        // uart 메세지모음 : 열수가 없다 등..
        #region
        private string UART_SETTING_FILE_PATH = Application.StartupPath + "\\uart.ini";
        #endregion

        private void setBaudRateString(string baudRateString) { this.baudRateString= baudRateString; }
        private void setDataBitsString(string dataBitsString) { this.dataBitsString= dataBitsString; }
        private void setStopBitsString(string stopBitsString) { this.stopBitsString= stopBitsString; }
        private void setParityBitsString(string parityBitsString) { this.parityBitsString= parityBitsString; }
        private void setComPortString(string comPortString) { this.comPortString = comPortString; }

        public string getBaudRateString() { return baudRateString; }
        public string getDataBitsString() { return dataBitsString; }
        public string getStopBitsString() { return stopBitsString; }
        public string getParityBitsString() { return parityBitsString; }
        public string getComPortString() { return comPortString; }

        //public System.IO.Ports.SerialPort serialPort;
        private INIFileLoader iniFileLoader; // 시리얼 속성값을 저장하기 위한 클래스
        //private Thread reader; // 시리얼 데이터를 스레드로 읽기 위해서
        
        private bool isAppendCRLF = true;
        //private int[] recvDecData;

        //private String rx_string;
        private int bytesCount = 0; // 들어오는 바이트 수

        private int displayMode = HEX_MODE;
        private string statusString = " "; // 상태 저장용 스트링

        public void setDisplayMode(int mode) { this.displayMode = mode; }
        public int getDisplayMode() { return this.displayMode; }
        public void debug(string str) { Console.WriteLine(str); }
        private void setStatusString(string str) { this.statusString = str; }
        public string getStatusString() { return this.statusString; }
        public void setBytesCount(int count) { this.bytesCount = count; } // 들어온 시리얼 바이트의 갯수        
        public int getBytesCount() { return this.bytesCount; }
        public void setAppendCRLF(bool crlf) { this.isAppendCRLF = crlf; }
        public bool getAppendCRLF() { return this.isAppendCRLF; }
        
        
        public UART() {
            try {
                //serialPort = new SerialPort();
                //serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialDataReceived);
                debug("시리얼 포트 객체 생성 했음\n");
            }
            catch (Exception exception) {
                MessageBox.Show("Serial Port 객체 생성중 에러가 발생했습니다.\n" + exception.ToString());
                debug("시리얼 포트 객체 생성중 에러 발생\n");
                return;
            }
            try {
            iniFileLoader = new INIFileLoader();
            }
            catch (Exception exception) {
                MessageBox.Show(".ini 파일 객체 생성중 에러가 발생했습니다.\n" + exception.ToString());
            }
            load();
            //recvDecData = new int[256];
        }

        /*
         * 하이고 이놈때문에 고생좀 했네
         */
        public string[] getComportStringArr() {
            string[] comPortStringArr= null; //new string[];;
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            foreach(string comPort in SerialPort.GetPortNames()) {
                arrayList.Add(comPort);
            }
            //arrayList.Sort();
            //arrayList.Reverse();
            comPortStringArr= new string[arrayList.Count];
            for (int i = 0; i < arrayList.Count; i++) {
                comPortStringArr[i] = arrayList[i].ToString(); 
            }
            return comPortStringArr;
        }

        // 파일이 없으면 하나 만들겠다고 말해주고 아래 코드에서 만든다.
        // ini 파일에서 설정된 정보를 읽어옵니다.
        public void load() {
            // uart.ini 파일이 존재하면 파일에서 속성값을 읽어온다.
            System.IO.FileStream fileStream = null;
            if (System.IO.File.Exists(UART_SETTING_FILE_PATH) == true) {
                try {
                    fileStream = new System.IO.FileStream(UART_SETTING_FILE_PATH, System.IO.FileMode.Open); // FileNotFoundException
                }
                catch (Exception exception) {
                    MessageBox.Show("ini 파일을 찾을수가 없습니다.\n" + exception.Message);
                }
                try {
                    baudRateString = iniFileLoader.getINIValue("UART Setting", "baud_rate", UART_SETTING_FILE_PATH);
                    BaudRate = Convert.ToInt32(baudRateString);                    

                    dataBitsString = iniFileLoader.getINIValue("UART Setting", "data_bit", UART_SETTING_FILE_PATH);
                    DataBits = Convert.ToInt32(dataBitsString);

                    stopBitsString = iniFileLoader.getINIValue("UART Setting", "stop_bit", UART_SETTING_FILE_PATH);
                    switch (stopBitsString) {
                        case "1": StopBits = StopBits.One; break;
                        case "2": StopBits = StopBits.Two; break;
                        default: StopBits = StopBits.One; break;
                    }

                    parityBitsString = iniFileLoader.getINIValue("UART Setting", "parity_bit", UART_SETTING_FILE_PATH);
                    switch(parityBitsString) {
                        case "None": Parity = Parity.None; break;
                        case "Odd": Parity = Parity.Odd; break;
                        case "Even": Parity = Parity.Even; break;
                        case "Mark": Parity = Parity.Mark; break;
                        case "Space": Parity = Parity.Space; break;
                        default : Parity = Parity.None; break;
                    }

                    comPortString = iniFileLoader.getINIValue("UART Setting", "com_port", UART_SETTING_FILE_PATH);
                    PortName = comPortString;

                    fileStream.Close();
                }
                catch (Exception exception) {
                    MessageBox.Show("ini 파일에서 속성을 읽어오던 중 에러가 발생했습니다.\n속성 정보가 맞는지 확인해 주세요.\n예를들어 통신속도가 숫자가 아닌 영문이나 한글인 경우 문제가 발생합니다." + exception.Message);
                }
            }

            // uart.ini 파일이 존재하지 않거나, 읽다가 에러가 나면 기본값을 넣어준다.
            else {
                MessageBox.Show("uart.ini 파일이 존재하지 않거나 읽던중 에러가 발생했습니다.\n기본값을 불러옵니다.\n기본값은 9600-8-N-1입니다");
                BaudRate = UART.DEFAULT_BAUD_RATE;
                DataBits = UART.DEFAULT_DATA_BITS;
                Parity = convParityBits(UART.DEFAULT_PARITY);
                StopBits = convStopBits(UART.DEFAULT_STOP_BITS);
                PortName = UART.DEFAULT_PORT_NAME;
            }
        }

        public void save() {
            // 저장할 파일이 존재하지 않는다면, 파일을 새로 하나 만듭니다.
            System.IO.FileStream fileStream = null;
            if (System.IO.File.Exists(UART_SETTING_FILE_PATH) == false) {
                //MessageBox.Show(FILE_NOT_EXSIT_MSG);
                MessageBox.Show("uart 설정을 저장할 파일이 없어서\n새로 하나 만듭니다.");
                try {
                    fileStream = new System.IO.FileStream(UART_SETTING_FILE_PATH, System.IO.FileMode.CreateNew);
                }
                catch (Exception exception) {
                    string tmpString = exception.ToString();
                    MessageBox.Show(tmpString + "\n파일 생성시 에러가 발생했습니다.");
                    return;
                }
                iniFileLoader.setINIValue("UART Setting", "baud_rate", getBaudRateString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "data_bit", getDataBitsString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "parity_bit", getParityBitsString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "stop_bit", getStopBitsString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "com_port", getComPortString(), UART_SETTING_FILE_PATH);
            }
            // 저장할 파일이 있다면 거기에 저장합니다.
            else {
                iniFileLoader.setINIValue("UART Setting", "baud_rate", getBaudRateString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "data_bit", getDataBitsString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "parity_bit", getParityBitsString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "stop_bit", getStopBitsString(), UART_SETTING_FILE_PATH);
                iniFileLoader.setINIValue("UART Setting", "com_port", getComPortString(), UART_SETTING_FILE_PATH);
            }
            if (fileStream != null) { fileStream.Close(); }
        }

        // 문자열 none, 0, 1, 2를 StopBits 형태로 돌려주는 함수
        public System.IO.Ports.StopBits convStopBits(string str) {
            switch (str) {
                case UART.DEFAULT_STOP_BITS: return StopBits.One;
                case "2": return StopBits.Two;
                default: return StopBits.One;
            }
        }

        public System.IO.Ports.Parity convParityBits(string str) {
            switch (str) {
                case UART.DEFAULT_PARITY: return Parity.None;
                case "Even": return Parity.Even;
                case "Odd": return Parity.Odd;
                default: return Parity.None;
            }
        }

        public string convStringToHex(string text) {
            byte[] byteArray = getByteArrayFromString(text);
            string result = "";
            foreach (byte ch in byteArray)
            {
                result += string.Format("{0:x2} ", ch);
            }
            return result;
        }

        public void write(string data) {
            // 객체가 생성되어 있는가? serial_port != null
            // Open 되어 있는가? 생성된 이후에 Connect 되어 있는가?
            // 보낼 내용이 있는가?
            try {
                Write(data);
            }
            catch (NullReferenceException exception) {
                MessageBox.Show("시리얼 포트 객체가 생성되지 않았습니다.\n" + exception.Message);
            }
            catch (InvalidOperationException exception) {
                MessageBox.Show("시리얼 포트가 닫혀있는데 메세지 전송을 시도했습니다.\n" + exception.Message);
            }
        }

        public void writeLine(string data) {
            write(data + "\n");
        }

        public void write(byte[] buffer, int offset, int count) {
            try {
                Write(buffer, offset, count);
            }
            catch (NullReferenceException nullReferenceException)
            {
                MessageBox.Show("통신이 이루어지지 않은 상태에서 쓰기를 시도했습니다.\n" + nullReferenceException.ToString());
                return;
            }
            catch (Exception exception) {
                MessageBox.Show("UART 통신 Write시에 알수없는 에러가 발생했습니다.\n" + exception.ToString());
                return;
            }
        }

        // open 9600 8 N 1 "COM8"
        public void open(int baudRate, int dataBits, Parity parityBits, StopBits stopBits, string comPort) {
            try {
                BaudRate = baudRate;
                DataBits = dataBits;
                Parity = parityBits;
                StopBits = stopBits;
                PortName = comPort;

                Open();
                setStatusString("Connected");

                setBaudRateString(Convert.ToString(baudRate));
                setDataBitsString(Convert.ToString(dataBits));
                setParityBitsString(Convert.ToString(parityBits));
                setStopBitsString(Convert.ToString(stopBits));
                setComPortString(comPort);
            }
            catch (Exception exception) {
                setStatusString("Connection Failed");
                throw new ComPortNotExistException("시리얼 포트 열기에 실패했습니다.\n" + exception.ToString());
            }
            save();
        }
        /*
        public void start() {
            close();
            try {
                reader = new Thread(new ThreadStart(read));
                reader.IsBackground = true;
                reader.Start();
            }
            catch (ThreadStartException threadStartException) {
                MessageBox.Show("스레드 Start시에 ThreadStartException 예외가 발생했습니다.\n" + threadStartException.ToString());
            }
            catch (Exception exception) {
                MessageBox.Show("스레드 Start시에 Exception 예외가 발생했습니다.\n" + exception.ToString());
            }
        }
        */
        public void close() {
            /*
            try {
                if (reader != null) {
                    reader.Abort();
                    //reader.Abort(); 스레드 종료 프로세스를 시작합니다. 종료되면 다시 start()해야 하나?
                    //reader.Interrupt(); WaitSleepJoin 상태에 있는 스레드를 중단합니다.
                    // reader.Join(); 스레드가 종료되거나 지정된시간이 경과할때까지 스레드 호출을 차단합니다.
                    //reader.Resume(); 일시 중단된 스레드를 다시 시작합니다.
                    //reader.Suspend(); 스레드를 일시 중단합니다. deprecated
                    reader = null;
                }
            }
            catch (ThreadAbortException threadAbortException) {
                MessageBox.Show("스레드 Abort시에 ThreadAbortException 예외가 발생했습니다.\n" + threadAbortException.ToString());
            }
            catch (Exception exception) {
                MessageBox.Show("스레드 Abort시에 Exception 예외가 발생했습니다.\n" + exception.ToString());
            }
            */
            try {
                Close();
            }
            catch (System.IO.IOException exception) {
                MessageBox.Show("시리얼 포트를 닫는중 IOException 예외가 발생했습니다." + exception.Message);
                return;
            }
            catch (Exception exception) {
                MessageBox.Show("시리얼 포트를 닫는중 알수없는 오류가 발생했습니다." + exception.Message);
            }
        }
/*
        public void read() {
            // 이걸 무한 루프로 돌려야 하나? 안돌리면 몇개 읽다 말던데?
            // 아나.. thread 어떻게 짰더라, 이렇게 짰던가..? 기억이 하나도 안나네
            while (true) {
                try {
                    rx_string = serialPort.ReadExisting(); 
                    if (rx_string != null) {
                        //setText(rx_string);
                        //setRichTextBox(convStringToHex(rx_string));
                    }
                }
                catch (System.InvalidOperationException exception1) {
                    MessageBox.Show("읽고 쓰는 중에 오류가 발생했습니다.\n포트를 강제로 닫습니다." + exception1.Message);
                    // 스레드를 멈추고 닫아야 해요. 아니면 계속 데이터가 날라와요
                    // 아 이거 뭐야 완전 멈출수도 없잖아!
                    reader.Abort(); // 근데 Abort 쓰는거 맞나?
                    //reader.Abort(); 스레드 종료 프로세스를 시작합니다. 종료되면 다시 start()해야 하나?
                    //reader.Interrupt(); WaitSleepJoin 상태에 있는 스레드를 중단합니다.
                    // reader.Join(); 스레드가 종료되거나 지정된시간이 경과할때까지 스레드 호출을 차단합니다.
                    //reader.Resume(); 일시 중단된 스레드를 다시 시작합니다.
                    //reader.Suspend(); 스레드를 일시 중단합니다. deprecated
                    close();
                }
                catch (Exception exception) {
                    MessageBox.Show("읽고 쓰는 중에 알수없는 오류가 발생했습니다.\n포트를 강제로 닫습니다." + exception.Message);
                    close();
                }
                Thread.Sleep(200); // qqq
            }
        }
*/
        /*
        public void read() {
            // 이걸 무한 루프로 돌려야 하나? 안돌리면 몇개 읽다 말던데?
            // 아나.. thread 어떻게 짰더라, 이렇게 짰던가..? 기억이 하나도 안나네
            while (true) {
                try {
                    rx_string = ReadExisting(); 
                    if (rx_string != null) {
                        //setText(rx_string);
                        //setRichTextBox(convStringToHex(rx_string));
                    }
                }
                catch (System.InvalidOperationException exception1) {
                    MessageBox.Show("읽고 쓰는 중에 오류가 발생했습니다.\n포트를 강제로 닫습니다." + exception1.Message);
                    // 스레드를 멈추고 닫아야 해요. 아니면 계속 데이터가 날라와요
                    // 아 이거 뭐야 완전 멈출수도 없잖아!
                    reader.Abort(); // 근데 Abort 쓰는거 맞나?
                    close();
                }
                catch (Exception exception) {
                    MessageBox.Show("읽고 쓰는 중에 알수없는 오류가 발생했습니다.\n포트를 강제로 닫습니다." + exception.Message);
                    close();
                }
                Thread.Sleep(200); // qqq
            }
        }
        */
        public void read(byte[] arr, int index, int count) {
            Read(arr, index, count);
        }

        public byte[] getByteArrayFromString(string text) {
            // referanced by : http://blog.naver.com/hursh1225/40120911491
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(text);
            return byteArray;

            // http://kin.naver.com/qna/detail.nhn?d1id=1&dirId=1040102&docId=64337086&qb=QyMg7Iuc66as7Ja8IGhleCDstpzroKU=&enc=utf8&section=kin&rank=2&search_sort=0&spq=0&pid=SbMm9doRR1Vssvfy4o4ssssssuR-388954&sid=VGOhCwoUU1EAADTyFN8
            //System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            //return encoding.GetBytes(text);            
        }
    }

    public class ComPortNotExistException : ApplicationException {
        public ComPortNotExistException(string message) : base(message) {
        }
        /*
        public ComPortNotExistException() : this("해당 com 포트를 찾을수가 없다구!") {
        }
         */
    }
}
