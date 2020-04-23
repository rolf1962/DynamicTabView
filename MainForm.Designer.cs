namespace DynamicTabView
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAllTogether = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContacts
            // 
            this.buttonContacts.Location = new System.Drawing.Point(12, 12);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(274, 23);
            this.buttonContacts.TabIndex = 0;
            this.buttonContacts.Text = "&Kontakte";
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Click += new System.EventHandler(this.ButtonContactsClick);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(12, 42);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(274, 23);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "&Einstellungen";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
            // 
            // buttonAllTogether
            // 
            this.buttonAllTogether.Location = new System.Drawing.Point(12, 71);
            this.buttonAllTogether.Name = "buttonAllTogether";
            this.buttonAllTogether.Size = new System.Drawing.Size(274, 23);
            this.buttonAllTogether.TabIndex = 2;
            this.buttonAllTogether.Text = "&Alle zusammen";
            this.buttonAllTogether.UseVisualStyleBackColor = true;
            this.buttonAllTogether.Click += new System.EventHandler(this.ButtonAllTogetherClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 174);
            this.Controls.Add(this.buttonAllTogether);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonContacts);
            this.Name = "MainForm";
            this.Text = "Dynamische Tabansicht";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAllTogether;
    }
}

