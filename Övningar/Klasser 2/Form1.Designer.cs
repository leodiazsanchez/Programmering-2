namespace Klasser_2
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxmin = new System.Windows.Forms.TextBox();
            this.tbxabove = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listOut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(143, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(156, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(143, 83);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(156, 20);
            this.tbxPoints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Poäng:";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(143, 132);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Lägg till";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(224, 132);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 5;
            this.btnremove.Text = "Ångra";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gräns för godkänt";
            // 
            // tbxmin
            // 
            this.tbxmin.Location = new System.Drawing.Point(143, 346);
            this.tbxmin.Name = "tbxmin";
            this.tbxmin.Size = new System.Drawing.Size(156, 20);
            this.tbxmin.TabIndex = 8;
            // 
            // tbxabove
            // 
            this.tbxabove.Location = new System.Drawing.Point(143, 397);
            this.tbxabove.Name = "tbxabove";
            this.tbxabove.ReadOnly = true;
            this.tbxabove.Size = new System.Drawing.Size(156, 20);
            this.tbxabove.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Antal över gräns";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listOut
            // 
            this.listOut.FormattingEnabled = true;
            this.listOut.Location = new System.Drawing.Point(64, 181);
            this.listOut.Name = "listOut";
            this.listOut.Size = new System.Drawing.Size(235, 147);
            this.listOut.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.listOut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbxabove);
            this.Controls.Add(this.tbxmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Provresultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxmin;
        private System.Windows.Forms.TextBox tbxabove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listOut;
    }
}

