namespace CANTOOL
{
    partial class ReciveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitlePannel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reciveTitlePanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reciveBtnNav = new System.Windows.Forms.Button();
            this.TitlePannel.SuspendLayout();
            this.reciveTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePannel
            // 
            this.TitlePannel.Controls.Add(this.comboBox2);
            this.TitlePannel.Controls.Add(this.comboBox1);
            this.TitlePannel.Controls.Add(this.label5);
            this.TitlePannel.Controls.Add(this.label4);
            this.TitlePannel.Controls.Add(this.label3);
            this.TitlePannel.Controls.Add(this.label1);
            this.TitlePannel.Controls.Add(this.ChannelLabel);
            this.TitlePannel.Location = new System.Drawing.Point(12, 12);
            this.TitlePannel.Name = "TitlePannel";
            this.TitlePannel.Size = new System.Drawing.Size(691, 38);
            this.TitlePannel.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "发送",
            "接收",
            "全部"});
            this.comboBox2.Location = new System.Drawing.Point(247, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(86, 29);
            this.comboBox2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBox2, "方向");
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CAN1",
            "CAN2",
            "全部"});
            this.comboBox1.Location = new System.Drawing.Point(67, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 29);
            this.comboBox1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.comboBox1, "通道");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(494, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(363, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(424, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "方向";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(182, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "消息ID";
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChannelLabel.Location = new System.Drawing.Point(3, 6);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(58, 21);
            this.ChannelLabel.TabIndex = 3;
            this.ChannelLabel.Text = "时间戳";
            // 
            // reciveTitlePanel
            // 
            this.reciveTitlePanel.Controls.Add(this.button3);
            this.reciveTitlePanel.Controls.Add(this.button1);
            this.reciveTitlePanel.Controls.Add(this.button2);
            this.reciveTitlePanel.Controls.Add(this.reciveBtnNav);
            this.reciveTitlePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reciveTitlePanel.Location = new System.Drawing.Point(0, 422);
            this.reciveTitlePanel.Name = "reciveTitlePanel";
            this.reciveTitlePanel.Size = new System.Drawing.Size(704, 59);
            this.reciveTitlePanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::CANTOOL.Properties.Resources.playWhite;
            this.button3.Location = new System.Drawing.Point(449, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "暂停";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CANTOOL.Properties.Resources.timeSaveWhite;
            this.button1.Location = new System.Drawing.Point(159, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::CANTOOL.Properties.Resources.clearwhite;
            this.button2.Location = new System.Drawing.Point(299, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "清空";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reciveBtnNav
            // 
            this.reciveBtnNav.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reciveBtnNav.FlatAppearance.BorderSize = 0;
            this.reciveBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveBtnNav.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciveBtnNav.ForeColor = System.Drawing.Color.White;
            this.reciveBtnNav.Image = global::CANTOOL.Properties.Resources.saveWhite;
            this.reciveBtnNav.Location = new System.Drawing.Point(9, 3);
            this.reciveBtnNav.Name = "reciveBtnNav";
            this.reciveBtnNav.Size = new System.Drawing.Size(144, 39);
            this.reciveBtnNav.TabIndex = 3;
            this.reciveBtnNav.Text = "实时保存";
            this.reciveBtnNav.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reciveBtnNav.UseVisualStyleBackColor = true;
            // 
            // ReciveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.reciveTitlePanel);
            this.Controls.Add(this.TitlePannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReciveForm";
            this.Text = "ReciveForm";
            this.Load += new System.EventHandler(this.ReciveForm_Load);
            this.TitlePannel.ResumeLayout(false);
            this.TitlePannel.PerformLayout();
            this.reciveTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePannel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.Panel reciveTitlePanel;
        private System.Windows.Forms.Button reciveBtnNav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}