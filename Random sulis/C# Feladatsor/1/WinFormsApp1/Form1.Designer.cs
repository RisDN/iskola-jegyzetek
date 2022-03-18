
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.udvozol = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.vezeteknev_box = new System.Windows.Forms.TextBox();
            this.keresztnev_box = new System.Windows.Forms.TextBox();
            this.telszam_box = new System.Windows.Forms.TextBox();
            this.kijelzo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezetéknév: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonszám:";
            // 
            // udvozol
            // 
            this.udvozol.Location = new System.Drawing.Point(83, 258);
            this.udvozol.Name = "udvozol";
            this.udvozol.Size = new System.Drawing.Size(75, 23);
            this.udvozol.TabIndex = 3;
            this.udvozol.Text = "Üdvözöl";
            this.udvozol.UseVisualStyleBackColor = true;
            this.udvozol.Click += new System.EventHandler(this.udvozol_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(190, 258);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "Bezár";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // vezeteknev_box
            // 
            this.vezeteknev_box.Location = new System.Drawing.Point(142, 46);
            this.vezeteknev_box.Name = "vezeteknev_box";
            this.vezeteknev_box.Size = new System.Drawing.Size(100, 23);
            this.vezeteknev_box.TabIndex = 5;
            // 
            // keresztnev_box
            // 
            this.keresztnev_box.Location = new System.Drawing.Point(142, 89);
            this.keresztnev_box.Name = "keresztnev_box";
            this.keresztnev_box.Size = new System.Drawing.Size(100, 23);
            this.keresztnev_box.TabIndex = 6;
            // 
            // telszam_box
            // 
            this.telszam_box.Location = new System.Drawing.Point(142, 132);
            this.telszam_box.Name = "telszam_box";
            this.telszam_box.Size = new System.Drawing.Size(100, 23);
            this.telszam_box.TabIndex = 7;
            // 
            // kijelzo
            // 
            this.kijelzo.BackColor = System.Drawing.Color.DarkKhaki;
            this.kijelzo.Cursor = System.Windows.Forms.Cursors.Default;
            this.kijelzo.ForeColor = System.Drawing.Color.LemonChiffon;
            this.kijelzo.Location = new System.Drawing.Point(105, 180);
            this.kijelzo.Multiline = true;
            this.kijelzo.Name = "kijelzo";
            this.kijelzo.ReadOnly = true;
            this.kijelzo.Size = new System.Drawing.Size(150, 59);
            this.kijelzo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 321);
            this.Controls.Add(this.kijelzo);
            this.Controls.Add(this.telszam_box);
            this.Controls.Add(this.keresztnev_box);
            this.Controls.Add(this.vezeteknev_box);
            this.Controls.Add(this.close);
            this.Controls.Add(this.udvozol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Üdvözlet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button udvozol;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox vezeteknev_box;
        private System.Windows.Forms.TextBox keresztnev_box;
        private System.Windows.Forms.TextBox telszam_box;
        private System.Windows.Forms.TextBox kijelzo;
    }
}

