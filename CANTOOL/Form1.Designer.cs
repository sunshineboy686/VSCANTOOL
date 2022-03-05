namespace CANTOOL
{
    partial class CANMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitMainContainer = new System.Windows.Forms.SplitContainer();
            this.LeftNavigationPanel = new System.Windows.Forms.Panel();
            this.aboutHelpBtnNav = new System.Windows.Forms.Button();
            this.funBtnNav = new System.Windows.Forms.Button();
            this.sendBtnNav = new System.Windows.Forms.Button();
            this.configBtnNav = new System.Windows.Forms.Button();
            this.reciveBtnNav = new System.Windows.Forms.Button();
            this.leftTopPanel = new System.Windows.Forms.Panel();
            this.leftTitleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.rightTittlePanel = new System.Windows.Forms.Panel();
            this.skinBut = new System.Windows.Forms.Button();
            this.collapsedBun = new System.Windows.Forms.Button();
            this.tittleContent = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.MaxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainContainer)).BeginInit();
            this.splitMainContainer.Panel1.SuspendLayout();
            this.splitMainContainer.Panel2.SuspendLayout();
            this.splitMainContainer.SuspendLayout();
            this.LeftNavigationPanel.SuspendLayout();
            this.leftTopPanel.SuspendLayout();
            this.rightTittlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMainContainer
            // 
            this.splitMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMainContainer.Location = new System.Drawing.Point(0, 0);
            this.splitMainContainer.Name = "splitMainContainer";
            // 
            // splitMainContainer.Panel1
            // 
            this.splitMainContainer.Panel1.AutoScroll = true;
            this.splitMainContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.splitMainContainer.Panel1.Controls.Add(this.LeftNavigationPanel);
            this.splitMainContainer.Panel1.Controls.Add(this.leftTopPanel);
            this.splitMainContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMainContainer.Panel1MinSize = 150;
            // 
            // splitMainContainer.Panel2
            // 
            this.splitMainContainer.Panel2.Controls.Add(this.contentPanel);
            this.splitMainContainer.Panel2.Controls.Add(this.rightTittlePanel);
            this.splitMainContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMainContainer.Panel2MinSize = 500;
            this.splitMainContainer.Size = new System.Drawing.Size(909, 546);
            this.splitMainContainer.SplitterDistance = 202;
            this.splitMainContainer.SplitterWidth = 3;
            this.splitMainContainer.TabIndex = 0;
            // 
            // LeftNavigationPanel
            // 
            this.LeftNavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.LeftNavigationPanel.Controls.Add(this.aboutHelpBtnNav);
            this.LeftNavigationPanel.Controls.Add(this.funBtnNav);
            this.LeftNavigationPanel.Controls.Add(this.sendBtnNav);
            this.LeftNavigationPanel.Controls.Add(this.configBtnNav);
            this.LeftNavigationPanel.Controls.Add(this.reciveBtnNav);
            this.LeftNavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftNavigationPanel.Location = new System.Drawing.Point(0, 38);
            this.LeftNavigationPanel.Name = "LeftNavigationPanel";
            this.LeftNavigationPanel.Size = new System.Drawing.Size(202, 508);
            this.LeftNavigationPanel.TabIndex = 1;
            // 
            // aboutHelpBtnNav
            // 
            this.aboutHelpBtnNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutHelpBtnNav.FlatAppearance.BorderSize = 0;
            this.aboutHelpBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutHelpBtnNav.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutHelpBtnNav.ForeColor = System.Drawing.Color.White;
            this.aboutHelpBtnNav.Image = global::CANTOOL.Properties.Resources.aboutViewRed;
            this.aboutHelpBtnNav.Location = new System.Drawing.Point(0, 458);
            this.aboutHelpBtnNav.Name = "aboutHelpBtnNav";
            this.aboutHelpBtnNav.Size = new System.Drawing.Size(202, 50);
            this.aboutHelpBtnNav.TabIndex = 7;
            this.aboutHelpBtnNav.Text = "关于帮助";
            this.aboutHelpBtnNav.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.aboutHelpBtnNav.UseVisualStyleBackColor = true;
            this.aboutHelpBtnNav.Click += new System.EventHandler(this.aboutHelpBtnNav_Click);
            // 
            // funBtnNav
            // 
            this.funBtnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.funBtnNav.FlatAppearance.BorderSize = 0;
            this.funBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.funBtnNav.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funBtnNav.ForeColor = System.Drawing.Color.White;
            this.funBtnNav.Image = global::CANTOOL.Properties.Resources.functionView;
            this.funBtnNav.Location = new System.Drawing.Point(0, 165);
            this.funBtnNav.Name = "funBtnNav";
            this.funBtnNav.Size = new System.Drawing.Size(202, 55);
            this.funBtnNav.TabIndex = 5;
            this.funBtnNav.Text = "功能扩展";
            this.funBtnNav.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.funBtnNav.UseVisualStyleBackColor = true;
            this.funBtnNav.Click += new System.EventHandler(this.funBtnNav_Click);
            // 
            // sendBtnNav
            // 
            this.sendBtnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendBtnNav.FlatAppearance.BorderSize = 0;
            this.sendBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtnNav.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtnNav.ForeColor = System.Drawing.Color.White;
            this.sendBtnNav.Image = global::CANTOOL.Properties.Resources.sendView;
            this.sendBtnNav.Location = new System.Drawing.Point(0, 110);
            this.sendBtnNav.Name = "sendBtnNav";
            this.sendBtnNav.Size = new System.Drawing.Size(202, 55);
            this.sendBtnNav.TabIndex = 4;
            this.sendBtnNav.Text = "发送设置";
            this.sendBtnNav.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendBtnNav.UseVisualStyleBackColor = true;
            this.sendBtnNav.Click += new System.EventHandler(this.sendBtnNav_Click);
            // 
            // configBtnNav
            // 
            this.configBtnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.configBtnNav.FlatAppearance.BorderSize = 0;
            this.configBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configBtnNav.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configBtnNav.ForeColor = System.Drawing.Color.White;
            this.configBtnNav.Image = global::CANTOOL.Properties.Resources.setView;
            this.configBtnNav.Location = new System.Drawing.Point(0, 55);
            this.configBtnNav.Name = "configBtnNav";
            this.configBtnNav.Size = new System.Drawing.Size(202, 55);
            this.configBtnNav.TabIndex = 3;
            this.configBtnNav.Text = "设备配置";
            this.configBtnNav.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.configBtnNav.UseVisualStyleBackColor = true;
            this.configBtnNav.Click += new System.EventHandler(this.configBtnNav_Click);
            // 
            // reciveBtnNav
            // 
            this.reciveBtnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.reciveBtnNav.FlatAppearance.BorderSize = 0;
            this.reciveBtnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciveBtnNav.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciveBtnNav.ForeColor = System.Drawing.Color.White;
            this.reciveBtnNav.Image = global::CANTOOL.Properties.Resources.reciveView;
            this.reciveBtnNav.Location = new System.Drawing.Point(0, 0);
            this.reciveBtnNav.Name = "reciveBtnNav";
            this.reciveBtnNav.Size = new System.Drawing.Size(202, 55);
            this.reciveBtnNav.TabIndex = 2;
            this.reciveBtnNav.Text = "接收显示";
            this.reciveBtnNav.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reciveBtnNav.UseVisualStyleBackColor = true;
            this.reciveBtnNav.Click += new System.EventHandler(this.reciveBtnNav_Click);
            // 
            // leftTopPanel
            // 
            this.leftTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.leftTopPanel.Controls.Add(this.leftTitleLabel);
            this.leftTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftTopPanel.Location = new System.Drawing.Point(0, 0);
            this.leftTopPanel.Name = "leftTopPanel";
            this.leftTopPanel.Size = new System.Drawing.Size(202, 38);
            this.leftTopPanel.TabIndex = 0;
            // 
            // leftTitleLabel
            // 
            this.leftTitleLabel.BackColor = System.Drawing.Color.Red;
            this.leftTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTitleLabel.ForeColor = System.Drawing.Color.White;
            this.leftTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.leftTitleLabel.Name = "leftTitleLabel";
            this.leftTitleLabel.Size = new System.Drawing.Size(202, 38);
            this.leftTitleLabel.TabIndex = 0;
            this.leftTitleLabel.Text = "YOU CAN";
            this.leftTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftTitleLabel.Click += new System.EventHandler(this.leftTitleLabel_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 38);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(704, 508);
            this.contentPanel.TabIndex = 1;
            // 
            // rightTittlePanel
            // 
            this.rightTittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(142)))), ((int)(((byte)(185)))));
            this.rightTittlePanel.Controls.Add(this.skinBut);
            this.rightTittlePanel.Controls.Add(this.collapsedBun);
            this.rightTittlePanel.Controls.Add(this.tittleContent);
            this.rightTittlePanel.Controls.Add(this.closeBtn);
            this.rightTittlePanel.Controls.Add(this.minBtn);
            this.rightTittlePanel.Controls.Add(this.MaxButton);
            this.rightTittlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightTittlePanel.Location = new System.Drawing.Point(0, 0);
            this.rightTittlePanel.Name = "rightTittlePanel";
            this.rightTittlePanel.Size = new System.Drawing.Size(704, 38);
            this.rightTittlePanel.TabIndex = 0;
            this.rightTittlePanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rightTittlePanel_MouseDoubleClick);
            this.rightTittlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightTittlePanel_MouseDown);
            this.rightTittlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightTittlePanel_MouseMove);
            this.rightTittlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightTittlePanel_MouseUp);
            // 
            // skinBut
            // 
            this.skinBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinBut.BackgroundImage = global::CANTOOL.Properties.Resources.skinred;
            this.skinBut.FlatAppearance.BorderSize = 0;
            this.skinBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinBut.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinBut.ForeColor = System.Drawing.Color.White;
            this.skinBut.Location = new System.Drawing.Point(569, 6);
            this.skinBut.Name = "skinBut";
            this.skinBut.Size = new System.Drawing.Size(33, 29);
            this.skinBut.TabIndex = 14;
            this.skinBut.UseVisualStyleBackColor = true;
            this.skinBut.Click += new System.EventHandler(this.skinBut_Click);
            // 
            // collapsedBun
            // 
            this.collapsedBun.BackgroundImage = global::CANTOOL.Properties.Resources.collpseLeft_32;
            this.collapsedBun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.collapsedBun.FlatAppearance.BorderSize = 0;
            this.collapsedBun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapsedBun.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collapsedBun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(246)))));
            this.collapsedBun.Location = new System.Drawing.Point(3, 3);
            this.collapsedBun.Name = "collapsedBun";
            this.collapsedBun.Size = new System.Drawing.Size(28, 32);
            this.collapsedBun.TabIndex = 6;
            this.collapsedBun.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.collapsedBun.UseVisualStyleBackColor = true;
            this.collapsedBun.Click += new System.EventHandler(this.collapsedBun_Click);
            // 
            // tittleContent
            // 
            this.tittleContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tittleContent.AutoSize = true;
            this.tittleContent.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleContent.ForeColor = System.Drawing.Color.White;
            this.tittleContent.Location = new System.Drawing.Point(148, 7);
            this.tittleContent.Name = "tittleContent";
            this.tittleContent.Size = new System.Drawing.Size(76, 28);
            this.tittleContent.TabIndex = 13;
            this.tittleContent.Text = "Home";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(676, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 32);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(608, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(28, 32);
            this.minBtn.TabIndex = 11;
            this.minBtn.Text = "—";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.FlatAppearance.BorderSize = 0;
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxButton.ForeColor = System.Drawing.Color.White;
            this.MaxButton.Location = new System.Drawing.Point(642, 3);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(28, 32);
            this.MaxButton.TabIndex = 12;
            this.MaxButton.Text = "☑";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // CANMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 546);
            this.Controls.Add(this.splitMainContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(925, 585);
            this.Name = "CANMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANMainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CANMainForm_Load);
            this.splitMainContainer.Panel1.ResumeLayout(false);
            this.splitMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMainContainer)).EndInit();
            this.splitMainContainer.ResumeLayout(false);
            this.LeftNavigationPanel.ResumeLayout(false);
            this.leftTopPanel.ResumeLayout(false);
            this.rightTittlePanel.ResumeLayout(false);
            this.rightTittlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMainContainer;
        private System.Windows.Forms.Panel leftTopPanel;
        private System.Windows.Forms.Panel rightTittlePanel;
        private System.Windows.Forms.Panel LeftNavigationPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button funBtnNav;
        private System.Windows.Forms.Button sendBtnNav;
        private System.Windows.Forms.Button configBtnNav;
        private System.Windows.Forms.Button reciveBtnNav;
        private System.Windows.Forms.Label tittleContent;
        private System.Windows.Forms.Button collapsedBun;
        private System.Windows.Forms.Button aboutHelpBtnNav;
        private System.Windows.Forms.Button skinBut;
        private System.Windows.Forms.Label leftTitleLabel;
    }
}

