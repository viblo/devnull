namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmrAutoPilot = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFtl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStarInfo = new System.Windows.Forms.Button();
            this.chkAutoPilot = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnPlanetInfo = new System.Windows.Forms.Button();
            this.btnSystemTravel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlanetInfo = new System.Windows.Forms.TextBox();
            this.cbxPlanetInfo = new System.Windows.Forms.ComboBox();
            this.pbxSystem = new System.Windows.Forms.PictureBox();
            this.pbxUni = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbInventory = new System.Windows.Forms.ComboBox();
            this.btnDroneGet = new System.Windows.Forms.Button();
            this.btnDroneDrop = new System.Windows.Forms.Button();
            this.btnDroneLvlUp = new System.Windows.Forms.Button();
            this.btnDroneLevelDown = new System.Windows.Forms.Button();
            this.chkScanner = new System.Windows.Forms.CheckBox();
            this.btnDroneRight = new System.Windows.Forms.Button();
            this.btnDroneLeft = new System.Windows.Forms.Button();
            this.btnDroneDown = new System.Windows.Forms.Button();
            this.btnDroneUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRecallDrone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxAnomalies = new System.Windows.Forms.ComboBox();
            this.btnDeployDrone = new System.Windows.Forms.Button();
            this.btnRefreshDrone = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tmrDrone = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gwEntities = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gwItems = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUni)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 2000;
            this.tmr1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrAutoPilot
            // 
            this.tmrAutoPilot.Enabled = true;
            this.tmrAutoPilot.Interval = 2000;
            this.tmrAutoPilot.Tick += new System.EventHandler(this.tmrAutoPilot_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 533);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pbxSystem);
            this.tabPage1.Controls.Add(this.pbxUni);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Universe/Systems";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnFtl);
            this.groupBox3.Location = new System.Drawing.Point(755, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 52);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Universe Controls";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnFtl
            // 
            this.btnFtl.Location = new System.Drawing.Point(119, 17);
            this.btnFtl.Name = "btnFtl";
            this.btnFtl.Size = new System.Drawing.Size(75, 23);
            this.btnFtl.TabIndex = 2;
            this.btnFtl.Text = "ftl";
            this.btnFtl.UseVisualStyleBackColor = true;
            this.btnFtl.Click += new System.EventHandler(this.btnFtl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(3, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 152);
            this.dataGridView1.TabIndex = 25;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Name";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StarSystem";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CoreRadius";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SurfGrav";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Anomalies";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStarInfo);
            this.groupBox2.Controls.Add(this.chkAutoPilot);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.btnPlanetInfo);
            this.groupBox2.Controls.Add(this.btnSystemTravel);
            this.groupBox2.Location = new System.Drawing.Point(755, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planet Controls";
            // 
            // btnStarInfo
            // 
            this.btnStarInfo.Location = new System.Drawing.Point(6, 19);
            this.btnStarInfo.Name = "btnStarInfo";
            this.btnStarInfo.Size = new System.Drawing.Size(75, 23);
            this.btnStarInfo.TabIndex = 8;
            this.btnStarInfo.Text = "star info";
            this.btnStarInfo.UseVisualStyleBackColor = true;
            this.btnStarInfo.Click += new System.EventHandler(this.btnStarInfo_Click);
            // 
            // chkAutoPilot
            // 
            this.chkAutoPilot.AutoSize = true;
            this.chkAutoPilot.Location = new System.Drawing.Point(10, 71);
            this.chkAutoPilot.Name = "chkAutoPilot";
            this.chkAutoPilot.Size = new System.Drawing.Size(71, 17);
            this.chkAutoPilot.TabIndex = 15;
            this.chkAutoPilot.Text = "Auto Pilot";
            this.chkAutoPilot.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // btnPlanetInfo
            // 
            this.btnPlanetInfo.Location = new System.Drawing.Point(119, 71);
            this.btnPlanetInfo.Name = "btnPlanetInfo";
            this.btnPlanetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnPlanetInfo.TabIndex = 10;
            this.btnPlanetInfo.Text = "scan planet";
            this.btnPlanetInfo.UseVisualStyleBackColor = true;
            this.btnPlanetInfo.Click += new System.EventHandler(this.btnPlanetInfo_Click);
            // 
            // btnSystemTravel
            // 
            this.btnSystemTravel.Location = new System.Drawing.Point(119, 42);
            this.btnSystemTravel.Name = "btnSystemTravel";
            this.btnSystemTravel.Size = new System.Drawing.Size(75, 23);
            this.btnSystemTravel.TabIndex = 9;
            this.btnSystemTravel.Text = "travel";
            this.btnSystemTravel.UseVisualStyleBackColor = true;
            this.btnSystemTravel.Click += new System.EventHandler(this.btnSystemTravel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPlanetInfo);
            this.groupBox1.Controls.Add(this.cbxPlanetInfo);
            this.groupBox1.Location = new System.Drawing.Point(755, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 209);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "planet info";
            // 
            // txtPlanetInfo
            // 
            this.txtPlanetInfo.Location = new System.Drawing.Point(6, 46);
            this.txtPlanetInfo.Multiline = true;
            this.txtPlanetInfo.Name = "txtPlanetInfo";
            this.txtPlanetInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlanetInfo.Size = new System.Drawing.Size(186, 150);
            this.txtPlanetInfo.TabIndex = 14;
            // 
            // cbxPlanetInfo
            // 
            this.cbxPlanetInfo.FormattingEnabled = true;
            this.cbxPlanetInfo.Location = new System.Drawing.Point(6, 19);
            this.cbxPlanetInfo.Name = "cbxPlanetInfo";
            this.cbxPlanetInfo.Size = new System.Drawing.Size(121, 21);
            this.cbxPlanetInfo.TabIndex = 13;
            this.cbxPlanetInfo.SelectedIndexChanged += new System.EventHandler(this.cbxPlanetInfo_SelectedIndexChanged);
            // 
            // pbxSystem
            // 
            this.pbxSystem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxSystem.Location = new System.Drawing.Point(377, 3);
            this.pbxSystem.Name = "pbxSystem";
            this.pbxSystem.Size = new System.Drawing.Size(354, 327);
            this.pbxSystem.TabIndex = 21;
            this.pbxSystem.TabStop = false;
            this.pbxSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSystem_Paint);
            // 
            // pbxUni
            // 
            this.pbxUni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxUni.Location = new System.Drawing.Point(3, 3);
            this.pbxUni.Name = "pbxUni";
            this.pbxUni.Size = new System.Drawing.Size(368, 327);
            this.pbxUni.TabIndex = 20;
            this.pbxUni.TabStop = false;
            this.pbxUni.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxUni_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.gwItems);
            this.tabPage2.Controls.Add(this.gwEntities);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.chkScanner);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnRefreshDrone);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Planet/Drones";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbInventory);
            this.groupBox4.Controls.Add(this.btnDroneGet);
            this.groupBox4.Controls.Add(this.btnDroneDrop);
            this.groupBox4.Location = new System.Drawing.Point(306, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 85);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inventory";
            // 
            // cmbInventory
            // 
            this.cmbInventory.FormattingEnabled = true;
            this.cmbInventory.Location = new System.Drawing.Point(17, 19);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(104, 21);
            this.cmbInventory.TabIndex = 16;
            // 
            // btnDroneGet
            // 
            this.btnDroneGet.Location = new System.Drawing.Point(73, 46);
            this.btnDroneGet.Name = "btnDroneGet";
            this.btnDroneGet.Size = new System.Drawing.Size(48, 23);
            this.btnDroneGet.TabIndex = 15;
            this.btnDroneGet.Text = "Get";
            this.btnDroneGet.UseVisualStyleBackColor = true;
            this.btnDroneGet.Click += new System.EventHandler(this.btnDroneGet_Click);
            // 
            // btnDroneDrop
            // 
            this.btnDroneDrop.Location = new System.Drawing.Point(10, 46);
            this.btnDroneDrop.Name = "btnDroneDrop";
            this.btnDroneDrop.Size = new System.Drawing.Size(57, 23);
            this.btnDroneDrop.TabIndex = 14;
            this.btnDroneDrop.Text = "Drop";
            this.btnDroneDrop.UseVisualStyleBackColor = true;
            this.btnDroneDrop.Click += new System.EventHandler(this.btnDroneDrop_Click);
            // 
            // btnDroneLvlUp
            // 
            this.btnDroneLvlUp.Location = new System.Drawing.Point(4, 103);
            this.btnDroneLvlUp.Name = "btnDroneLvlUp";
            this.btnDroneLvlUp.Size = new System.Drawing.Size(66, 23);
            this.btnDroneLvlUp.TabIndex = 13;
            this.btnDroneLvlUp.Text = "Level Up";
            this.btnDroneLvlUp.UseVisualStyleBackColor = true;
            // 
            // btnDroneLevelDown
            // 
            this.btnDroneLevelDown.Location = new System.Drawing.Point(71, 104);
            this.btnDroneLevelDown.Name = "btnDroneLevelDown";
            this.btnDroneLevelDown.Size = new System.Drawing.Size(77, 23);
            this.btnDroneLevelDown.TabIndex = 12;
            this.btnDroneLevelDown.Text = "Level Down";
            this.btnDroneLevelDown.UseVisualStyleBackColor = true;
            // 
            // chkScanner
            // 
            this.chkScanner.AutoSize = true;
            this.chkScanner.Location = new System.Drawing.Point(358, 163);
            this.chkScanner.Name = "chkScanner";
            this.chkScanner.Size = new System.Drawing.Size(111, 17);
            this.chkScanner.TabIndex = 11;
            this.chkScanner.Text = "ScannerActivated";
            this.chkScanner.UseVisualStyleBackColor = true;
            // 
            // btnDroneRight
            // 
            this.btnDroneRight.Location = new System.Drawing.Point(88, 44);
            this.btnDroneRight.Name = "btnDroneRight";
            this.btnDroneRight.Size = new System.Drawing.Size(47, 23);
            this.btnDroneRight.TabIndex = 10;
            this.btnDroneRight.Text = "Right";
            this.btnDroneRight.UseVisualStyleBackColor = true;
            this.btnDroneRight.Click += new System.EventHandler(this.btnDroneRight_Click);
            // 
            // btnDroneLeft
            // 
            this.btnDroneLeft.Location = new System.Drawing.Point(6, 44);
            this.btnDroneLeft.Name = "btnDroneLeft";
            this.btnDroneLeft.Size = new System.Drawing.Size(47, 23);
            this.btnDroneLeft.TabIndex = 9;
            this.btnDroneLeft.Text = "Left";
            this.btnDroneLeft.UseVisualStyleBackColor = true;
            this.btnDroneLeft.Click += new System.EventHandler(this.btnDroneLeft_Click);
            // 
            // btnDroneDown
            // 
            this.btnDroneDown.Location = new System.Drawing.Point(51, 75);
            this.btnDroneDown.Name = "btnDroneDown";
            this.btnDroneDown.Size = new System.Drawing.Size(47, 23);
            this.btnDroneDown.TabIndex = 8;
            this.btnDroneDown.Text = "Down";
            this.btnDroneDown.UseVisualStyleBackColor = true;
            this.btnDroneDown.Click += new System.EventHandler(this.btnDroneDown_Click);
            // 
            // btnDroneUp
            // 
            this.btnDroneUp.Location = new System.Drawing.Point(52, 19);
            this.btnDroneUp.Name = "btnDroneUp";
            this.btnDroneUp.Size = new System.Drawing.Size(39, 23);
            this.btnDroneUp.TabIndex = 7;
            this.btnDroneUp.Text = "Up";
            this.btnDroneUp.UseVisualStyleBackColor = true;
            this.btnDroneUp.Click += new System.EventHandler(this.btnDroneUp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "manualScan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRecallDrone
            // 
            this.btnRecallDrone.Location = new System.Drawing.Point(22, 74);
            this.btnRecallDrone.Name = "btnRecallDrone";
            this.btnRecallDrone.Size = new System.Drawing.Size(84, 23);
            this.btnRecallDrone.TabIndex = 5;
            this.btnRecallDrone.Text = "recall drone";
            this.btnRecallDrone.UseVisualStyleBackColor = true;
            this.btnRecallDrone.Click += new System.EventHandler(this.btnRecallDrone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(476, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 366);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // cbxAnomalies
            // 
            this.cbxAnomalies.FormattingEnabled = true;
            this.cbxAnomalies.Location = new System.Drawing.Point(17, 19);
            this.cbxAnomalies.Name = "cbxAnomalies";
            this.cbxAnomalies.Size = new System.Drawing.Size(89, 21);
            this.cbxAnomalies.TabIndex = 3;
            // 
            // btnDeployDrone
            // 
            this.btnDeployDrone.Location = new System.Drawing.Point(22, 45);
            this.btnDeployDrone.Name = "btnDeployDrone";
            this.btnDeployDrone.Size = new System.Drawing.Size(84, 23);
            this.btnDeployDrone.TabIndex = 2;
            this.btnDeployDrone.Text = "deploy drone";
            this.btnDeployDrone.UseVisualStyleBackColor = true;
            this.btnDeployDrone.Click += new System.EventHandler(this.btnDeployDrone_Click);
            // 
            // btnRefreshDrone
            // 
            this.btnRefreshDrone.Location = new System.Drawing.Point(379, 134);
            this.btnRefreshDrone.Name = "btnRefreshDrone";
            this.btnRefreshDrone.Size = new System.Drawing.Size(90, 23);
            this.btnRefreshDrone.TabIndex = 1;
            this.btnRefreshDrone.Text = "Refresh Drone";
            this.btnRefreshDrone.UseVisualStyleBackColor = true;
            this.btnRefreshDrone.Click += new System.EventHandler(this.btnRefreshDrone_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column12,
            this.Column10,
            this.Column11});
            this.dataGridView2.Location = new System.Drawing.Point(8, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(461, 122);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DroneId";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Map";
            this.Column9.Name = "Column9";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Items";
            this.Column12.Name = "Column12";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "CurrentPos";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "LatestScan";
            this.Column11.Name = "Column11";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(7, 539);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(959, 79);
            this.txtLog.TabIndex = 22;
            // 
            // tmrDrone
            // 
            this.tmrDrone.Enabled = true;
            this.tmrDrone.Interval = 1000;
            this.tmrDrone.Tick += new System.EventHandler(this.tmrDrone_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDroneUp);
            this.groupBox5.Controls.Add(this.btnDroneDown);
            this.groupBox5.Controls.Add(this.btnDroneLvlUp);
            this.groupBox5.Controls.Add(this.btnDroneLevelDown);
            this.groupBox5.Controls.Add(this.btnDroneLeft);
            this.groupBox5.Controls.Add(this.btnDroneRight);
            this.groupBox5.Location = new System.Drawing.Point(147, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 138);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Drone movement";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxAnomalies);
            this.groupBox6.Controls.Add(this.btnDeployDrone);
            this.groupBox6.Controls.Add(this.btnRecallDrone);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(8, 134);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 132);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Drone deployment";
            // 
            // gwEntities
            // 
            this.gwEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.gwEntities.Location = new System.Drawing.Point(8, 278);
            this.gwEntities.Name = "gwEntities";
            this.gwEntities.Size = new System.Drawing.Size(402, 78);
            this.gwEntities.TabIndex = 20;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Name";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "X";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Y";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "ThingId";
            this.Column16.Name = "Column16";
            // 
            // gwItems
            // 
            this.gwItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwItems.Location = new System.Drawing.Point(8, 362);
            this.gwItems.Name = "gwItems";
            this.gwItems.Size = new System.Drawing.Size(461, 99);
            this.gwItems.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 625);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Starship Commander - Advanced Edition";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUni)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gwEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmrAutoPilot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFtl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStarInfo;
        private System.Windows.Forms.CheckBox chkAutoPilot;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnPlanetInfo;
        private System.Windows.Forms.Button btnSystemTravel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlanetInfo;
        private System.Windows.Forms.ComboBox cbxPlanetInfo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox pbxSystem;
        private System.Windows.Forms.PictureBox pbxUni;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRefreshDrone;
        private System.Windows.Forms.Button btnDeployDrone;
        private System.Windows.Forms.ComboBox cbxAnomalies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrDrone;
        private System.Windows.Forms.Button btnRecallDrone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDroneRight;
        private System.Windows.Forms.Button btnDroneLeft;
        private System.Windows.Forms.Button btnDroneDown;
        private System.Windows.Forms.Button btnDroneUp;
        private System.Windows.Forms.CheckBox chkScanner;
        private System.Windows.Forms.Button btnDroneGet;
        private System.Windows.Forms.Button btnDroneDrop;
        private System.Windows.Forms.Button btnDroneLvlUp;
        private System.Windows.Forms.Button btnDroneLevelDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbInventory;
        private System.Windows.Forms.DataGridView gwItems;
        private System.Windows.Forms.DataGridView gwEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

