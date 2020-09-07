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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelReleaseNotes = new System.Windows.Forms.Label();
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
            this.buttonUpdate.Image = global::AutoUpdaterDotNET.Properties.Resources.download_32;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // labelUpdate
            // 
            resources.ApplyResources(this.labelUpdate, "labelUpdate");
            this.labelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelUpdate.Name = "labelUpdate";
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelDescription.Name = "labelDescription";
            // 
            // labelReleaseNotes
            // 
            resources.ApplyResources(this.labelReleaseNotes, "labelReleaseNotes");
            this.labelReleaseNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.labelReleaseNotes.Name = "labelReleaseNotes";
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.webBrowser.ForeColor = System.Drawing.Color.Red;
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ReadOnly = true;
            // 
            // UpdateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelReleaseNotes);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.pictureBoxIcon);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelReleaseNotes;
        private System.Windows.Forms.RichTextBox webBrowser;
    }
}