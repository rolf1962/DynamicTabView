namespace DynamicTabView.TabPages
{
    partial class ContactsUserControl
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
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label remarksLabel;
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.contactsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(4, 97);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(76, 13);
            birthdateLabel.TabIndex = 0;
            birthdateLabel.Text = "Geburtsdatum:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(42, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(28, 70);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 4;
            surnameLabel.Text = "Vorname:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(28, 122);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 6;
            remarksLabel.Text = "Remarks:";
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(86, 93);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.birthdateDateTimePicker.TabIndex = 1;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.BindingSource;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(DynamicTabView.ViewModels.ContactsUserControlViewModel);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(86, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(197, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(86, 67);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(197, 20);
            this.surnameTextBox.TabIndex = 5;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(86, 119);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(197, 20);
            this.remarksTextBox.TabIndex = 7;
            // 
            // contactsComboBox
            // 
            this.contactsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BindingSource, "CurrentContact", true));
            this.contactsComboBox.DataSource = this.contactsBindingSource;
            this.contactsComboBox.DisplayMember = "Surname";
            this.contactsComboBox.FormattingEnabled = true;
            this.contactsComboBox.Location = new System.Drawing.Point(86, 14);
            this.contactsComboBox.Name = "contactsComboBox";
            this.contactsComboBox.Size = new System.Drawing.Size(300, 21);
            this.contactsComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Auswahl:";
            // 
            // ContactsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactsComboBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Name = "ContactsUserControl";
            this.Size = new System.Drawing.Size(389, 152);
            this.Title = "Kontakt";
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.ComboBox contactsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        protected System.Windows.Forms.BindingSource BindingSource;
    }
}
