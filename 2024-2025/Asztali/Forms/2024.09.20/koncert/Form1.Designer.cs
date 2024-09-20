namespace koncert
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siting_count = new System.Windows.Forms.ComboBox();
            this.sitting_2 = new System.Windows.Forms.RadioButton();
            this.sitting_1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.standing_count = new System.Windows.Forms.ComboBox();
            this.standing_2 = new System.Windows.Forms.RadioButton();
            this.standing_1 = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.Label();
            this.újVásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újVásárlásToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.siting_count);
            this.groupBox1.Controls.Add(this.sitting_2);
            this.groupBox1.Controls.Add(this.sitting_1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(23, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Ülőhely";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(237, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mennyiség (db)";
            // 
            // siting_count
            // 
            this.siting_count.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siting_count.FormattingEnabled = true;
            this.siting_count.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.siting_count.Location = new System.Drawing.Point(231, 54);
            this.siting_count.Name = "siting_count";
            this.siting_count.Size = new System.Drawing.Size(121, 28);
            this.siting_count.TabIndex = 2;
            this.siting_count.SelectedIndexChanged += new System.EventHandler(this.siting_count_SelectedIndexChanged);
            // 
            // sitting_2
            // 
            this.sitting_2.AutoSize = true;
            this.sitting_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sitting_2.Location = new System.Drawing.Point(18, 77);
            this.sitting_2.Name = "sitting_2";
            this.sitting_2.Size = new System.Drawing.Size(183, 20);
            this.sitting_2.TabIndex = 1;
            this.sitting_2.TabStop = true;
            this.sitting_2.Text = "2. árkategória - 2990 Ft";
            this.sitting_2.UseVisualStyleBackColor = true;
            this.sitting_2.CheckedChanged += new System.EventHandler(this.sitting_2_CheckedChanged);
            // 
            // sitting_1
            // 
            this.sitting_1.AutoSize = true;
            this.sitting_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sitting_1.Location = new System.Drawing.Point(18, 35);
            this.sitting_1.Name = "sitting_1";
            this.sitting_1.Size = new System.Drawing.Size(183, 20);
            this.sitting_1.TabIndex = 0;
            this.sitting_1.TabStop = true;
            this.sitting_1.Text = "1. árkategória - 1990 Ft\r\n";
            this.sitting_1.UseVisualStyleBackColor = true;
            this.sitting_1.CheckedChanged += new System.EventHandler(this.sitting_1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újVásárlásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.standing_count);
            this.groupBox2.Controls.Add(this.standing_2);
            this.groupBox2.Controls.Add(this.standing_1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(23, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Állóhely";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(237, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mennyiség (db)";
            // 
            // standing_count
            // 
            this.standing_count.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.standing_count.FormattingEnabled = true;
            this.standing_count.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.standing_count.Location = new System.Drawing.Point(231, 54);
            this.standing_count.Name = "standing_count";
            this.standing_count.Size = new System.Drawing.Size(121, 28);
            this.standing_count.TabIndex = 2;
            this.standing_count.SelectedIndexChanged += new System.EventHandler(this.standing_count_SelectedIndexChanged);
            // 
            // standing_2
            // 
            this.standing_2.AutoSize = true;
            this.standing_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.standing_2.Location = new System.Drawing.Point(18, 77);
            this.standing_2.Name = "standing_2";
            this.standing_2.Size = new System.Drawing.Size(183, 20);
            this.standing_2.TabIndex = 1;
            this.standing_2.TabStop = true;
            this.standing_2.Text = "2. árkategória - 2190 Ft";
            this.standing_2.UseVisualStyleBackColor = true;
            this.standing_2.CheckedChanged += new System.EventHandler(this.standing_2_CheckedChanged);
            // 
            // standing_1
            // 
            this.standing_1.AutoSize = true;
            this.standing_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.standing_1.Location = new System.Drawing.Point(18, 35);
            this.standing_1.Name = "standing_1";
            this.standing_1.Size = new System.Drawing.Size(183, 20);
            this.standing_1.TabIndex = 0;
            this.standing_1.TabStop = true;
            this.standing_1.Text = "1. árkategória - 1490 Ft";
            this.standing_1.UseVisualStyleBackColor = true;
            this.standing_1.CheckedChanged += new System.EventHandler(this.standing_1_CheckedChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.output.Location = new System.Drawing.Point(18, 361);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 25);
            this.output.TabIndex = 3;
            // 
            // újVásárlásToolStripMenuItem
            // 
            this.újVásárlásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újVásárlásToolStripMenuItem1,
            this.kilépésToolStripMenuItem});
            this.újVásárlásToolStripMenuItem.Name = "újVásárlásToolStripMenuItem";
            this.újVásárlásToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.újVásárlásToolStripMenuItem.Text = "Jegyvásárlás";
            // 
            // újVásárlásToolStripMenuItem1
            // 
            this.újVásárlásToolStripMenuItem1.Name = "újVásárlásToolStripMenuItem1";
            this.újVásárlásToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.újVásárlásToolStripMenuItem1.Text = "Új vásárlás";
            this.újVásárlásToolStripMenuItem1.Click += new System.EventHandler(this.újVásárlásToolStripMenuItem1_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 412);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Koncert jegyvásárlás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sitting_1;
        private System.Windows.Forms.RadioButton sitting_2;
        private System.Windows.Forms.ComboBox siting_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox standing_count;
        private System.Windows.Forms.RadioButton standing_2;
        private System.Windows.Forms.RadioButton standing_1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.ToolStripMenuItem újVásárlásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újVásárlásToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}

