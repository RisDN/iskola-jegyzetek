namespace homerseklet
{
    partial class AdatokRogzitese
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.azonosito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napszak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homerseklet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csapadek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.input_azonosito = new System.Windows.Forms.TextBox();
            this.input_varos = new System.Windows.Forms.TextBox();
            this.input_datum = new System.Windows.Forms.DateTimePicker();
            this.input_homerseklet = new System.Windows.Forms.TextBox();
            this.input_csapadek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_napszak = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azonosito,
            this.varos,
            this.napszak,
            this.datum,
            this.homerseklet,
            this.csapadek});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(13, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
          
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(745, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Művelet";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Módosítás";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Új felvétele";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // azonosito
            // 
            this.azonosito.HeaderText = "Azonosító";
            this.azonosito.Name = "azonosito";
            this.azonosito.ReadOnly = true;
            // 
            // varos
            // 
            this.varos.HeaderText = "Város";
            this.varos.Name = "varos";
            this.varos.ReadOnly = true;
            // 
            // napszak
            // 
            this.napszak.HeaderText = "Napszak";
            this.napszak.Name = "napszak";
            this.napszak.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // homerseklet
            // 
            this.homerseklet.HeaderText = "Mért hőmérséklet";
            this.homerseklet.Name = "homerseklet";
            this.homerseklet.ReadOnly = true;
            // 
            // csapadek
            // 
            this.csapadek.HeaderText = "Mért csapadék";
            this.csapadek.Name = "csapadek";
            this.csapadek.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Elvetés";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // input_azonosito
            // 
            this.input_azonosito.Location = new System.Drawing.Point(801, 167);
            this.input_azonosito.Name = "input_azonosito";
            this.input_azonosito.Size = new System.Drawing.Size(139, 20);
            this.input_azonosito.TabIndex = 4;
            // 
            // input_varos
            // 
            this.input_varos.Location = new System.Drawing.Point(801, 204);
            this.input_varos.MaxLength = 40;
            this.input_varos.Name = "input_varos";
            this.input_varos.Size = new System.Drawing.Size(139, 20);
            this.input_varos.TabIndex = 5;
            // 
            // input_datum
            // 
            this.input_datum.CustomFormat = "yyyy-MM-dd";
            this.input_datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.input_datum.Location = new System.Drawing.Point(801, 269);
            this.input_datum.Name = "input_datum";
            this.input_datum.Size = new System.Drawing.Size(139, 20);
            this.input_datum.TabIndex = 6;
            // 
            // input_homerseklet
            // 
            this.input_homerseklet.Location = new System.Drawing.Point(801, 305);
            this.input_homerseklet.Name = "input_homerseklet";
            this.input_homerseklet.Size = new System.Drawing.Size(139, 20);
            this.input_homerseklet.TabIndex = 7;
            // 
            // input_csapadek
            // 
            this.input_csapadek.Location = new System.Drawing.Point(801, 341);
            this.input_csapadek.Name = "input_csapadek";
            this.input_csapadek.Size = new System.Drawing.Size(139, 20);
            this.input_csapadek.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Város:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mért hőmérséklet: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dátum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mért csapadék:";
            // 
            // input_napszak
            // 
            this.input_napszak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_napszak.FormattingEnabled = true;
            this.input_napszak.Items.AddRange(new object[] {
            "reggel",
            "délelőtt",
            "délután",
            "este",
            "éjszaka"});
            this.input_napszak.Location = new System.Drawing.Point(801, 236);
            this.input_napszak.Name = "input_napszak";
            this.input_napszak.Size = new System.Drawing.Size(137, 21);
            this.input_napszak.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Napszak:";
            // 
            // AdatokRogzitese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_napszak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_csapadek);
            this.Controls.Add(this.input_homerseklet);
            this.Controls.Add(this.input_datum);
            this.Controls.Add(this.input_varos);
            this.Controls.Add(this.input_azonosito);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdatokRogzitese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adatok rögzítése";
            this.Load += new System.EventHandler(this.AdatokRogzitese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn azonosito;
        private System.Windows.Forms.DataGridViewTextBoxColumn varos;
        private System.Windows.Forms.DataGridViewTextBoxColumn napszak;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn homerseklet;
        private System.Windows.Forms.DataGridViewTextBoxColumn csapadek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox input_azonosito;
        private System.Windows.Forms.TextBox input_varos;
        private System.Windows.Forms.DateTimePicker input_datum;
        private System.Windows.Forms.TextBox input_homerseklet;
        private System.Windows.Forms.TextBox input_csapadek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox input_napszak;
        private System.Windows.Forms.Label label6;
    }
}