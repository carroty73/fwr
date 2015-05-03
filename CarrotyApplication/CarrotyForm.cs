using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

using ZedGraph;

namespace CarrotyApplication {

    public partial class Form1 : Form {
        /*
        private PointPairList accXPointPairList; // 가속도 
        private PointPairList accYPointPairList;
        private PointPairList accZPointPairList;
        */
        private PointPairList tempPointPairList; // 온도 데이터
        private PointPairList humiPointPairList; // 습도 데이터

        //private LineItem accXCurve;    // 가속도 x 그래프
        //private LineItem accYCurve;    // 가속도 y 그래프 abc
        //private LineItem accZCurve;    // 가속도 z 그래프
        
        private LineItem tempCurve; // 온도 그래프
        private LineItem humiCurve; // 습도 그래프

        private UART uart;
        private INIFileLoader loader;

        private byte[] byteArray = null;
        private string recievedString = "";
        private long index = 0;

        //long cnt = 0;
        //int accX = 0;
        //int accY = 0;
        //int accZ = 0;

        public WindowsApplication.InfoForm infoForm;

        private byte totalBytesCount = 0;

        public int getTotalBytesCount() {
            return this.totalBytesCount;
        }

        public void setTotalBytesCount(byte count) {
            totalBytesCount = count;
        }

        public void initGraph() {
            //drawAccGraph(tempZedGraphControl);
            drawTempGraph(tempZedGraphControl);
            drawHumiGraph(humiZedGraphControl);
        }

        public void initInfoForm() {
            infoForm = new WindowsApplication.InfoForm();
            infoForm.Visible = true;
            infoForm.Activate();
        }

        public void uartInit() {
            uart = new UART(); // 일단 uart 객체를 만든다. 만든다고 열린것은 아니다!!
            //uart.load("파일 정보"); uart.open("어쩌구 
            //uart.DataReceived += new SerialDataReceivedEventHandler(uart.DataRe
            uart.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialDataReceived);
        }

        // string str = "테스트";
        // string->byte[]
        // byte[] bytes = Encoding.Default.GetBytes(str);
        // byte[]->string
        // str = Encoding.Default.GetString(bytes);

        private void serialDataReceived(object sender, EventArgs e) {
            uart.setBytesCount(uart.BytesToRead);
            if (uart.getBytesCount() > 0) { // 몬가 데이터가 들어왔다면!
                byteArray = new byte[uart.getBytesCount()];
                uart.read(byteArray, 0, uart.getBytesCount());

                if ((uart.getBytesCount()==6)&&(byteArray[0] == FWRProtocol.ACK)) {
                    FWRPacket packet = new FWRPacket(0x40);
                    packet.buffer[0] = byteArray[0]; // ACK
                    packet.buffer[1] = byteArray[1]; // CMD
                    packet.buffer[2] = byteArray[2]; // Current Flow : 현재 (Flow A,B,C,E,S,F,a,b,c 중의 하나) 0x53 = 'S' 니까 현재 행정은 Stop 상태라는 의미
                    packet.buffer[3] = byteArray[3]; // 온도
                    packet.buffer[4] = byteArray[4]; // 습도
                    packet.buffer[5] = byteArray[5]; // ETX

                    drawTempADC(index++, byteArray[3]);
                    drawHumiADC(index++, byteArray[4]);
                }

                //uart.debug(Convert.ToString(byteArray[0]));
                recievedString = Encoding.Default.GetString(byteArray);
                uart.debug(recievedString);
                display(recievedString);
            }
        }

        public void initForm() {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            // http://blog.naver.com/balam1013/50044131401
            // http://blog.naver.com/thefeel777/130095019045

           openButton.Enabled = true;
           closeButton.Enabled = false;
           baudRateComboBox.Enabled = true;
           dataBitComboBox.Enabled = true;
           stopBitComboBox.Enabled = true;
           parityBitComboBox.Enabled = true;
           portComboBox.Enabled = true;
           toolStripStatusLabel2.Text = uart.getStatusString();
           //toolStripStatusLabel.Text = "xyz";

           switch (uart.getBaudRateString()) {
               case "2400" : baudRateComboBox.SelectedIndex = 0; break;
               case "4800": baudRateComboBox.SelectedIndex = 1; break;
               case "9600": baudRateComboBox.SelectedIndex = 2; break;
               case "14400": baudRateComboBox.SelectedIndex = 3; break;
               case "19200": baudRateComboBox.SelectedIndex = 4; break;
               case "38400": baudRateComboBox.SelectedIndex = 5; break;
               case "57600": baudRateComboBox.SelectedIndex = 6; break;
               case "115200": baudRateComboBox.SelectedIndex = 7; break;
               default: baudRateComboBox.SelectedIndex = 2; break;
           }

           switch (uart.getDataBitsString()) {
               case "7": dataBitComboBox.SelectedIndex = 0; break;
               case "8": dataBitComboBox.SelectedIndex = 1; break;
               default: dataBitComboBox.SelectedIndex = 1; break;
           }

           switch (uart.getParityBitsString()) {
               case "None": parityBitComboBox.SelectedIndex = 0; break;
               case "Odd":  parityBitComboBox.SelectedIndex = 1; break;
               case "Even": parityBitComboBox.SelectedIndex = 2; break;
               case "Mark": parityBitComboBox.SelectedIndex = 3; break;
               case "Space": parityBitComboBox.SelectedIndex = 4; break;
               default: parityBitComboBox.SelectedIndex = 0; break;
           }

           switch (uart.getStopBitsString()) {
               case "1": dataBitComboBox.SelectedIndex = 0; break;
               case "2": dataBitComboBox.SelectedIndex = 1; break;
               default: dataBitComboBox.SelectedIndex = 1; break;
           }

           portComboBox.Items.Clear();
           for (int i = 0; i < uart.getComportStringArr().Length; i++) {
               portComboBox.Items.Add(uart.getComportStringArr()[i]);
           }
           portComboBox.Text = uart.getComPortString();

            /*
            Dictionary<Int32, String> risk= new Dictionary<int, string>();
            risk.Add(1, "c1");
            risk.Add(2, "c2");
            risk.Add(3, "c3");
            portComboBox.DataSource = new BindingSource(risk, null);
            //portComboBox.DisplayMember = "Value";
            //portComboBox.ValueMember = "Key";
            portComboBox.DisplayMember = "c2";
            //portComboBox.ValueMember = "Key";
            */
        }

        public Form1() {
            InitializeComponent();
            uartInit();
            initForm();
            initGraph();
            initInfoForm();
            this.WindowState = FormWindowState.Normal;
            infoForm.Focus();
            infoForm.Activate();
            
            loader = new INIFileLoader();
        }

        private void openButton_Click(object sender, EventArgs e) {
            uart.close();
            openButton.Enabled = false;
            closeButton.Enabled = true;
            baudRateComboBox.Enabled = false;
            dataBitComboBox.Enabled = false;
            stopBitComboBox.Enabled = false;
            parityBitComboBox.Enabled = false;
            portComboBox.Enabled = false;

            string baudRateString = baudRateComboBox.SelectedItem.ToString();
            string dataBitsString = dataBitComboBox.SelectedItem.ToString();
            string stopBitsString = stopBitComboBox.SelectedItem.ToString();
            string parityBitsString = parityBitComboBox.SelectedItem.ToString();
            string comPortString = portComboBox.SelectedItem.ToString();

            int baudRate = Convert.ToInt32(baudRateString);
            int dataBits = Convert.ToInt32(dataBitsString);
            //int parityBits = Convert.ToInt32(parityBitsString);
            //int stopBits = Convert.ToInt32(stopBitsString);
            try {
                uart.open(baudRate, dataBits, uart.convParityBits(parityBitsString), uart.convStopBits(stopBitsString), comPortString);
            }
            catch(ComPortNotExistException exception) {
                initForm();
                MessageBox.Show("컴포트가 없어요!\n"+exception.ToString());
            }
        }


        #region 가속도ADC그리는함수
        /*
        public void drawAccGraph(ZedGraphControl zedGraphControl) {
            GraphPane myPane = zedGraphControl.GraphPane;

            myPane.Title.Text = "Acceleration(g)";
            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "Angle";
            
            myPane.XAxis.Scale.MinorStep = 1.0f;
            myPane.XAxis.Scale.MajorStep = 1.0f; //.MinorStep = 1.0F;
            myPane.XAxis.Scale.Min = -1.0f;
            myPane.XAxis.Scale.Max = 16.0f;

            myPane.YAxis.Scale.MinorStep = 5.0f;
            myPane.YAxis.Scale.MajorStep = 25.0;
            myPane.YAxis.Scale.Min = 0.0f;
            myPane.YAxis.Scale.Max = 255;

            accXPointPairList = new PointPairList();
            accYPointPairList = new PointPairList();
            accZPointPairList = new PointPairList();

            accXCurve = myPane.AddCurve("x", accXPointPairList, Color.Orange);
            accYCurve = myPane.AddCurve("y", accYPointPairList, Color.LightGreen);
            accZCurve = myPane.AddCurve("z", accZPointPairList, Color.LightBlue);

            // Don't display the line (This makes a scatter plot)
            accXCurve.Line.IsVisible = false;
            accYCurve.Line.IsVisible = false;
            accZCurve.Line.IsVisible = false;
            // Hide the symbol outline
            accXCurve.Symbol.Border.IsVisible = false;
            accYCurve.Symbol.Border.IsVisible = false;
            accZCurve.Symbol.Border.IsVisible = false;
            // Make the symbols opaque by filling them with white
            accXCurve.Symbol.Size = 3;
            accYCurve.Symbol.Size = 3;
            accZCurve.Symbol.Size = 3;

            accXCurve.Symbol.Fill = new Fill(Color.Red);
            accYCurve.Symbol.Fill = new Fill(Color.Green);
            accZCurve.Symbol.Fill = new Fill(Color.Blue);

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;

            zedGraphControl.AxisChange();
        }
        */
        #endregion

        public void drawTempGraph(ZedGraphControl zedGraphControl) {
            GraphPane myPane = zedGraphControl.GraphPane;

            myPane.Title.Text = "온도 그래프";
            myPane.XAxis.Title.Text = "시간";
            myPane.YAxis.Title.Text = "온도";

            tempPointPairList = new PointPairList();
            myPane.XAxis.Scale.MinorStep = 1.0f;
            myPane.XAxis.Scale.MajorStep = 1.0f; //.MinorStep = 1.0F;
            myPane.XAxis.Scale.Min = -1.0f;
            myPane.XAxis.Scale.Max = 16.0f;

            myPane.YAxis.Scale.MinorStep = 5.0f;
            myPane.YAxis.Scale.MajorStep = 25.0;
            myPane.YAxis.Scale.Min = 0.0f;
            myPane.YAxis.Scale.Max = 255;

            tempCurve = myPane.AddCurve("Temperature", tempPointPairList, Color.Orange); 

            // Don't display the line (This makes a scatter plot)
            tempCurve.Line.IsVisible = false;
            // Hide the symbol outline
            tempCurve.Symbol.Border.IsVisible = false;
            // Make the symbols opaque by filling them with white
            tempCurve.Symbol.Size = 3;
            tempCurve.Symbol.Fill = new Fill(Color.Red);

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;

            zedGraphControl.AxisChange();
        }

        public void drawHumiGraph(ZedGraphControl zedGraphControl) {
            GraphPane myPane = zedGraphControl.GraphPane;

            myPane.Title.Text = "습도 그래프";
            myPane.XAxis.Title.Text = "시간";
            myPane.YAxis.Title.Text = "습도";

            humiPointPairList = new PointPairList();
            myPane.XAxis.Scale.MinorStep = 1.0f;
            myPane.XAxis.Scale.MajorStep = 1.0f; //.MinorStep = 1.0F;
            myPane.XAxis.Scale.Min = -1.0f;
            myPane.XAxis.Scale.Max = 16.0f;

            myPane.YAxis.Scale.MinorStep = 5.0f;
            myPane.YAxis.Scale.MajorStep = 25.0;
            myPane.YAxis.Scale.Min = 0.0f;
            myPane.YAxis.Scale.Max = 255;

            humiCurve = myPane.AddCurve("Humidity", humiPointPairList, Color.LightGreen);

            // Don't display the line (This makes a scatter plot)
            humiCurve.Line.IsVisible = false;
            // Hide the symbol outline
            humiCurve.Symbol.Border.IsVisible = false;
            // Make the symbols opaque by filling them with white
            humiCurve.Symbol.Size = 3;
            humiCurve.Symbol.Fill = new Fill(Color.Green);

            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;

            zedGraphControl.AxisChange();
        }
        

        #region x,y,z축 그리는 함수
        /*
        delegate void DrawXADCCallback(long index, double adcValue);
        // 요기가 그리는 부분
        public void drawXADC(long index, double adcValue) {
            if (this.tempZedGraphControl.InvokeRequired) {
                DrawXADCCallback drawXADCCallback = new DrawXADCCallback(drawXADC);
                this.Invoke(drawXADCCallback, new object[] { index, adcValue });
            }
            else {
                accXPointPairList.Add(index, adcValue);
                accXCurve.Line.IsVisible = true;
                tempZedGraphControl.Refresh();
            }
        }

        delegate void DrawYADCCallback(long index, double adcValue);
        // 요기가 그리는 부분
        public void drawYADC(long index, double adcValue) {
            if (this.tempZedGraphControl.InvokeRequired) {
                DrawYADCCallback drawYADCCallback = new DrawYADCCallback(drawXADC);
                this.Invoke(drawYADCCallback, new object[] { index, adcValue });
            }
            else {
                accYPointPairList.Add(index, adcValue);
                accYCurve.Line.IsVisible = true;
                tempZedGraphControl.Refresh();
            }
        }

        delegate void DrawZADCCallback(long index, double adcValue);
        // 요기가 그리는 부분
        public void drawZADC(long index, double adcValue) {
            if (this.tempZedGraphControl.InvokeRequired) {
                DrawZADCCallback drawZADCCallback = new DrawZADCCallback(drawXADC);
                this.Invoke(drawZADCCallback, new object[] { index, adcValue });
            }
            else {
                accZPointPairList.Add(index, adcValue);
                accZCurve.Line.IsVisible = true;
                tempZedGraphControl.Refresh();
            }
        }
*/
        #endregion

        delegate void DrawTempADCCallback(long index, double adcValue);
        // 요기가 그리는 부분
        public void drawTempADC(long index, double adcValue) {
            if (this.tempZedGraphControl.InvokeRequired) {
                DrawTempADCCallback drawTempADCCallback = new DrawTempADCCallback(drawTempADC);
                this.Invoke(drawTempADCCallback, new object[] { index, adcValue });
            }
            else {
                tempPointPairList.Add(index, adcValue);
                tempCurve.Line.IsVisible = true; 
                tempZedGraphControl.Refresh();
            }
        }

        delegate void DrawHumiADCCallback(long index, double adcValue);
        // 요기가 그리는 부분
        public void drawHumiADC(long index, double adcValue) {
            if (this.humiZedGraphControl.InvokeRequired) {
                DrawHumiADCCallback drawHumiADCCallback = new DrawHumiADCCallback(drawHumiADC);
                this.Invoke(drawHumiADCCallback, new object[] { index, adcValue });
            }
            else {
                humiPointPairList.Add(index, adcValue);
                humiCurve.Line.IsVisible = true; 
                humiZedGraphControl.Refresh();
            }
        }
              


        // referanced by : http://blog.naver.com/hursh1225/40120911491
        public string getStringFromByteArray(byte[] byteArray) {
            string text = System.Text.Encoding.Default.GetString(byteArray);
            return text;
        }

        // http://cafe.naver.com/noransmile/94
        public static string getByteArrayToString(byte[] byteArray) {
            StringBuilder hex= new StringBuilder(byteArray.Length*2);
            int index = 0;
            foreach (var b in byteArray)
            {
                hex.AppendFormat("{0:x2} ", b);
                index++;
                if (index == 20) {
                    index = 0;
                    hex.Append(Environment.NewLine);
                }
            }
            return hex.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            initForm();
            uart.close();
        }


        delegate void SetTextCallback(string text);
        // qqq 요기가 중요하긴 한데 왜 중요한지 기억이 안나네 ㅋㅋㅋ
        // cross thread 에러던가.. 아마 다른 스레드에서 textfield 갱신하는 스레드를
        // 건드리기 때문에 나는거 같던데..
        private void setText(string text) {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.rxRichTextBox.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(setText);
                this.Invoke(d, new object[] { text });
            }
            else {
                //rxRichTextBox.Text += text;
                rxRichTextBox.AppendText(text);
            }
        }

        private void display(string text) {
            string str= "";
            if (this.rxRichTextBox.InvokeRequired) {
                try {
                    SetTextCallback setTextCallback = new SetTextCallback(display);
                    this.Invoke(setTextCallback, new object[] { text });
                }
                catch (ObjectDisposedException exception) {
                    MessageBox.Show("프로그램이 비정상적으로 종료되었습니다.\n"+exception.ToString());
                    uart.close();
                    return;
                }
            }
            else {
                switch(uart.getDisplayMode()) {
                  case UART.ASCII_MODE :
                      char[] charArray = new char[uart.getBytesCount()];
                      charArray = text.ToCharArray();
                      foreach (char ch in charArray) {
                          str +=ch;
                      }                        
                      break;
                  case UART.HEX_MODE:
                      str= BitConverter.ToString(byteArray).Replace("-", " ");
                      str += " "; 
                      break;
//                case UART.DEC_MODE:
//                      break;
                  case UART.BIN_MODE :
                      char[] binArray = new char[uart.getBytesCount()];
                      binArray = text.ToCharArray();
                      foreach (char ch in binArray) {
                          //str += string.Format("{0:d8}", Convert.ToString(ch, 2));
                          str += Convert.ToString(ch, 2).PadLeft(8,'0');
                          //Convert.ToString(
                          //str += Convert.ToString(ch, 2);
                          //str += str;
                          str += " ";
                          //str += Convert.ToString(ch, 2) + " ";
                      } 
                      break;
                  default: 
                      str = BitConverter.ToString(byteArray).Replace("-", " ");
                      str += " "; 
                      break;
                }
                rxRichTextBox.AppendText(str);
                if (uart.getAppendCRLF()) { rxRichTextBox.AppendText("\n"); }
                rxRichTextBox.SelectionStart = rxRichTextBox.Text.Length;
                rxRichTextBox.ScrollToCaret();
            }            
        }

        private void txButton1_Click(object sender, EventArgs e) { uart.write(txTextBox1.Text.Trim()); txTextBox1.Clear(); }
        private void txButton2_Click(object sender, EventArgs e) { uart.write(txTextBox2.Text.Trim()); txTextBox2.Clear(); }
        private void txButton3_Click(object sender, EventArgs e) { uart.write(txTextBox3.Text.Trim()); txTextBox3.Clear(); }
        private void txButton4_Click(object sender, EventArgs e) { uart.write(txTextBox4.Text.Trim()); txTextBox4.Clear(); }
        private void clearButton_Click(object sender, EventArgs e) { rxRichTextBox.Clear(); }

        private void displayComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            int tmpFormatIndex= displayComboBox.SelectedIndex;
            switch (tmpFormatIndex) {
                case UART.ASCII_MODE :
                    uart.setDisplayMode(UART.ASCII_MODE);
                    rxRichTextBox.AppendText("ASCII Mode Converted.\n");
                    break;
                case UART.HEX_MODE:
                    uart.setDisplayMode(UART.HEX_MODE);
                    rxRichTextBox.AppendText("Hex Mode Converted.\n");
                    break;
                case UART.DEC_MODE:
                    uart.setDisplayMode(UART.DEC_MODE);
                    rxRichTextBox.AppendText("DEC Mode not supported.\n");
                    break;
                case UART.BIN_MODE:
                    uart.setDisplayMode(UART.BIN_MODE);
                    rxRichTextBox.AppendText("BIN Mode Converted.\n");
                    break;
                default:
                    uart.setDisplayMode(UART.HEX_MODE);
                    rxRichTextBox.AppendText("Default Mode : HEX Mode");
                    break;
            }
        }

        // C# 숫자결과의 출력 포맷 지정http://durubiz.tistory.com/35
        // http://ryuschool.tistory.com/249
        // http://ryuschool.tistory.com/249
        // http://msdn.microsoft.com/ko-kr/library/dwhawy9k(v=vs.110).aspx
        // http://www.csharpstudy.com/Tip/Tip-number-format.aspx <- 요기 괜찮음 서식지정자


        /* ************************************************************
         * 그래프 그리기 샘플 함수 모음
        ************************************************************ */
/*
        public void drawSampleSineGraph(ZedGraphControl zgc) {
            graphPane1 = zgc.GraphPane;
            xPointPairList = new PointPairList();

            graphPane1.Title.Text = "Sine Wave Graph";
            graphPane1.XAxis.Title.Text = "Time (X)";
            graphPane1.XAxis.Scale.MinorStep = 1.0f;
            graphPane1.XAxis.Scale.MajorStep = 2.0f; //.MinorStep = 1.0F;
            graphPane1.XAxis.Scale.Min = 0.0f;
            graphPane1.XAxis.Scale.Max = 60.0f;

            graphPane1.YAxis.Title.Text = "Value (Y)";
            graphPane1.YAxis.Scale.MinorStep = 1.0f;
            graphPane1.YAxis.Scale.MajorStep = 20.0f;
            graphPane1.YAxis.Scale.Min = -10.0f;
            graphPane1.YAxis.Scale.Max = 10.0f;

            double x;
            double y;
            for (int i = 0; i < 60; i++)
            {
                x = (double)i;
                y = Math.Sin((double)i * 0.5) * 8;
                xPointPairList.Add(x, y);
            }
            LineItem tempCurve = graphPane1.AddCurve("sin", xPointPairList, Color.Magenta, SymbolType.Circle);
            tempCurve.Line.Width = 1.0f;
            tempZedGraphControl.AxisChange();
            tempZedGraphControl.Invalidate();
            tempZedGraphControl.Refresh();
        }
*/
        private void initButton_Click(object sender, EventArgs e) {
            tempZedGraphControl.Refresh();
        }

        private void fwrResetButton_Click(object sender, EventArgs e) {
            grind1stTextBox.Text = Convert.ToString(0);
            grind2stTextBox.Text = Convert.ToString(0);
            grind3stTextBox.Text = Convert.ToString(0);
            grind4stTextBox.Text = Convert.ToString(0);
            grind5stTextBox.Text = Convert.ToString(0);
            grind6stTextBox.Text = Convert.ToString(0);
            grind7stTextBox.Text = Convert.ToString(0);
            grind8stTextBox.Text = Convert.ToString(0);
            grind9stTextBox.Text = Convert.ToString(0);
            grind10stTextBox.Text = Convert.ToString(0);
            grind11stTextBox.Text = Convert.ToString(0);
            grind12stTextBox.Text = Convert.ToString(0);
            grind13stTextBox.Text = Convert.ToString(0);
            grind14stTextBox.Text = Convert.ToString(0);
            grind15stTextBox.Text = Convert.ToString(0);

            grindSol1OnTimeTextBox.Text = Convert.ToString(0);
            grindSol1OffTimeTextBox.Text = Convert.ToString(0);

            dryCWTimeTextBox.Text= Convert.ToString(0);
            dryCCWTimeTextBox.Text= Convert.ToString(0);
            dryMAXTempTextBox.Text= Convert.ToString(0);
            dryMINHumiTextBox.Text= Convert.ToString(0);
            drySol2OnTimeTextBox.Text = Convert.ToString(0);
            drySol2OffTimeTextBox.Text= Convert.ToString(0);
            flushTimeTextBox.Text = Convert.ToString(0);
        }

        // 분쇄만
        private void onlyGrindButton_Click(object sender, EventArgs e) {
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.ONLY_GRIND); 
            uart.write(tmpPacket.getBuffer(), 0, 3);
        }

        // 건조만!
        private void onlyDryButton_Click(object sender, EventArgs e) {
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.ONLY_DRY);
            uart.write(tmpPacket.getBuffer(), 0, 3);
        }

        // 배출만
        private void onlyFlushButton_Click(object sender, EventArgs e)
        {
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.ONLY_FLUSH);
            uart.write(tmpPacket.getBuffer(), 0, 3);
        }

        // 스탑
        private void stopButton_Click(object sender, EventArgs e) {
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.STOP);
            uart.write(tmpPacket.getBuffer(), 0, 3);
        }

        // run
        private void runButton_Click(object sender, EventArgs e) {
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.RUN);
            uart.write(tmpPacket.getBuffer(), 0, 3);
        }

        // 재시작
        private void restartButton_Click(object sender, EventArgs e) {
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.RESTART);
            uart.write(tmpPacket.getBuffer(), 0, 3);
        }

        //string 
        private void grindDataSendButton_Click(object sender, EventArgs e) {
            // 기본적인 검사, textbox에 숫자만 입력해야 되요. a,b,c.. 이런거 입력하면 안되요.
            // 아니면 걍 함수를 나가버려요.
            if (!isNumber(grind1stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind2stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind3stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind4stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind5stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind6stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind7stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind8stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind9stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind10stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind11stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind12stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind13stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind14stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind15stTextBox.Text)) { MessageBox.Show("시간이 숫자가 아닙니다."); return; }

            if (!isNumber(grindSol1OnTimeTextBox.Text)) { MessageBox.Show("솔밸브1 ON 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grindSol1OffTimeTextBox.Text)) { MessageBox.Show("솔밸브1 OFF 시간이 숫자가 아닙니다."); return; }

            int grind1stTime = Convert.ToInt32(grind1stTextBox.Text);
            int grind2stTime = Convert.ToInt32(grind2stTextBox.Text);
            int grind3stTime = Convert.ToInt32(grind3stTextBox.Text);
            int grind4stTime = Convert.ToInt32(grind4stTextBox.Text);
            int grind5stTime = Convert.ToInt32(grind5stTextBox.Text);
            int grind6stTime = Convert.ToInt32(grind6stTextBox.Text);
            int grind7stTime = Convert.ToInt32(grind7stTextBox.Text);
            int grind8stTime = Convert.ToInt32(grind8stTextBox.Text);
            int grind9stTime = Convert.ToInt32(grind9stTextBox.Text);
            int grind10stTime = Convert.ToInt32(grind10stTextBox.Text);
            int grind11stTime = Convert.ToInt32(grind11stTextBox.Text);
            int grind12stTime = Convert.ToInt32(grind12stTextBox.Text);
            int grind13stTime = Convert.ToInt32(grind13stTextBox.Text);
            int grind14stTime = Convert.ToInt32(grind14stTextBox.Text);
            int grind15stTime = Convert.ToInt32(grind15stTextBox.Text);

            int grindSol1OnTime  = Convert.ToInt32(grindSol1OnTimeTextBox.Text);
            int grindSol1OffTime = Convert.ToInt32(grindSol1OffTimeTextBox.Text);

            // 비지니스로직 검사, 입력되는 값이 숫자라 하더라도, 일정 범위안에 들어와야 되요.
            // 아니면 걍 함수를 나가버려요.
            if (!isValid(grind1stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind2stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind3stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind4stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind5stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind6stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind7stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind8stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind9stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind10stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind11stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind12stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind13stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind14stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grind15stTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }

            if (!isValid(grindSol1OnTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }
            if (!isValid(grindSol1OffTime)) { MessageBox.Show("입력값의 범위는 5<값<250 입니다."); return; }

            byte[] data = new byte[15];
            //string getComoBoxSelectedString = "";
            /*
            data[4] = FWRProtocol.PAUSE; // 0x00 
            //data[5] = Convert.ToByte(grindPauseTimeTextBox.Text); qqq
            data[6] = FWRProtocol.END; // 0xFF 동작끗
            data[7] = Convert.ToByte(grindSol1OnTimeTextBox.Text);
            data[8] = Convert.ToByte(grindSol1OffTimeTextBox.Text);
            */

            data[totalBytesCount] = Convert.ToByte(grind1stTime); totalBytesCount++;

            //getComoBoxSelectedString = grind2stComboBox.SelectedItem.ToString();
            try {
                if (grind2stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind2stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind2stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind3stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind3stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind3stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind4stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind4stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind4stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind5stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind5stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind5stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind6stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind6stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind6stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind7stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind7stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind7stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind8stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind8stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind8stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind9stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind9stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind9stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind10stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind10stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind10stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind11stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind11stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind11stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind12stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind12stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind12stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind13stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind13stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind13stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            try {
                if (grind14stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind14stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind14stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());   }

            try {
                if (grind15stComboBox.SelectedItem.ToString() == "STOP") {
                    data[totalBytesCount] = 0x00; totalBytesCount++;
                    data[totalBytesCount] = Convert.ToByte(grind15stTime); totalBytesCount++;
                }
                else {
                    data[totalBytesCount] = Convert.ToByte(grind15stTime); totalBytesCount++;
                }
            }
            catch (IndexOutOfRangeException exception) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); Console.WriteLine(exception.ToString());  }

            /*
            data[totalBytesCount] = Convert.ToByte(grind1stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind3stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind4stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind5stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind6stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind7stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind8stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind9stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind10stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind11stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind12stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind13stTime); totalBytesCount++;
            data[totalBytesCount] = Convert.ToByte(grind14stTime); totalBytesCount++;
            */

            /*
            data[count] = Convert.ToByte(grind1stTime);
            if (grind2stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; }  else { data[++count] = Convert.ToByte(grind2stTime); }
            if (grind3stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind3stTime);}
            if (grind4stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind4stTime);}
            if (grind5stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind5stTime);}
            if (grind6stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind6stTime);}
            if (grind7stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind7stTime);}
            if (grind8stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind8stTime);}
            if (grind9stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind9stTime);}
            if (grind10stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind10stTime);}
            if (grind11stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind11stTime);}
            if (grind12stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind12stTime);}
            if (grind13stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind13stTime);}
            if (grind14stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind14stTime);}
            if (grind15stComboBox.SelectedItem.ToString() == "STOP") { data[++count] = 0x00; } if (count > 15) { MessageBox.Show("최대 패킷 사이즈를 넘어섰습니다."); return; } else { data[++count] = Convert.ToByte(grind15stTime); }
            */
            /*
            data[1] = Convert.ToByte(grind1stTime);
            data[2] = Convert.ToByte(grind1stTime);
            data[3] = Convert.ToByte(grind1stTime);
            data[4] = Convert.ToByte(grind1stTime);
            data[5] = Convert.ToByte(grind1stTime);
            data[6] = Convert.ToByte(grind1stTime);
            data[7] = Convert.ToByte(grind1stTime);
            data[8] = Convert.ToByte(grind1stTime);
            data[9] = Convert.ToByte(grind1stTime);
            data[10] = Convert.ToByte(grind1stTime);
            data[11] = Convert.ToByte(grind1stTime);
            data[12] = Convert.ToByte(grind1stTime);
            data[13] = Convert.ToByte(grind1stTime);
            data[14] = Convert.ToByte(grind1stTime);
            data[15] = Convert.ToByte(grind1stTime);
            */
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.GRIND, data, 15);
            uart.write(tmpPacket.getBuffer(), 0, 15+3); 

            totalBytesCount = 0;
        }

        private void dryDataSendButton_Click(object sender, EventArgs e) {

            if (!isNumber(dryCWTimeTextBox.Text)) { MessageBox.Show("정방향 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(dryCCWTimeTextBox.Text)) { MessageBox.Show("역방향 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(dryMAXTempTextBox.Text)) { MessageBox.Show("최대 온도값이 숫자가 아닙니다."); return; }
            if (!isNumber(dryMINHumiTextBox.Text)) { MessageBox.Show("최소 습도값이 숫자가 아닙니다."); return; }
            if (!isNumber(drySol2OnTimeTextBox.Text)) { MessageBox.Show("솔밸브2 ON 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(drySol2OffTimeTextBox.Text)) { MessageBox.Show("솔밸브2 OFF 시간이 숫자가 아닙니다."); return; }

            int dry1stCWTime     = Convert.ToInt32(dryCWTimeTextBox.Text);
            int dry1stCCWTime    = Convert.ToInt32(dryCCWTimeTextBox.Text);
            int dryMAXTemp       = Convert.ToInt32(dryMAXTempTextBox.Text);
            int dryMINHumi       = Convert.ToInt32(dryMINHumiTextBox.Text);
            int grindSol2OnTime  = Convert.ToInt32(drySol2OnTimeTextBox.Text);
            int grindSol2OffTime = Convert.ToInt32(drySol2OffTimeTextBox.Text);

            // 비지니스로직 검사, 입력되는 값이 숫자라 하더라도, 일정 범위안에 들어와야 되요.
            // 아니면 걍 함수를 나가버려요.
            if (!isValid(dry1stCWTime)) { MessageBox.Show("5에서 250사이의 값을 넣으라고요!!!"); return; }
            if (!isValid(dry1stCCWTime)) { MessageBox.Show("5에서 250사이의 값을 넣으라고요!!!"); return; }
            if (!isValidTemp(dryMAXTemp)) { MessageBox.Show("0에서 100사이의 값을 넣으세요.!!"); return; } 
            if (!isValidHumi(dryMINHumi)) { MessageBox.Show("0에서 100사이의 값을 넣으세요!!"); return; }
            if (!isValid(grindSol2OnTime)) { MessageBox.Show("5에서 250사이의 값을 넣으라고요!!!"); return; }
            if (!isValid(grindSol2OffTime)) { MessageBox.Show("5에서 250사이의 값을 넣으라고요!!!"); return; }

            byte[] data = new byte[6];
            data[0] = Convert.ToByte(dryCWTimeTextBox.Text);
            data[1] = Convert.ToByte(dryCCWTimeTextBox.Text);
            data[2] = Convert.ToByte(dryMAXTempTextBox.Text);
            data[3] = Convert.ToByte(dryMINHumiTextBox.Text);
            data[4] = Convert.ToByte(drySol2OnTimeTextBox.Text);
            data[5] = Convert.ToByte(drySol2OffTimeTextBox.Text);

            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.DRY, data, 6);
            uart.write(tmpPacket.getBuffer(), 0, 9);
        }


        private void flushDataSendButton_Click(object sender, EventArgs e) {
            if (!isNumber(flushTimeTextBox.Text)) { MessageBox.Show("배출 시간이 숫자가 아닙니다."); return; }
            int flushTime = Convert.ToInt32(flushTimeTextBox.Text);
            if (!isValid(flushTime)) { MessageBox.Show("5에서 250사이의 값을 넣으라고요!!!"); return; }

            byte[] data= new byte[1];
            data[0]= Convert.ToByte(flushTimeTextBox.Text);
            FWRPacket tmpPacket = new FWRPacket(FWRProtocol.FLUSH, data, 1);
            uart.write(tmpPacket.getBuffer(), 0, 4);
        }

        // 텍스트박스에서 입력된 문자가 숫자 맞니? "123"-> 123, "abc"-> error
        public bool isNumber(string str) {
            for (int i = 0; i < str.Length; i++) {
                if (Char.IsDigit(str[i])) { continue; }
                else return false;
            }
            return true;
        }

        // 입력값이 5<value<250 사이일때만 true 
        public bool isValid(int value) {
            if ((value >= 5) && (value <= 250)) { return true; }
            else return false;
        }

        // 온도는 0<=value<=100 사이일때만 true 
        public bool isValidTemp(int value) {
            if ((value >= 0) && (value <= 100)) { return true; }
            else return false;
        }

        // 습도는 0<=value<=100 사이일때만 true 
        public bool isValidHumi(int value)
        {
            if ((value >= 0) && (value <= 100)) { return true; }
            else return false;
        }

        private void saveButton_Click(object sender, EventArgs e) {
            // 기본적인 검사, textbox에 숫자만 입력해야 되요. a,b,c.. 이런거 입력하면 안되요.
            // 아니면 걍 함수를 나가버려요.

            if (!isNumber(grind1stTextBox.Text)) { MessageBox.Show("모터 회전 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind2stTextBox.Text)) { MessageBox.Show("모터 회전 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind3stTextBox.Text)) { MessageBox.Show("모터 회전 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind4stTextBox.Text)) { MessageBox.Show("모터 회전 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grind5stTextBox.Text)) { MessageBox.Show("모터 회전 시간이 숫자가 아닙니다."); return; }
            if (!isNumber(grindSol1OffTimeTextBox.Text)) { MessageBox.Show("솔밸브1 동작 시간이 숫자가 아닙니다."); return; }
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @".\";
            saveFileDialog.Title = "Save INI File";
            saveFileDialog.DefaultExt = "ini";
            saveFileDialog.Filter = "ini 파일 (*.ini)|*.ini";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {

                loader.setINIValue("Grind Setting",  "GRIND_1ST_VAL", grind1stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_2ST_VAL", grind2stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_3ST_VAL", grind3stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_4ST_VAL", grind4stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_5ST_VAL", grind5stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_6ST_VAL", grind6stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_7ST_VAL", grind7stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_8ST_VAL", grind8stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_9ST_VAL", grind9stTextBox.Text,  saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_10ST_VAL", grind10stTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_11ST_VAL", grind11stTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_12ST_VAL", grind12stTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_13ST_VAL", grind13stTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_14ST_VAL", grind14stTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_15ST_VAL", grind15stTextBox.Text, saveFileDialog.FileName);

                loader.setINIValue("Grind Setting",  "GRIND_1ST_DIR",  grind1stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_2ST_DIR",  grind2stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_3ST_DIR",  grind3stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_4ST_DIR",  grind4stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_5ST_DIR",  grind5stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_6ST_DIR",  grind6stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_7ST_DIR",  grind7stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_8ST_DIR",  grind8stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting",  "GRIND_9ST_DIR",  grind9stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_10ST_DIR", grind10stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_11ST_DIR", grind11stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_12ST_DIR", grind12stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_13ST_DIR", grind13stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_14ST_DIR", grind14stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_15ST_DIR", grind15stComboBox.SelectedItem.ToString(), saveFileDialog.FileName);

                loader.setINIValue("Grind Setting", "GRIND_SOL1_START_TIME", grindSol1StartTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_SOL1_ON_TIME",    grindSol1OnTimeTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Grind Setting", "GRIND_SOL1_OFF_TIME",   grindSol1OffTimeTextBox.Text, saveFileDialog.FileName);

                loader.setINIValue("Dry Setting", "DRY_CW", dryCWTimeTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Dry Setting", "DRY_CCW", dryCCWTimeTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Dry Setting", "DRY_MAX_TEMP", dryMAXTempTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Dry Setting", "DRY_MIN_HUMI", dryMINHumiTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Dry Setting", "DRY_SOL2_ON_TIME", drySol2OnTimeTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Dry Setting", "DRY_SOL2_OFF_TIME", drySol2OffTimeTextBox.Text, saveFileDialog.FileName);
                loader.setINIValue("Dry Setting", "DRY_SOL2_STOP_TIME", drySol2StopTimeTextBox.Text, saveFileDialog.FileName);

                loader.setINIValue("Flush Setting", "ACTIVE_TIME", flushTimeTextBox.Text, saveFileDialog.FileName); 

                /*
                grindSol1StartTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_SOL1_START", openFileDialog.FileName);
                grindSol1OnTimeTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_SOL1_ON_TIME", openFileDialog.FileName);
                grindSol1OffTimeTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_SOL1_OFF_TIME", openFileDialog.FileName);

                dryCWTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_CW", openFileDialog.FileName);
                dryCCWTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_CCW", openFileDialog.FileName);
                dryMAXTempTextBox.Text = loader.getINIValue("Dry Setting", "DRY_MAX_TEMP", openFileDialog.FileName);
                dryMINHumiTextBox.Text = loader.getINIValue("Dry Setting", "DRY_MIN_HUMI", openFileDialog.FileName);

                drySol2OnTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_SOL2_ON_TIME", openFileDialog.FileName);
                drySol2OffTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_SOL2_OFF_TIME", openFileDialog.FileName);

                flushTimeTextBox.Text = loader.getINIValue("Flush Setting", "ACTIVE_TIME", openFileDialog.FileName);                  
                 */
            }
            MessageBox.Show(saveFileDialog.FileName + "에 저장되었습니다.");
        }

        private void setComboBox(ComboBox box, string text) {
            switch (text) {
                case "CW": box.SelectedIndex = 0; break;
                case "CCW": box.SelectedIndex = 1; break;
                case "STOP": box.SelectedIndex = 2; break;
            }
        }

        private void loadButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "ini";
            openFileDialog.Title = "Load INI File";
            openFileDialog.Filter = "ini 파일 (*.ini)|*.ini";
            //string text = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                //text = loader.getINIValue("Grind Setting", "GRIND_1ST_DIR", openFileDialog.FileName);
                //if (text == "CW") { grind1stComboBox.SelectedIndex = 0; } else { grind1stComboBox.SelectedIndex = 1; }
                grind1stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_1ST_VAL", openFileDialog.FileName);

                setComboBox(grind2stComboBox, loader.getINIValue("Grind Setting", "GRIND_2ST_DIR", openFileDialog.FileName));
                grind2stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_2ST_VAL", openFileDialog.FileName);

                setComboBox(grind3stComboBox, loader.getINIValue("Grind Setting", "GRIND_3ST_DIR", openFileDialog.FileName));
                grind3stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_3ST_VAL", openFileDialog.FileName);

                setComboBox(grind4stComboBox, loader.getINIValue("Grind Setting", "GRIND_4ST_DIR", openFileDialog.FileName));
                grind4stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_4ST_VAL", openFileDialog.FileName);

                setComboBox(grind5stComboBox, loader.getINIValue("Grind Setting", "GRIND_5ST_DIR", openFileDialog.FileName));
                grind5stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_5ST_VAL", openFileDialog.FileName);

                setComboBox(grind6stComboBox, loader.getINIValue("Grind Setting", "GRIND_6ST_DIR", openFileDialog.FileName));
                grind6stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_6ST_VAL", openFileDialog.FileName);

                setComboBox(grind7stComboBox, loader.getINIValue("Grind Setting", "GRIND_7ST_DIR", openFileDialog.FileName));
                grind7stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_7ST_VAL", openFileDialog.FileName);

                setComboBox(grind8stComboBox, loader.getINIValue("Grind Setting", "GRIND_8ST_DIR", openFileDialog.FileName));
                grind8stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_8ST_VAL", openFileDialog.FileName);

                setComboBox(grind9stComboBox, loader.getINIValue("Grind Setting", "GRIND_9ST_DIR", openFileDialog.FileName));
                grind9stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_9ST_VAL", openFileDialog.FileName);

                setComboBox(grind10stComboBox, loader.getINIValue("Grind Setting", "GRIND_10ST_DIR", openFileDialog.FileName));
                grind10stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_10ST_VAL", openFileDialog.FileName);

                setComboBox(grind11stComboBox, loader.getINIValue("Grind Setting", "GRIND_11ST_DIR", openFileDialog.FileName));
                grind11stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_11ST_VAL", openFileDialog.FileName);

                setComboBox(grind12stComboBox, loader.getINIValue("Grind Setting", "GRIND_12ST_DIR", openFileDialog.FileName));
                grind12stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_12ST_VAL", openFileDialog.FileName);

                setComboBox(grind13stComboBox, loader.getINIValue("Grind Setting", "GRIND_13ST_DIR", openFileDialog.FileName));
                grind13stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_13ST_VAL", openFileDialog.FileName);

                setComboBox(grind14stComboBox, loader.getINIValue("Grind Setting", "GRIND_14ST_DIR", openFileDialog.FileName));
                grind14stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_14ST_VAL", openFileDialog.FileName);

                setComboBox(grind15stComboBox, loader.getINIValue("Grind Setting", "GRIND_15ST_DIR", openFileDialog.FileName));
                grind15stTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_15ST_VAL", openFileDialog.FileName);

                /////////////////////////
                grindSol1StartTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_SOL1_START_TIME", openFileDialog.FileName);
                grindSol1OnTimeTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_SOL1_ON_TIME", openFileDialog.FileName);
                grindSol1OffTimeTextBox.Text = loader.getINIValue("Grind Setting", "GRIND_SOL1_OFF_TIME", openFileDialog.FileName);

                dryCWTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_CW", openFileDialog.FileName);
                dryCCWTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_CCW", openFileDialog.FileName);
                dryMAXTempTextBox.Text = loader.getINIValue("Dry Setting", "DRY_MAX_TEMP", openFileDialog.FileName);
                dryMINHumiTextBox.Text = loader.getINIValue("Dry Setting", "DRY_MIN_HUMI", openFileDialog.FileName);

                drySol2OnTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_SOL2_ON_TIME", openFileDialog.FileName);
                drySol2OffTimeTextBox.Text = loader.getINIValue("Dry Setting", "DRY_SOL2_OFF_TIME", openFileDialog.FileName);

                flushTimeTextBox.Text = loader.getINIValue("Flush Setting", "ACTIVE_TIME", openFileDialog.FileName);
            }
        }

        private void serialPortx_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void addCRLFcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addCRLFcheckBox.Checked) { uart.setAppendCRLF(true); }
            else { uart.setAppendCRLF(false); }
        }



        private void grind1stComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //if (grind1stComboBox.SelectedItem.ToString() == "STOP") { setTotalBytesCount(getTotalBytesCount() + 2); }
            //else { setTotalBytesCount(getTotalBytesCount() + 1); }
            //totalByteCountLabel.Text= Convert.ToString(getTotalBytesCount());
        }

        private void grind2stComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //if (grind2stComboBox.SelectedItem.ToString() == "STOP") { setTotalBytesCount(getTotalBytesCount() + 2); }
            //else { setTotalBytesCount(getTotalBytesCount() + 1); }
            //totalByteCountLabel.Text = Convert.ToString(getTotalBytesCount());
        }
    }
}


