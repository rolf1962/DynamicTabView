namespace DynamicTabView.UserControls
{
    partial class ContactsCommunicationsUserControl
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
            System.Windows.Forms.Label accessLabel;
            System.Windows.Forms.Label communicationTypeLabel;
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communicationsComboBox = new System.Windows.Forms.ComboBox();
            this.communicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accessTextBox = new System.Windows.Forms.TextBox();
            this.communicationTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            accessLabel = new System.Windows.Forms.Label();
            communicationTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new System.Drawing.Point(1, 38);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new System.Drawing.Size(58, 13);
            accessLabel.TabIndex = 9;
            accessLabel.Text = "Anschluss:";
            // 
            // communicationTypeLabel
            // 
            communicationTypeLabel.AutoSize = true;
            communicationTypeLabel.Location = new System.Drawing.Point(1, 64);
            communicationTypeLabel.Name = "communicationTypeLabel";
            communicationTypeLabel.Size = new System.Drawing.Size(23, 13);
            communicationTypeLabel.TabIndex = 11;
            communicationTypeLabel.Text = "Art:";
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(DynamicTabView.ViewModels.ContactsCommunicationsUserControlViewModel);
            // 
            // communicationsComboBox
            // 
            this.communicationsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BindingSource, "CurrentContactCommunication", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.communicationsComboBox.DataSource = this.communicationsBindingSource;
            this.communicationsComboBox.FormattingEnabled = true;
            this.communicationsComboBox.Location = new System.Drawing.Point(65, 8);
            this.communicationsComboBox.Name = "communicationsComboBox";
            this.communicationsComboBox.Size = new System.Drawing.Size(300, 21);
            this.communicationsComboBox.TabIndex = 0;
            // 
            // communicationsBindingSource
            // 
            this.communicationsBindingSource.DataMember = "ContactCommunications";
            this.communicationsBindingSource.DataSource = this.BindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Auswahl:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(accessLabel);
            this.panel1.Controls.Add(this.accessTextBox);
            this.panel1.Controls.Add(communicationTypeLabel);
            this.panel1.Controls.Add(this.communicationTypeTextBox);
            this.panel1.Controls.Add(this.communicationsComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 91);
            this.panel1.TabIndex = 13;
            // 
            // accessTextBox
            // 
            this.accessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.communicationsBindingSource, "Access", true));
            this.accessTextBox.Location = new System.Drawing.Point(65, 35);
            this.accessTextBox.Name = "accessTextBox";
            this.accessTextBox.Size = new System.Drawing.Size(151, 20);
            this.accessTextBox.TabIndex = 10;
            // 
            // communicationTypeTextBox
            // 
            this.communicationTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.communicationsBindingSource, "CommunicationType", true));
            this.communicationTypeTextBox.Location = new System.Drawing.Point(65, 61);
            this.communicationTypeTextBox.Name = "communicationTypeTextBox";
            this.communicationTypeTextBox.Size = new System.Drawing.Size(151, 20);
            this.communicationTypeTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "CurrentContact", true));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // ContactsCommunicationsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "TabText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ContactsCommunicationsUserControl";
            this.Size = new System.Drawing.Size(396, 117);
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ComboBox communicationsComboBox;
        private System.Windows.Forms.BindingSource communicationsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accessTextBox;
        private System.Windows.Forms.TextBox communicationTypeTextBox;
    }
}
