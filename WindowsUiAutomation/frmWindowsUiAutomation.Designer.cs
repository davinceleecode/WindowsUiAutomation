namespace WindowsUiAutomation
{
    partial class frmWindowsUiAutomation
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GenderTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CountryTab = new System.Windows.Forms.TabPage();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.NameTab = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.GenderTab.SuspendLayout();
            this.CountryTab.SuspendLayout();
            this.NameTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(75, 286);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 44);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Automation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(284, 286);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GenderTab);
            this.tabControl1.Controls.Add(this.CountryTab);
            this.tabControl1.Controls.Add(this.NameTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 256);
            this.tabControl1.TabIndex = 9;
            // 
            // GenderTab
            // 
            this.GenderTab.Controls.Add(this.label1);
            this.GenderTab.Controls.Add(this.radioButton2);
            this.GenderTab.Controls.Add(this.radioButton1);
            this.GenderTab.Location = new System.Drawing.Point(4, 25);
            this.GenderTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderTab.Name = "GenderTab";
            this.GenderTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderTab.Size = new System.Drawing.Size(541, 227);
            this.GenderTab.TabIndex = 0;
            this.GenderTab.Text = "GenderTab";
            this.GenderTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gender :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(328, 101);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 24);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(221, 101);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CountryTab
            // 
            this.CountryTab.Controls.Add(this.lblCountry);
            this.CountryTab.Controls.Add(this.cmbCountry);
            this.CountryTab.Location = new System.Drawing.Point(4, 25);
            this.CountryTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountryTab.Name = "CountryTab";
            this.CountryTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountryTab.Size = new System.Drawing.Size(541, 227);
            this.CountryTab.TabIndex = 1;
            this.CountryTab.Text = "CountryTab";
            this.CountryTab.UseVisualStyleBackColor = true;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(87, 103);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(77, 20);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Country :";
            // 
            // cmbCountry
            // 
            this.cmbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire",
            "Azerbaijan",
            "Pakistan",
            "Palau",
            "Panama",
            "Palau",
            "Panama",
            "Papal States*",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Piedmont-Sardinia*",
            "Poland",
            "Portugal",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy"});
            this.cmbCountry.Location = new System.Drawing.Point(183, 98);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(271, 28);
            this.cmbCountry.TabIndex = 4;
            // 
            // NameTab
            // 
            this.NameTab.Controls.Add(this.lblName);
            this.NameTab.Controls.Add(this.txtName);
            this.NameTab.Location = new System.Drawing.Point(4, 25);
            this.NameTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTab.Name = "NameTab";
            this.NameTab.Size = new System.Drawing.Size(541, 227);
            this.NameTab.TabIndex = 2;
            this.NameTab.Text = "NameTab";
            this.NameTab.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(95, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(176, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(271, 27);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "davinceleecode";
            // 
            // frmWindowsUiAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 336);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmWindowsUiAutomation";
            this.Text = "WindowsUiAutomation";
            this.tabControl1.ResumeLayout(false);
            this.GenderTab.ResumeLayout(false);
            this.GenderTab.PerformLayout();
            this.CountryTab.ResumeLayout(false);
            this.CountryTab.PerformLayout();
            this.NameTab.ResumeLayout(false);
            this.NameTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GenderTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage CountryTab;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TabPage NameTab;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

