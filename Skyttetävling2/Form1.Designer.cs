namespace Skyttetävling2
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
            this.tbxnamn = new System.Windows.Forms.TextBox();
            this.tbxpoängreg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxpoängsök = new System.Windows.Forms.TextBox();
            this.btnurval = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.listOut = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poäng";
            // 
            // tbxnamn
            // 
            this.tbxnamn.Location = new System.Drawing.Point(123, 39);
            this.tbxnamn.Name = "tbxnamn";
            this.tbxnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxnamn.TabIndex = 2;
            // 
            // tbxpoängreg
            // 
            this.tbxpoängreg.Location = new System.Drawing.Point(123, 93);
            this.tbxpoängreg.Name = "tbxpoängreg";
            this.tbxpoängreg.Size = new System.Drawing.Size(100, 20);
            this.tbxpoängreg.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOut);
            this.groupBox1.Controls.Add(this.btnurval);
            this.groupBox1.Controls.Add(this.tbxpoängsök);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(61, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök poäng över";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Poäng";
            // 
            // tbxpoängsök
            // 
            this.tbxpoängsök.Location = new System.Drawing.Point(49, 35);
            this.tbxpoängsök.Name = "tbxpoängsök";
            this.tbxpoängsök.Size = new System.Drawing.Size(100, 20);
            this.tbxpoängsök.TabIndex = 1;
            // 
            // btnurval
            // 
            this.btnurval.Location = new System.Drawing.Point(49, 62);
            this.btnurval.Name = "btnurval";
            this.btnurval.Size = new System.Drawing.Size(100, 23);
            this.btnurval.TabIndex = 2;
            this.btnurval.Text = "Visa urval";
            this.btnurval.UseVisualStyleBackColor = true;
            this.btnurval.Click += new System.EventHandler(this.btnurval_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(229, 93);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 5;
            this.btnreg.Text = "Registera";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // listOut
            // 
            this.listOut.FormattingEnabled = true;
            this.listOut.Location = new System.Drawing.Point(10, 110);
            this.listOut.Name = "listOut";
            this.listOut.Size = new System.Drawing.Size(165, 108);
            this.listOut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxpoängreg);
            this.Controls.Add(this.tbxnamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxnamn;
        private System.Windows.Forms.TextBox tbxpoängreg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnurval;
        private System.Windows.Forms.TextBox tbxpoängsök;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.ListBox listOut;
    }
}

