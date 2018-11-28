namespace GearliathRobotCommandForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputCmdButton = new System.Windows.Forms.Button();
            this.removeCmdButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(501, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 384);
            this.panel1.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(738, 20);
            this.inputBox.TabIndex = 1;
            // 
            // inputCmdButton
            // 
            this.inputCmdButton.Location = new System.Drawing.Point(12, 26);
            this.inputCmdButton.Name = "inputCmdButton";
            this.inputCmdButton.Size = new System.Drawing.Size(111, 23);
            this.inputCmdButton.TabIndex = 2;
            this.inputCmdButton.Text = "Input Command";
            this.inputCmdButton.UseVisualStyleBackColor = true;
            this.inputCmdButton.Click += new System.EventHandler(this.inputCmdButton_Click);
            // 
            // removeCmdButton
            // 
            this.removeCmdButton.Location = new System.Drawing.Point(129, 26);
            this.removeCmdButton.Name = "removeCmdButton";
            this.removeCmdButton.Size = new System.Drawing.Size(111, 23);
            this.removeCmdButton.TabIndex = 3;
            this.removeCmdButton.Text = "Remove Command";
            this.removeCmdButton.UseVisualStyleBackColor = true;
            this.removeCmdButton.Click += new System.EventHandler(this.removeCmdButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-175, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 315);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 56);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(110, 23);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Open Help Window";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 85);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(110, 23);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // indexTextBox
            // 
            this.indexTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.indexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indexTextBox.Location = new System.Drawing.Point(456, 40);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.ReadOnly = true;
            this.indexTextBox.Size = new System.Drawing.Size(30, 20);
            this.indexTextBox.TabIndex = 8;
            this.indexTextBox.TextChanged += new System.EventHandler(this.indexTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.removeCmdButton);
            this.Controls.Add(this.inputCmdButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "11619 Robot Control Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button inputCmdButton;
        private System.Windows.Forms.Button removeCmdButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.Label label1;
    }
}

