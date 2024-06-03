namespace screenshx
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxInfo = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.Label();
            this.roomCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.roomCode);
            this.panel1.Controls.Add(this.boxStatus);
            this.panel1.Controls.Add(this.boxInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 146);
            this.panel1.TabIndex = 0;
            // 
            // boxInfo
            // 
            this.boxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.boxInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.boxInfo.Location = new System.Drawing.Point(0, 0);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.Size = new System.Drawing.Size(1273, 146);
            this.boxInfo.TabIndex = 0;
            this.boxInfo.Text = "Parsing info.";
            this.boxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxStatus
            // 
            this.boxStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.boxStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.boxStatus.Location = new System.Drawing.Point(0, 96);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(1273, 50);
            this.boxStatus.TabIndex = 1;
            this.boxStatus.Text = "boxStatus.Text";
            this.boxStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomCode
            // 
            this.roomCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roomCode.AutoSize = true;
            this.roomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.roomCode.ForeColor = System.Drawing.Color.White;
            this.roomCode.Location = new System.Drawing.Point(1174, 96);
            this.roomCode.Name = "roomCode";
            this.roomCode.Size = new System.Drawing.Size(87, 36);
            this.roomCode.TabIndex = 2;
            this.roomCode.Text = "0000";
            this.roomCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomCode.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 620);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label boxStatus;
        private System.Windows.Forms.Label boxInfo;
        private System.Windows.Forms.Label roomCode;
    }
}

