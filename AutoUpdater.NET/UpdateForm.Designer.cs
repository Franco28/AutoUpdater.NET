using System.Threading;

namespace AutoUpdaterDotNET
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new MaterialSkin.Controls.MaterialButton();
            this.labelUpdate = new MaterialSkin.Controls.MaterialLabel();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.labelReleaseNotes = new MaterialSkin.Controls.MaterialLabel();
            this.webBrowser = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::AutoUpdaterDotNET.Properties.Resources.update;
            resources.ApplyResources(this.pictureBoxIcon, "pictureBoxIcon");
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.DrawShadows = true;
            this.buttonUpdate.HighEmphasis = false;
            this.buttonUpdate.Icon = null;
            this.buttonUpdate.Image = global::AutoUpdaterDotNET.Properties.Resources.download_32;
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonUpdate.UseAccentColor = true;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // labelUpdate
            // 
            resources.ApplyResources(this.labelUpdate, "labelUpdate");
            this.labelUpdate.Depth = 0;
            this.labelUpdate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUpdate.HighEmphasis = true;
            this.labelUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.UseAccent = true;
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.Depth = 0;
            this.labelDescription.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            // 
            // labelReleaseNotes
            // 
            resources.ApplyResources(this.labelReleaseNotes, "labelReleaseNotes");
            this.labelReleaseNotes.Depth = 0;
            this.labelReleaseNotes.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelReleaseNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelReleaseNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelReleaseNotes.Name = "labelReleaseNotes";
            this.labelReleaseNotes.UseAccent = true;
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.BackColor = System.Drawing.Color.White;
            this.webBrowser.ForeColor = System.Drawing.Color.Black;
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ReadOnly = true;
            // 
            // UpdateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelReleaseNotes);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.pictureBoxIcon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.UpdateFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private MaterialSkin.Controls.MaterialButton buttonUpdate;
        private MaterialSkin.Controls.MaterialLabel labelUpdate;
        private MaterialSkin.Controls.MaterialLabel labelDescription;
        private MaterialSkin.Controls.MaterialLabel labelReleaseNotes;
        private System.Windows.Forms.RichTextBox webBrowser;
    }
}