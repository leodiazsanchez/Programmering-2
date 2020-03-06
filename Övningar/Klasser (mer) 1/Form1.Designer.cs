namespace Klasser__mer__1
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
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.tbxDest = new System.Windows.Forms.TextBox();
            this.tbxDagar = new System.Windows.Forms.TextBox();
            this.btnBoka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSök = new System.Windows.Forms.Button();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.lbxOut = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(91, 47);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 0;
            // 
            // tbxDest
            // 
            this.tbxDest.Location = new System.Drawing.Point(91, 112);
            this.tbxDest.Name = "tbxDest";
            this.tbxDest.Size = new System.Drawing.Size(100, 20);
            this.tbxDest.TabIndex = 1;
            // 
            // tbxDagar
            // 
            this.tbxDagar.Location = new System.Drawing.Point(91, 169);
            this.tbxDagar.Name = "tbxDagar";
            this.tbxDagar.Size = new System.Drawing.Size(100, 20);
            this.tbxDagar.TabIndex = 2;
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(214, 169);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(41, 23);
            this.btnBoka.TabIndex = 3;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            this.btnBoka.Click += new System.EventHandler(this.btnBoka_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Antal dagar";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(214, 253);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(41, 23);
            this.btnSök.TabIndex = 8;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(91, 255);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 9;
            // 
            // lbxOut
            // 
            this.lbxOut.FormattingEnabled = true;
            this.lbxOut.Location = new System.Drawing.Point(91, 308);
            this.lbxOut.Name = "lbxOut";
            this.lbxOut.Size = new System.Drawing.Size(164, 95);
            this.lbxOut.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Namn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxOut);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoka);
            this.Controls.Add(this.tbxDagar);
            this.Controls.Add(this.tbxDest);
            this.Controls.Add(this.tbxKund);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.TextBox tbxDest;
        private System.Windows.Forms.TextBox tbxDagar;
        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.ListBox lbxOut;
        private System.Windows.Forms.Label label4;
    }
}

