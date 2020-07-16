﻿namespace Network_Tools
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
            this.WhoIsGroupBox = new System.Windows.Forms.GroupBox();
            this.seartchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.WhoIsResultBox = new System.Windows.Forms.RichTextBox();
            this.portScanner = new System.Windows.Forms.GroupBox();
            this.portList = new System.Windows.Forms.ListView();
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singlePorting = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.port2 = new System.Windows.Forms.TextBox();
            this.port1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newScan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.scanProgress = new System.Windows.Forms.ProgressBar();
            this.WhoIsGroupBox.SuspendLayout();
            this.portScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhoIsGroupBox
            // 
            this.WhoIsGroupBox.Controls.Add(this.portScanner);
            this.WhoIsGroupBox.Controls.Add(this.seartchButton);
            this.WhoIsGroupBox.Controls.Add(this.label1);
            this.WhoIsGroupBox.Controls.Add(this.addressBox);
            this.WhoIsGroupBox.Controls.Add(this.WhoIsResultBox);
            this.WhoIsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoIsGroupBox.Location = new System.Drawing.Point(31, 60);
            this.WhoIsGroupBox.Name = "WhoIsGroupBox";
            this.WhoIsGroupBox.Size = new System.Drawing.Size(545, 513);
            this.WhoIsGroupBox.TabIndex = 0;
            this.WhoIsGroupBox.TabStop = false;
            this.WhoIsGroupBox.Text = "WhoIs";
            // 
            // seartchButton
            // 
            this.seartchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seartchButton.Location = new System.Drawing.Point(334, 47);
            this.seartchButton.Name = "seartchButton";
            this.seartchButton.Size = new System.Drawing.Size(59, 21);
            this.seartchButton.TabIndex = 5;
            this.seartchButton.Text = "Search";
            this.seartchButton.UseVisualStyleBackColor = true;
            this.seartchButton.Click += new System.EventHandler(this.WhoIsSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domain Name";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.Location = new System.Drawing.Point(26, 47);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(272, 21);
            this.addressBox.TabIndex = 2;
            this.addressBox.Enter += new System.EventHandler(this.WhoIsAddressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.WhoIsAddressBox_Leave);
            // 
            // WhoIsResultBox
            // 
            this.WhoIsResultBox.Location = new System.Drawing.Point(26, 96);
            this.WhoIsResultBox.Name = "WhoIsResultBox";
            this.WhoIsResultBox.Size = new System.Drawing.Size(479, 383);
            this.WhoIsResultBox.TabIndex = 0;
            this.WhoIsResultBox.Text = "";
            // 
            // portScanner
            // 
            this.portScanner.Controls.Add(this.scanProgress);
            this.portScanner.Controls.Add(this.portList);
            this.portScanner.Controls.Add(this.singlePorting);
            this.portScanner.Controls.Add(this.label3);
            this.portScanner.Controls.Add(this.port2);
            this.portScanner.Controls.Add(this.port1);
            this.portScanner.Controls.Add(this.label2);
            this.portScanner.Controls.Add(this.newScan);
            this.portScanner.Controls.Add(this.label4);
            this.portScanner.Controls.Add(this.inputIP);
            this.portScanner.Location = new System.Drawing.Point(0, 0);
            this.portScanner.Name = "portScanner";
            this.portScanner.Size = new System.Drawing.Size(545, 513);
            this.portScanner.TabIndex = 6;
            this.portScanner.TabStop = false;
            this.portScanner.Text = "Port Scanner";
            // 
            // portList
            // 
            this.portList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.port,
            this.status});
            this.portList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portList.HideSelection = false;
            this.portList.Location = new System.Drawing.Point(119, 157);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(311, 308);
            this.portList.TabIndex = 19;
            this.portList.UseCompatibleStateImageBehavior = false;
            this.portList.View = System.Windows.Forms.View.Details;
            // 
            // port
            // 
            this.port.Text = "Port";
            this.port.Width = 128;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 127;
            // 
            // singlePorting
            // 
            this.singlePorting.AutoSize = true;
            this.singlePorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePorting.Location = new System.Drawing.Point(119, 127);
            this.singlePorting.Name = "singlePorting";
            this.singlePorting.Size = new System.Drawing.Size(125, 17);
            this.singlePorting.TabIndex = 18;
            this.singlePorting.Text = "Single Port Scanning";
            this.singlePorting.UseVisualStyleBackColor = true;
            this.singlePorting.Click += new System.EventHandler(this.singlePortCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "to";
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(242, 98);
            this.port2.MaxLength = 5;
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(44, 22);
            this.port2.TabIndex = 16;
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(167, 98);
            this.port1.MaxLength = 5;
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(44, 22);
            this.port1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ports";
            // 
            // newScan
            // 
            this.newScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScan.Location = new System.Drawing.Point(364, 66);
            this.newScan.Name = "newScan";
            this.newScan.Size = new System.Drawing.Size(66, 27);
            this.newScan.TabIndex = 13;
            this.newScan.Text = "Scan";
            this.newScan.UseVisualStyleBackColor = true;
            this.newScan.Click += new System.EventHandler(this.portScan);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "IP";
            // 
            // inputIP
            // 
            this.inputIP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inputIP.Location = new System.Drawing.Point(145, 68);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(213, 22);
            this.inputIP.TabIndex = 11;
            this.inputIP.Text = "Ex: 192.168.1.1";
            this.inputIP.Enter += new System.EventHandler(this.PorScannerInputIP_Enter);
            this.inputIP.Leave += new System.EventHandler(this.PortScannerInputIP_Leave);
            // 
            // scanProgress
            // 
            this.scanProgress.Location = new System.Drawing.Point(0, 490);
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(545, 23);
            this.scanProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.scanProgress.TabIndex = 20;
            this.scanProgress.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 602);
            this.Controls.Add(this.WhoIsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WhoIsGroupBox.ResumeLayout(false);
            this.WhoIsGroupBox.PerformLayout();
            this.portScanner.ResumeLayout(false);
            this.portScanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WhoIsGroupBox;
        private System.Windows.Forms.RichTextBox WhoIsResultBox;
        private System.Windows.Forms.Button seartchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.GroupBox portScanner;
        private System.Windows.Forms.ProgressBar scanProgress;
        private System.Windows.Forms.ListView portList;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.CheckBox singlePorting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.TextBox port1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newScan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputIP;
    }
}

