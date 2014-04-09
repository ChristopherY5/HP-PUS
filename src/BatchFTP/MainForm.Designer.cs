namespace BatchFTP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFirmwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendTestFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printConfigPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMaint = new System.Windows.Forms.RadioButton();
            this.radioResetPage = new System.Windows.Forms.RadioButton();
            this.radioResetSerial = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ftpButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.passwordStatusLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pageCountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.printFileDialoge = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.printerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // printerToolStripMenuItem
            // 
            this.printerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFirmwareToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendTestFileToolStripMenuItem,
            this.printConfigPageToolStripMenuItem});
            this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
            this.printerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.printerToolStripMenuItem.Text = "Printer";
            // 
            // updateFirmwareToolStripMenuItem
            // 
            this.updateFirmwareToolStripMenuItem.Name = "updateFirmwareToolStripMenuItem";
            this.updateFirmwareToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateFirmwareToolStripMenuItem.Text = "Update Firmware";
            this.updateFirmwareToolStripMenuItem.Click += new System.EventHandler(this.updateFirmwareToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // sendTestFileToolStripMenuItem
            // 
            this.sendTestFileToolStripMenuItem.Name = "sendTestFileToolStripMenuItem";
            this.sendTestFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sendTestFileToolStripMenuItem.Text = "Send Test Page";
            this.sendTestFileToolStripMenuItem.Click += new System.EventHandler(this.sendTestFileToolStripMenuItem_Click);
            // 
            // printConfigPageToolStripMenuItem
            // 
            this.printConfigPageToolStripMenuItem.Name = "printConfigPageToolStripMenuItem";
            this.printConfigPageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.printConfigPageToolStripMenuItem.Text = "Print Config Page";
            this.printConfigPageToolStripMenuItem.Click += new System.EventHandler(this.printConfigPageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMaint);
            this.groupBox1.Controls.Add(this.radioResetPage);
            this.groupBox1.Controls.Add(this.radioResetSerial);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Action";
            // 
            // radioMaint
            // 
            this.radioMaint.AutoSize = true;
            this.radioMaint.Location = new System.Drawing.Point(14, 65);
            this.radioMaint.Name = "radioMaint";
            this.radioMaint.Size = new System.Drawing.Size(149, 17);
            this.radioMaint.TabIndex = 6;
            this.radioMaint.Text = "Reset Maintenance Count";
            this.radioMaint.UseVisualStyleBackColor = true;
            this.radioMaint.CheckedChanged += new System.EventHandler(this.radioResetSerial_CheckedChanged);
            // 
            // radioResetPage
            // 
            this.radioResetPage.AutoSize = true;
            this.radioResetPage.Location = new System.Drawing.Point(14, 42);
            this.radioResetPage.Name = "radioResetPage";
            this.radioResetPage.Size = new System.Drawing.Size(112, 17);
            this.radioResetPage.TabIndex = 5;
            this.radioResetPage.Text = "Reset Page Count";
            this.radioResetPage.UseVisualStyleBackColor = true;
            this.radioResetPage.CheckedChanged += new System.EventHandler(this.radioResetSerial_CheckedChanged);
            // 
            // radioResetSerial
            // 
            this.radioResetSerial.AutoSize = true;
            this.radioResetSerial.Checked = true;
            this.radioResetSerial.Location = new System.Drawing.Point(14, 19);
            this.radioResetSerial.Name = "radioResetSerial";
            this.radioResetSerial.Size = new System.Drawing.Size(91, 17);
            this.radioResetSerial.TabIndex = 4;
            this.radioResetSerial.TabStop = true;
            this.radioResetSerial.Text = "Change Serial";
            this.radioResetSerial.UseVisualStyleBackColor = true;
            this.radioResetSerial.CheckedChanged += new System.EventHandler(this.radioResetSerial_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 172);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printer IP\'s";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(163, 125);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0.0.0.0\r\n0.0.0.0\r\n0.0.0.0";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Serial:";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(63, 19);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(124, 20);
            this.textBoxSerial.TabIndex = 10;
            this.textBoxSerial.Text = "none";
            this.textBoxSerial.Leave += new System.EventHandler(this.textBoxSerial_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(453, 37);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(420, 471);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ftpButton
            // 
            this.ftpButton.Location = new System.Drawing.Point(341, 280);
            this.ftpButton.Name = "ftpButton";
            this.ftpButton.Size = new System.Drawing.Size(75, 23);
            this.ftpButton.TabIndex = 13;
            this.ftpButton.Text = "FTP";
            this.ftpButton.UseVisualStyleBackColor = true;
            this.ftpButton.Click += new System.EventHandler(this.ftpButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"rfu files (*.rfu)|*.rfu";
            this.openFileDialog1.Title = "Select Firmware File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.passwordStatusLabel);
            this.groupBox4.Controls.Add(this.passwordTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.pageCountBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(8, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Page Count";
            // 
            // passwordStatusLabel
            // 
            this.passwordStatusLabel.AutoSize = true;
            this.passwordStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordStatusLabel.Location = new System.Drawing.Point(111, 72);
            this.passwordStatusLabel.Name = "passwordStatusLabel";
            this.passwordStatusLabel.Size = new System.Drawing.Size(49, 13);
            this.passwordStatusLabel.TabIndex = 4;
            this.passwordStatusLabel.Text = "Incorrect";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(10, 69);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(95, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password (Required for Page = 0)";
            // 
            // pageCountBox
            // 
            this.pageCountBox.Location = new System.Drawing.Point(102, 21);
            this.pageCountBox.Name = "pageCountBox";
            this.pageCountBox.Size = new System.Drawing.Size(57, 20);
            this.pageCountBox.TabIndex = 1;
            this.pageCountBox.Text = "0";
            this.pageCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pageCountBox.TextChanged += new System.EventHandler(this.pageCountBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "New Page Count:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxSerial);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(215, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 153);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Action Settings";
            // 
            // printFileDialoge
            // 
            this.printFileDialoge.Title = "Select file to Print";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ftpButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "HP Printer / MFP Utility Kit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioMaint;
        private System.Windows.Forms.RadioButton radioResetPage;
        private System.Windows.Forms.RadioButton radioResetSerial;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ftpButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pageCountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendTestFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printConfigPageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.OpenFileDialog printFileDialoge;
        private System.Windows.Forms.ToolStripMenuItem updateFirmwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

