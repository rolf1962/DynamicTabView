namespace DynamicTabView.UserControls
{
    partial class SettingsPathsUserControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageLibraryPathLabel;
            System.Windows.Forms.Label storagePathLabel;
            System.Windows.Forms.Label tempPathLabel;
            this.imageLibraryPathTextBox = new System.Windows.Forms.TextBox();
            this.storagePathTextBox = new System.Windows.Forms.TextBox();
            this.tempPathTextBox = new System.Windows.Forms.TextBox();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            imageLibraryPathLabel = new System.Windows.Forms.Label();
            storagePathLabel = new System.Windows.Forms.Label();
            tempPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLibraryPathLabel
            // 
            imageLibraryPathLabel.AutoSize = true;
            imageLibraryPathLabel.Location = new System.Drawing.Point(15, 6);
            imageLibraryPathLabel.Name = "imageLibraryPathLabel";
            imageLibraryPathLabel.Size = new System.Drawing.Size(98, 13);
            imageLibraryPathLabel.TabIndex = 1;
            imageLibraryPathLabel.Text = "Image Library Path:";
            // 
            // storagePathLabel
            // 
            storagePathLabel.AutoSize = true;
            storagePathLabel.Location = new System.Drawing.Point(15, 32);
            storagePathLabel.Name = "storagePathLabel";
            storagePathLabel.Size = new System.Drawing.Size(72, 13);
            storagePathLabel.TabIndex = 3;
            storagePathLabel.Text = "Storage Path:";
            // 
            // tempPathLabel
            // 
            tempPathLabel.AutoSize = true;
            tempPathLabel.Location = new System.Drawing.Point(15, 58);
            tempPathLabel.Name = "tempPathLabel";
            tempPathLabel.Size = new System.Drawing.Size(62, 13);
            tempPathLabel.TabIndex = 5;
            tempPathLabel.Text = "Temp Path:";
            // 
            // imageLibraryPathTextBox
            // 
            this.imageLibraryPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "SettingsPaths.ImageLibraryPath", true));
            this.imageLibraryPathTextBox.Location = new System.Drawing.Point(119, 3);
            this.imageLibraryPathTextBox.Name = "imageLibraryPathTextBox";
            this.imageLibraryPathTextBox.Size = new System.Drawing.Size(273, 20);
            this.imageLibraryPathTextBox.TabIndex = 2;
            // 
            // storagePathTextBox
            // 
            this.storagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "SettingsPaths.StoragePath", true));
            this.storagePathTextBox.Location = new System.Drawing.Point(119, 29);
            this.storagePathTextBox.Name = "storagePathTextBox";
            this.storagePathTextBox.Size = new System.Drawing.Size(273, 20);
            this.storagePathTextBox.TabIndex = 4;
            // 
            // tempPathTextBox
            // 
            this.tempPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "SettingsPaths.TempPath", true));
            this.tempPathTextBox.Location = new System.Drawing.Point(119, 55);
            this.tempPathTextBox.Name = "tempPathTextBox";
            this.tempPathTextBox.Size = new System.Drawing.Size(273, 20);
            this.tempPathTextBox.TabIndex = 6;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(DynamicTabView.ViewModels.SettingsPathsUserControlViewModel);
            // 
            // SettingsPathsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(imageLibraryPathLabel);
            this.Controls.Add(this.imageLibraryPathTextBox);
            this.Controls.Add(storagePathLabel);
            this.Controls.Add(this.storagePathTextBox);
            this.Controls.Add(tempPathLabel);
            this.Controls.Add(this.tempPathTextBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "TabText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "SettingsPathsUserControl";
            this.Size = new System.Drawing.Size(399, 81);
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.TextBox imageLibraryPathTextBox;
        private System.Windows.Forms.TextBox storagePathTextBox;
        private System.Windows.Forms.TextBox tempPathTextBox;
    }
}
