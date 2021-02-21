namespace Scripting_FinalProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempOutTB = new System.Windows.Forms.TextBox();
            this.tempInTB = new System.Windows.Forms.TextBox();
            this.humTB = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.maxTempButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lightRedButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mood Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inside temp (DHT11)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outside temp (LM35)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Inside Humidity (DHT11)";
            // 
            // tempOutTB
            // 
            this.tempOutTB.Location = new System.Drawing.Point(510, 53);
            this.tempOutTB.Multiline = true;
            this.tempOutTB.Name = "tempOutTB";
            this.tempOutTB.ReadOnly = true;
            this.tempOutTB.Size = new System.Drawing.Size(247, 40);
            this.tempOutTB.TabIndex = 6;
            // 
            // tempInTB
            // 
            this.tempInTB.Location = new System.Drawing.Point(510, 123);
            this.tempInTB.Multiline = true;
            this.tempInTB.Name = "tempInTB";
            this.tempInTB.ReadOnly = true;
            this.tempInTB.Size = new System.Drawing.Size(247, 44);
            this.tempInTB.TabIndex = 18;
            // 
            // humTB
            // 
            this.humTB.Location = new System.Drawing.Point(510, 182);
            this.humTB.Multiline = true;
            this.humTB.Name = "humTB";
            this.humTB.ReadOnly = true;
            this.humTB.Size = new System.Drawing.Size(247, 43);
            this.humTB.TabIndex = 8;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(44, 147);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(146, 59);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // maxTempButton
            // 
            this.maxTempButton.Location = new System.Drawing.Point(253, 266);
            this.maxTempButton.Name = "maxTempButton";
            this.maxTempButton.Size = new System.Drawing.Size(151, 52);
            this.maxTempButton.TabIndex = 14;
            this.maxTempButton.Text = "Temp Max";
            this.maxTempButton.UseVisualStyleBackColor = true;
            this.maxTempButton.Click += new System.EventHandler(this.maxTempButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBox1.Location = new System.Drawing.Point(438, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // lightRedButton
            // 
            this.lightRedButton.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lightRedButton.BackColor = System.Drawing.Color.Red;
            this.lightRedButton.ForeColor = System.Drawing.Color.White;
            this.lightRedButton.Location = new System.Drawing.Point(253, 356);
            this.lightRedButton.Name = "lightRedButton";
            this.lightRedButton.Size = new System.Drawing.Size(460, 94);
            this.lightRedButton.TabIndex = 16;
            this.lightRedButton.Text = "Red LED Toggle";
            this.lightRedButton.UseVisualStyleBackColor = false;
            this.lightRedButton.BackColorChanged += new System.EventHandler(this.lightRedButton_Click);
            this.lightRedButton.BackgroundImageChanged += new System.EventHandler(this.lightRedButton_Click);
            this.lightRedButton.Click += new System.EventHandler(this.lightRedButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox2.Location = new System.Drawing.Point(61, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Use Rotator on Hardware";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lightRedButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maxTempButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.humTB);
            this.Controls.Add(this.tempInTB);
            this.Controls.Add(this.tempOutTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IoT Prototype 30018755";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tempOutTB;
        private System.Windows.Forms.TextBox tempInTB;
        private System.Windows.Forms.TextBox humTB;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button maxTempButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button lightRedButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    }
}

