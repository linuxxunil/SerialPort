namespace SerialPortApplication
{
    partial class SerialPortForm1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_about = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimeGap = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSetPort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comDataBits = new System.Windows.Forms.ComboBox();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBaudRate = new System.Windows.Forms.ComboBox();
            this.comCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtReceiveList = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(433, 21);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(75, 23);
            this.btn_about.TabIndex = 0;
            this.btn_about.Text = "about";
            this.btn_about.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(337, 22);
            this.txtPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTimeGap);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnSetPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comStopBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comDataBits);
            this.groupBox1.Controls.Add(this.comParity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comBaudRate);
            this.groupBox1.Controls.Add(this.comCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 287);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtDataSize
            // 
            this.txtDataSize.Location = new System.Drawing.Point(102, 202);
            this.txtDataSize.Name = "txtDataSize";
            this.txtDataSize.Size = new System.Drawing.Size(120, 22);
            this.txtDataSize.TabIndex = 16;
            this.txtDataSize.Text = "512";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(37, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data Size : ";
            // 
            // txtTimeGap
            // 
            this.txtTimeGap.Location = new System.Drawing.Point(102, 172);
            this.txtTimeGap.Name = "txtTimeGap";
            this.txtTimeGap.Size = new System.Drawing.Size(120, 22);
            this.txtTimeGap.TabIndex = 13;
            this.txtTimeGap.Text = "10";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(148, 252);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSetPort
            // 
            this.btnSetPort.Location = new System.Drawing.Point(67, 252);
            this.btnSetPort.Name = "btnSetPort";
            this.btnSetPort.Size = new System.Drawing.Size(75, 23);
            this.btnSetPort.TabIndex = 11;
            this.btnSetPort.Text = "Set Port";
            this.btnSetPort.UseVisualStyleBackColor = true;
            this.btnSetPort.Click += new System.EventHandler(this.btnSetPort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(8, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time Gap (ms) : ";
            // 
            // comStopBits
            // 
            this.comStopBits.FormattingEnabled = true;
            this.comStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comStopBits.Location = new System.Drawing.Point(102, 142);
            this.comStopBits.Name = "comStopBits";
            this.comStopBits.Size = new System.Drawing.Size(120, 20);
            this.comStopBits.TabIndex = 9;
            this.comStopBits.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(37, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stop Bits : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(37, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Bits :";
            // 
            // comDataBits
            // 
            this.comDataBits.FormattingEnabled = true;
            this.comDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comDataBits.Location = new System.Drawing.Point(103, 112);
            this.comDataBits.Name = "comDataBits";
            this.comDataBits.Size = new System.Drawing.Size(120, 20);
            this.comDataBits.TabIndex = 6;
            this.comDataBits.Text = "8";
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comParity.Location = new System.Drawing.Point(102, 82);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(120, 20);
            this.comParity.TabIndex = 5;
            this.comParity.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "       Parity : ";
            // 
            // comBaudRate
            // 
            this.comBaudRate.FormattingEnabled = true;
            this.comBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000",
            "230400"});
            this.comBaudRate.Location = new System.Drawing.Point(103, 53);
            this.comBaudRate.Name = "comBaudRate";
            this.comBaudRate.Size = new System.Drawing.Size(120, 20);
            this.comBaudRate.TabIndex = 2;
            this.comBaudRate.Text = "9600";
            // 
            // comCom
            // 
            this.comCom.FormattingEnabled = true;
            this.comCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.comCom.Location = new System.Drawing.Point(103, 22);
            this.comCom.Name = "comCom";
            this.comCom.Size = new System.Drawing.Size(120, 20);
            this.comCom.TabIndex = 1;
            this.comCom.Text = "COM1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "          Port : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Controls.Add(this.btn_about);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtReceiveList
            // 
            this.txtReceiveList.Location = new System.Drawing.Point(257, 59);
            this.txtReceiveList.Multiline = true;
            this.txtReceiveList.Name = "txtReceiveList";
            this.txtReceiveList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceiveList.Size = new System.Drawing.Size(269, 278);
            this.txtReceiveList.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 344);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(514, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 373);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtReceiveList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comCom;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBaudRate;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comStopBits;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReceiveList;
        private System.Windows.Forms.TextBox txtTimeGap;
        private System.Windows.Forms.TextBox txtDataSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

