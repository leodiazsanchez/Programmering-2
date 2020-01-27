namespace Forms_1
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
            this.lblAnv = new System.Windows.Forms.Label();
            this.lblLösen = new System.Windows.Forms.Label();
            this.txtAnv = new System.Windows.Forms.TextBox();
            this.txtLösen = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnv
            // 
            this.lblAnv.AutoSize = true;
            this.lblAnv.Location = new System.Drawing.Point(80, 89);
            this.lblAnv.Name = "lblAnv";
            this.lblAnv.Size = new System.Drawing.Size(79, 13);
            this.lblAnv.TabIndex = 0;
            this.lblAnv.Text = "Användarnamn";
            // 
            // lblLösen
            // 
            this.lblLösen.AutoSize = true;
            this.lblLösen.Location = new System.Drawing.Point(80, 177);
            this.lblLösen.Name = "lblLösen";
            this.lblLösen.Size = new System.Drawing.Size(51, 13);
            this.lblLösen.TabIndex = 1;
            this.lblLösen.Text = "Lösenord";
            // 
            // txtAnv
            // 
            this.txtAnv.Location = new System.Drawing.Point(165, 86);
            this.txtAnv.Name = "txtAnv";
            this.txtAnv.Size = new System.Drawing.Size(100, 20);
            this.txtAnv.TabIndex = 2;
            // 
            // txtLösen
            // 
            this.txtLösen.Location = new System.Drawing.Point(165, 174);
            this.txtLösen.Name = "txtLösen";
            this.txtLösen.Size = new System.Drawing.Size(100, 20);
            this.txtLösen.TabIndex = 3;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(165, 231);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(165, 278);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 13);
            this.lblResultat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtLösen);
            this.Controls.Add(this.txtAnv);
            this.Controls.Add(this.lblLösen);
            this.Controls.Add(this.lblAnv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnv;
        private System.Windows.Forms.Label lblLösen;
        private System.Windows.Forms.TextBox txtAnv;
        private System.Windows.Forms.TextBox txtLösen;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblResultat;
    }
}

