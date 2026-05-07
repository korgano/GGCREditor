using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using GGCREditorLib.GameProfile;

namespace GGCREditor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            UILanguageManager.Initialize();
            GGCREditorLib.Logger.Initialize();
        }

        private string currentDir = null;

        private void 选择路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please set the directory where the game data folder is located";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["path"] != null)
            {
                dialog.SelectedPath = config.AppSettings.Settings["path"].Value;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.SelectedPath.EndsWith("data"))
                {
                    GGCREditorLib.Logger.LogDebug(string.Format("Data folder set FAILED: path does not end with 'data': {0}", dialog.SelectedPath));
                    MessageBox.Show("Game files must be in a folder named 'data'.", "Directory is invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (config.AppSettings.Settings["path"] == null)
                    {
                        config.AppSettings.Settings.Add("path", null);
                    }
                    config.AppSettings.Settings["path"].Value = dialog.SelectedPath;
                    config.Save();

                    this.currentDir = dialog.SelectedPath;
                    GGCRStaticConfig.PATH = this.currentDir;
                    GGCREditorLib.Logger.LogDebug(string.Format("Data folder set: {0}", this.currentDir));

                    GameDetector.DetectionResult detection = GameDetector.Detect(this.currentDir);
                    if (detection != null && detection.Confidence > 0)
                    {
                        string selectedGameId = GameConfirmationDialog.ShowAndGetResult(detection);
                        if (!string.IsNullOrEmpty(selectedGameId))
                        {
                            GameProfileManager.Instance.SetActiveProfileById(selectedGameId);
                            GameProfileManager.Instance.SetProfilePath(this.currentDir);
                        }
                    }

                    GGCRStaticConfig.SyncWithActiveProfile();
                    enableAll();
                    tslblDir.Text = this.currentDir;
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FrmEditPeople form = FrmEditPeople.CreateForm();
            form.Show();
            form.BringToFront();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UILanguageManager.Initialize();
            GGCREditorLib.Logger.Initialize();
            GGCREditorLib.Logger.LogDebug("Application started");

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["path"] != null)
            {
                this.currentDir = config.AppSettings.Settings["path"].Value;
                tslblDir.Text = this.currentDir;
                GGCRStaticConfig.PATH = this.currentDir;
                GGCREditorLib.Logger.LogDebug(string.Format("Data folder loaded from config: {0}", this.currentDir));

                GameDetector.DetectionResult detection = GameDetector.Detect(this.currentDir);
                if (detection != null && detection.Confidence > 0 && detection.Profile != null)
                {
                    GameProfileManager.Instance.SetActiveProfile(detection.Profile);
                    GameProfileManager.Instance.SetProfilePath(this.currentDir);
                    GGCRStaticConfig.SyncWithActiveProfile();
                }

                enableAll();
            }

            bool hasOldLanguageKey = config.AppSettings.Settings["language"] != null;
            string oldLanguageValue = hasOldLanguageKey ? config.AppSettings.Settings["language"].Value : null;

            string uiLanguage = null;
            string gameLanguage = null;
            bool linkLanguages = true;

            if (config.AppSettings.Settings["uiLanguage"] != null)
            {
                uiLanguage = config.AppSettings.Settings["uiLanguage"].Value;
            }

            if (config.AppSettings.Settings["gameLanguage"] != null)
            {
                gameLanguage = config.AppSettings.Settings["gameLanguage"].Value;
            }

            if (config.AppSettings.Settings["linkLanguages"] != null)
            {
                string linkValue = config.AppSettings.Settings["linkLanguages"].Value;
                linkLanguages = (linkValue == "true" || linkValue == "1");
            }

            if (hasOldLanguageKey && oldLanguageValue != null)
            {
                gameLanguage = oldLanguageValue;
                config.AppSettings.Settings.Remove("language");
            }

            if (string.IsNullOrEmpty(uiLanguage))
            {
                uiLanguage = UILanguageManager.GetDefaultUILanguage();
            }

            if (string.IsNullOrEmpty(gameLanguage))
            {
                gameLanguage = "schinese";
            }

            UILanguageManager.LinkLanguages = linkLanguages;
            UILanguageManager.UILanguage = uiLanguage;
            UILanguageManager.GameLanguage = gameLanguage;

            if (config.AppSettings.Settings["uiLanguage"] == null)
            {
                config.AppSettings.Settings.Add("uiLanguage", uiLanguage);
            }
            else
            {
                config.AppSettings.Settings["uiLanguage"].Value = uiLanguage;
            }

            if (config.AppSettings.Settings["gameLanguage"] == null)
            {
                config.AppSettings.Settings.Add("gameLanguage", gameLanguage);
            }
            else
            {
                config.AppSettings.Settings["gameLanguage"].Value = gameLanguage;
            }

            if (config.AppSettings.Settings["linkLanguages"] == null)
            {
                config.AppSettings.Settings.Add("linkLanguages", linkLanguages ? "true" : "false");
            }
            else
            {
                config.AppSettings.Settings["linkLanguages"].Value = linkLanguages ? "true" : "false";
            }

            config.Save();

            showGameLanguage(gameLanguage);
            showUILanguage(uiLanguage);
            showLinkLanguages(linkLanguages);
            showLoggingLevel();

            UILanguageManager.LanguageChanged += new EventHandler(OnLanguageChanged);
        }

        private void OnLanguageChanged(object sender, EventArgs e)
        {
            showUILanguage(UILanguageManager.UILanguage);
            showGameLanguage(UILanguageManager.GameLanguage);
            showLinkLanguages(UILanguageManager.LinkLanguages);
            ApplyLanguage();
        }

        private void enableAll()
        {
            flowContainer.Enabled = true;
            flowContainer2.Enabled = true;
        }

        private void btnEditGundam_Click(object sender, EventArgs e)
        {
            new FrmEditGundam().ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmEditWeapon form = new FrmEditWeapon();
            form.ShowDialog();
        }

        private void btnEditText_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\" + GGCRStaticConfig.Language + @"\CharacterSpecList.tbl");
            form.ShowDialog();
        }

        private void btnEditMachineTxt_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\" + GGCRStaticConfig.Language + @"\MachineSpecList.tbl");
            form.ShowDialog();
        }

        private void btnEditMachineDesc_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\" + GGCRStaticConfig.Language + @"\SpecProfileList.tbl");
            form.ShowDialog();
        }

        private void btnEditAbility_Click(object sender, EventArgs e)
        {
            FrmEditText form = new FrmEditText(GGCRStaticConfig.PATH + @"\language\" + GGCRStaticConfig.Language + @"\AbilitySpecList.tbl");
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "TBL文件|*.tbl";
            // dialog.InitialDirectory = GGCRStaticConfig.PATH;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FrmEditText form = new FrmEditText(dialog.FileName);
                form.ShowDialog();
            }
        }

        private void btnEditAbility_Click_1(object sender, EventArgs e)
        {
            FrmEditAbility form = new FrmEditAbility();
            form.ShowDialog();
        }

        private void koreanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string language = (sender as ToolStripMenuItem).Tag.ToString();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["gameLanguage"] == null)
            {
                config.AppSettings.Settings.Add("gameLanguage", language);
            }
            config.AppSettings.Settings["gameLanguage"].Value = language;
            config.Save();

            UILanguageManager.SetGameLanguage(language);
        }

        private void uiLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string language = (sender as ToolStripMenuItem).Tag.ToString();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["uiLanguage"] == null)
            {
                config.AppSettings.Settings.Add("uiLanguage", language);
            }
            config.AppSettings.Settings["uiLanguage"].Value = language;
            config.Save();

            UILanguageManager.SetUILanguage(language);
        }

        private void tsmiLinkLanguages_Click(object sender, EventArgs e)
        {
            bool newLinkState = !UILanguageManager.LinkLanguages;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings["linkLanguages"] == null)
            {
                config.AppSettings.Settings.Add("linkLanguages", newLinkState ? "true" : "false");
            }
            config.AppSettings.Settings["linkLanguages"].Value = newLinkState ? "true" : "false";
            config.Save();

            UILanguageManager.SetLinkLanguages(newLinkState);
        }

        private void showGameLanguage(string language)
        {
            lblLang.Text = language;
            GGCRStaticConfig.Language = language;

            foreach (ToolStripDropDownItem item in tsmiLanguage.DropDownItems)
            {
                if ((item.Tag != null ? item.Tag.ToString() : "") == language)
                {
                    (item as ToolStripMenuItem).Checked = true;
                }
                else
                {
                    (item as ToolStripMenuItem).Checked = false;
                }
            }
        }

        private void showUILanguage(string language)
        {
            foreach (ToolStripItem item in tsmiUILanguage.DropDownItems)
            {
                if (item is ToolStripMenuItem && item.Tag != null)
                {
                    if (item.Tag.ToString() == language)
                    {
                        (item as ToolStripMenuItem).Checked = true;
                    }
                    else
                    {
                        (item as ToolStripMenuItem).Checked = false;
                    }
                }
            }
        }

        private void showLinkLanguages(bool linked)
        {
            tsmiLinkLanguages.Checked = linked;
            tsmiLinkLanguages.CheckState = linked ? CheckState.Checked : CheckState.Unchecked;
        }

        private void tsmiLogLevel_Click(object sender, EventArgs e)
        {
            string level = (sender as ToolStripMenuItem).Tag.ToString();
            GGCREditorLib.Logger.CurrentLevel = (GGCREditorLib.LogLevel)Enum.Parse(typeof(GGCREditorLib.LogLevel), level);
            GGCREditorLib.Logger.SaveToConfig();
            showLoggingLevel();
            GGCREditorLib.Logger.LogDebug(string.Format("Log level changed to: {0}", level));
        }

        private void showLoggingLevel()
        {
            GGCREditorLib.LogLevel level = GGCREditorLib.Logger.CurrentLevel;
            tsmiLogOff.Checked = false;
            tsmiLogDebug.Checked = false;
            tsmiLogEdits.Checked = false;

            switch (level)
            {
                case GGCREditorLib.LogLevel.Off:
                    tsmiLogOff.Checked = true;
                    break;
                case GGCREditorLib.LogLevel.Debug:
                    tsmiLogDebug.Checked = true;
                    break;
                case GGCREditorLib.LogLevel.Edits:
                    tsmiLogEdits.Checked = true;
                    break;
            }
        }

        public void ApplyLanguage()
        {
            this.Text = StringResources.Get("AppTitle");
            this.文件ToolStripMenuItem.Text = StringResources.Get("Menu_File");
            this.选择路径ToolStripMenuItem.Text = StringResources.Get("Menu_SetDataPath");
            this.tsmiLanguage.Text = StringResources.Get("Menu_GameLanguage");
            this.tsmiUILanguage.Text = StringResources.Get("Menu_UILanguage");
            this.tsmiLinkLanguages.Text = StringResources.Get("Menu_LinkLanguages");
            this.toolsToolStripMenuItem.Text = StringResources.Get("Menu_Tools");

            this.btnEditMaster.Text = StringResources.Get("Btn_EditMaster");
            this.btnEditGundam.Text = StringResources.Get("Btn_EditGundam");
            this.btnEditWeapon.Text = StringResources.Get("Btn_EditWeapon");
            this.btnEditPeopleText.Text = StringResources.Get("Btn_EditPeopleText");
            this.btnEditMachineTxt.Text = StringResources.Get("Btn_EditMachineTxt");
            this.btnEditMachineDesc.Text = StringResources.Get("Btn_EditMachineDesc");
            this.btnEditAbilityText.Text = StringResources.Get("Btn_EditAbilityText");
            this.btnEditAbility.Text = StringResources.Get("Btn_EditAbility");
            this.btnEditTBL.Text = StringResources.Get("Btn_EditTBL");

            this.tslblDir.Text = StringResources.Get("Status_SetDataPath");
            this.label1.Text = StringResources.Get("Label_Credits");
        }

    }
}
