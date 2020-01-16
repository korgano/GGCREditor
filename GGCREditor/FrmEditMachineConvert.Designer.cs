namespace GGCREditor
{
    partial class FrmEditMachineConvert
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
            this.lsMain = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbState = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsMain
            // 
            this.lsMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsMain.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.lsMain.FormattingEnabled = true;
            this.lsMain.ItemHeight = 12;
            this.lsMain.Location = new System.Drawing.Point(26, 32);
            this.lsMain.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.lsMain.Name = "lsMain";
            this.lsMain.Size = new System.Drawing.Size(929, 612);
            this.lsMain.TabIndex = 0;
            this.lsMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsMain_DrawItem);
            this.lsMain.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lsMain_MeasureItem);
            this.lsMain.SelectedIndexChanged += new System.EventHandler(this.lsMain_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(973, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "指令";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(977, 261);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(750, 61);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加一条(直接写入文件,无需保存)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboTo
            // 
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(1049, 101);
            this.cboTo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(674, 40);
            this.cboTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(973, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(973, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "原始";
            // 
            // cboFrom
            // 
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(1049, 32);
            this.cboFrom.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(674, 40);
            this.cboFrom.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1398, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboAction
            // 
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Location = new System.Drawing.Point(1049, 173);
            this.cboAction.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(674, 40);
            this.cboAction.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.stFile, this.toolStripStatusLabel2, this.lbState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1753, 37);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stFile
            // 
            this.stFile.Name = "stFile";
            this.stFile.Size = new System.Drawing.Size(238, 32);
            this.stFile.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1245, 32);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // lbState
            // 
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(238, 32);
            this.lbState.Text = "toolStripStatusLabel3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(995, 451);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(612, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "变型机构必须同时具有 A=>B 与 B=>A 才可生效";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(995, 527);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(630, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "若机体本身不具有换装/变形等能力 修改可能无效";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(977, 339);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(407, 61);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除选中(直接写入,无法撤销)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmEditMachineConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 712);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.cboTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmEditMachineConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "变型/换装修改";
            this.Load += new System.EventHandler(this.FrmEditMachineConvert_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lsMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}