namespace BlackIceServer
{
    partial class GhostType
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
            this.ghostBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ghostBox
            // 
            this.ghostBox.BackColor = System.Drawing.Color.Black;
            this.ghostBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghostBox.ForeColor = System.Drawing.Color.Red;
            this.ghostBox.Location = new System.Drawing.Point(0, 0);
            this.ghostBox.Margin = new System.Windows.Forms.Padding(0);
            this.ghostBox.Multiline = true;
            this.ghostBox.Name = "ghostBox";
            this.ghostBox.Size = new System.Drawing.Size(742, 691);
            this.ghostBox.TabIndex = 0;
            // 
            // GhostType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 690);
            this.Controls.Add(this.ghostBox);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "GhostType";
            this.Text = "GhostType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ghostBox;

    }
}