using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANTOOL
{
    public partial class CANMainForm : Form
    {
        private Point mouseOff; //抓取窗体Form中的鼠标的坐标,需要设置一个参数
        private bool leftFlag;
        bool collpseFlag = false;
        public ReciveForm reciveForm;
        public SendForm sendForm;
        public ConfigForm configForm;
        // public Color leftNavColor= Color.FromArgb(100,38, 59, 83);
        // public Color headTitleColor = Color.FromArgb(100, 107, 142, 185);
        public byte colorCnt = 0;
        public CANMainForm()
        {
            InitializeComponent();
            this.Text = null;
            this.ControlBox = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);   //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
            this.Close();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void rightTittlePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void rightTittlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)   //判断鼠标左键是否被按下
            {
                mouseOff = new Point(e.X, e.Y); //通过结构，将鼠标在窗体中的坐标（e.X,e.Y）赋值给mouseOff参数
                leftFlag = true;    //标记鼠标左键的状态
            }
        }

        private void rightTittlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)    //判断，鼠标左键是否被按下
            {
                Point mouseSet = Control.MousePosition; //抓取屏幕中鼠标光标所在的位置
                mouseSet.Offset(-mouseOff.X-leftTopPanel.Width, -mouseOff.Y);  //两个坐标相减，得到窗体左上角相对于屏幕的坐标
                Location = mouseSet;    //将上面得到的坐标赋值给窗体Form的Location属性
            }
        }

        private void rightTittlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void CANMainForm_Load(object sender, EventArgs e)
        {

        }

        private void collapsedBun_Click(object sender, EventArgs e)
        {
            if (!collpseFlag)
            {
                splitMainContainer.Panel1Collapsed = true;
                collpseFlag = true;
               collapsedBun.BackgroundImage = global::CANTOOL.Properties.Resources.collpseRight_32;

            }
            else
            {
                splitMainContainer.Panel1Collapsed = false;
                collpseFlag = false;
                collapsedBun.BackgroundImage = global::CANTOOL.Properties.Resources.collpseLeft_32;
            }
        }

        private void reciveBtnNav_Click(object sender, EventArgs e)
        {
            tittleContent.Text = reciveBtnNav.Text;
            contentPanel.Controls.Clear();
            if (reciveForm == null)
            {
                reciveForm = new ReciveForm();
               // listenUSBThread.Start();
            }
            reciveForm.TopLevel = false;
            contentPanel.Controls.Add(reciveForm);
            reciveForm.Show();
            reciveForm.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void configBtnNav_Click(object sender, EventArgs e)
        {
            tittleContent.Text = configBtnNav.Text;
            contentPanel.Controls.Clear();
            /**
            if (sendForm == null)
            {
                sendForm = new SendForm();
                // listenUSBThread.Start();
            }
            sendForm.TopLevel = false;
            contentPanel.Controls.Add(sendForm);
            sendForm.Show();
            sendForm.Dock = System.Windows.Forms.DockStyle.Fill;
            ***/



            if (configForm == null)
            {
                configForm = new ConfigForm();
              
            }
            configForm.Show();
            configForm.Activate();
        }

        private void sendBtnNav_Click(object sender, EventArgs e)
        {
            tittleContent.Text = sendBtnNav.Text;

            if (sendForm == null)
            {
                sendForm = new SendForm();

            }
            sendForm.Show();
            sendForm.Activate();
        }

        private void funBtnNav_Click(object sender, EventArgs e)
        {
            tittleContent.Text = funBtnNav.Text;
           
           // leftNavColor
        }

        private void aboutHelpBtnNav_Click(object sender, EventArgs e)
        {
            tittleContent.Text = aboutHelpBtnNav.Text;
        }

        private void skinBut_Click(object sender, EventArgs e)
        {

            tittleContent.Text = colorCnt.ToString();
            switch (colorCnt)
            {
                case 0:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 38, 59, 83);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 38, 59, 83);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);


                    break;
                case 1:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 35, 150, 243);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 35, 150, 243);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 2:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x3f, 0x51, 0x85);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x3f, 0x51, 0x85);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 3:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x00, 0x96, 0x88);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x00, 0x96, 0x88);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 4:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xff, 0x57, 0x22);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xff, 0x57, 0x22);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 5:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x60, 0x7d, 0x8b);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x60, 0x7d, 0x8b);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 6:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xff, 0x98, 0x00);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xff, 0x98, 0x00);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 7:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x9c, 0x27, 0xb0);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x9c, 0x27, 0xb0);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 8:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x21, 0x96, 0xf3);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x21, 0x96, 0xf3);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 9:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xea, 0x67, 0x6c);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xea, 0x67, 0x6c);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 10:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xe4, 0x1a, 0x4a);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xe4, 0x1a, 0x4a);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 11:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x59, 0x78, 0xbb);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x59, 0x78, 0xbb);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, -0.1);
                    break;
                case 12:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x01, 0x87, 0x90);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x01, 0x87, 0x90);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 13:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x0e, 0x34, 0x41);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x0e, 0x34, 0x41);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 14:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xa1, 0x20, 0x59);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xa1, 0x20, 0x59);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 15:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x12, 0x68, 0x81);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x12, 0x68, 0x81);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 16:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x8b, 0xc2, 0x40);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x8b, 0xc2, 0x40);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 17:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x36, 0x4d, 0x5b);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x36, 0x4d, 0x5b);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 18:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xc7, 0xdc, 0x5b);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xc7, 0xdc, 0x5b);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 19:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x00, 0x94, 0xbc);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x00, 0x94, 0xbc);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 20:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xe4, 0x12, 0x6b);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xe4, 0x12, 0x6b);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 21:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x43, 0xb7, 0x6e);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x43, 0xb7, 0x6e);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 22:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0x78, 0xcf, 0xe9);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0x78, 0xcf, 0xe9);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
                case 23:
                    ColorTheme.leftNavColor = Color.FromArgb(255, 0xb7, 0x1c, 0x46);
                    ColorTheme.headTitleColor = Color.FromArgb(255, 0xb7, 0x1c, 0x46);
                    LeftNavigationPanel.BackColor = ColorTheme.leftNavColor;
                    rightTittlePanel.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);

                    reciveBtnNav.BackColor = ColorTheme.leftNavColor;
                    configBtnNav.BackColor = ColorTheme.leftNavColor;
                    sendBtnNav.BackColor = ColorTheme.leftNavColor;
                    funBtnNav.BackColor = ColorTheme.leftNavColor;
                    aboutHelpBtnNav.BackColor = ColorTheme.leftNavColor;

                    closeBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    MaxButton.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    minBtn.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    skinBut.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    tittleContent.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    collapsedBun.BackColor = ColorTheme.Change_Color_Brightness(ColorTheme.headTitleColor, 0.1);
                    break;
            }
            if(sendForm != null)
            {
                sendForm.ColorTheme_Init();
            }
            if (configForm != null)
            {
                configForm.ColorTheme_Init();
            }
            if (reciveForm != null)
            {
                reciveForm.ColorTheme_Init();
            }
            colorCnt++;
            if (colorCnt >= 24)
            {
                colorCnt = 0;
            }
        }

        private void leftTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
