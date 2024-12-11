namespace szalloda
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
            this.adatok_output = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ejszakak_input = new System.Windows.Forms.ComboBox();
            this.nev_input = new System.Windows.Forms.TextBox();
            this.vendegek_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tip_teljes = new System.Windows.Forms.RadioButton();
            this.tip_fel = new System.Windows.Forms.RadioButton();
            this.tip_nincs = new System.Windows.Forms.RadioButton();
            this.sum_vendegej = new System.Windows.Forms.Label();
            this.teljesellatasok = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.torzsvendegek_output = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adatok_output
            // 
            this.adatok_output.Enabled = false;
            this.adatok_output.Location = new System.Drawing.Point(37, 30);
            this.adatok_output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adatok_output.Name = "adatok_output";
            this.adatok_output.Size = new System.Drawing.Size(419, 264);
            this.adatok_output.TabIndex = 0;
            this.adatok_output.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.torzsvendegek_output);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.teljesellatasok);
            this.panel1.Controls.Add(this.sum_vendegej);
            this.panel1.Location = new System.Drawing.Point(37, 331);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 131);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(486, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendég neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(486, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Éjszakák száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(486, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendégek száma:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tip_nincs);
            this.groupBox1.Controls.Add(this.tip_fel);
            this.groupBox1.Controls.Add(this.tip_teljes);
            this.groupBox1.Location = new System.Drawing.Point(490, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ellátás típúsa";
            // 
            // ejszakak_input
            // 
            this.ejszakak_input.FormattingEnabled = true;
            this.ejszakak_input.Location = new System.Drawing.Point(645, 93);
            this.ejszakak_input.Name = "ejszakak_input";
            this.ejszakak_input.Size = new System.Drawing.Size(124, 21);
            this.ejszakak_input.TabIndex = 6;
            // 
            // nev_input
            // 
            this.nev_input.Location = new System.Drawing.Point(621, 49);
            this.nev_input.Name = "nev_input";
            this.nev_input.Size = new System.Drawing.Size(148, 20);
            this.nev_input.TabIndex = 7;
            // 
            // vendegek_input
            // 
            this.vendegek_input.Location = new System.Drawing.Point(650, 139);
            this.vendegek_input.Name = "vendegek_input";
            this.vendegek_input.Size = new System.Drawing.Size(119, 20);
            this.vendegek_input.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(789, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 86);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(789, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 85);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tip_teljes
            // 
            this.tip_teljes.AutoSize = true;
            this.tip_teljes.Location = new System.Drawing.Point(6, 19);
            this.tip_teljes.Name = "tip_teljes";
            this.tip_teljes.Size = new System.Drawing.Size(55, 17);
            this.tip_teljes.TabIndex = 1;
            this.tip_teljes.TabStop = true;
            this.tip_teljes.Text = "teljes";
            this.tip_teljes.UseVisualStyleBackColor = true;
            // 
            // tip_fel
            // 
            this.tip_fel.AutoSize = true;
            this.tip_fel.Location = new System.Drawing.Point(6, 42);
            this.tip_fel.Name = "tip_fel";
            this.tip_fel.Size = new System.Drawing.Size(80, 17);
            this.tip_fel.TabIndex = 2;
            this.tip_fel.TabStop = true;
            this.tip_fel.Text = "fél panzió";
            this.tip_fel.UseVisualStyleBackColor = true;
            // 
            // tip_nincs
            // 
            this.tip_nincs.AutoSize = true;
            this.tip_nincs.Location = new System.Drawing.Point(6, 68);
            this.tip_nincs.Name = "tip_nincs";
            this.tip_nincs.Size = new System.Drawing.Size(55, 17);
            this.tip_nincs.TabIndex = 3;
            this.tip_nincs.TabStop = true;
            this.tip_nincs.Text = "nincs";
            this.tip_nincs.UseVisualStyleBackColor = true;
            // 
            // sum_vendegej
            // 
            this.sum_vendegej.AutoSize = true;
            this.sum_vendegej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum_vendegej.Location = new System.Drawing.Point(16, 17);
            this.sum_vendegej.Name = "sum_vendegej";
            this.sum_vendegej.Size = new System.Drawing.Size(289, 20);
            this.sum_vendegej.TabIndex = 11;
            this.sum_vendegej.Text = "Vendég éjszakák száma összesen:";
            // 
            // teljesellatasok
            // 
            this.teljesellatasok.AutoSize = true;
            this.teljesellatasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teljesellatasok.Location = new System.Drawing.Point(16, 80);
            this.teljesellatasok.Name = "teljesellatasok";
            this.teljesellatasok.Size = new System.Drawing.Size(307, 20);
            this.teljesellatasok.TabIndex = 12;
            this.teljesellatasok.Text = "A teljes ellátást igénybevevők száma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(580, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Törzsvendégek:";
            // 
            // torzsvendegek_output
            // 
            this.torzsvendegek_output.Enabled = false;
            this.torzsvendegek_output.Location = new System.Drawing.Point(590, 47);
            this.torzsvendegek_output.Name = "torzsvendegek_output";
            this.torzsvendegek_output.Size = new System.Drawing.Size(194, 73);
            this.torzsvendegek_output.TabIndex = 14;
            this.torzsvendegek_output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(933, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vendegek_input);
            this.Controls.Add(this.nev_input);
            this.Controls.Add(this.ejszakak_input);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adatok_output);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox adatok_output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ejszakak_input;
        private System.Windows.Forms.TextBox nev_input;
        private System.Windows.Forms.TextBox vendegek_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton tip_nincs;
        private System.Windows.Forms.RadioButton tip_fel;
        private System.Windows.Forms.RadioButton tip_teljes;
        private System.Windows.Forms.Label sum_vendegej;
        private System.Windows.Forms.Label teljesellatasok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox torzsvendegek_output;
    }
}

