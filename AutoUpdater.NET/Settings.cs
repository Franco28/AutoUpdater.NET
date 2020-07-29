using System;

namespace AutoUpdaterDotNET
{
    public class Settings
    {

        private System.String m_oToolLang;
        private System.String m_oToolTheme;
        private System.String m_oSelectedDevice;
        private System.String m_oSaveProfiles;
        private System.String m_oLogoBinOpen;
        private System.String m_oLogoBinOpenSave;
        private System.String m_oLogoWasSaved;
        private System.String m_oChekcForUpdates;

        public System.String ChekcForUpdates
        {
            get { return m_oChekcForUpdates; }
            set { m_oChekcForUpdates = value; }
        }

        public System.String LogoWasSaved
        {
            get { return m_oLogoWasSaved; }
            set { m_oLogoWasSaved = value; }
        }

        public System.String LogoBinOpenSave
        {
            get { return m_oLogoBinOpenSave; }
            set { m_oLogoBinOpenSave = value; }
        }

        public System.String LogoBinOpen
        {
            get { return m_oLogoBinOpen; }
            set { m_oLogoBinOpen = value; }
        }

        public System.String SaveProfiles
        {
            get { return m_oSaveProfiles; }
            set { m_oSaveProfiles = value; }
        }

        public System.String DeviceSelected
        {
            get { return m_oSelectedDevice; }
            set { m_oSelectedDevice = value; }
        }

        public System.String ToolTheme
        {
            get { return m_oToolTheme; }
            set { m_oToolTheme = value; }
        }

        public System.String ToolLang
        {
            get { return m_oToolLang; }
            set { m_oToolLang = value; }
        }
    }
}
