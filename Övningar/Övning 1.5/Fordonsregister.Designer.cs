namespace Övning_1._5
{
    partial class Fordonsregister
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
            this.tbxreg = new System.Windows.Forms.TextBox();
            this.tbxmärke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxRegister = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMC = new System.Windows.Forms.RadioButton();
            this.rbtnBilar = new System.Windows.Forms.RadioButton();
            this.rbtnAlla = new System.Windows.Forms.RadioButton();
            this.tbxmodell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxreg
            // 
            this.tbxreg.Location = new System.Drawing.Point(66, 79);
            this.tbxreg.Name = "tbxreg";
            this.tbxreg.Size = new System.Drawing.Size(100, 20);
            this.tbxreg.TabIndex = 0;
            // 
            // tbxmärke
            // 
            this.tbxmärke.Location = new System.Drawing.Point(66, 132);
            this.tbxmärke.Name = "tbxmärke";
            this.tbxmärke.Size = new System.Drawing.Size(100, 20);
            this.tbxmärke.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reg-nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Typ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxRegister
            // 
            this.lbxRegister.FormattingEnabled = true;
            this.lbxRegister.Location = new System.Drawing.Point(248, 79);
            this.lbxRegister.Name = "lbxRegister";
            this.lbxRegister.Size = new System.Drawing.Size(155, 147);
            this.lbxRegister.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Register";
            // 
            // cbxTyp
            // 
            this.cbxTyp.AutoCompleteCustomSource.AddRange(new string[] {
            "Bil",
            "MC"});
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.cbxTyp.Location = new System.Drawing.Point(66, 216);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(100, 21);
            this.cbxTyp.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMC);
            this.groupBox1.Controls.Add(this.rbtnBilar);
            this.groupBox1.Controls.Add(this.rbtnAlla);
            this.groupBox1.Location = new System.Drawing.Point(248, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 58);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnMC
            // 
            this.rbtnMC.AutoSize = true;
            this.rbtnMC.Location = new System.Drawing.Point(108, 19);
            this.rbtnMC.Name = "rbtnMC";
            this.rbtnMC.Size = new System.Drawing.Size(41, 17);
            this.rbtnMC.TabIndex = 2;
            this.rbtnMC.TabStop = true;
            this.rbtnMC.Text = "MC";
            this.rbtnMC.UseVisualStyleBackColor = true;
            this.rbtnMC.CheckedChanged += new System.EventHandler(this.rbtnMC_CheckedChanged);
            // 
            // rbtnBilar
            // 
            this.rbtnBilar.AutoSize = true;
            this.rbtnBilar.Location = new System.Drawing.Point(54, 19);
            this.rbtnBilar.Name = "rbtnBilar";
            this.rbtnBilar.Size = new System.Drawing.Size(45, 17);
            this.rbtnBilar.TabIndex = 1;
            this.rbtnBilar.TabStop = true;
            this.rbtnBilar.Text = "Bilar";
            this.rbtnBilar.UseVisualStyleBackColor = true;
            this.rbtnBilar.CheckedChanged += new System.EventHandler(this.rbtnBilar_CheckedChanged);
            // 
            // rbtnAlla
            // 
            this.rbtnAlla.AutoSize = true;
            this.rbtnAlla.Location = new System.Drawing.Point(6, 19);
            this.rbtnAlla.Name = "rbtnAlla";
            this.rbtnAlla.Size = new System.Drawing.Size(42, 17);
            this.rbtnAlla.TabIndex = 0;
            this.rbtnAlla.TabStop = true;
            this.rbtnAlla.Text = "Alla";
            this.rbtnAlla.UseVisualStyleBackColor = true;
            this.rbtnAlla.CheckedChanged += new System.EventHandler(this.rbtnAlla_CheckedChanged);
            // 
            // tbxmodell
            // 
            this.tbxmodell.Location = new System.Drawing.Point(66, 175);
            this.tbxmodell.Name = "tbxmodell";
            this.tbxmodell.Size = new System.Drawing.Size(100, 20);
            this.tbxmodell.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modell";
            // 
            // Fordonsregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxmodell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxmärke);
            this.Controls.Add(this.tbxreg);
            this.Name = "Fordonsregister";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxreg;
        private System.Windows.Forms.TextBox tbxmärke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMC;
        private System.Windows.Forms.RadioButton rbtnBilar;
        private System.Windows.Forms.RadioButton rbtnAlla;
        private System.Windows.Forms.TextBox tbxmodell;
        private System.Windows.Forms.Label label5;
    }
}

