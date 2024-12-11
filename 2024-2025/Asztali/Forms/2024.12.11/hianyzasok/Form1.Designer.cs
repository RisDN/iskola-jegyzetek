namespace hianyzasok
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
            this.table_output = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osztaly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanyadik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igazolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemIgazolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszesHianyzas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.osszesh_output = new System.Windows.Forms.Label();
            this.legtobb_h = new System.Windows.Forms.Label();
            this.mentes_btn = new System.Windows.Forms.Button();
            this.htanulok = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nev_input = new System.Windows.Forms.TextBox();
            this.osztaly_input = new System.Windows.Forms.TextBox();
            this.hanyadikan_input = new System.Windows.Forms.ComboBox();
            this.igazolt_input = new System.Windows.Forms.TextBox();
            this.nemigazolt_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_output)).BeginInit();
            this.SuspendLayout();
            // 
            // adatok_output
            // 
            this.adatok_output.Location = new System.Drawing.Point(36, 35);
            this.adatok_output.Name = "adatok_output";
            this.adatok_output.Size = new System.Drawing.Size(644, 220);
            this.adatok_output.TabIndex = 0;
            this.adatok_output.Text = "";
            // 
            // table_output
            // 
            this.table_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.osztaly,
            this.hanyadik,
            this.Igazolt,
            this.nemIgazolt,
            this.osszesHianyzas});
            this.table_output.Location = new System.Drawing.Point(36, 261);
            this.table_output.Name = "table_output";
            this.table_output.Size = new System.Drawing.Size(644, 184);
            this.table_output.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Név";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // osztaly
            // 
            this.osztaly.HeaderText = "Osztály";
            this.osztaly.Name = "osztaly";
            this.osztaly.ReadOnly = true;
            // 
            // hanyadik
            // 
            this.hanyadik.HeaderText = "Hányadik";
            this.hanyadik.Name = "hanyadik";
            this.hanyadik.ReadOnly = true;
            // 
            // Igazolt
            // 
            this.Igazolt.HeaderText = "Igazolt";
            this.Igazolt.Name = "Igazolt";
            this.Igazolt.ReadOnly = true;
            // 
            // nemIgazolt
            // 
            this.nemIgazolt.HeaderText = "Nem igazolt";
            this.nemIgazolt.Name = "nemIgazolt";
            this.nemIgazolt.ReadOnly = true;
            // 
            // osszesHianyzas
            // 
            this.osszesHianyzas.HeaderText = "Összes hiányzás";
            this.osszesHianyzas.Name = "osszesHianyzas";
            this.osszesHianyzas.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adatok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(686, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(686, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Osztály:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(686, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hányadikán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(686, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Igazolt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(686, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nem igazolt:";
            // 
            // osszesh_output
            // 
            this.osszesh_output.AutoSize = true;
            this.osszesh_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osszesh_output.Location = new System.Drawing.Point(686, 222);
            this.osszesh_output.Name = "osszesh_output";
            this.osszesh_output.Size = new System.Drawing.Size(222, 16);
            this.osszesh_output.TabIndex = 8;
            this.osszesh_output.Text = "Összes hiányzása adott napon:";
            // 
            // legtobb_h
            // 
            this.legtobb_h.AutoSize = true;
            this.legtobb_h.BackColor = System.Drawing.Color.Transparent;
            this.legtobb_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.legtobb_h.ForeColor = System.Drawing.Color.Red;
            this.legtobb_h.Location = new System.Drawing.Point(755, 303);
            this.legtobb_h.Name = "legtobb_h";
            this.legtobb_h.Size = new System.Drawing.Size(155, 20);
            this.legtobb_h.TabIndex = 9;
            this.legtobb_h.Text = "Legtöbb hiányzás:";
            // 
            // mentes_btn
            // 
            this.mentes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentes_btn.Location = new System.Drawing.Point(975, 44);
            this.mentes_btn.Name = "mentes_btn";
            this.mentes_btn.Size = new System.Drawing.Size(157, 197);
            this.mentes_btn.TabIndex = 10;
            this.mentes_btn.Text = "Mentés";
            this.mentes_btn.UseVisualStyleBackColor = true;
            this.mentes_btn.Click += new System.EventHandler(this.mentes_btn_Click);
            // 
            // htanulok
            // 
            this.htanulok.Enabled = false;
            this.htanulok.Location = new System.Drawing.Point(974, 326);
            this.htanulok.Name = "htanulok";
            this.htanulok.Size = new System.Drawing.Size(157, 108);
            this.htanulok.TabIndex = 11;
            this.htanulok.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(971, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tanulók:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(755, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Órák száma:";
            // 
            // nev_input
            // 
            this.nev_input.Location = new System.Drawing.Point(735, 35);
            this.nev_input.Name = "nev_input";
            this.nev_input.Size = new System.Drawing.Size(168, 20);
            this.nev_input.TabIndex = 14;
            // 
            // osztaly_input
            // 
            this.osztaly_input.Location = new System.Drawing.Point(758, 73);
            this.osztaly_input.Name = "osztaly_input";
            this.osztaly_input.Size = new System.Drawing.Size(143, 20);
            this.osztaly_input.TabIndex = 15;
            // 
            // hanyadikan_input
            // 
            this.hanyadikan_input.FormattingEnabled = true;
            this.hanyadikan_input.Location = new System.Drawing.Point(798, 115);
            this.hanyadikan_input.Name = "hanyadikan_input";
            this.hanyadikan_input.Size = new System.Drawing.Size(103, 21);
            this.hanyadikan_input.TabIndex = 16;
            // 
            // igazolt_input
            // 
            this.igazolt_input.Location = new System.Drawing.Point(762, 151);
            this.igazolt_input.Name = "igazolt_input";
            this.igazolt_input.Size = new System.Drawing.Size(141, 20);
            this.igazolt_input.TabIndex = 17;
            this.igazolt_input.TextChanged += new System.EventHandler(this.igazolt_input_TextChanged);
            // 
            // nemigazolt_input
            // 
            this.nemigazolt_input.Location = new System.Drawing.Point(801, 187);
            this.nemigazolt_input.Name = "nemigazolt_input";
            this.nemigazolt_input.Size = new System.Drawing.Size(100, 20);
            this.nemigazolt_input.TabIndex = 18;
            this.nemigazolt_input.TextChanged += new System.EventHandler(this.nemigazolt_input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 460);
            this.Controls.Add(this.nemigazolt_input);
            this.Controls.Add(this.igazolt_input);
            this.Controls.Add(this.hanyadikan_input);
            this.Controls.Add(this.osztaly_input);
            this.Controls.Add(this.nev_input);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.htanulok);
            this.Controls.Add(this.mentes_btn);
            this.Controls.Add(this.legtobb_h);
            this.Controls.Add(this.osszesh_output);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_output);
            this.Controls.Add(this.adatok_output);
            this.Name = "Form1";
            this.Text = "Mulasztások- szeptember hónap";
            ((System.ComponentModel.ISupportInitialize)(this.table_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox adatok_output;
        private System.Windows.Forms.DataGridView table_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn osztaly;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanyadik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igazolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemIgazolt;
        private System.Windows.Forms.DataGridViewTextBoxColumn osszesHianyzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label osszesh_output;
        private System.Windows.Forms.Label legtobb_h;
        private System.Windows.Forms.Button mentes_btn;
        private System.Windows.Forms.RichTextBox htanulok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nev_input;
        private System.Windows.Forms.TextBox osztaly_input;
        private System.Windows.Forms.ComboBox hanyadikan_input;
        private System.Windows.Forms.TextBox igazolt_input;
        private System.Windows.Forms.TextBox nemigazolt_input;
    }
}

