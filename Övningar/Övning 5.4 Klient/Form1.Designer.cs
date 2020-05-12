namespace Övning_5._4_Klient
{
    partial class Klient
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
            this.btnAnslut = new System.Windows.Forms.Button();
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnHöger = new System.Windows.Forms.Button();
            this.btnVänster = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(179, 25);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 0;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // btnUpp
            // 
            this.btnUpp.Location = new System.Drawing.Point(98, 103);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(75, 23);
            this.btnUpp.TabIndex = 1;
            this.btnUpp.Text = "Upp";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.btnUpp_Click);
            // 
            // btnHöger
            // 
            this.btnHöger.Location = new System.Drawing.Point(179, 156);
            this.btnHöger.Name = "btnHöger";
            this.btnHöger.Size = new System.Drawing.Size(75, 23);
            this.btnHöger.TabIndex = 2;
            this.btnHöger.Text = "Höger";
            this.btnHöger.UseVisualStyleBackColor = true;
            this.btnHöger.Click += new System.EventHandler(this.btnHöger_Click);
            // 
            // btnVänster
            // 
            this.btnVänster.Location = new System.Drawing.Point(12, 156);
            this.btnVänster.Name = "btnVänster";
            this.btnVänster.Size = new System.Drawing.Size(75, 23);
            this.btnVänster.TabIndex = 3;
            this.btnVänster.Text = "Vänster";
            this.btnVänster.UseVisualStyleBackColor = true;
            this.btnVänster.Click += new System.EventHandler(this.btnVänster_Click);
            // 
            // btnNer
            // 
            this.btnNer.Location = new System.Drawing.Point(98, 198);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(75, 23);
            this.btnNer.TabIndex = 4;
            this.btnNer.Text = "Ner";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.btnNer_Click);
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(73, 27);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 20);
            this.tbxIP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP:";
            // 
            // Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnVänster);
            this.Controls.Add(this.btnHöger);
            this.Controls.Add(this.btnUpp);
            this.Controls.Add(this.btnAnslut);
            this.Name = "Klient";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.Button btnHöger;
        private System.Windows.Forms.Button btnVänster;
        private System.Windows.Forms.Button btnNer;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label label1;
    }
}

