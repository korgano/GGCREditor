namespace GGCREditor
{
    partial class FrmEditGundam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditGundam));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsGundam = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBatchImport = new System.Windows.Forms.Button();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnEditWeapon = new System.Windows.Forms.Button();
            this.cboSkill5 = new System.Windows.Forms.ComboBox();
            this.cboEarthSize = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.cboSkill4 = new System.Windows.Forms.ComboBox();
            this.cboSkill3 = new System.Windows.Forms.ComboBox();
            this.cboSkill2 = new System.Windows.Forms.ComboBox();
            this.cboSkill1 = new System.Windows.Forms.ComboBox();
            this.cboE5 = new System.Windows.Forms.ComboBox();
            this.cboE4 = new System.Windows.Forms.ComboBox();
            this.cboE3 = new System.Windows.Forms.ComboBox();
            this.cboE2 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cboE1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMapCount = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstMap = new System.Windows.Forms.TextBox();
            this.txtWeaponCount = new System.Windows.Forms.TextBox();
            this.txtWeapon1ID = new System.Windows.Forms.TextBox();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpd = new System.Windows.Forms.TextBox();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiLblState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(90, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(425, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lsGundam
            // 
            this.lsGundam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsGundam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsGundam.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsGundam.FormattingEnabled = true;
            this.lsGundam.ItemHeight = 16;
            this.lsGundam.Location = new System.Drawing.Point(19, 42);
            this.lsGundam.Margin = new System.Windows.Forms.Padding(4);
            this.lsGundam.Name = "lsGundam";
            this.lsGundam.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsGundam.Size = new System.Drawing.Size(498, 950);
            this.lsGundam.TabIndex = 9;
            this.lsGundam.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsGundam_DrawItem);
            this.lsGundam.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lsGundam_MeasureItem);
            this.lsGundam.SelectedIndexChanged += new System.EventHandler(this.lsGundam_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "搜 Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnBatchImport);
            this.groupBox1.Controls.Add(this.btnExportAll);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.pic1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.btnEditWeapon);
            this.groupBox1.Controls.Add(this.cboSkill5);
            this.groupBox1.Controls.Add(this.cboEarthSize);
            this.groupBox1.Controls.Add(this.cboSize);
            this.groupBox1.Controls.Add(this.cboSkill4);
            this.groupBox1.Controls.Add(this.cboSkill3);
            this.groupBox1.Controls.Add(this.cboSkill2);
            this.groupBox1.Controls.Add(this.cboSkill1);
            this.groupBox1.Controls.Add(this.cboE5);
            this.groupBox1.Controls.Add(this.cboE4);
            this.groupBox1.Controls.Add(this.cboE3);
            this.groupBox1.Controls.Add(this.cboE2);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.cboE1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMapCount);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstMap);
            this.groupBox1.Controls.Add(this.txtWeaponCount);
            this.groupBox1.Controls.Add(this.txtWeapon1ID);
            this.groupBox1.Controls.Add(this.txtPic);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtUUID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtHP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSpd);
            this.groupBox1.Controls.Add(this.txtMove);
            this.groupBox1.Controls.Add(this.txtAct);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDef);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(523, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(626, 900);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性 ATTR";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(437, 786);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "保存 Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBatchImport
            // 
            this.btnBatchImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchImport.Location = new System.Drawing.Point(545, 831);
            this.btnBatchImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatchImport.Name = "btnBatchImport";
            this.btnBatchImport.Size = new System.Drawing.Size(68, 65);
            this.btnBatchImport.TabIndex = 27;
            this.btnBatchImport.Text = "批量\r\n导入\r\nBatch Import";
            this.btnBatchImport.UseVisualStyleBackColor = true;
            this.btnBatchImport.Click += new System.EventHandler(this.btnBatchImport_Click);
            // 
            // btnExportAll
            // 
            this.btnExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAll.Location = new System.Drawing.Point(545, 777);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(68, 53);
            this.btnExportAll.TabIndex = 27;
            this.btnExportAll.Text = "导出\r\nExport\r\nTXT";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(422, 76);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(192, 46);
            this.btnConvert.TabIndex = 26;
            this.btnConvert.Text = "变型换装修改 Modifications";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.Red;
            this.label32.Location = new System.Drawing.Point(26, 831);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(347, 32);
            this.label32.TabIndex = 25;
            this.label32.Text = "若有修改,请先保存再导出 按住Ctrl可多选后批量导出\r\nSave, then export. Use Ctrl to multi-select";
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(130, 76);
            this.pic1.Margin = new System.Windows.Forms.Padding(4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(192, 96);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 24;
            this.pic1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(439, 855);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "导入 Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(439, 824);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "导出 Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 215);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 16);
            this.label24.TabIndex = 21;
            this.label24.Text = "系列 Series";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(129, 211);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.Size = new System.Drawing.Size(190, 22);
            this.txtGroup.TabIndex = 22;
            // 
            // btnEditWeapon
            // 
            this.btnEditWeapon.Location = new System.Drawing.Point(473, 680);
            this.btnEditWeapon.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditWeapon.Name = "btnEditWeapon";
            this.btnEditWeapon.Size = new System.Drawing.Size(140, 82);
            this.btnEditWeapon.TabIndex = 20;
            this.btnEditWeapon.Text = "拥有武器修改 Mod Weapon";
            this.btnEditWeapon.UseVisualStyleBackColor = true;
            this.btnEditWeapon.Click += new System.EventHandler(this.btnEditWeapon_Click);
            // 
            // cboSkill5
            // 
            this.cboSkill5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill5.FormattingEnabled = true;
            this.cboSkill5.Location = new System.Drawing.Point(422, 634);
            this.cboSkill5.Margin = new System.Windows.Forms.Padding(4);
            this.cboSkill5.Name = "cboSkill5";
            this.cboSkill5.Size = new System.Drawing.Size(190, 24);
            this.cboSkill5.TabIndex = 19;
            // 
            // cboEarthSize
            // 
            this.cboEarthSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEarthSize.FormattingEnabled = true;
            this.cboEarthSize.Location = new System.Drawing.Point(129, 555);
            this.cboEarthSize.Margin = new System.Windows.Forms.Padding(4);
            this.cboEarthSize.Name = "cboEarthSize";
            this.cboEarthSize.Size = new System.Drawing.Size(190, 24);
            this.cboEarthSize.TabIndex = 19;
            this.cboEarthSize.SelectedIndexChanged += new System.EventHandler(this.cboEarthSize_SelectedIndexChanged);
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(132, 506);
            this.cboSize.Margin = new System.Windows.Forms.Padding(4);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(190, 24);
            this.cboSize.TabIndex = 19;
            // 
            // cboSkill4
            // 
            this.cboSkill4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill4.FormattingEnabled = true;
            this.cboSkill4.Location = new System.Drawing.Point(422, 584);
            this.cboSkill4.Margin = new System.Windows.Forms.Padding(4);
            this.cboSkill4.Name = "cboSkill4";
            this.cboSkill4.Size = new System.Drawing.Size(190, 24);
            this.cboSkill4.TabIndex = 19;
            // 
            // cboSkill3
            // 
            this.cboSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill3.FormattingEnabled = true;
            this.cboSkill3.Location = new System.Drawing.Point(422, 534);
            this.cboSkill3.Margin = new System.Windows.Forms.Padding(4);
            this.cboSkill3.Name = "cboSkill3";
            this.cboSkill3.Size = new System.Drawing.Size(190, 24);
            this.cboSkill3.TabIndex = 19;
            // 
            // cboSkill2
            // 
            this.cboSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill2.FormattingEnabled = true;
            this.cboSkill2.Location = new System.Drawing.Point(422, 485);
            this.cboSkill2.Margin = new System.Windows.Forms.Padding(4);
            this.cboSkill2.Name = "cboSkill2";
            this.cboSkill2.Size = new System.Drawing.Size(190, 24);
            this.cboSkill2.TabIndex = 19;
            // 
            // cboSkill1
            // 
            this.cboSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkill1.FormattingEnabled = true;
            this.cboSkill1.Location = new System.Drawing.Point(422, 442);
            this.cboSkill1.Margin = new System.Windows.Forms.Padding(4);
            this.cboSkill1.Name = "cboSkill1";
            this.cboSkill1.Size = new System.Drawing.Size(190, 24);
            this.cboSkill1.TabIndex = 19;
            // 
            // cboE5
            // 
            this.cboE5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE5.FormattingEnabled = true;
            this.cboE5.Location = new System.Drawing.Point(422, 273);
            this.cboE5.Margin = new System.Windows.Forms.Padding(4);
            this.cboE5.Name = "cboE5";
            this.cboE5.Size = new System.Drawing.Size(67, 24);
            this.cboE5.TabIndex = 19;
            // 
            // cboE4
            // 
            this.cboE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE4.FormattingEnabled = true;
            this.cboE4.Location = new System.Drawing.Point(545, 273);
            this.cboE4.Margin = new System.Windows.Forms.Padding(4);
            this.cboE4.Name = "cboE4";
            this.cboE4.Size = new System.Drawing.Size(67, 24);
            this.cboE4.TabIndex = 19;
            // 
            // cboE3
            // 
            this.cboE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE3.FormattingEnabled = true;
            this.cboE3.Location = new System.Drawing.Point(430, 332);
            this.cboE3.Margin = new System.Windows.Forms.Padding(4);
            this.cboE3.Name = "cboE3";
            this.cboE3.Size = new System.Drawing.Size(67, 24);
            this.cboE3.TabIndex = 19;
            // 
            // cboE2
            // 
            this.cboE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE2.FormattingEnabled = true;
            this.cboE2.Location = new System.Drawing.Point(545, 332);
            this.cboE2.Margin = new System.Windows.Forms.Padding(4);
            this.cboE2.Name = "cboE2";
            this.cboE2.Size = new System.Drawing.Size(67, 24);
            this.cboE2.TabIndex = 19;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(28, 864);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(361, 32);
            this.label30.TabIndex = 6;
            this.label30.Text = "导入功能会根据数据头自动匹配数据,导入完成请保存. \r\nPlease save when the import is complete.";
            // 
            // cboE1
            // 
            this.cboE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboE1.FormattingEnabled = true;
            this.cboE1.Location = new System.Drawing.Point(500, 364);
            this.cboE1.Margin = new System.Windows.Forms.Padding(4);
            this.cboE1.Name = "cboE1";
            this.cboE1.Size = new System.Drawing.Size(67, 24);
            this.cboE1.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(26, 777);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(265, 48);
            this.label18.TabIndex = 6;
            this.label18.Text = "每个人物单独保存,保存前请备份原文件\r\nEach is saved separately, please back up\r\n the original file " +
    "before saving";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(265, 738);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 16);
            this.label28.TabIndex = 2;
            this.label28.Text = "武器数量 Weapon Count";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(265, 681);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "武器数量 Weapon Count";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(26, 680);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(246, 16);
            this.label27.TabIndex = 2;
            this.label27.Text = "第一地图炮ID First Map Weapon Id ???";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(353, 147);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 16);
            this.label31.TabIndex = 2;
            this.label31.Text = "立绘 Icon";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(327, 181);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "地址 Address";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(26, 614);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(201, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "第一武器ID First Weapon Id ???";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(76, 30);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 16);
            this.label26.TabIndex = 2;
            this.label26.Text = "UID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-7, 181);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "机体名 Body Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 257);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "宇宙 Space";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "空中 Aerial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 312);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "地上 On the Ground";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "水上 Over Water";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "水中 Underwater";
            // 
            // txtMapCount
            // 
            this.txtMapCount.Location = new System.Drawing.Point(344, 756);
            this.txtMapCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtMapCount.Name = "txtMapCount";
            this.txtMapCount.Size = new System.Drawing.Size(112, 22);
            this.txtMapCount.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(343, 213);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 16);
            this.label25.TabIndex = 2;
            this.label25.Text = "价格 Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "HP";
            // 
            // txtFirstMap
            // 
            this.txtFirstMap.Location = new System.Drawing.Point(130, 700);
            this.txtFirstMap.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstMap.Name = "txtFirstMap";
            this.txtFirstMap.Size = new System.Drawing.Size(112, 22);
            this.txtFirstMap.TabIndex = 3;
            // 
            // txtWeaponCount
            // 
            this.txtWeaponCount.Location = new System.Drawing.Point(344, 701);
            this.txtWeaponCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeaponCount.Name = "txtWeaponCount";
            this.txtWeaponCount.Size = new System.Drawing.Size(112, 22);
            this.txtWeaponCount.TabIndex = 3;
            // 
            // txtWeapon1ID
            // 
            this.txtWeapon1ID.Location = new System.Drawing.Point(127, 635);
            this.txtWeapon1ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeapon1ID.Name = "txtWeapon1ID";
            this.txtWeapon1ID.Size = new System.Drawing.Size(112, 22);
            this.txtWeapon1ID.TabIndex = 3;
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(422, 144);
            this.txtPic.Margin = new System.Windows.Forms.Padding(4);
            this.txtPic.Name = "txtPic";
            this.txtPic.ReadOnly = true;
            this.txtPic.Size = new System.Drawing.Size(190, 22);
            this.txtPic.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(421, 181);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(190, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // txtUUID
            // 
            this.txtUUID.Location = new System.Drawing.Point(121, 27);
            this.txtUUID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.ReadOnly = true;
            this.txtUUID.Size = new System.Drawing.Size(491, 22);
            this.txtUUID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 181);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(421, 211);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 22);
            this.txtPrice.TabIndex = 0;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(132, 251);
            this.txtHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(190, 22);
            this.txtHP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "EN";
            // 
            // txtEN
            // 
            this.txtEN.Location = new System.Drawing.Point(132, 297);
            this.txtEN.Margin = new System.Windows.Forms.Padding(4);
            this.txtEN.Name = "txtEN";
            this.txtEN.Size = new System.Drawing.Size(190, 22);
            this.txtEN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "攻击 ATK";
            // 
            // txtSpd
            // 
            this.txtSpd.Location = new System.Drawing.Point(130, 416);
            this.txtSpd.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpd.Name = "txtSpd";
            this.txtSpd.Size = new System.Drawing.Size(190, 22);
            this.txtSpd.TabIndex = 4;
            // 
            // txtMove
            // 
            this.txtMove.Location = new System.Drawing.Point(130, 460);
            this.txtMove.Margin = new System.Windows.Forms.Padding(4);
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(190, 22);
            this.txtMove.TabIndex = 4;
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(129, 334);
            this.txtAct.Margin = new System.Windows.Forms.Padding(4);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(190, 22);
            this.txtAct.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(362, 614);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "能力5 Ability";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(362, 563);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "能力4 Ability";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(367, 514);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "能力3 Ability";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 466);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "能力2 Ability";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 422);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "能力1 Ability";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 555);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "占地图面积 # of Tiles";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "防御 DEF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 512);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "SIZE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "机动力 Energy";
            // 
            // txtDef
            // 
            this.txtDef.Location = new System.Drawing.Point(132, 375);
            this.txtDef.Margin = new System.Windows.Forms.Padding(4);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(190, 22);
            this.txtDef.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "移动 Move";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFile,
            this.tsmiLblState,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1007);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1159, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblFile
            // 
            this.tslblFile.Name = "tslblFile";
            this.tslblFile.Size = new System.Drawing.Size(151, 20);
            this.tslblFile.Text = "toolStripStatusLabel1";
            // 
            // tsmiLblState
            // 
            this.tsmiLblState.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.tsmiLblState.Name = "tsmiLblState";
            this.tsmiLblState.Size = new System.Drawing.Size(755, 21);
            this.tsmiLblState.Spring = true;
            this.tsmiLblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(229, 20);
            this.toolStripStatusLabel1.Text = "感谢lxdlxd99的机体数据 (credits)";
            // 
            // FrmEditGundam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 1033);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsGundam);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1144, 533);
            this.Name = "FrmEditGundam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "机体信息修改 Modify Gundam";
            this.Load += new System.EventHandler(this.FrmEditGundam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lsGundam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMove;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboE5;
        private System.Windows.Forms.ComboBox cboE4;
        private System.Windows.Forms.ComboBox cboE3;
        private System.Windows.Forms.ComboBox cboE2;
        private System.Windows.Forms.ComboBox cboE1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboSkill5;
        private System.Windows.Forms.ComboBox cboSkill4;
        private System.Windows.Forms.ComboBox cboSkill3;
        private System.Windows.Forms.ComboBox cboSkill2;
        private System.Windows.Forms.ComboBox cboSkill1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblFile;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsmiLblState;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtWeaponCount;
        private System.Windows.Forms.TextBox txtWeapon1ID;
        private System.Windows.Forms.Button btnEditWeapon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMapCount;
        private System.Windows.Forms.TextBox txtFirstMap;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.ComboBox cboEarthSize;
        private System.Windows.Forms.Button btnBatchImport;
        private System.Windows.Forms.Button btnSave;
    }
}