using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Threading;
using System.IO;

namespace CANTOOL
{
    public partial class ConfigForm : Form
    {
        public static ConfigForm configForm;
        private Point mouseOff; //抓取窗体Form中的鼠标的坐标,需要设置一个参数
        private bool leftFlag;
        public String usbComMName = null;
        public SerialPort PortCom;
        public ConfigForm()
        {
            InitializeComponent();
            Init_Form();
            ColorTheme_Init();
            PortCom = new SerialPort();
        }
        public void ColorTheme_Init()
        {
            TitlePannel.BackColor = ColorTheme.headTitleColor;
            configLabel.BackColor = ColorTheme.headTitleColor;
            ConfigLeftPannel.BackColor = ColorTheme.headTitleColor;
           // FunModeComboBox.BackColor = ColorTheme.headTitleColor;
           // ControlRateComboBox.BackColor = ColorTheme.headTitleColor;
           // ChannelComboBox.BackColor = ColorTheme.headTitleColor;
           // DataRateComboBox.BackColor = ColorTheme.headTitleColor;
            //ComboBoxFilter.BackColor = ColorTheme.headTitleColor;
            foreach (Control ctrl in ConfigRightPannel.Controls)
            {
                if (ctrl.GetType().FullName == "System.Windows.Forms.Button")
                {
                    ctrl.BackColor = ColorTheme.leftNavColor;
                }
            }

        }
        public void Init_Form()
        {
         
            ChannelComboBox.SelectedIndex = 0;
            FunModeComboBox.SelectedIndex = 0;
            ControlRateComboBox.SelectedIndex = 0;
            DataRateComboBox.SelectedIndex = 0;
            ComboBoxFilter.SelectedIndex = 0;
         }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TitlePannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)    //判断，鼠标左键是否被按下
            {
                Point mouseSet = Control.MousePosition; //抓取屏幕中鼠标光标所在的位置
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);  //两个坐标相减，得到窗体左上角相对于屏幕的坐标
                Location = mouseSet;    //将上面得到的坐标赋值给窗体Form的Location属性
            }
        }

        private void TitlePannel_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void TitlePannel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)   //判断鼠标左键是否被按下
            {
                mouseOff = new Point(e.X, e.Y); //通过结构，将鼠标在窗体中的坐标（e.X,e.Y）赋值给mouseOff参数
                leftFlag = true;    //标记鼠标左键的状态
            }
        }

        private void DeviceConBtn_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxRCAN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRCAN.Checked)
            {
                LabelFilter.Visible = true;
                ComboBoxFilter.Visible = true;
                StartIdLabel.Visible = true;
                TextBoxStartId.Visible = true;
                EndIdLabel.Visible = true;
                TextBoxEndId.Visible = true;
            }
            else
            {
                LabelFilter.Visible = false;
                ComboBoxFilter.Visible = false;
                StartIdLabel.Visible = false;
                TextBoxStartId.Visible = false;
                EndIdLabel.Visible = false;
                TextBoxEndId.Visible = false;
            }
        }

        private void checkBoxRCAN_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxRCAN.Checked)
            {
                LabelFilter.Visible = true;
                ComboBoxFilter.Visible = true;
                StartIdLabel.Visible = true;
                TextBoxStartId.Visible = true;
                EndIdLabel.Visible = true;
                TextBoxEndId.Visible = true;
            }
            else
            {
                LabelFilter.Visible = false;
                ComboBoxFilter.Visible = false;
                StartIdLabel.Visible = false;
                TextBoxStartId.Visible = false;
                EndIdLabel.Visible = false;
                TextBoxEndId.Visible = false;
            }
        }
        public string GetPortNum(String vid_pid)
        {

            int StartIndex = 0;
            int EndIndex = 0;
            string GetusbCom = null;
            ManagementObjectCollection USBControllerDeviceCollection = new ManagementObjectSearcher("SELECT * FROM Win32_USBControllerDevice").Get();
            if (USBControllerDeviceCollection != null)
            {
                foreach (ManagementObject USBControllerDevice in USBControllerDeviceCollection)
                {
                    String Dependent = (USBControllerDevice["Dependent"] as String).Split(new Char[] { '=' })[1];

                    if (Dependent.Contains(vid_pid))
                    {
                        ManagementObjectCollection PnPEntityCollection = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE DeviceID=" + Dependent).Get();
                        if (PnPEntityCollection != null)
                        {
                            foreach (ManagementObject Entity in PnPEntityCollection)
                            {
                                String DevName = Entity["Name"] as String;// 设备名称
                                if (DevName.Contains("(COM"))
                                {
                                    StartIndex = DevName.IndexOf("(COM", StartIndex);
                                    EndIndex = StartIndex;
                                    EndIndex = DevName.IndexOf(")", EndIndex);
                                    GetusbCom = DevName.Substring(StartIndex + 1, EndIndex - StartIndex - 1);

                                }
                            }
                        }
                    }
                }
            }

            return GetusbCom;
        }

        void PortCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (PortCom.IsOpen)
            {
                int cnt = PortCom.BytesToRead;
                byte[] readBuffer = new byte[cnt];
                cnt = PortCom.Read(readBuffer, 0, readBuffer.Length);

                usbCom.Recive_Data_Deal(readBuffer, cnt);
            }
        }
        private void DeviceConBtn_Click_1(object sender, EventArgs e)
        {
            byte[] OBBuf = new byte[32];

            if (DeviceConBtn.Text == "连接设备")
            {

                usbComMName = GetPortNum("VID_0483&PID_5740");
                if (usbComMName == null)
                {
                    Invoke((EventHandler)delegate
                    {
                        MessageBox.Show("未找到设备\r\n");
                    });
                    return;
                }

                PortCom.PortName = usbComMName;
                // PortCom.DataReceived += new Ports.SerialDataReceivedEventHandler(spReceive_DataReceived);
                PortCom.BaudRate = 115200;
                PortCom.ReadTimeout = 10;
                PortCom.ReceivedBytesThreshold = 1;
                PortCom.DataReceived += new SerialDataReceivedEventHandler(PortCom_DataReceived);
                try
                {
                    lock (PortLock)
                    {
                        PortCom.Open();
                        Invoke((EventHandler)delegate
                        {
                            OpenButton.Text = "关闭设备";
                            DataTextBox.AppendText("设备连接成功\r\n");
                          
                        });
                        usbCom.COMOpenFlag = true;
                    }

                }
                catch (Exception ex)
                {
                    Invoke((EventHandler)delegate
                    {
                        DataTextBox.AppendText("设备连接失败" + ex.Message + "\r\n");
                    });
                    PortCom.Close();
                }
            }
            else
            {
                try
                {
                    lock (PortLock)
                    {
                        OBBuf[0] = 1;

                        //usbComMName = GetPortNum("VID_0483&PID_5740");

                        if (usbCom.COMOpenFlag)
                        {
                            usbCom.Send_Data_Deal(0x0109, OBBuf, 1);
                        }

                        //Thread.Sleep(1);
                        PortCom.Close();
                        usbCom.COMOpenFlag = false;
                        Invoke((EventHandler)delegate
                        {
                            OpenButton.Text = "连接设备";
                            DataTextBox.AppendText("关闭设备成功\r\n");
                        });
                    }
                }
                //ext("error+" + ex.Message + "请选择串口\n");
                catch (Exception ex)
                {

                    Invoke((EventHandler)delegate
                    {
                        DataTextBox.AppendText("关闭设备失败" + ex.Message + "\r\n");
                        OpenButton.Text = "连接设备";
                    });

                }

            }
        }
    }
}
