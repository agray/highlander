namespace pheonix
{
    partial class frmTheHighLander {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheHighLander));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(107, 12);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(271, 20);
            this.txtRoot.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Root Directory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(409, 156);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(62, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(107, 41);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(364, 107);
            this.txtConsole.TabIndex = 9;
            this.txtConsole.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Console Output";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(107, 185);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(271, 20);
            this.txtOutputPath.TabIndex = 8;
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(12, 188);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutputPath.Size = new System.Drawing.Size(64, 13);
            this.lblOutputPath.TabIndex = 2;
            this.lblOutputPath.Text = "Output Path";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(409, 183);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(62, 23);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "Move Files";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(345, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(384, 183);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(24, 23);
            this.btnOutputPath.TabIndex = 11;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // frmTheHighLander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 212);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 342);
            this.MinimumSize = new System.Drawing.Size(488, 250);
            this.Name = "frmTheHighLander";
            this.Text = "The HighLander";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOutputPath;
    }
}

