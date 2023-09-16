namespace PresentationLayer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTeamA = new System.Windows.Forms.Label();
            this.lbTeamB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.btnDisplayLog = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.txtTeamA = new System.Windows.Forms.TextBox();
            this.txtTeamB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTeamB);
            this.groupBox1.Controls.Add(this.txtTeamA);
            this.groupBox1.Controls.Add(this.btnSaveResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbTeamB);
            this.groupBox1.Controls.Add(this.lbTeamA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matches";
            // 
            // lbTeamA
            // 
            this.lbTeamA.AutoSize = true;
            this.lbTeamA.Location = new System.Drawing.Point(26, 37);
            this.lbTeamA.Name = "lbTeamA";
            this.lbTeamA.Size = new System.Drawing.Size(91, 25);
            this.lbTeamA.TabIndex = 0;
            this.lbTeamA.Text = "TEAM A";
            // 
            // lbTeamB
            // 
            this.lbTeamB.AutoSize = true;
            this.lbTeamB.Location = new System.Drawing.Point(194, 37);
            this.lbTeamB.Name = "lbTeamB";
            this.lbTeamB.Size = new System.Drawing.Size(91, 25);
            this.lbTeamB.TabIndex = 1;
            this.lbTeamB.Text = "TEAM B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "vs";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(31, 137);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(234, 38);
            this.btnSaveResult.TabIndex = 6;
            this.btnSaveResult.Text = "Save Result";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.BtnSaveResult_Click);
            // 
            // btnDisplayLog
            // 
            this.btnDisplayLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayLog.Location = new System.Drawing.Point(435, 70);
            this.btnDisplayLog.Name = "btnDisplayLog";
            this.btnDisplayLog.Size = new System.Drawing.Size(256, 35);
            this.btnDisplayLog.TabIndex = 7;
            this.btnDisplayLog.Text = "Display log";
            this.btnDisplayLog.UseVisualStyleBackColor = true;
            this.btnDisplayLog.Click += new System.EventHandler(this.BtnDisplayLog_Click);
            // 
            // listLog
            // 
            this.listLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 25;
            this.listLog.Location = new System.Drawing.Point(435, 107);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(256, 204);
            this.listLog.TabIndex = 8;
            // 
            // txtTeamA
            // 
            this.txtTeamA.Location = new System.Drawing.Point(31, 65);
            this.txtTeamA.Name = "txtTeamA";
            this.txtTeamA.Size = new System.Drawing.Size(86, 31);
            this.txtTeamA.TabIndex = 7;
            // 
            // txtTeamB
            // 
            this.txtTeamB.Location = new System.Drawing.Point(199, 65);
            this.txtTeamB.Name = "txtTeamB";
            this.txtTeamB.Size = new System.Drawing.Size(86, 31);
            this.txtTeamB.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnDisplayLog);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTeamB;
        private System.Windows.Forms.Label lbTeamA;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Button btnDisplayLog;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.TextBox txtTeamB;
        private System.Windows.Forms.TextBox txtTeamA;
    }
}

