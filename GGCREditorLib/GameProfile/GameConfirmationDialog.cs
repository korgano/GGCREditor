using System;
using System.Windows.Forms;
using GGCREditorLib.GameProfile;

namespace GGCREditorLib.GameProfile
{
    public class GameConfirmationDialog : Form
    {
        private Label lblTitle;
        private Label lblDetected;
        private Label lblConfidence;
        private ComboBox cmbGameSelect;
        private Button btnConfirm;
        private Button btnCancel;
        private GroupBox grpInfo;

        public string SelectedGameId { get; private set; }

        public GameConfirmationDialog(GameDetector.DetectionResult result)
        {
            InitializeComponent();

            if (result != null && result.Profile != null)
            {
                lblDetected.Text = result.Profile.GameName;
                lblConfidence.Text = string.Format("Confidence: {0}%", result.Confidence);
                cmbGameSelect.SelectedValue = result.Profile.GameId;
            }
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblDetected = new System.Windows.Forms.Label();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.cmbGameSelect = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 20);
            this.lblTitle.Text = "Game Detected";

            this.grpInfo.Controls.Add(this.lblDetected);
            this.grpInfo.Controls.Add(this.lblConfidence);
            this.grpInfo.Location = new System.Drawing.Point(16, 38);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(356, 77);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Detection Result";

            this.lblDetected.AutoSize = true;
            this.lblDetected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDetected.Location = new System.Drawing.Point(15, 25);
            this.lblDetected.Name = "lblDetected";
            this.lblDetected.Size = new System.Drawing.Size(100, 17);
            this.lblDetected.Text = "[Game Name]";

            this.lblConfidence.AutoSize = true;
            this.lblConfidence.Location = new System.Drawing.Point(15, 50);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(100, 13);
            this.lblConfidence.Text = "Confidence: 0%";

            this.cmbGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameSelect.FormattingEnabled = true;
            this.cmbGameSelect.Location = new System.Drawing.Point(16, 130);
            this.cmbGameSelect.Name = "cmbGameSelect";
            this.cmbGameSelect.Size = new System.Drawing.Size(356, 21);

            GameProfileManager mgr = GameProfileManager.Instance;
            foreach (IGGCGameProfile profile in mgr.GetAllProfiles())
            {
                cmbGameSelect.Items.Add(new KeyValuePair<string, string>(profile.GameId, profile.GameName));
            }
            cmbGameSelect.DisplayMember = "Value";
            cmbGameSelect.ValueMember = "Key";

            if (cmbGameSelect.Items.Count > 0)
            {
                cmbGameSelect.SelectedIndex = 0;
            }

            this.btnConfirm.Location = new System.Drawing.Point(204, 167);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 30);
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.Text = "Cancel";

            this.AcceptButton = this.btnConfirm;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbGameSelect);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameConfirmationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Game";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbGameSelect.SelectedItem is KeyValuePair<string, string> selected)
            {
                SelectedGameId = selected.Key;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public static string ShowAndGetResult(GameDetector.DetectionResult result)
        {
            using (GameConfirmationDialog dialog = new GameConfirmationDialog(result))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedGameId;
                }
                return null;
            }
        }
    }
}