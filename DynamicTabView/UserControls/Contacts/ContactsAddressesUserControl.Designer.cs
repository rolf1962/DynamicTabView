namespace DynamicTabView.UserControls
{
    partial class ContactsAddressesUserControl
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label houseNoLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label zipCodeLabel;
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressesComboBox = new System.Windows.Forms.ComboBox();
            this.addressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.houseNoTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            cityLabel = new System.Windows.Forms.Label();
            houseNoLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(126, 38);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "City:";
            // 
            // houseNoLabel
            // 
            houseNoLabel.AutoSize = true;
            houseNoLabel.Location = new System.Drawing.Point(246, 64);
            houseNoLabel.Name = "houseNoLabel";
            houseNoLabel.Size = new System.Drawing.Size(58, 13);
            houseNoLabel.TabIndex = 3;
            houseNoLabel.Text = "House No:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(1, 64);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 5;
            streetLabel.Text = "Street:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(1, 38);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            zipCodeLabel.TabIndex = 7;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(DynamicTabView.ViewModels.ContactsAddressesUserControlViewModel);
            // 
            // addressesComboBox
            // 
            this.addressesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.BindingSource, "CurrentContactAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addressesComboBox.DataSource = this.addressesBindingSource;
            this.addressesComboBox.FormattingEnabled = true;
            this.addressesComboBox.Location = new System.Drawing.Point(65, 8);
            this.addressesComboBox.Name = "addressesComboBox";
            this.addressesComboBox.Size = new System.Drawing.Size(300, 21);
            this.addressesComboBox.TabIndex = 0;
            // 
            // addressesBindingSource
            // 
            this.addressesBindingSource.DataMember = "ContactAddresses";
            this.addressesBindingSource.DataSource = this.BindingSource;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "CurrentContactAddress.City", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cityTextBox.Location = new System.Drawing.Point(159, 35);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(206, 20);
            this.cityTextBox.TabIndex = 2;
            // 
            // houseNoTextBox
            // 
            this.houseNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "CurrentContactAddress.HouseNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.houseNoTextBox.Location = new System.Drawing.Point(310, 61);
            this.houseNoTextBox.Name = "houseNoTextBox";
            this.houseNoTextBox.Size = new System.Drawing.Size(55, 20);
            this.houseNoTextBox.TabIndex = 4;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "CurrentContactAddress.Street", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.streetTextBox.Location = new System.Drawing.Point(65, 61);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(175, 20);
            this.streetTextBox.TabIndex = 6;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource, "CurrentContactAddress.ZipCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zipCodeTextBox.Location = new System.Drawing.Point(65, 35);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(55, 20);
            this.zipCodeTextBox.TabIndex = 8;
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
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addressesComboBox);
            this.panel1.Controls.Add(this.zipCodeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(zipCodeLabel);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.streetTextBox);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(streetLabel);
            this.panel1.Controls.Add(houseNoLabel);
            this.panel1.Controls.Add(this.houseNoTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 100);
            this.panel1.TabIndex = 11;
            // 
            // ContactsAddressesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "ContactsAddressesUserControl";
            this.Size = new System.Drawing.Size(408, 129);
            this.Title = "Adressen";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ComboBox addressesComboBox;
        private System.Windows.Forms.BindingSource addressesBindingSource;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox houseNoTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
