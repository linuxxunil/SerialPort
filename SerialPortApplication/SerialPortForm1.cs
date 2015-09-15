using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace SerialPortApplication
{
    public partial class SerialPortForm1 : Form
    {
        private SerialPort comPort = null;

        public SerialPortForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initSerialPort();
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.txtPath.Text = openFileDialog1.FileName;

        }

        private Parity getParity()
        {

            switch (comParity.Text)
            {
                case "None": return Parity.None;
                case "Odd": return Parity.Odd;
                case "Even": return Parity.Even;
                case "Mark": return Parity.Mark;
                case "Space": return Parity.Space;
            }
            return Parity.None;
        }

        private String getComPort()
        {
            return comCom.Text;
        }

        private int getBaudRate()
        {
            return int.Parse(comBaudRate.Text);
        }

        private int getDataBits()
        {
            return int.Parse(comDataBits.Text);
        }

        private StopBits getStopBits()
        {
            switch (comStopBits.Text)
            {
                case "1": return StopBits.One;
                case "1.5": return StopBits.OnePointFive;
                case "2": return StopBits.Two;
            }
            return StopBits.One;
        }

        private int getTimeGap()
        {
            return int.Parse(txtTimeGap.Text);
        }


        private int getDataSize()
        {
            return int.Parse(txtDataSize.Text);
        }

        private String getTxtPath()
        {
            return txtPath.Text;
        }

        private void initSerialPort()
        {
            if (comPort != null)
                closeSerialPort();

            comPort = new SerialPort(getComPort(),
                                      getBaudRate(),
                                      getParity(),
                                      getDataBits(),
                                      getStopBits());

            comPort.DataReceived += new SerialDataReceivedEventHandler(doSerialRecevie);

            if (!comPort.IsOpen)
            {
                try
                {
                    comPort.Open();
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Port open failure");
                }

            }
        }

        private void btnSetPort_Click(object sender, EventArgs e)
        {
            initSerialPort();
        }

        private void closeSerialPort()
        {
            comPort.Close();
        }

        delegate void SetTextCallback(string text);

        private void setReceiveList(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtReceiveList.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setReceiveList);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtReceiveList.Text += text;
            }
        }

        private void doSerialRecevie(Object sender, SerialDataReceivedEventArgs e)
        {

            Byte[] buffer = new Byte[1024];
            Int32 length = (sender as SerialPort).Read(buffer, 0, buffer.Length);
            string result = System.Text.Encoding.UTF8.GetString(buffer);
            this.setReceiveList(result);
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int size = getDataSize();
                int timeGap = getTimeGap();
                String path = getTxtPath();
                int n;
                StreamReader file = new StreamReader(path);
                char[] buffer = new char[size];
                int totalStep = (int)file.BaseStream.Length / size;

                progressBar1.Maximum = totalStep;
                progressBar1.Value = 0;
                progressBar1.Step = 1;

                while ((n = file.Read(buffer, 0, size)) > 0)
                {
                    if ((progressBar1.Value + 1) < progressBar1.Maximum)
                        progressBar1.Value += progressBar1.Step;
                    comPort.Write(buffer, 0, n);

                    Thread.Sleep(timeGap);
                }
                progressBar1.Value = totalStep;
                file.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Can't open send file");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("The port can't access");
            }
        }

    }
}
