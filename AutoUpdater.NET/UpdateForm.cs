
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AutoUpdaterDotNET
{
    internal partial class UpdateForm : MaterialForm
    {
        private readonly SettingsMng oConfigMng = new SettingsMng();
        private readonly UpdateInfoEventArgs _args;
        private readonly MaterialSkinManager materialSkinManager;

        public UpdateForm(UpdateInfoEventArgs args)
        {
            _args = args;

            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            oConfigMng.LoadConfig();
            if (oConfigMng.Config.ToolTheme == "light")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue700, Accent.LightBlue700, TextShade.WHITE);
            }
            if (oConfigMng.Config.ToolTheme == "dark")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
            var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/Franco28/MotoBootLogoMaker/MaterialUI/Setup/changelog.txt");
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