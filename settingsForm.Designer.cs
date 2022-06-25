namespace thinkpad_kb
{
    partial class settingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kbAutoDimLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kbAutoDimTime = new System.Windows.Forms.NumericUpDown();
            this.kbAutoDim = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kbAutoLightLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kbAutoLight = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbAutoDimTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kbAutoDimLevel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kbAutoDimTime);
            this.groupBox1.Controls.Add(this.kbAutoDim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Dim";
            // 
            // kbAutoDimLevel
            // 
            this.kbAutoDimLevel.FormattingEnabled = true;
            this.kbAutoDimLevel.Location = new System.Drawing.Point(79, 62);
            this.kbAutoDimLevel.Name = "kbAutoDimLevel";
            this.kbAutoDimLevel.Size = new System.Drawing.Size(121, 21);
            this.kbAutoDimLevel.TabIndex = 5;
            this.kbAutoDimLevel.SelectedIndexChanged += new System.EventHandler(this.kbAutoDimLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dim level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dim after";
            // 
            // kbAutoDimTime
            // 
            this.kbAutoDimTime.Location = new System.Drawing.Point(79, 37);
            this.kbAutoDimTime.Name = "kbAutoDimTime";
            this.kbAutoDimTime.Size = new System.Drawing.Size(43, 20);
            this.kbAutoDimTime.TabIndex = 1;
            // 
            // kbAutoDim
            // 
            this.kbAutoDim.AutoSize = true;
            this.kbAutoDim.Location = new System.Drawing.Point(6, 19);
            this.kbAutoDim.Name = "kbAutoDim";
            this.kbAutoDim.Size = new System.Drawing.Size(250, 17);
            this.kbAutoDim.TabIndex = 0;
            this.kbAutoDim.Text = "Enable backlight dim when keyboard is inactive";
            this.kbAutoDim.UseVisualStyleBackColor = true;
            this.kbAutoDim.CheckedChanged += new System.EventHandler(this.kbAutoDim_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kbAutoLightLevel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kbAutoLight);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto Light";
            // 
            // kbAutoLightLevel
            // 
            this.kbAutoLightLevel.FormattingEnabled = true;
            this.kbAutoLightLevel.Location = new System.Drawing.Point(79, 42);
            this.kbAutoLightLevel.Name = "kbAutoLightLevel";
            this.kbAutoLightLevel.Size = new System.Drawing.Size(121, 21);
            this.kbAutoLightLevel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Light level:";
            // 
            // kbAutoLight
            // 
            this.kbAutoLight.AutoSize = true;
            this.kbAutoLight.Location = new System.Drawing.Point(6, 19);
            this.kbAutoLight.Name = "kbAutoLight";
            this.kbAutoLight.Size = new System.Drawing.Size(203, 17);
            this.kbAutoLight.TabIndex = 0;
            this.kbAutoLight.Text = "Enable backlight when a key pressed";
            this.kbAutoLight.UseVisualStyleBackColor = true;
            this.kbAutoLight.CheckedChanged += new System.EventHandler(this.kbAutoLight_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Thinkpad Keyboard Light";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThinkPad Keyboard Light Settings";
            this.Resize += new System.EventHandler(this.settingsForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbAutoDimTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox kbAutoDimLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown kbAutoDimTime;
        private System.Windows.Forms.CheckBox kbAutoDim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox kbAutoLightLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox kbAutoLight;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

