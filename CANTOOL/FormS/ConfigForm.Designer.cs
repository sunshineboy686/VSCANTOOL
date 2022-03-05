namespace CANTOOL
{
    partial class ConfigForm
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
            this.TitlePannel = new System.Windows.Forms.Panel();
            this.configLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.ConfigRightPannel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxRCAN = new System.Windows.Forms.CheckBox();
            this.EndIdLabel = new System.Windows.Forms.Label();
            this.TextBoxEndId = new System.Windows.Forms.TextBox();
            this.TextBoxStartId = new System.Windows.Forms.TextBox();
            this.StartIdLabel = new System.Windows.Forms.Label();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataRateLabel = new System.Windows.Forms.Label();
            this.DataRateComboBox = new System.Windows.Forms.ComboBox();
            this.ControlRateLabel = new System.Windows.Forms.Label();
            this.ControlRateComboBox = new System.Windows.Forms.ComboBox();
            this.FunModeLabel = new System.Windows.Forms.Label();
            this.FunModeComboBox = new System.Windows.Forms.ComboBox();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.ChannelComboBox = new System.Windows.Forms.ComboBox();
            this.DeviceConBtn = new System.Windows.Forms.Button();
            this.ConfigLeftPannel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.TitlePannel.SuspendLayout();
            this.ContentPannel.SuspendLayout();
            this.ConfigRightPannel.SuspendLayout();
            this.ConfigLeftPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlePannel
            // 
            this.TitlePannel.BackColor = System.Drawing.Color.Black;
            this.TitlePannel.Controls.Add(this.configLabel);
            this.TitlePannel.Controls.Add(this.closeBtn);
            this.TitlePannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePannel.Location = new System.Drawing.Point(0, 0);
            this.TitlePannel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TitlePannel.Name = "TitlePannel";
            this.TitlePannel.Size = new System.Drawing.Size(1384, 72);
            this.TitlePannel.TabIndex = 1;
            this.TitlePannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePannel_MouseDown);
            this.TitlePannel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePannel_MouseMove);
            this.TitlePannel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePannel_MouseUp);
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.configLabel.ForeColor = System.Drawing.Color.White;
            this.configLabel.Location = new System.Drawing.Point(-2, 14);
            this.configLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(174, 50);
            this.configLabel.TabIndex = 12;
            this.configLabel.Text = "配置界面";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1322, 8);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(56, 64);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ContentPannel
            // 
            this.ContentPannel.BackColor = System.Drawing.Color.White;
            this.ContentPannel.Controls.Add(this.ConfigRightPannel);
            this.ContentPannel.Controls.Add(this.ConfigLeftPannel);
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPannel.Location = new System.Drawing.Point(0, 72);
            this.ContentPannel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(1384, 1158);
            this.ContentPannel.TabIndex = 2;
            // 
            // ConfigRightPannel
            // 
            this.ConfigRightPannel.Controls.Add(this.label4);
            this.ConfigRightPannel.Controls.Add(this.checkBoxRCAN);
            this.ConfigRightPannel.Controls.Add(this.EndIdLabel);
            this.ConfigRightPannel.Controls.Add(this.TextBoxEndId);
            this.ConfigRightPannel.Controls.Add(this.TextBoxStartId);
            this.ConfigRightPannel.Controls.Add(this.StartIdLabel);
            this.ConfigRightPannel.Controls.Add(this.LabelFilter);
            this.ConfigRightPannel.Controls.Add(this.ComboBoxFilter);
            this.ConfigRightPannel.Controls.Add(this.button1);
            this.ConfigRightPannel.Controls.Add(this.dataRateLabel);
            this.ConfigRightPannel.Controls.Add(this.DataRateComboBox);
            this.ConfigRightPannel.Controls.Add(this.ControlRateLabel);
            this.ConfigRightPannel.Controls.Add(this.ControlRateComboBox);
            this.ConfigRightPannel.Controls.Add(this.FunModeLabel);
            this.ConfigRightPannel.Controls.Add(this.FunModeComboBox);
            this.ConfigRightPannel.Controls.Add(this.ChannelLabel);
            this.ConfigRightPannel.Controls.Add(this.ChannelComboBox);
            this.ConfigRightPannel.Controls.Add(this.DeviceConBtn);
            this.ConfigRightPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigRightPannel.Location = new System.Drawing.Point(422, 0);
            this.ConfigRightPannel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ConfigRightPannel.Name = "ConfigRightPannel";
            this.ConfigRightPannel.Size = new System.Drawing.Size(962, 1158);
            this.ConfigRightPannel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(266, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 41);
            this.label4.TabIndex = 33;
            this.label4.Text = "工作模式";
            // 
            // checkBoxRCAN
            // 
            this.checkBoxRCAN.AutoSize = true;
            this.checkBoxRCAN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxRCAN.Location = new System.Drawing.Point(274, 674);
            this.checkBoxRCAN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxRCAN.Name = "checkBoxRCAN";
            this.checkBoxRCAN.Size = new System.Drawing.Size(114, 46);
            this.checkBoxRCAN.TabIndex = 32;
            this.checkBoxRCAN.Text = "滤波";
            this.checkBoxRCAN.UseVisualStyleBackColor = true;
            this.checkBoxRCAN.CheckedChanged += new System.EventHandler(this.checkBoxRCAN_CheckedChanged_1);
            // 
            // EndIdLabel
            // 
            this.EndIdLabel.AutoSize = true;
            this.EndIdLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndIdLabel.Location = new System.Drawing.Point(262, 980);
            this.EndIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EndIdLabel.Name = "EndIdLabel";
            this.EndIdLabel.Size = new System.Drawing.Size(180, 41);
            this.EndIdLabel.TabIndex = 31;
            this.EndIdLabel.Text = "结束ID(0x):";
            this.EndIdLabel.Visible = false;
            // 
            // TextBoxEndId
            // 
            this.TextBoxEndId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEndId.Location = new System.Drawing.Point(514, 974);
            this.TextBoxEndId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxEndId.Name = "TextBoxEndId";
            this.TextBoxEndId.Size = new System.Drawing.Size(254, 50);
            this.TextBoxEndId.TabIndex = 30;
            this.TextBoxEndId.Visible = false;
            // 
            // TextBoxStartId
            // 
            this.TextBoxStartId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxStartId.Location = new System.Drawing.Point(514, 856);
            this.TextBoxStartId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxStartId.Name = "TextBoxStartId";
            this.TextBoxStartId.Size = new System.Drawing.Size(254, 50);
            this.TextBoxStartId.TabIndex = 29;
            this.TextBoxStartId.Visible = false;
            // 
            // StartIdLabel
            // 
            this.StartIdLabel.AutoSize = true;
            this.StartIdLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartIdLabel.Location = new System.Drawing.Point(262, 872);
            this.StartIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StartIdLabel.Name = "StartIdLabel";
            this.StartIdLabel.Size = new System.Drawing.Size(180, 41);
            this.StartIdLabel.TabIndex = 28;
            this.StartIdLabel.Text = "起始ID(0x):";
            this.StartIdLabel.Visible = false;
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelFilter.Location = new System.Drawing.Point(244, 754);
            this.LabelFilter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(146, 41);
            this.LabelFilter.TabIndex = 27;
            this.LabelFilter.Text = "滤波方式";
            this.LabelFilter.Visible = false;
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "10K",
            "20K",
            "50K",
            "100K",
            "125K",
            "200K",
            "250K",
            "300K",
            "500K",
            "800K",
            "1M"});
            this.ComboBoxFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxFilter.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "CAN1",
            "CAN2"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(514, 742);
            this.ComboBoxFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(254, 43);
            this.ComboBoxFilter.TabIndex = 26;
            this.ComboBoxFilter.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(700, 1060);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 74);
            this.button1.TabIndex = 25;
            this.button1.Text = "初始化CAN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataRateLabel
            // 
            this.dataRateLabel.AutoSize = true;
            this.dataRateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataRateLabel.Location = new System.Drawing.Point(262, 560);
            this.dataRateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dataRateLabel.Name = "dataRateLabel";
            this.dataRateLabel.Size = new System.Drawing.Size(210, 41);
            this.dataRateLabel.TabIndex = 24;
            this.dataRateLabel.Text = "数据段波特率";
            // 
            // DataRateComboBox
            // 
            this.DataRateComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataRateComboBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataRateComboBox.FormattingEnabled = true;
            this.DataRateComboBox.Items.AddRange(new object[] {
            "10K",
            "20K",
            "50K",
            "100K",
            "125K",
            "200K",
            "250K",
            "300K",
            "500K",
            "800K",
            "1M",
            "2M",
            "4M",
            "5M"});
            this.DataRateComboBox.Location = new System.Drawing.Point(514, 600);
            this.DataRateComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DataRateComboBox.Name = "DataRateComboBox";
            this.DataRateComboBox.Size = new System.Drawing.Size(254, 43);
            this.DataRateComboBox.TabIndex = 23;
            // 
            // ControlRateLabel
            // 
            this.ControlRateLabel.AutoSize = true;
            this.ControlRateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlRateLabel.Location = new System.Drawing.Point(262, 470);
            this.ControlRateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ControlRateLabel.Name = "ControlRateLabel";
            this.ControlRateLabel.Size = new System.Drawing.Size(178, 41);
            this.ControlRateLabel.TabIndex = 22;
            this.ControlRateLabel.Text = "域段波特率";
            // 
            // ControlRateComboBox
            // 
            this.ControlRateComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "10K",
            "20K",
            "50K",
            "100K",
            "125K",
            "200K",
            "250K",
            "300K",
            "500K",
            "800K",
            "1M"});
            this.ControlRateComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ControlRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlRateComboBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlRateComboBox.FormattingEnabled = true;
            this.ControlRateComboBox.Items.AddRange(new object[] {
            "CAN1",
            "CAN2"});
            this.ControlRateComboBox.Location = new System.Drawing.Point(514, 458);
            this.ControlRateComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ControlRateComboBox.Name = "ControlRateComboBox";
            this.ControlRateComboBox.Size = new System.Drawing.Size(254, 43);
            this.ControlRateComboBox.TabIndex = 21;
            // 
            // FunModeLabel
            // 
            this.FunModeLabel.AutoSize = true;
            this.FunModeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunModeLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FunModeLabel.Location = new System.Drawing.Point(266, 252);
            this.FunModeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FunModeLabel.Name = "FunModeLabel";
            this.FunModeLabel.Size = new System.Drawing.Size(146, 41);
            this.FunModeLabel.TabIndex = 20;
            this.FunModeLabel.Text = "工作模式";
            // 
            // FunModeComboBox
            // 
            this.FunModeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FunModeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunModeComboBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FunModeComboBox.FormattingEnabled = true;
            this.FunModeComboBox.Items.AddRange(new object[] {
            "CAN",
            "FDCAN",
            "FDCAN-加速"});
            this.FunModeComboBox.Location = new System.Drawing.Point(514, 252);
            this.FunModeComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FunModeComboBox.Name = "FunModeComboBox";
            this.FunModeComboBox.Size = new System.Drawing.Size(254, 43);
            this.FunModeComboBox.TabIndex = 19;
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChannelLabel.Location = new System.Drawing.Point(266, 152);
            this.ChannelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(82, 41);
            this.ChannelLabel.TabIndex = 18;
            this.ChannelLabel.Text = "通道";
            // 
            // ChannelComboBox
            // 
            this.ChannelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ChannelComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChannelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChannelComboBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChannelComboBox.FormattingEnabled = true;
            this.ChannelComboBox.Items.AddRange(new object[] {
            "CAN1",
            "CAN2"});
            this.ChannelComboBox.Location = new System.Drawing.Point(514, 152);
            this.ChannelComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ChannelComboBox.Name = "ChannelComboBox";
            this.ChannelComboBox.Size = new System.Drawing.Size(254, 43);
            this.ChannelComboBox.TabIndex = 17;
            // 
            // DeviceConBtn
            // 
            this.DeviceConBtn.BackColor = System.Drawing.Color.Black;
            this.DeviceConBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceConBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceConBtn.ForeColor = System.Drawing.Color.White;
            this.DeviceConBtn.Location = new System.Drawing.Point(648, 32);
            this.DeviceConBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeviceConBtn.Name = "DeviceConBtn";
            this.DeviceConBtn.Size = new System.Drawing.Size(184, 74);
            this.DeviceConBtn.TabIndex = 16;
            this.DeviceConBtn.Text = "连接设备";
            this.DeviceConBtn.UseVisualStyleBackColor = false;
            this.DeviceConBtn.Click += new System.EventHandler(this.DeviceConBtn_Click_1);
            // 
            // ConfigLeftPannel
            // 
            this.ConfigLeftPannel.BackColor = System.Drawing.Color.Black;
            this.ConfigLeftPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfigLeftPannel.Controls.Add(this.label3);
            this.ConfigLeftPannel.Controls.Add(this.label2);
            this.ConfigLeftPannel.Controls.Add(this.label1);
            this.ConfigLeftPannel.Controls.Add(this.PictureBoxImage);
            this.ConfigLeftPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConfigLeftPannel.Location = new System.Drawing.Point(0, 0);
            this.ConfigLeftPannel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ConfigLeftPannel.Name = "ConfigLeftPannel";
            this.ConfigLeftPannel.Size = new System.Drawing.Size(422, 1158);
            this.ConfigLeftPannel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 1068);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEVELOP BY LILEI SOFT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 624);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "YOU CAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "SO I THINK";
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PictureBoxImage.Image = global::CANTOOL.Properties.Resources.cilun;
            this.PictureBoxImage.Location = new System.Drawing.Point(42, 125);
            this.PictureBoxImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(342, 278);
            this.PictureBoxImage.TabIndex = 0;
            this.PictureBoxImage.TabStop = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1384, 1230);
            this.Controls.Add(this.ContentPannel);
            this.Controls.Add(this.TitlePannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.TopMost = true;
            this.TitlePannel.ResumeLayout(false);
            this.TitlePannel.PerformLayout();
            this.ContentPannel.ResumeLayout(false);
            this.ConfigRightPannel.ResumeLayout(false);
            this.ConfigRightPannel.PerformLayout();
            this.ConfigLeftPannel.ResumeLayout(false);
            this.ConfigLeftPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePannel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel ContentPannel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Panel ConfigRightPannel;
        private System.Windows.Forms.CheckBox checkBoxRCAN;
        private System.Windows.Forms.Label EndIdLabel;
        private System.Windows.Forms.TextBox TextBoxEndId;
        private System.Windows.Forms.TextBox TextBoxStartId;
        private System.Windows.Forms.Label StartIdLabel;
        private System.Windows.Forms.Label LabelFilter;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dataRateLabel;
        private System.Windows.Forms.ComboBox DataRateComboBox;
        private System.Windows.Forms.Label ControlRateLabel;
        private System.Windows.Forms.ComboBox ControlRateComboBox;
        private System.Windows.Forms.Label FunModeLabel;
        private System.Windows.Forms.ComboBox FunModeComboBox;
        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.ComboBox ChannelComboBox;
        private System.Windows.Forms.Button DeviceConBtn;
        private System.Windows.Forms.Panel ConfigLeftPannel;
        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}