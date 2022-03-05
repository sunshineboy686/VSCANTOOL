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
    public partial class SendForm : Form
    {
        private Point mouseOff; //抓取窗体Form中的鼠标的坐标,需要设置一个参数
        private bool leftFlag;
        SendCANInfo[] sendCanFBuf;
        SendCANInfo curSendFInfo;
        public int sendCanFIndex = 0;
        public SendForm()
        {
            InitializeComponent();
            SendForm_Init();
            ColorTheme_Init();
            sendCanFBuf = new SendCANInfo[32];
            curSendFInfo = new SendCANInfo();
        }

        private void SendForm_Load(object sender, EventArgs e)
        {

        }

        private void SFTopPannel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ColorTheme_Init()
        {
            SFTTopTittlePanle.BackColor = ColorTheme.headTitleColor;
            // configLabel.BackColor = ColorTheme.headTitleColor;
            foreach (Control ctrl in SFTopPannel.Controls)
            {
                if (ctrl.GetType().FullName == "System.Windows.Forms.Button")
                {
                    ctrl.BackColor = ColorTheme.leftNavColor;
                }
            }
            foreach (Control ctrl in SFBottomPannel.Controls)
            {
                if (ctrl.GetType().FullName == "System.Windows.Forms.Button")
                {
                    ctrl.BackColor = ColorTheme.leftNavColor;
                }
            }
            foreach (Control ctrl in SFTTopTittlePanle.Controls)
            {
                if (ctrl.GetType().FullName == "System.Windows.Forms.Button")
                {
                    ctrl.BackColor = ColorTheme.leftNavColor;
                }
            }
        }
        void SendForm_Init()
        {
            this.Text = null;
            this.ControlBox = false;                                //隐藏最上方的一栏
        }

        private void SFTTopTittlePanle_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void SFTTopTittlePanle_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)    //判断，鼠标左键是否被按下
            {
                Point mouseSet = Control.MousePosition; //抓取屏幕中鼠标光标所在的位置
                mouseSet.Offset(-mouseOff.X, -mouseOff.Y);  //两个坐标相减，得到窗体左上角相对于屏幕的坐标
                Location = mouseSet;    //将上面得到的坐标赋值给窗体Form的Location属性
            }
        }

        private void SFTTopTittlePanle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)   //判断鼠标左键是否被按下
            {
                mouseOff = new Point(e.X, e.Y); //通过结构，将鼠标在窗体中的坐标（e.X,e.Y）赋值给mouseOff参数
                leftFlag = true;    //标记鼠标左键的状态
            }
        }

        private void SFCloseBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
        }

        private void SFMinBtn_Click(object sender, EventArgs e)
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

        private void SFMaxButton_Click(object sender, EventArgs e)
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

        private void AddListBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            int ColIndex = 0;
            string SendData = SDataTextBox.Text;
            List<string> SendDataList = new List<string>();
            SendData = SendData.Replace(" ", "");

            if (sendCanFIndex > 32)
            {
                MessageBox.Show("添加数量超出范围");
                return;
            }
            for (int i = 0; i < SendData.Length; i += 2)
            {
                SendDataList.Add(SendData.Substring(i, 2));
            }
            for (int i = 0; i < SendDataList.Count; i++)
            {
                curSendFInfo.dataBuf[i] = (byte)(Convert.ToInt32(SendDataList[i], 16));
            }
            curSendFInfo.sendLen = (byte)SendDataList.Count;
            curSendFInfo.canCH = (byte)CANCHComBox.SelectedIndex;
            curSendFInfo.canID = System.Convert.ToUInt32("0x" + IdTextBox.Text, 16);
            curSendFInfo.frameFormat = (byte)SFrameFormatCombox.SelectedIndex;
            curSendFInfo.frameType = (byte)SFrameTypeCombox.SelectedIndex;
            curSendFInfo.sendCnt = int.Parse(SendCntTBox.Text);
            curSendFInfo.cntInterTime = int.Parse(InterTimeTBox.Text);
            sendCanFBuf[sendCanFIndex] = curSendFInfo;
            sendCanFIndex++;


            rowIndex = SendDataGridView.Rows.Add();
            SendDataGridView.Rows[rowIndex].HeaderCell.Value = rowIndex.ToString();
            //dictiCanId.Add(hexId, rowIndex);
            for (ColIndex = 0; ColIndex < SendDataGridView.ColumnCount; ColIndex++)
            {
                if (SendDataGridView.Columns[ColIndex].Name == "CHColumn")
                {
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = "CAN" + curSendFInfo.canCH.ToString();
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "IDColumn")
                {
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = string.Format("{0:X8}",curSendFInfo.canID);
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "LenColumn")
                {
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = curSendFInfo.sendLen.ToString();
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "FrameTypeColumn")
                {
                    if (curSendFInfo.frameType == 0)
                    {
                        SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = "标准帧";
                    }
                    else
                    {
                        SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = "扩展帧";
                    }
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "dataColumn")
                {
                    SendData = "";
                    for (int i = 0; i < curSendFInfo.sendLen; i++)
                    {
                        SendData += string.Format("{0:X2}", curSendFInfo.dataBuf[i]);
                        SendData += " ";
                    }
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = SendData;
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "SendCntColumn")
                {
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = curSendFInfo.sendCnt.ToString();
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "SendInterTimeColumn")
                {
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = curSendFInfo.cntInterTime.ToString();
                }
                else if (SendDataGridView.Columns[ColIndex].Name == "StateColumn")
                {
                    SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = "nothing";
                }
                else
                {
                    //SendDataGridView.Rows[rowIndex].Cells[ColIndex].Value = "监听";
                }
                //DataGridViewA.Rows[RowIndex].Cells[ColIndex].Value = "lilei" + ColIndex.ToString();
            }

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string SendData = SDataTextBox.Text;
            List<string> SendDataList = new List<string>();
            SendData = SendData.Replace(" ", "");

            if (sendCanFIndex > 32)
            {
                MessageBox.Show("添加数量超出范围");
                return;
            }
            for (int i = 0; i < SendData.Length; i += 2)
            {
                SendDataList.Add(SendData.Substring(i, 2));
            }
            for (int i = 0; i < SendDataList.Count; i++)
            {
                curSendFInfo.dataBuf[i] = (byte)(Convert.ToInt32(SendDataList[i], 16));
            }
            curSendFInfo.canCH = (byte)CANCHComBox.SelectedIndex;
            curSendFInfo.canID = System.Convert.ToUInt32("0x" + IdTextBox.Text, 16);
            curSendFInfo.frameFormat = (byte)SFrameFormatCombox.SelectedIndex;
            curSendFInfo.frameType = (byte)SFrameTypeCombox.SelectedIndex;
            curSendFInfo.sendCnt = int.Parse(SendCntTBox.Text);
            curSendFInfo.cntInterTime = int.Parse(InterTimeTBox.Text);
        }
        private int GetSelectedRowIndex(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                return 0;
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Selected)
                {
                    return row.Index;
                }
            }
            return 0;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            bool deleteFlag = false;
            int rowIndex = 0;
            if (this.SendDataGridView.SelectedRows == null || this.SendDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");
                return;
            }
            foreach (DataGridViewRow dr in this.SendDataGridView.SelectedRows)
            {
                if (dr.IsNewRow == false)
                {
                    //如果不是已提交的行，默认情况下在添加一行数据成功后，DataGridView为新建一行作为新数据的插入位置
                    this.SendDataGridView.Rows.Remove(dr);
                    deleteFlag = true;
                }
            }
         
            if (deleteFlag)
            {
                for (rowIndex = 0; rowIndex < SendDataGridView.Rows.Count-1; rowIndex++)
                {
                    SendDataGridView.Rows[rowIndex].HeaderCell.Value = rowIndex.ToString();
                }
            }
        }

        private void UpMoveBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            if (this.SendDataGridView.SelectedRows == null || this.SendDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");
            }
            else
            {
                if (this.SendDataGridView.SelectedRows[0].Index <= 0)
                {
                    MessageBox.Show("此行已在顶端，不能再上移！");
                }
                else
                {
                    //注意：这里是非绑定数据情况的上移行
                    // 选择的行号  
                    int selectedRowIndex = GetSelectedRowIndex(this.SendDataGridView);
                    if (selectedRowIndex >= 1)
                    {
                        // 拷贝选中的行  
                        DataGridViewRow newRow = SendDataGridView.Rows[selectedRowIndex];
                        // 删除选中的行  
                        SendDataGridView.Rows.Remove(SendDataGridView.Rows[selectedRowIndex]);
                        // 将拷贝的行，插入到选中的上一行位置  
                        SendDataGridView.Rows.Insert(selectedRowIndex - 1, newRow);
                        SendDataGridView.ClearSelection();
                        // 选中最初选中的行 
                        SendDataGridView.Rows[selectedRowIndex - 1].Selected = true;
                    }
                    for (rowIndex = 0; rowIndex < SendDataGridView.Rows.Count - 1; rowIndex++)
                    {
                        SendDataGridView.Rows[rowIndex].HeaderCell.Value = rowIndex.ToString();
                    }
                }
            }
        }
        private void DownMoveBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            if (this.SendDataGridView.SelectedRows == null || this.SendDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一行，单击第一列以选中行");
            }
            else
            {
                if (this.SendDataGridView.SelectedRows[0].Index >= this.SendDataGridView.Rows.Count - 1 -1)
                {
                    MessageBox.Show("此行已在底端，不能再下移！");
                }
                else
                {
                    int selectedRowIndex = GetSelectedRowIndex(this.SendDataGridView);
                    if (selectedRowIndex < SendDataGridView.Rows.Count - 1)
                    {
                        // 拷贝选中的行  
                        DataGridViewRow newRow = SendDataGridView.Rows[selectedRowIndex];
                        // 删除选中的行  
                        SendDataGridView.Rows.Remove(SendDataGridView.Rows[selectedRowIndex]);
                        // 将拷贝的行，插入到选中的下一行位置  
                        SendDataGridView.Rows.Insert(selectedRowIndex + 1, newRow);
                        SendDataGridView.ClearSelection();
                        // 选中最初选中的行  
                        SendDataGridView.Rows[selectedRowIndex + 1].Selected = true;
                    }
                    for (rowIndex = 0; rowIndex < SendDataGridView.Rows.Count - 1; rowIndex++)
                    {
                        SendDataGridView.Rows[rowIndex].HeaderCell.Value = rowIndex.ToString();
                    }
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SendDataGridView.Rows.Clear();
        }
    }
}
