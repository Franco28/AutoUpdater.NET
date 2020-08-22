
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AutoUpdaterDotNET
{
    internal partial class UpdateForm : Form
    {
        private readonly SettingsMng oConfigMng = new SettingsMng();
        private readonly UpdateInfoEventArgs _args;

        public UpdateForm(UpdateInfoEventArgs args)
        {
            _args = args;

            InitializeComponent();

            oConfigMng.LoadConfig();
            if (oConfigMng.Config.ToolTheme == "light")
            {
                this.BackColor = Color.FromArgb(250, 232, 232);  
                this.ForeColor = Color.FromArgb(38, 38, 38);

                webBrowser.BackColor = labelReleaseNotes.BackColor = labelDescription.BackColor = labelUpdate.BackColor = pictureBoxIcon.BackColor = Color.FromArgb(250, 232, 232);
                webBrowser.ForeColor = labelReleaseNotes.ForeColor = labelDescription.ForeColor = labelUpdate.ForeColor = Color.FromArgb(38, 38, 38);

                buttonUpdate.FlatStyle = FlatStyle.Standard;
                buttonUpdate.BackColor = Color.FromArgb(255, 255, 255);
                buttonUpdate.ForeColor = Color.FromArgb(38, 38, 38);
            }
            if (oConfigMng.Config.ToolTheme == "dark")
            {
                this.BackColor = Color.FromArgb(38, 38, 38);
                this.ForeColor = Color.FromArgb(250, 232, 232);

                webBrowser.BackColor = labelReleaseNotes.BackColor = labelDescription.BackColor = labelUpdate.BackColor = pictureBoxIcon.BackColor = Color.FromArgb(38, 38, 38);
                webBrowser.ForeColor = labelReleaseNotes.ForeColor = labelDescription.ForeColor = labelUpdate.ForeColor = Color.FromArgb(250, 232, 232);

                buttonUpdate.FlatStyle = FlatStyle.Flat;
                buttonUpdate.BackColor = Color.FromArgb(38, 38, 38);
                buttonUpdate.ForeColor = Color.FromArgb(250, 232, 232);
            }
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            Text = string.Format(resources.GetString("$this.Text", CultureInfo.CurrentCulture),
                AutoUpdater.AppTitle, _args.CurrentVersion);
            labelUpdate.Text = string.Format(resources.GetString("labelUpdate.Text", CultureInfo.CurrentCulture),
                AutoUpdater.AppTitle);
            labelDescription.Text =
                string.Format(resources.GetString("labelDescription.Text", CultureInfo.CurrentCulture),
                    AutoUpdater.AppTitle, _args.CurrentVersion, _args.InstalledVersion);

            if (AutoUpdater.Mandatory && AutoUpdater.UpdateMode == Mode.Forced)
            {
                ControlBox = false;
            }
        }

        private void UpdateFormLoad(object sender, EventArgs e)
        {
            var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/Franco28/MotoBootLogoMaker/master/x86/Setup/changelog.txt");
            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
                webBrowser.Text = strContent.ToString();
            }
            var labelSize = new Size(Width - 110, 0);
            labelDescription.MaximumSize = labelUpdate.MaximumSize = labelSize;
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (AutoUpdater.OpenDownloadPage)
            {
                var processStartInfo = new ProcessStartInfo(_args.DownloadURL);

                Process.Start(processStartInfo);

                DialogResult = DialogResult.OK;
            }
            else
            {
                if (AutoUpdater.DownloadUpdate(_args))
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AutoUpdater.Running = false;
        }
    }
}