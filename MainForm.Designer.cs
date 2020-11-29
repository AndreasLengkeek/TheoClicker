namespace TheoClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDblClick = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconds:";
            // 
            // txtSeconds
            // 
            this.txtSeconds.DecimalPlaces = 1;
            this.txtSeconds.Location = new System.Drawing.Point(121, 17);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(76, 23);
            this.txtSeconds.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double Click:";
            // 
            // chkDblClick
            // 
            this.chkDblClick.AutoSize = true;
            this.chkDblClick.Location = new System.Drawing.Point(122, 50);
            this.chkDblClick.Name = "chkDblClick";
            this.chkDblClick.Size = new System.Drawing.Size(15, 14);
            this.chkDblClick.TabIndex = 3;
            this.chkDblClick.UseVisualStyleBackColor = true;
            this.chkDblClick.CheckedChanged += new System.EventHandler(this.DblClick_CheckChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Delay:";
            // 
            // txtDelay
            // 
            this.txtDelay.DecimalPlaces = 1;
            this.txtDelay.Enabled = false;
            this.txtDelay.Location = new System.Drawing.Point(121, 73);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(76, 23);
            this.txtDelay.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 108);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start! (Ctrl+F1)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(38, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(159, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(122, 108);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop (Ctrl+F2)";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 180);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkDblClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TheoClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDblClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtDelay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer delayTimer;
    }
}