namespace Övning_2._8__2_
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
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnVikt = new System.Windows.Forms.RadioButton();
            this.rbtnSak = new System.Windows.Forms.RadioButton();
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxItem = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(487, 32);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(254, 342);
            this.lbxItems.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSak);
            this.groupBox1.Controls.Add(this.rbtnVikt);
            this.groupBox1.Location = new System.Drawing.Point(243, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varutyp";
            // 
            // rbtnVikt
            // 
            this.rbtnVikt.AutoSize = true;
            this.rbtnVikt.Location = new System.Drawing.Point(6, 19);
            this.rbtnVikt.Name = "rbtnVikt";
            this.rbtnVikt.Size = new System.Drawing.Size(59, 17);
            this.rbtnVikt.TabIndex = 0;
            this.rbtnVikt.TabStop = true;
            this.rbtnVikt.Text = "Lösvikt";
            this.rbtnVikt.UseVisualStyleBackColor = true;
            // 
            // rbtnSak
            // 
            this.rbtnSak.AutoSize = true;
            this.rbtnSak.Location = new System.Drawing.Point(6, 56);
            this.rbtnSak.Name = "rbtnSak";
            this.rbtnSak.Size = new System.Drawing.Size(69, 17);
            this.rbtnSak.TabIndex = 1;
            this.rbtnSak.TabStop = true;
            this.rbtnSak.Text = "Stycksak";
            this.rbtnSak.UseVisualStyleBackColor = true;
            // 
            // tbxSum
            // 
            this.tbxSum.Location = new System.Drawing.Point(556, 398);
            this.tbxSum.Name = "tbxSum";
            this.tbxSum.Size = new System.Drawing.Size(185, 20);
            this.tbxSum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summa (kr):";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mängd";
            // 
            // tbxItem
            // 
            this.tbxItem.Location = new System.Drawing.Point(123, 32);
            this.tbxItem.Name = "tbxItem";
            this.tbxItem.Size = new System.Drawing.Size(185, 20);
            this.tbxItem.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(123, 75);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(185, 20);
            this.tbxPrice.TabIndex = 9;
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(123, 125);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(185, 20);
            this.tbxAmount.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSak;
        private System.Windows.Forms.RadioButton rbtnVikt;
        private System.Windows.Forms.TextBox tbxSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxItem;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxAmount;
    }
}

