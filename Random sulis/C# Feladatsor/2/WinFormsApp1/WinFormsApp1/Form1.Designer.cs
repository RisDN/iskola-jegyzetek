
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
            this.button1 = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.keresztnev_kijelzo = new System.Windows.Forms.TextBox();
            this.vezeteknev_kijelzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hossz_kijelzo = new System.Windows.Forms.TextBox();
            this.kijelzo = new System.Windows.Forms.Label();
            this.torles = new System.Windows.Forms.Button();
            this.vege = new System.Windows.Forms.Button();
            this.doktor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem a nevet: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Üdvözlés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(26, 47);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(287, 23);
            this.input.TabIndex = 2;
            // 
            // keresztnev_kijelzo
            // 
            this.keresztnev_kijelzo.Location = new System.Drawing.Point(160, 147);
            this.keresztnev_kijelzo.Name = "keresztnev_kijelzo";
            this.keresztnev_kijelzo.ReadOnly = true;
            this.keresztnev_kijelzo.Size = new System.Drawing.Size(153, 23);
            this.keresztnev_kijelzo.TabIndex = 3;
            // 
            // vezeteknev_kijelzo
            // 
            this.vezeteknev_kijelzo.Location = new System.Drawing.Point(160, 93);
            this.vezeteknev_kijelzo.Name = "vezeteknev_kijelzo";
            this.vezeteknev_kijelzo.ReadOnly = true;
            this.vezeteknev_kijelzo.Size = new System.Drawing.Size(153, 23);
            this.vezeteknev_kijelzo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vezetéknév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keresztnév: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "A név hossza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(243, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "karakter.";
            // 
            // hossz_kijelzo
            // 
            this.hossz_kijelzo.Location = new System.Drawing.Point(150, 203);
            this.hossz_kijelzo.Name = "hossz_kijelzo";
            this.hossz_kijelzo.ReadOnly = true;
            this.hossz_kijelzo.Size = new System.Drawing.Size(87, 23);
            this.hossz_kijelzo.TabIndex = 9;
            this.hossz_kijelzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kijelzo
            // 
            this.kijelzo.AutoSize = true;
            this.kijelzo.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kijelzo.Location = new System.Drawing.Point(45, 244);
            this.kijelzo.Name = "kijelzo";
            this.kijelzo.Size = new System.Drawing.Size(0, 20);
            this.kijelzo.TabIndex = 10;
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(44, 337);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(75, 23);
            this.torles.TabIndex = 11;
            this.torles.Text = "Törlés";
            this.torles.UseMnemonic = false;
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // vege
            // 
            this.vege.Location = new System.Drawing.Point(215, 337);
            this.vege.Name = "vege";
            this.vege.Size = new System.Drawing.Size(75, 23);
            this.vege.TabIndex = 12;
            this.vege.Text = "Vége";
            this.vege.UseMnemonic = false;
            this.vege.UseVisualStyleBackColor = true;
            // 
            // doktor
            // 
            this.doktor.Location = new System.Drawing.Point(215, 296);
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(75, 23);
            this.doktor.TabIndex = 13;
            this.doktor.Text = "Doktor";
            this.doktor.UseVisualStyleBackColor = true;
            this.doktor.Click += new System.EventHandler(this.doktor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 386);
            this.Controls.Add(this.doktor);
            this.Controls.Add(this.vege);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.kijelzo);
            this.Controls.Add(this.hossz_kijelzo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vezeteknev_kijelzo);
            this.Controls.Add(this.keresztnev_kijelzo);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox keresztnev_kijelzo;
        private System.Windows.Forms.TextBox vezeteknev_kijelzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hossz_kijelzo;
        private System.Windows.Forms.Label kijelzo;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Button vege;
        private System.Windows.Forms.Button doktor;
    }
}

