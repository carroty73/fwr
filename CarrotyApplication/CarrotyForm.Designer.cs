namespace CarrotyApplication
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.parityBitComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rxRichTextBox = new System.Windows.Forms.TextBox();
            this.addCRLFcheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.displayComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txButton4 = new System.Windows.Forms.Button();
            this.txTextBox4 = new System.Windows.Forms.TextBox();
            this.txButton3 = new System.Windows.Forms.Button();
            this.txButton2 = new System.Windows.Forms.Button();
            this.txButton1 = new System.Windows.Forms.Button();
            this.txTextBox3 = new System.Windows.Forms.TextBox();
            this.txTextBox2 = new System.Windows.Forms.TextBox();
            this.txTextBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.humiZedGraphControl = new ZedGraph.ZedGraphControl();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tempZedGraphControl = new ZedGraph.ZedGraphControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.fwrResetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.grindSol1StartTextBox = new System.Windows.Forms.TextBox();
            this.grindSol1OnTimeTextBox = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.grindSol1OffTimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.onlyFlushButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.onlyDryButton = new System.Windows.Forms.Button();
            this.onlyGrindButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.flushDataSendButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.flushTimeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.drySol2StopTimeTextBox = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.drySol2OnTimeTextBox = new System.Windows.Forms.TextBox();
            this.dryDataSendButton = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.drySol2OffTimeTextBox = new System.Windows.Forms.TextBox();
            this.dryMINHumiTextBox = new System.Windows.Forms.TextBox();
            this.dryMAXTempTextBox = new System.Windows.Forms.TextBox();
            this.dryCCWTimeTextBox = new System.Windows.Forms.TextBox();
            this.dryCWTimeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.totalByteCountLabel = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.grind1stComboBox = new System.Windows.Forms.ComboBox();
            this.grind15stComboBox = new System.Windows.Forms.ComboBox();
            this.grind14stComboBox = new System.Windows.Forms.ComboBox();
            this.grind9stComboBox = new System.Windows.Forms.ComboBox();
            this.grind7stComboBox = new System.Windows.Forms.ComboBox();
            this.grind6stComboBox = new System.Windows.Forms.ComboBox();
            this.grind12stComboBox = new System.Windows.Forms.ComboBox();
            this.grind13stComboBox = new System.Windows.Forms.ComboBox();
            this.grind10stComboBox = new System.Windows.Forms.ComboBox();
            this.grind11stComboBox = new System.Windows.Forms.ComboBox();
            this.grind8stComboBox = new System.Windows.Forms.ComboBox();
            this.grind5stComboBox = new System.Windows.Forms.ComboBox();
            this.grind4stComboBox = new System.Windows.Forms.ComboBox();
            this.grind3stComboBox = new System.Windows.Forms.ComboBox();
            this.grind2stComboBox = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grind14stTextBox = new System.Windows.Forms.TextBox();
            this.grind13stTextBox = new System.Windows.Forms.TextBox();
            this.grind12stTextBox = new System.Windows.Forms.TextBox();
            this.grind15stTextBox = new System.Windows.Forms.TextBox();
            this.grind11stTextBox = new System.Windows.Forms.TextBox();
            this.grind10stTextBox = new System.Windows.Forms.TextBox();
            this.grind9stTextBox = new System.Windows.Forms.TextBox();
            this.grind8stTextBox = new System.Windows.Forms.TextBox();
            this.grind7stTextBox = new System.Windows.Forms.TextBox();
            this.grind6stTextBox = new System.Windows.Forms.TextBox();
            this.grind5stTextBox = new System.Windows.Forms.TextBox();
            this.grind4stTextBox = new System.Windows.Forms.TextBox();
            this.grind2stTextBox = new System.Windows.Forms.TextBox();
            this.grind3stTextBox = new System.Windows.Forms.TextBox();
            this.grind1stTextBox = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.grindDataSendButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portComboBox);
            this.groupBox1.Controls.Add(this.parityBitComboBox);
            this.groupBox1.Controls.Add(this.stopBitComboBox);
            this.groupBox1.Controls.Add(this.dataBitComboBox);
            this.groupBox1.Controls.Add(this.baudRateComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(537, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comm. Setting";
            // 
            // portComboBox
            // 
            this.portComboBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(80, 198);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.portComboBox.Size = new System.Drawing.Size(101, 23);
            this.portComboBox.TabIndex = 6;
            this.portComboBox.Text = "COM1";
            // 
            // parityBitComboBox
            // 
            this.parityBitComboBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.parityBitComboBox.FormattingEnabled = true;
            this.parityBitComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityBitComboBox.Location = new System.Drawing.Point(80, 118);
            this.parityBitComboBox.Name = "parityBitComboBox";
            this.parityBitComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parityBitComboBox.Size = new System.Drawing.Size(101, 23);
            this.parityBitComboBox.TabIndex = 4;
            this.parityBitComboBox.Text = "None";
            // 
            // stopBitComboBox
            // 
            this.stopBitComboBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopBitComboBox.FormattingEnabled = true;
            this.stopBitComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitComboBox.Location = new System.Drawing.Point(80, 158);
            this.stopBitComboBox.Name = "stopBitComboBox";
            this.stopBitComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopBitComboBox.Size = new System.Drawing.Size(101, 23);
            this.stopBitComboBox.TabIndex = 5;
            this.stopBitComboBox.Text = "1";
            // 
            // dataBitComboBox
            // 
            this.dataBitComboBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataBitComboBox.FormattingEnabled = true;
            this.dataBitComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.dataBitComboBox.Location = new System.Drawing.Point(80, 78);
            this.dataBitComboBox.Name = "dataBitComboBox";
            this.dataBitComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataBitComboBox.Size = new System.Drawing.Size(101, 23);
            this.dataBitComboBox.TabIndex = 3;
            this.dataBitComboBox.Text = "8";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(80, 38);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baudRateComboBox.Size = new System.Drawing.Size(101, 23);
            this.baudRateComboBox.TabIndex = 2;
            this.baudRateComboBox.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stop Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Bits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baudrate";
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.openButton.Location = new System.Drawing.Point(537, 414);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(80, 40);
            this.openButton.TabIndex = 7;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.Location = new System.Drawing.Point(657, 414);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 40);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rxRichTextBox);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 453);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RX";
            // 
            // rxRichTextBox
            // 
            this.rxRichTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxRichTextBox.Location = new System.Drawing.Point(7, 24);
            this.rxRichTextBox.Multiline = true;
            this.rxRichTextBox.Name = "rxRichTextBox";
            this.rxRichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rxRichTextBox.Size = new System.Drawing.Size(503, 423);
            this.rxRichTextBox.TabIndex = 0;
            // 
            // addCRLFcheckBox
            // 
            this.addCRLFcheckBox.AutoSize = true;
            this.addCRLFcheckBox.Checked = true;
            this.addCRLFcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addCRLFcheckBox.Location = new System.Drawing.Point(99, 108);
            this.addCRLFcheckBox.Name = "addCRLFcheckBox";
            this.addCRLFcheckBox.Size = new System.Drawing.Size(87, 16);
            this.addCRLFcheckBox.TabIndex = 10;
            this.addCRLFcheckBox.Text = "Add CR/LF";
            this.addCRLFcheckBox.UseVisualStyleBackColor = true;
            this.addCRLFcheckBox.CheckedChanged += new System.EventHandler(this.addCRLFcheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Format";
            // 
            // displayComboBox
            // 
            this.displayComboBox.FormattingEnabled = true;
            this.displayComboBox.Items.AddRange(new object[] {
            "ASCII",
            "HEX",
            "DEC",
            "BIN"});
            this.displayComboBox.Location = new System.Drawing.Point(99, 71);
            this.displayComboBox.Name = "displayComboBox";
            this.displayComboBox.Size = new System.Drawing.Size(82, 20);
            this.displayComboBox.TabIndex = 9;
            this.displayComboBox.Text = "HEX";
            this.displayComboBox.SelectedIndexChanged += new System.EventHandler(this.displayComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(99, 31);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txButton4);
            this.groupBox3.Controls.Add(this.txTextBox4);
            this.groupBox3.Controls.Add(this.txButton3);
            this.groupBox3.Controls.Add(this.txButton2);
            this.groupBox3.Controls.Add(this.txButton1);
            this.groupBox3.Controls.Add(this.txTextBox3);
            this.groupBox3.Controls.Add(this.txTextBox2);
            this.groupBox3.Controls.Add(this.txTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(6, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 157);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TX";
            // 
            // txButton4
            // 
            this.txButton4.Location = new System.Drawing.Point(637, 120);
            this.txButton4.Name = "txButton4";
            this.txButton4.Size = new System.Drawing.Size(75, 25);
            this.txButton4.TabIndex = 14;
            this.txButton4.Text = "Send";
            this.txButton4.UseVisualStyleBackColor = true;
            this.txButton4.Click += new System.EventHandler(this.txButton4_Click);
            // 
            // txTextBox4
            // 
            this.txTextBox4.Location = new System.Drawing.Point(19, 121);
            this.txTextBox4.Name = "txTextBox4";
            this.txTextBox4.Size = new System.Drawing.Size(592, 25);
            this.txTextBox4.TabIndex = 6;
            // 
            // txButton3
            // 
            this.txButton3.Location = new System.Drawing.Point(637, 88);
            this.txButton3.Name = "txButton3";
            this.txButton3.Size = new System.Drawing.Size(75, 25);
            this.txButton3.TabIndex = 13;
            this.txButton3.Text = "Send";
            this.txButton3.UseVisualStyleBackColor = true;
            this.txButton3.Click += new System.EventHandler(this.txButton3_Click);
            // 
            // txButton2
            // 
            this.txButton2.Location = new System.Drawing.Point(637, 56);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(75, 25);
            this.txButton2.TabIndex = 12;
            this.txButton2.Text = "Send";
            this.txButton2.UseVisualStyleBackColor = true;
            this.txButton2.Click += new System.EventHandler(this.txButton2_Click);
            // 
            // txButton1
            // 
            this.txButton1.Location = new System.Drawing.Point(637, 23);
            this.txButton1.Name = "txButton1";
            this.txButton1.Size = new System.Drawing.Size(75, 26);
            this.txButton1.TabIndex = 11;
            this.txButton1.Text = "Send";
            this.txButton1.UseVisualStyleBackColor = true;
            this.txButton1.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // txTextBox3
            // 
            this.txTextBox3.Location = new System.Drawing.Point(19, 89);
            this.txTextBox3.Name = "txTextBox3";
            this.txTextBox3.Size = new System.Drawing.Size(592, 25);
            this.txTextBox3.TabIndex = 2;
            // 
            // txTextBox2
            // 
            this.txTextBox2.Location = new System.Drawing.Point(19, 57);
            this.txTextBox2.Name = "txTextBox2";
            this.txTextBox2.Size = new System.Drawing.Size(592, 25);
            this.txTextBox2.TabIndex = 1;
            // 
            // txTextBox1
            // 
            this.txTextBox1.Location = new System.Drawing.Point(19, 25);
            this.txTextBox1.Name = "txTextBox1";
            this.txTextBox1.Size = new System.Drawing.Size(592, 25);
            this.txTextBox1.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 679);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(771, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(635, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(9, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 652);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.openButton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.closeButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UART";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.clearButton);
            this.groupBox8.Controls.Add(this.addCRLFcheckBox);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.displayComboBox);
            this.groupBox8.Location = new System.Drawing.Point(537, 264);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 139);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Display Setting";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 3;
            this.label26.Text = "Display";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.humiZedGraphControl);
            this.tabPage2.Controls.Add(this.comboBox7);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tempZedGraphControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // humiZedGraphControl
            // 
            this.humiZedGraphControl.BackColor = System.Drawing.Color.Transparent;
            this.humiZedGraphControl.Location = new System.Drawing.Point(8, 246);
            this.humiZedGraphControl.Name = "humiZedGraphControl";
            this.humiZedGraphControl.ScrollGrace = 0D;
            this.humiZedGraphControl.ScrollMaxX = 0D;
            this.humiZedGraphControl.ScrollMaxY = 0D;
            this.humiZedGraphControl.ScrollMaxY2 = 0D;
            this.humiZedGraphControl.ScrollMinX = 0D;
            this.humiZedGraphControl.ScrollMinY = 0D;
            this.humiZedGraphControl.ScrollMinY2 = 0D;
            this.humiZedGraphControl.Size = new System.Drawing.Size(732, 241);
            this.humiZedGraphControl.TabIndex = 10;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "ASCII",
            "HEX"});
            this.comboBox7.Location = new System.Drawing.Point(478, 502);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 20);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.Text = "ASCII";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tempZedGraphControl
            // 
            this.tempZedGraphControl.BackColor = System.Drawing.Color.Transparent;
            this.tempZedGraphControl.Location = new System.Drawing.Point(6, 6);
            this.tempZedGraphControl.Name = "tempZedGraphControl";
            this.tempZedGraphControl.ScrollGrace = 0D;
            this.tempZedGraphControl.ScrollMaxX = 0D;
            this.tempZedGraphControl.ScrollMaxY = 0D;
            this.tempZedGraphControl.ScrollMaxY2 = 0D;
            this.tempZedGraphControl.ScrollMinX = 0D;
            this.tempZedGraphControl.ScrollMinY = 0D;
            this.tempZedGraphControl.ScrollMinY2 = 0D;
            this.tempZedGraphControl.Size = new System.Drawing.Size(734, 234);
            this.tempZedGraphControl.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.onlyFlushButton);
            this.tabPage4.Controls.Add(this.restartButton);
            this.tabPage4.Controls.Add(this.stopButton);
            this.tabPage4.Controls.Add(this.runButton);
            this.tabPage4.Controls.Add(this.onlyDryButton);
            this.tabPage4.Controls.Add(this.onlyGrindButton);
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(754, 626);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "FWR";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.fwrResetButton);
            this.groupBox9.Controls.Add(this.saveButton);
            this.groupBox9.Controls.Add(this.loadButton);
            this.groupBox9.Location = new System.Drawing.Point(390, 419);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(345, 82);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Load && Save";
            // 
            // fwrResetButton
            // 
            this.fwrResetButton.Location = new System.Drawing.Point(26, 25);
            this.fwrResetButton.Name = "fwrResetButton";
            this.fwrResetButton.Size = new System.Drawing.Size(75, 40);
            this.fwrResetButton.TabIndex = 8;
            this.fwrResetButton.Text = "Reset";
            this.fwrResetButton.UseVisualStyleBackColor = true;
            this.fwrResetButton.Click += new System.EventHandler(this.fwrResetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(140, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(249, 25);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 40);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // grindSol1StartTextBox
            // 
            this.grindSol1StartTextBox.Enabled = false;
            this.grindSol1StartTextBox.Location = new System.Drawing.Point(15, 474);
            this.grindSol1StartTextBox.Name = "grindSol1StartTextBox";
            this.grindSol1StartTextBox.Size = new System.Drawing.Size(60, 21);
            this.grindSol1StartTextBox.TabIndex = 156;
            this.grindSol1StartTextBox.Text = "0";
            this.grindSol1StartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grindSol1OnTimeTextBox
            // 
            this.grindSol1OnTimeTextBox.Location = new System.Drawing.Point(103, 474);
            this.grindSol1OnTimeTextBox.Name = "grindSol1OnTimeTextBox";
            this.grindSol1OnTimeTextBox.Size = new System.Drawing.Size(60, 21);
            this.grindSol1OnTimeTextBox.TabIndex = 17;
            this.grindSol1OnTimeTextBox.Text = "0";
            this.grindSol1OnTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(14, 457);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(63, 12);
            this.label58.TabIndex = 11;
            this.label58.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "ON Time";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(186, 457);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 12);
            this.label29.TabIndex = 11;
            this.label29.Text = "OFF Time";
            // 
            // grindSol1OffTimeTextBox
            // 
            this.grindSol1OffTimeTextBox.Location = new System.Drawing.Point(187, 474);
            this.grindSol1OffTimeTextBox.Name = "grindSol1OffTimeTextBox";
            this.grindSol1OffTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grindSol1OffTimeTextBox.Size = new System.Drawing.Size(60, 21);
            this.grindSol1OffTimeTextBox.TabIndex = 10;
            this.grindSol1OffTimeTextBox.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 477);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "sec";
            // 
            // onlyFlushButton
            // 
            this.onlyFlushButton.Location = new System.Drawing.Point(292, 562);
            this.onlyFlushButton.Name = "onlyFlushButton";
            this.onlyFlushButton.Size = new System.Drawing.Size(75, 52);
            this.onlyFlushButton.TabIndex = 15;
            this.onlyFlushButton.Text = "Only Flush";
            this.onlyFlushButton.UseVisualStyleBackColor = true;
            this.onlyFlushButton.Click += new System.EventHandler(this.onlyFlushButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(541, 562);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 52);
            this.restartButton.TabIndex = 14;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(420, 562);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 52);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(647, 562);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(89, 52);
            this.runButton.TabIndex = 12;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // onlyDryButton
            // 
            this.onlyDryButton.Location = new System.Drawing.Point(148, 562);
            this.onlyDryButton.Name = "onlyDryButton";
            this.onlyDryButton.Size = new System.Drawing.Size(75, 52);
            this.onlyDryButton.TabIndex = 11;
            this.onlyDryButton.Text = "Only Dry";
            this.onlyDryButton.UseVisualStyleBackColor = true;
            this.onlyDryButton.Click += new System.EventHandler(this.onlyDryButton_Click);
            // 
            // onlyGrindButton
            // 
            this.onlyGrindButton.Location = new System.Drawing.Point(23, 562);
            this.onlyGrindButton.Name = "onlyGrindButton";
            this.onlyGrindButton.Size = new System.Drawing.Size(75, 52);
            this.onlyGrindButton.TabIndex = 10;
            this.onlyGrindButton.Text = "Only Grind";
            this.onlyGrindButton.UseVisualStyleBackColor = true;
            this.onlyGrindButton.Click += new System.EventHandler(this.onlyGrindButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.flushDataSendButton);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.flushTimeTextBox);
            this.groupBox7.Location = new System.Drawing.Point(390, 293);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(346, 120);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Flush (=\'C\') Setting";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(292, 33);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(45, 12);
            this.label35.TabIndex = 31;
            this.label35.Text = "secx10";
            // 
            // flushDataSendButton
            // 
            this.flushDataSendButton.Location = new System.Drawing.Point(131, 62);
            this.flushDataSendButton.Name = "flushDataSendButton";
            this.flushDataSendButton.Size = new System.Drawing.Size(75, 33);
            this.flushDataSendButton.TabIndex = 12;
            this.flushDataSendButton.Text = "Send";
            this.flushDataSendButton.UseVisualStyleBackColor = true;
            this.flushDataSendButton.Click += new System.EventHandler(this.flushDataSendButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 12);
            this.label25.TabIndex = 11;
            this.label25.Text = "Active Time";
            // 
            // flushTimeTextBox
            // 
            this.flushTimeTextBox.Location = new System.Drawing.Point(186, 24);
            this.flushTimeTextBox.Name = "flushTimeTextBox";
            this.flushTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flushTimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.flushTimeTextBox.TabIndex = 0;
            this.flushTimeTextBox.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.drySol2StopTimeTextBox);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.drySol2OnTimeTextBox);
            this.groupBox6.Controls.Add(this.dryDataSendButton);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.drySol2OffTimeTextBox);
            this.groupBox6.Controls.Add(this.dryMINHumiTextBox);
            this.groupBox6.Controls.Add(this.dryMAXTempTextBox);
            this.groupBox6.Controls.Add(this.dryCCWTimeTextBox);
            this.groupBox6.Controls.Add(this.dryCWTimeTextBox);
            this.groupBox6.Location = new System.Drawing.Point(390, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(347, 261);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dry (=\'B\') Setting";
            // 
            // drySol2StopTimeTextBox
            // 
            this.drySol2StopTimeTextBox.Enabled = false;
            this.drySol2StopTimeTextBox.Location = new System.Drawing.Point(186, 187);
            this.drySol2StopTimeTextBox.Name = "drySol2StopTimeTextBox";
            this.drySol2StopTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drySol2StopTimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.drySol2StopTimeTextBox.TabIndex = 31;
            this.drySol2StopTimeTextBox.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(292, 190);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(26, 12);
            this.label36.TabIndex = 30;
            this.label36.Text = "sec";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(292, 163);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 12);
            this.label34.TabIndex = 30;
            this.label34.Text = "sec";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(292, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 12);
            this.label33.TabIndex = 29;
            this.label33.Text = "sec";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(292, 106);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 12);
            this.label32.TabIndex = 28;
            this.label32.Text = "%";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(292, 80);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 12);
            this.label31.TabIndex = 27;
            this.label31.Text = "C";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(292, 53);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 12);
            this.label30.TabIndex = 26;
            this.label30.Text = "sec";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(292, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 12);
            this.label28.TabIndex = 25;
            this.label28.Text = "sec";
            // 
            // drySol2OnTimeTextBox
            // 
            this.drySol2OnTimeTextBox.Location = new System.Drawing.Point(186, 133);
            this.drySol2OnTimeTextBox.Name = "drySol2OnTimeTextBox";
            this.drySol2OnTimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.drySol2OnTimeTextBox.TabIndex = 12;
            this.drySol2OnTimeTextBox.Text = "0";
            this.drySol2OnTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dryDataSendButton
            // 
            this.dryDataSendButton.Location = new System.Drawing.Point(131, 214);
            this.dryDataSendButton.Name = "dryDataSendButton";
            this.dryDataSendButton.Size = new System.Drawing.Size(75, 36);
            this.dryDataSendButton.TabIndex = 11;
            this.dryDataSendButton.Text = "Send";
            this.dryDataSendButton.UseVisualStyleBackColor = true;
            this.dryDataSendButton.Click += new System.EventHandler(this.dryDataSendButton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 136);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 12);
            this.label27.TabIndex = 10;
            this.label27.Text = "SOL2 ON Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "Stop Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 12);
            this.label24.TabIndex = 10;
            this.label24.Text = "SOL2 OFF Time";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 12);
            this.label23.TabIndex = 10;
            this.label23.Text = "min HUMI";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "MAX Temp";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 12);
            this.label21.TabIndex = 10;
            this.label21.Text = "CCW";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 12);
            this.label20.TabIndex = 10;
            this.label20.Text = "CW";
            // 
            // drySol2OffTimeTextBox
            // 
            this.drySol2OffTimeTextBox.Location = new System.Drawing.Point(186, 160);
            this.drySol2OffTimeTextBox.Name = "drySol2OffTimeTextBox";
            this.drySol2OffTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drySol2OffTimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.drySol2OffTimeTextBox.TabIndex = 4;
            this.drySol2OffTimeTextBox.Text = "0";
            // 
            // dryMINHumiTextBox
            // 
            this.dryMINHumiTextBox.Location = new System.Drawing.Point(186, 103);
            this.dryMINHumiTextBox.Name = "dryMINHumiTextBox";
            this.dryMINHumiTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dryMINHumiTextBox.Size = new System.Drawing.Size(100, 21);
            this.dryMINHumiTextBox.TabIndex = 3;
            this.dryMINHumiTextBox.Text = "0";
            // 
            // dryMAXTempTextBox
            // 
            this.dryMAXTempTextBox.Location = new System.Drawing.Point(186, 77);
            this.dryMAXTempTextBox.Name = "dryMAXTempTextBox";
            this.dryMAXTempTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dryMAXTempTextBox.Size = new System.Drawing.Size(100, 21);
            this.dryMAXTempTextBox.TabIndex = 2;
            this.dryMAXTempTextBox.Text = "0";
            // 
            // dryCCWTimeTextBox
            // 
            this.dryCCWTimeTextBox.Location = new System.Drawing.Point(186, 50);
            this.dryCCWTimeTextBox.Name = "dryCCWTimeTextBox";
            this.dryCCWTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dryCCWTimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.dryCCWTimeTextBox.TabIndex = 1;
            this.dryCCWTimeTextBox.Text = "0";
            // 
            // dryCWTimeTextBox
            // 
            this.dryCWTimeTextBox.Location = new System.Drawing.Point(186, 21);
            this.dryCWTimeTextBox.Name = "dryCWTimeTextBox";
            this.dryCWTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dryCWTimeTextBox.Size = new System.Drawing.Size(100, 21);
            this.dryCWTimeTextBox.TabIndex = 0;
            this.dryCWTimeTextBox.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grindSol1StartTextBox);
            this.groupBox5.Controls.Add(this.totalByteCountLabel);
            this.groupBox5.Controls.Add(this.label59);
            this.groupBox5.Controls.Add(this.grindSol1OnTimeTextBox);
            this.groupBox5.Controls.Add(this.grind1stComboBox);
            this.groupBox5.Controls.Add(this.label58);
            this.groupBox5.Controls.Add(this.grind15stComboBox);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.grind14stComboBox);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.grindSol1OffTimeTextBox);
            this.groupBox5.Controls.Add(this.grind9stComboBox);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.grind7stComboBox);
            this.groupBox5.Controls.Add(this.grind6stComboBox);
            this.groupBox5.Controls.Add(this.grind12stComboBox);
            this.groupBox5.Controls.Add(this.grind13stComboBox);
            this.groupBox5.Controls.Add(this.grind10stComboBox);
            this.groupBox5.Controls.Add(this.grind11stComboBox);
            this.groupBox5.Controls.Add(this.grind8stComboBox);
            this.groupBox5.Controls.Add(this.grind5stComboBox);
            this.groupBox5.Controls.Add(this.grind4stComboBox);
            this.groupBox5.Controls.Add(this.grind3stComboBox);
            this.groupBox5.Controls.Add(this.grind2stComboBox);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label54);
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.label57);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label40);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.grind14stTextBox);
            this.groupBox5.Controls.Add(this.grind13stTextBox);
            this.groupBox5.Controls.Add(this.grind12stTextBox);
            this.groupBox5.Controls.Add(this.grind15stTextBox);
            this.groupBox5.Controls.Add(this.grind11stTextBox);
            this.groupBox5.Controls.Add(this.grind10stTextBox);
            this.groupBox5.Controls.Add(this.grind9stTextBox);
            this.groupBox5.Controls.Add(this.grind8stTextBox);
            this.groupBox5.Controls.Add(this.grind7stTextBox);
            this.groupBox5.Controls.Add(this.grind6stTextBox);
            this.groupBox5.Controls.Add(this.grind5stTextBox);
            this.groupBox5.Controls.Add(this.grind4stTextBox);
            this.groupBox5.Controls.Add(this.grind2stTextBox);
            this.groupBox5.Controls.Add(this.grind3stTextBox);
            this.groupBox5.Controls.Add(this.grind1stTextBox);
            this.groupBox5.Controls.Add(this.label56);
            this.groupBox5.Controls.Add(this.label64);
            this.groupBox5.Controls.Add(this.grindDataSendButton);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(21, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 544);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grind (=\'A\') Motor Setting";
            // 
            // totalByteCountLabel
            // 
            this.totalByteCountLabel.AutoSize = true;
            this.totalByteCountLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalByteCountLabel.Location = new System.Drawing.Point(291, 63);
            this.totalByteCountLabel.Name = "totalByteCountLabel";
            this.totalByteCountLabel.Size = new System.Drawing.Size(21, 21);
            this.totalByteCountLabel.TabIndex = 175;
            this.totalByteCountLabel.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(264, 38);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(62, 12);
            this.label59.TabIndex = 174;
            this.label59.Text = "Total Byte";
            // 
            // grind1stComboBox
            // 
            this.grind1stComboBox.FormattingEnabled = true;
            this.grind1stComboBox.Items.AddRange(new object[] {
            "CW"});
            this.grind1stComboBox.Location = new System.Drawing.Point(57, 39);
            this.grind1stComboBox.Name = "grind1stComboBox";
            this.grind1stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind1stComboBox.TabIndex = 173;
            this.grind1stComboBox.Text = "CW";
            this.grind1stComboBox.SelectedIndexChanged += new System.EventHandler(this.grind1stComboBox_SelectedIndexChanged);
            // 
            // grind15stComboBox
            // 
            this.grind15stComboBox.FormattingEnabled = true;
            this.grind15stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind15stComboBox.Location = new System.Drawing.Point(57, 417);
            this.grind15stComboBox.Name = "grind15stComboBox";
            this.grind15stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind15stComboBox.TabIndex = 172;
            this.grind15stComboBox.Text = "CW";
            // 
            // grind14stComboBox
            // 
            this.grind14stComboBox.FormattingEnabled = true;
            this.grind14stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind14stComboBox.Location = new System.Drawing.Point(57, 390);
            this.grind14stComboBox.Name = "grind14stComboBox";
            this.grind14stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind14stComboBox.TabIndex = 171;
            this.grind14stComboBox.Text = "CCW";
            // 
            // grind9stComboBox
            // 
            this.grind9stComboBox.FormattingEnabled = true;
            this.grind9stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind9stComboBox.Location = new System.Drawing.Point(57, 255);
            this.grind9stComboBox.Name = "grind9stComboBox";
            this.grind9stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind9stComboBox.TabIndex = 170;
            this.grind9stComboBox.Text = "CW";
            // 
            // grind7stComboBox
            // 
            this.grind7stComboBox.FormattingEnabled = true;
            this.grind7stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind7stComboBox.Location = new System.Drawing.Point(57, 201);
            this.grind7stComboBox.Name = "grind7stComboBox";
            this.grind7stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind7stComboBox.TabIndex = 169;
            this.grind7stComboBox.Text = "CW";
            // 
            // grind6stComboBox
            // 
            this.grind6stComboBox.FormattingEnabled = true;
            this.grind6stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind6stComboBox.Location = new System.Drawing.Point(57, 174);
            this.grind6stComboBox.Name = "grind6stComboBox";
            this.grind6stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind6stComboBox.TabIndex = 168;
            this.grind6stComboBox.Text = "CCW";
            // 
            // grind12stComboBox
            // 
            this.grind12stComboBox.FormattingEnabled = true;
            this.grind12stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind12stComboBox.Location = new System.Drawing.Point(57, 336);
            this.grind12stComboBox.Name = "grind12stComboBox";
            this.grind12stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind12stComboBox.TabIndex = 167;
            this.grind12stComboBox.Text = "CCW";
            // 
            // grind13stComboBox
            // 
            this.grind13stComboBox.FormattingEnabled = true;
            this.grind13stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind13stComboBox.Location = new System.Drawing.Point(57, 363);
            this.grind13stComboBox.Name = "grind13stComboBox";
            this.grind13stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind13stComboBox.TabIndex = 165;
            this.grind13stComboBox.Text = "CW";
            // 
            // grind10stComboBox
            // 
            this.grind10stComboBox.FormattingEnabled = true;
            this.grind10stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind10stComboBox.Location = new System.Drawing.Point(57, 282);
            this.grind10stComboBox.Name = "grind10stComboBox";
            this.grind10stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind10stComboBox.TabIndex = 164;
            this.grind10stComboBox.Text = "CCW";
            // 
            // grind11stComboBox
            // 
            this.grind11stComboBox.FormattingEnabled = true;
            this.grind11stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind11stComboBox.Location = new System.Drawing.Point(57, 309);
            this.grind11stComboBox.Name = "grind11stComboBox";
            this.grind11stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind11stComboBox.TabIndex = 162;
            this.grind11stComboBox.Text = "CW";
            // 
            // grind8stComboBox
            // 
            this.grind8stComboBox.FormattingEnabled = true;
            this.grind8stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind8stComboBox.Location = new System.Drawing.Point(57, 228);
            this.grind8stComboBox.Name = "grind8stComboBox";
            this.grind8stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind8stComboBox.TabIndex = 161;
            this.grind8stComboBox.Text = "CCW";
            // 
            // grind5stComboBox
            // 
            this.grind5stComboBox.FormattingEnabled = true;
            this.grind5stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind5stComboBox.Location = new System.Drawing.Point(57, 147);
            this.grind5stComboBox.Name = "grind5stComboBox";
            this.grind5stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind5stComboBox.TabIndex = 159;
            this.grind5stComboBox.Text = "CW";
            // 
            // grind4stComboBox
            // 
            this.grind4stComboBox.FormattingEnabled = true;
            this.grind4stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind4stComboBox.Location = new System.Drawing.Point(57, 120);
            this.grind4stComboBox.Name = "grind4stComboBox";
            this.grind4stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind4stComboBox.TabIndex = 158;
            this.grind4stComboBox.Text = "CCW";
            // 
            // grind3stComboBox
            // 
            this.grind3stComboBox.FormattingEnabled = true;
            this.grind3stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind3stComboBox.Location = new System.Drawing.Point(57, 93);
            this.grind3stComboBox.Name = "grind3stComboBox";
            this.grind3stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind3stComboBox.TabIndex = 156;
            this.grind3stComboBox.Text = "CW";
            // 
            // grind2stComboBox
            // 
            this.grind2stComboBox.FormattingEnabled = true;
            this.grind2stComboBox.Items.AddRange(new object[] {
            "CW",
            "CCW",
            "STOP"});
            this.grind2stComboBox.Location = new System.Drawing.Point(57, 66);
            this.grind2stComboBox.Name = "grind2stComboBox";
            this.grind2stComboBox.Size = new System.Drawing.Size(60, 20);
            this.grind2stComboBox.TabIndex = 155;
            this.grind2stComboBox.Text = "CCW";
            this.grind2stComboBox.SelectedIndexChanged += new System.EventHandler(this.grind2stComboBox_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(18, 418);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(27, 12);
            this.label42.TabIndex = 154;
            this.label42.Text = "15st";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 391);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(27, 12);
            this.label43.TabIndex = 153;
            this.label43.Text = "14st";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(18, 364);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(27, 12);
            this.label44.TabIndex = 152;
            this.label44.Text = "13st";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(18, 337);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(27, 12);
            this.label45.TabIndex = 151;
            this.label45.Text = "12st";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(18, 310);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(27, 12);
            this.label46.TabIndex = 150;
            this.label46.Text = "11st";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(18, 283);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(27, 12);
            this.label47.TabIndex = 149;
            this.label47.Text = "10st";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(18, 256);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(21, 12);
            this.label48.TabIndex = 148;
            this.label48.Text = "9st";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(18, 229);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(21, 12);
            this.label49.TabIndex = 147;
            this.label49.Text = "8st";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(18, 202);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(21, 12);
            this.label50.TabIndex = 146;
            this.label50.Text = "7st";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(18, 175);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(21, 12);
            this.label51.TabIndex = 145;
            this.label51.Text = "6st";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(18, 148);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(21, 12);
            this.label52.TabIndex = 144;
            this.label52.Text = "5st";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(18, 121);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(21, 12);
            this.label53.TabIndex = 143;
            this.label53.Text = "4st";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(18, 94);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(21, 12);
            this.label54.TabIndex = 142;
            this.label54.Text = "3st";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(18, 67);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(21, 12);
            this.label55.TabIndex = 141;
            this.label55.Text = "2st";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(18, 40);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(21, 12);
            this.label57.TabIndex = 140;
            this.label57.Text = "1st";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(211, 419);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(26, 12);
            this.label41.TabIndex = 139;
            this.label41.Text = "sec";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(211, 392);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(26, 12);
            this.label39.TabIndex = 137;
            this.label39.Text = "sec";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(211, 365);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(26, 12);
            this.label40.TabIndex = 136;
            this.label40.Text = "sec";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(211, 338);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(26, 12);
            this.label37.TabIndex = 135;
            this.label37.Text = "sec";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(211, 311);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(26, 12);
            this.label38.TabIndex = 134;
            this.label38.Text = "sec";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(211, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 12);
            this.label18.TabIndex = 133;
            this.label18.Text = "sec";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(211, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 12);
            this.label19.TabIndex = 132;
            this.label19.Text = "sec";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(211, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 12);
            this.label16.TabIndex = 131;
            this.label16.Text = "sec";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(211, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 12);
            this.label17.TabIndex = 130;
            this.label17.Text = "sec";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 12);
            this.label11.TabIndex = 129;
            this.label11.Text = "sec";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 12);
            this.label12.TabIndex = 128;
            this.label12.Text = "sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 12);
            this.label9.TabIndex = 127;
            this.label9.Text = "sec";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 12);
            this.label10.TabIndex = 126;
            this.label10.Text = "sec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 125;
            this.label8.Text = "sec";
            // 
            // grind14stTextBox
            // 
            this.grind14stTextBox.Location = new System.Drawing.Point(142, 389);
            this.grind14stTextBox.Name = "grind14stTextBox";
            this.grind14stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind14stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind14stTextBox.TabIndex = 94;
            this.grind14stTextBox.Text = "0";
            // 
            // grind13stTextBox
            // 
            this.grind13stTextBox.Location = new System.Drawing.Point(142, 362);
            this.grind13stTextBox.Name = "grind13stTextBox";
            this.grind13stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind13stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind13stTextBox.TabIndex = 93;
            this.grind13stTextBox.Text = "0";
            // 
            // grind12stTextBox
            // 
            this.grind12stTextBox.Location = new System.Drawing.Point(142, 335);
            this.grind12stTextBox.Name = "grind12stTextBox";
            this.grind12stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind12stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind12stTextBox.TabIndex = 92;
            this.grind12stTextBox.Text = "0";
            // 
            // grind15stTextBox
            // 
            this.grind15stTextBox.Location = new System.Drawing.Point(142, 416);
            this.grind15stTextBox.Name = "grind15stTextBox";
            this.grind15stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind15stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind15stTextBox.TabIndex = 91;
            this.grind15stTextBox.Text = "0";
            // 
            // grind11stTextBox
            // 
            this.grind11stTextBox.Location = new System.Drawing.Point(142, 308);
            this.grind11stTextBox.Name = "grind11stTextBox";
            this.grind11stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind11stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind11stTextBox.TabIndex = 90;
            this.grind11stTextBox.Text = "0";
            // 
            // grind10stTextBox
            // 
            this.grind10stTextBox.Location = new System.Drawing.Point(142, 281);
            this.grind10stTextBox.Name = "grind10stTextBox";
            this.grind10stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind10stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind10stTextBox.TabIndex = 89;
            this.grind10stTextBox.Text = "0";
            // 
            // grind9stTextBox
            // 
            this.grind9stTextBox.Location = new System.Drawing.Point(142, 254);
            this.grind9stTextBox.Name = "grind9stTextBox";
            this.grind9stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind9stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind9stTextBox.TabIndex = 88;
            this.grind9stTextBox.Text = "0";
            // 
            // grind8stTextBox
            // 
            this.grind8stTextBox.Location = new System.Drawing.Point(142, 227);
            this.grind8stTextBox.Name = "grind8stTextBox";
            this.grind8stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind8stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind8stTextBox.TabIndex = 87;
            this.grind8stTextBox.Text = "0";
            // 
            // grind7stTextBox
            // 
            this.grind7stTextBox.Location = new System.Drawing.Point(142, 200);
            this.grind7stTextBox.Name = "grind7stTextBox";
            this.grind7stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind7stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind7stTextBox.TabIndex = 86;
            this.grind7stTextBox.Text = "0";
            // 
            // grind6stTextBox
            // 
            this.grind6stTextBox.Location = new System.Drawing.Point(142, 173);
            this.grind6stTextBox.Name = "grind6stTextBox";
            this.grind6stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind6stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind6stTextBox.TabIndex = 85;
            this.grind6stTextBox.Text = "0";
            // 
            // grind5stTextBox
            // 
            this.grind5stTextBox.Location = new System.Drawing.Point(142, 146);
            this.grind5stTextBox.Name = "grind5stTextBox";
            this.grind5stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind5stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind5stTextBox.TabIndex = 84;
            this.grind5stTextBox.Text = "0";
            // 
            // grind4stTextBox
            // 
            this.grind4stTextBox.Location = new System.Drawing.Point(142, 119);
            this.grind4stTextBox.Name = "grind4stTextBox";
            this.grind4stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind4stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind4stTextBox.TabIndex = 83;
            this.grind4stTextBox.Text = "0";
            // 
            // grind2stTextBox
            // 
            this.grind2stTextBox.Location = new System.Drawing.Point(142, 65);
            this.grind2stTextBox.Name = "grind2stTextBox";
            this.grind2stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind2stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind2stTextBox.TabIndex = 82;
            this.grind2stTextBox.Text = "0";
            // 
            // grind3stTextBox
            // 
            this.grind3stTextBox.Location = new System.Drawing.Point(142, 92);
            this.grind3stTextBox.Name = "grind3stTextBox";
            this.grind3stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind3stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind3stTextBox.TabIndex = 80;
            this.grind3stTextBox.Text = "0";
            // 
            // grind1stTextBox
            // 
            this.grind1stTextBox.Location = new System.Drawing.Point(142, 38);
            this.grind1stTextBox.Name = "grind1stTextBox";
            this.grind1stTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grind1stTextBox.Size = new System.Drawing.Size(60, 21);
            this.grind1stTextBox.TabIndex = 81;
            this.grind1stTextBox.Text = "0";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(211, 41);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(26, 12);
            this.label56.TabIndex = 51;
            this.label56.Text = "sec";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(155, 23);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(37, 12);
            this.label64.TabIndex = 45;
            this.label64.Text = "Value";
            // 
            // grindDataSendButton
            // 
            this.grindDataSendButton.Location = new System.Drawing.Point(148, 504);
            this.grindDataSendButton.Name = "grindDataSendButton";
            this.grindDataSendButton.Size = new System.Drawing.Size(75, 34);
            this.grindDataSendButton.TabIndex = 16;
            this.grindDataSendButton.Text = "Send";
            this.grindDataSendButton.UseVisualStyleBackColor = true;
            this.grindDataSendButton.Click += new System.EventHandler(this.grindDataSendButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "Direction";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 655);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(771, 701);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Carroty USART Terminal ver1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox parityBitComboBox;
        private System.Windows.Forms.ComboBox stopBitComboBox;
        private System.Windows.Forms.ComboBox dataBitComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox rxRichTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txButton3;
        private System.Windows.Forms.Button txButton2;
        private System.Windows.Forms.Button txButton1;
        private System.Windows.Forms.TextBox txTextBox3;
        private System.Windows.Forms.TextBox txTextBox2;
        private System.Windows.Forms.TextBox txTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox displayComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button txButton4;
        private System.Windows.Forms.TextBox txTextBox4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private ZedGraph.ZedGraphControl tempZedGraphControl;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox addCRLFcheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button fwrResetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox flushTimeTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox drySol2OffTimeTextBox;
        private System.Windows.Forms.TextBox dryMINHumiTextBox;
        private System.Windows.Forms.TextBox dryMAXTempTextBox;
        private System.Windows.Forms.TextBox dryCCWTimeTextBox;
        private System.Windows.Forms.TextBox dryCWTimeTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button onlyDryButton;
        private System.Windows.Forms.Button onlyGrindButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button onlyFlushButton;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox grindSol1OffTimeTextBox;
        private System.Windows.Forms.Button flushDataSendButton;
        private System.Windows.Forms.Button dryDataSendButton;
        private System.Windows.Forms.Button grindDataSendButton;
        private ZedGraph.ZedGraphControl humiZedGraphControl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox grindSol1OnTimeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox drySol2OnTimeTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox drySol2StopTimeTextBox;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox grind14stTextBox;
        private System.Windows.Forms.TextBox grind13stTextBox;
        private System.Windows.Forms.TextBox grind12stTextBox;
        private System.Windows.Forms.TextBox grind15stTextBox;
        private System.Windows.Forms.TextBox grind11stTextBox;
        private System.Windows.Forms.TextBox grind10stTextBox;
        private System.Windows.Forms.TextBox grind9stTextBox;
        private System.Windows.Forms.TextBox grind8stTextBox;
        private System.Windows.Forms.TextBox grind7stTextBox;
        private System.Windows.Forms.TextBox grind6stTextBox;
        private System.Windows.Forms.TextBox grind5stTextBox;
        private System.Windows.Forms.TextBox grind4stTextBox;
        private System.Windows.Forms.TextBox grind2stTextBox;
        private System.Windows.Forms.TextBox grind3stTextBox;
        private System.Windows.Forms.TextBox grind1stTextBox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox grindSol1StartTextBox;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox grind2stComboBox;
        private System.Windows.Forms.ComboBox grind12stComboBox;
        private System.Windows.Forms.ComboBox grind13stComboBox;
        private System.Windows.Forms.ComboBox grind10stComboBox;
        private System.Windows.Forms.ComboBox grind11stComboBox;
        private System.Windows.Forms.ComboBox grind8stComboBox;
        private System.Windows.Forms.ComboBox grind5stComboBox;
        private System.Windows.Forms.ComboBox grind4stComboBox;
        private System.Windows.Forms.ComboBox grind3stComboBox;
        private System.Windows.Forms.ComboBox grind15stComboBox;
        private System.Windows.Forms.ComboBox grind14stComboBox;
        private System.Windows.Forms.ComboBox grind9stComboBox;
        private System.Windows.Forms.ComboBox grind7stComboBox;
        private System.Windows.Forms.ComboBox grind6stComboBox;
        private System.Windows.Forms.ComboBox grind1stComboBox;
        private System.Windows.Forms.Label totalByteCountLabel;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

