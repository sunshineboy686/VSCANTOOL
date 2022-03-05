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
    public partial class ReciveForm : Form
    {
        public ReciveForm()
        {
            InitializeComponent();
            ColorTheme_Init();
        }
        public void ColorTheme_Init()
        {
            foreach (Control ctrl in reciveTitlePanel.Controls)
            {
                if (ctrl.GetType().FullName == "System.Windows.Forms.Button")
                {
                    ctrl.BackColor = ColorTheme.leftNavColor;
                }
            }
        }
        private void TopRightPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

        }

        private void ReciveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
