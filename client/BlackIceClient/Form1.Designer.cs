namespace BlackIceClient
{
    partial class BlackIce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackIce));
            this.label1 = new System.Windows.Forms.Label();
            this.hackBlackIce = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.writeGhost = new System.Windows.Forms.Button();
            this.ghostTypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.popMessage = new System.Windows.Forms.Button();
            this.popTextbox = new System.Windows.Forms.TextBox();
            this.ejectRom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.closeRom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openBrowser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.terminateBtn = new System.Windows.Forms.Button();
            this.sketchTextBox = new System.Windows.Forms.TextBox();
            this.sketchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.jabBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hackBlackIce
            // 
            this.hackBlackIce.Location = new System.Drawing.Point(168, 11);
            this.hackBlackIce.Name = "hackBlackIce";
            this.hackBlackIce.Size = new System.Drawing.Size(75, 23);
            this.hackBlackIce.TabIndex = 2;
            this.hackBlackIce.Text = "Hack";
            this.hackBlackIce.UseVisualStyleBackColor = true;
            this.hackBlackIce.Click += new System.EventHandler(this.hackBlackIce_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ghost Type";
            // 
            // writeGhost
            // 
            this.writeGhost.Location = new System.Drawing.Point(168, 130);
            this.writeGhost.Name = "writeGhost";
            this.writeGhost.Size = new System.Drawing.Size(75, 23);
            this.writeGhost.TabIndex = 4;
            this.writeGhost.Text = "Write";
            this.writeGhost.UseVisualStyleBackColor = true;
            this.writeGhost.Click += new System.EventHandler(this.writeGhost_Click);
            // 
            // ghostTypeBox
            // 
            this.ghostTypeBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostTypeBox.Location = new System.Drawing.Point(22, 156);
            this.ghostTypeBox.Multiline = true;
            this.ghostTypeBox.Name = "ghostTypeBox";
            this.ghostTypeBox.Size = new System.Drawing.Size(440, 179);
            this.ghostTypeBox.TabIndex = 5;
            this.ghostTypeBox.Text = resources.GetString("ghostTypeBox.Text");
            this.ghostTypeBox.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pop Message";
            // 
            // popMessage
            // 
            this.popMessage.Location = new System.Drawing.Point(387, 11);
            this.popMessage.Name = "popMessage";
            this.popMessage.Size = new System.Drawing.Size(75, 23);
            this.popMessage.TabIndex = 7;
            this.popMessage.Text = "Pop";
            this.popMessage.UseVisualStyleBackColor = true;
            this.popMessage.Click += new System.EventHandler(this.popMessage_Click);
            // 
            // popTextbox
            // 
            this.popTextbox.Location = new System.Drawing.Point(262, 40);
            this.popTextbox.Name = "popTextbox";
            this.popTextbox.Size = new System.Drawing.Size(200, 20);
            this.popTextbox.TabIndex = 8;
            // 
            // ejectRom
            // 
            this.ejectRom.Location = new System.Drawing.Point(147, 341);
            this.ejectRom.Name = "ejectRom";
            this.ejectRom.Size = new System.Drawing.Size(75, 23);
            this.ejectRom.TabIndex = 10;
            this.ejectRom.Text = "Eject";
            this.ejectRom.UseVisualStyleBackColor = true;
            this.ejectRom.Click += new System.EventHandler(this.ejectRom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eject ROM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeRom
            // 
            this.closeRom.Location = new System.Drawing.Point(147, 370);
            this.closeRom.Name = "closeRom";
            this.closeRom.Size = new System.Drawing.Size(75, 23);
            this.closeRom.TabIndex = 12;
            this.closeRom.Text = "Close";
            this.closeRom.UseVisualStyleBackColor = true;
            this.closeRom.Click += new System.EventHandler(this.closeRom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Close ROM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openBrowser
            // 
            this.openBrowser.Location = new System.Drawing.Point(387, 67);
            this.openBrowser.Name = "openBrowser";
            this.openBrowser.Size = new System.Drawing.Size(75, 23);
            this.openBrowser.TabIndex = 15;
            this.openBrowser.Text = "Open";
            this.openBrowser.UseVisualStyleBackColor = true;
            this.openBrowser.Click += new System.EventHandler(this.openBrowser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Browser URL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(262, 93);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(200, 20);
            this.urlTextBox.TabIndex = 16;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(22, 40);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(140, 20);
            this.ipTextBox.TabIndex = 17;
            // 
            // terminateBtn
            // 
            this.terminateBtn.Location = new System.Drawing.Point(168, 40);
            this.terminateBtn.Name = "terminateBtn";
            this.terminateBtn.Size = new System.Drawing.Size(75, 23);
            this.terminateBtn.TabIndex = 18;
            this.terminateBtn.Text = "Terminate";
            this.terminateBtn.UseVisualStyleBackColor = true;
            this.terminateBtn.Click += new System.EventHandler(this.terminateBtn_Click);
            // 
            // sketchTextBox
            // 
            this.sketchTextBox.Location = new System.Drawing.Point(22, 93);
            this.sketchTextBox.Name = "sketchTextBox";
            this.sketchTextBox.Size = new System.Drawing.Size(140, 20);
            this.sketchTextBox.TabIndex = 21;
            // 
            // sketchBtn
            // 
            this.sketchBtn.Location = new System.Drawing.Point(168, 90);
            this.sketchBtn.Name = "sketchBtn";
            this.sketchBtn.Size = new System.Drawing.Size(75, 23);
            this.sketchBtn.TabIndex = 20;
            this.sketchBtn.Text = "Sketch";
            this.sketchBtn.UseVisualStyleBackColor = true;
            this.sketchBtn.Click += new System.EventHandler(this.sketchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Draw Sketch";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(389, 125);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 23;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Matrix App";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(387, 341);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 25;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Wallpaper";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jabBtn
            // 
            this.jabBtn.Location = new System.Drawing.Point(387, 370);
            this.jabBtn.Name = "jabBtn";
            this.jabBtn.Size = new System.Drawing.Size(75, 23);
            this.jabBtn.TabIndex = 27;
            this.jabBtn.Text = "Jabber";
            this.jabBtn.UseVisualStyleBackColor = true;
            this.jabBtn.Click += new System.EventHandler(this.jabBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Emoticons";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlackIce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 614);
            this.Controls.Add(this.jabBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sketchTextBox);
            this.Controls.Add(this.sketchBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.terminateBtn);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.openBrowser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeRom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ejectRom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.popTextbox);
            this.Controls.Add(this.popMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ghostTypeBox);
            this.Controls.Add(this.writeGhost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hackBlackIce);
            this.Controls.Add(this.label1);
            this.Name = "BlackIce";
            this.Text = "Black Ice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackIce_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hackBlackIce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button writeGhost;
        private System.Windows.Forms.TextBox ghostTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button popMessage;
        private System.Windows.Forms.TextBox popTextbox;
        private System.Windows.Forms.Button ejectRom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeRom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openBrowser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button terminateBtn;
        private System.Windows.Forms.TextBox sketchTextBox;
        private System.Windows.Forms.Button sketchBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button jabBtn;
        private System.Windows.Forms.Label label10;
    }
}

