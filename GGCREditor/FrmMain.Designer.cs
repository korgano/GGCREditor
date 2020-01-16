namespace GGCREditor
{
    partial class FrmMain
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.简体中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.繁体中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.繁体中文台湾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koreanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditMaster = new System.Windows.Forms.Button();
            this.btnEditGundam = new System.Windows.Forms.Button();
            this.btnEditWeapon = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLang = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditPeopleText = new System.Windows.Forms.Button();
            this.btnEditMachineTxt = new System.Windows.Forms.Button();
            this.btnEditMachineDesc = new System.Windows.Forms.Button();
            this.btnEditAbilityText = new System.Windows.Forms.Button();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditAbility = new System.Windows.Forms.Button();
            this.btnEditTBL = new System.Windows.Forms.Button();
            this.flowContainer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.flowContainer.SuspendLayout();
            this.flowContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1070, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.选择路径ToolStripMenuItem, this.tsmiLanguage});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(219, 36);
            this.文件ToolStripMenuItem.Text = "文件(File/Options)";
            // 
            // 选择路径ToolStripMenuItem
            // 
            this.选择路径ToolStripMenuItem.Name = "选择路径ToolStripMenuItem";
            this.选择路径ToolStripMenuItem.Size = new System.Drawing.Size(563, 38);
            this.选择路径ToolStripMenuItem.Text = "设置data文件夹路径 (Set data folder path)";
            this.选择路径ToolStripMenuItem.Click += new System.EventHandler(this.选择路径ToolStripMenuItem_Click);
            // 
            // tsmiLanguage
            // 
            this.tsmiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.简体中文ToolStripMenuItem, this.繁体中文ToolStripMenuItem, this.繁体中文台湾ToolStripMenuItem,
                this.englishToolStripMenuItem, this.japaneseToolStripMenuItem, this.koreanToolStripMenuItem
            });
            this.tsmiLanguage.Name = "tsmiLanguage";
            this.tsmiLanguage.Size = new System.Drawing.Size(563, 38);
            this.tsmiLanguage.Text = "选择游戏语言(Choose Game Language)";
            // 
            // 简体中文ToolStripMenuItem
            // 
            this.简体中文ToolStripMenuItem.Name = "简体中文ToolStripMenuItem";
            this.简体中文ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.简体中文ToolStripMenuItem.Tag = "schinese";
            this.简体中文ToolStripMenuItem.Text = "简体中文";
            this.简体中文ToolStripMenuItem.Click += new System.EventHandler(this.koreanToolStripMenuItem_Click);
            // 
            // 繁体中文ToolStripMenuItem
            // 
            this.繁体中文ToolStripMenuItem.Name = "繁体中文ToolStripMenuItem";
            this.繁体中文ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.繁体中文ToolStripMenuItem.Tag = "tchinese\\hk";
            this.繁体中文ToolStripMenuItem.Text = "繁体中文-香港";
            this.繁体中文ToolStripMenuItem.Click += new System.EventHandler(this.koreanToolStripMenuItem_Click);
            // 
            // 繁体中文台湾ToolStripMenuItem
            // 
            this.繁体中文台湾ToolStripMenuItem.Name = "繁体中文台湾ToolStripMenuItem";
            this.繁体中文台湾ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.繁体中文台湾ToolStripMenuItem.Tag = "tchinese\\tw";
            this.繁体中文台湾ToolStripMenuItem.Text = "繁体中文-台湾";
            this.繁体中文台湾ToolStripMenuItem.Click += new System.EventHandler(this.koreanToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.englishToolStripMenuItem.Tag = "english";
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.koreanToolStripMenuItem_Click);
            // 
            // japaneseToolStripMenuItem
            // 
            this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            this.japaneseToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.japaneseToolStripMenuItem.Tag = "japanese";
            this.japaneseToolStripMenuItem.Text = "Japanese";
            this.japaneseToolStripMenuItem.Click += new System.EventHandler(this.koreanToolStripMenuItem_Click);
            // 
            // koreanToolStripMenuItem
            // 
            this.koreanToolStripMenuItem.Name = "koreanToolStripMenuItem";
            this.koreanToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.koreanToolStripMenuItem.Tag = "korean";
            this.koreanToolStripMenuItem.Text = "Korean";
            this.koreanToolStripMenuItem.Click += new System.EventHandler(this.koreanToolStripMenuItem_Click);
            // 
            // btnEditMaster
            // 
            this.btnEditMaster.Location = new System.Drawing.Point(7, 8);
            this.btnEditMaster.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditMaster.Name = "btnEditMaster";
            this.btnEditMaster.Size = new System.Drawing.Size(167, 143);
            this.btnEditMaster.TabIndex = 1;
            this.btnEditMaster.Text = "修改角色 (Modify Pilots)";
            this.btnEditMaster.UseVisualStyleBackColor = true;
            this.btnEditMaster.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnEditGundam
            // 
            this.btnEditGundam.Location = new System.Drawing.Point(188, 8);
            this.btnEditGundam.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditGundam.Name = "btnEditGundam";
            this.btnEditGundam.Size = new System.Drawing.Size(167, 143);
            this.btnEditGundam.TabIndex = 2;
            this.btnEditGundam.Text = "修改机体/战舰 (Modify MS/MA/WS)";
            this.btnEditGundam.UseVisualStyleBackColor = true;
            this.btnEditGundam.Click += new System.EventHandler(this.btnEditGundam_Click);
            // 
            // btnEditWeapon
            // 
            this.btnEditWeapon.Location = new System.Drawing.Point(369, 8);
            this.btnEditWeapon.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditWeapon.Name = "btnEditWeapon";
            this.btnEditWeapon.Size = new System.Drawing.Size(195, 143);
            this.btnEditWeapon.TabIndex = 3;
            this.btnEditWeapon.Text = "修改武器 (Modify weapon)";
            this.btnEditWeapon.UseVisualStyleBackColor = true;
            this.btnEditWeapon.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.tslblDir, this.toolStripStatusLabel1, this.lblLang});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1070, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblDir
            // 
            this.tslblDir.Name = "tslblDir";
            this.tslblDir.Size = new System.Drawing.Size(751, 32);
            this.tslblDir.Text = "请点击-文件-设置data文件夹路径 (Set Data path, under File/Options)";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(226, 32);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblLang
            // 
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(61, 32);
            this.lblLang.Text = "lang";
            // 
            // label1
            // 
            this.label1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "感谢: 泷泽透明 lxdlxd99 gundamdxhk hgjzorro hj mediar (Credits)";
            // 
            // btnEditPeopleText
            // 
            this.btnEditPeopleText.Location = new System.Drawing.Point(842, 8);
            this.btnEditPeopleText.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditPeopleText.Name = "btnEditPeopleText";
            this.btnEditPeopleText.Size = new System.Drawing.Size(167, 143);
            this.btnEditPeopleText.TabIndex = 3;
            this.btnEditPeopleText.Text = "修改角色相关文本 pilot text";
            this.btnEditPeopleText.UseVisualStyleBackColor = true;
            this.btnEditPeopleText.Click += new System.EventHandler(this.btnEditText_Click);
            // 
            // btnEditMachineTxt
            // 
            this.btnEditMachineTxt.Location = new System.Drawing.Point(7, 8);
            this.btnEditMachineTxt.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditMachineTxt.Name = "btnEditMachineTxt";
            this.btnEditMachineTxt.Size = new System.Drawing.Size(233, 143);
            this.btnEditMachineTxt.TabIndex = 3;
            this.btnEditMachineTxt.Text = "修改机体/武器文本 (unit / weapon text";
            this.btnEditMachineTxt.UseVisualStyleBackColor = true;
            this.btnEditMachineTxt.Click += new System.EventHandler(this.btnEditMachineTxt_Click);
            // 
            // btnEditMachineDesc
            // 
            this.btnEditMachineDesc.Location = new System.Drawing.Point(254, 8);
            this.btnEditMachineDesc.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditMachineDesc.Name = "btnEditMachineDesc";
            this.btnEditMachineDesc.Size = new System.Drawing.Size(215, 143);
            this.btnEditMachineDesc.TabIndex = 3;
            this.btnEditMachineDesc.Text = "修改角色/机体描述\r\npilot / unit description";
            this.btnEditMachineDesc.UseVisualStyleBackColor = true;
            this.btnEditMachineDesc.Click += new System.EventHandler(this.btnEditMachineDesc_Click);
            // 
            // btnEditAbilityText
            // 
            this.btnEditAbilityText.Location = new System.Drawing.Point(483, 8);
            this.btnEditAbilityText.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditAbilityText.Name = "btnEditAbilityText";
            this.btnEditAbilityText.Size = new System.Drawing.Size(232, 143);
            this.btnEditAbilityText.TabIndex = 3;
            this.btnEditAbilityText.Text = "修改技能相关文本 Modify skill related text";
            this.btnEditAbilityText.UseVisualStyleBackColor = true;
            this.btnEditAbilityText.Click += new System.EventHandler(this.btnEditAbility_Click);
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.flowContainer.Controls.Add(this.btnEditMaster);
            this.flowContainer.Controls.Add(this.btnEditGundam);
            this.flowContainer.Controls.Add(this.btnEditWeapon);
            this.flowContainer.Controls.Add(this.btnEditAbility);
            this.flowContainer.Controls.Add(this.btnEditPeopleText);
            this.flowContainer.Enabled = false;
            this.flowContainer.Location = new System.Drawing.Point(26, 74);
            this.flowContainer.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(1020, 163);
            this.flowContainer.TabIndex = 4;
            // 
            // btnEditAbility
            // 
            this.btnEditAbility.Location = new System.Drawing.Point(578, 8);
            this.btnEditAbility.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditAbility.Name = "btnEditAbility";
            this.btnEditAbility.Size = new System.Drawing.Size(250, 143);
            this.btnEditAbility.TabIndex = 3;
            this.btnEditAbility.Text = "修改能力/技能/OP (Modify ability / skill)";
            this.btnEditAbility.UseVisualStyleBackColor = true;
            this.btnEditAbility.Click += new System.EventHandler(this.btnEditAbility_Click_1);
            // 
            // btnEditTBL
            // 
            this.btnEditTBL.Location = new System.Drawing.Point(729, 8);
            this.btnEditTBL.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnEditTBL.Name = "btnEditTBL";
            this.btnEditTBL.Size = new System.Drawing.Size(211, 143);
            this.btnEditTBL.TabIndex = 3;
            this.btnEditTBL.Text = "修改其他TBL文件 (other TBL files)";
            this.btnEditTBL.UseVisualStyleBackColor = true;
            this.btnEditTBL.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // flowContainer2
            // 
            this.flowContainer2.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.flowContainer2.Controls.Add(this.btnEditMachineTxt);
            this.flowContainer2.Controls.Add(this.btnEditMachineDesc);
            this.flowContainer2.Controls.Add(this.btnEditAbilityText);
            this.flowContainer2.Controls.Add(this.btnEditTBL);
            this.flowContainer2.Enabled = false;
            this.flowContainer2.Location = new System.Drawing.Point(26, 253);
            this.flowContainer2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.flowContainer2.Name = "flowContainer2";
            this.flowContainer2.Size = new System.Drawing.Size(1020, 163);
            this.flowContainer2.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 549);
            this.Controls.Add(this.flowContainer2);
            this.Controls.Add(this.flowContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GGCREditor 火线纵横-静态修改器 v2.5.1 - Power By RenYueHD";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowContainer.ResumeLayout(false);
            this.flowContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择路径ToolStripMenuItem;
        private System.Windows.Forms.Button btnEditMaster;
        private System.Windows.Forms.Button btnEditGundam;
        private System.Windows.Forms.Button btnEditWeapon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditPeopleText;
        private System.Windows.Forms.Button btnEditMachineTxt;
        private System.Windows.Forms.Button btnEditMachineDesc;
        private System.Windows.Forms.Button btnEditAbilityText;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Button btnEditTBL;
        private System.Windows.Forms.Button btnEditAbility;
        private System.Windows.Forms.FlowLayoutPanel flowContainer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLang;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguage;
        private System.Windows.Forms.ToolStripMenuItem 简体中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koreanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 繁体中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 繁体中文台湾ToolStripMenuItem;
    }
}

