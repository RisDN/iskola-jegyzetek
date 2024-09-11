namespace homerseklet
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
            this.heat_input = new System.Windows.Forms.TextBox();
            this.days_input = new System.Windows.Forms.TextBox();
            this.avarage_output = new System.Windows.Forms.TextBox();
            this.min_output = new System.Windows.Forms.TextBox();
            this.heat_output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heat_input
            // 
            this.heat_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.heat_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.heat_input.Location = new System.Drawing.Point(194, 72);
            this.heat_input.Name = "heat_input";
            this.heat_input.Size = new System.Drawing.Size(100, 20);
            this.heat_input.TabIndex = 0;
            // 
            // days_input
            // 
            this.days_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.days_input.ForeColor = System.Drawing.SystemColors.WindowText;
            this.days_input.Location = new System.Drawing.Point(194, 38);
            this.days_input.Name = "days_input";
            this.days_input.Size = new System.Drawing.Size(100, 20);
            this.days_input.TabIndex = 1;
            // 
            // avarage_output
            // 
            this.avarage_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.avarage_output.Enabled = false;
            this.avarage_output.ForeColor = System.Drawing.SystemColors.WindowText;
            this.avarage_output.Location = new System.Drawing.Point(214, 166);
            this.avarage_output.Name = "avarage_output";
            this.avarage_output.ReadOnly = true;
            this.avarage_output.Size = new System.Drawing.Size(100, 20);
            this.avarage_output.TabIndex = 3;
            // 
            // min_output
            // 
            this.min_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.min_output.Enabled = false;
            this.min_output.ForeColor = System.Drawing.SystemColors.WindowText;
            this.min_output.Location = new System.Drawing.Point(271, 202);
            this.min_output.Name = "min_output";
            this.min_output.ReadOnly = true;
            this.min_output.Size = new System.Drawing.Size(100, 20);
            this.min_output.TabIndex = 4;
            // 
            // heat_output
            // 
            this.heat_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.heat_output.Enabled = false;
            this.heat_output.ForeColor = System.Drawing.SystemColors.WindowText;
            this.heat_output.Location = new System.Drawing.Point(320, 239);
            this.heat_output.Name = "heat_output";
            this.heat_output.ReadOnly = true;
            this.heat_output.Size = new System.Drawing.Size(100, 20);
            this.heat_output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Napok száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hőmérséklet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Átlagos hőmérséklet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Legalacsonyabb hőmérséklet:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(49, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Megadott hőmérsékletű napok száma";
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateBtn.Location = new System.Drawing.Point(505, 56);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(109, 71);
            this.generateBtn.TabIndex = 11;
            this.generateBtn.Text = "Generálás";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.Location = new System.Drawing.Point(505, 175);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(109, 71);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output.ForeColor = System.Drawing.Color.Red;
            this.output.Location = new System.Drawing.Point(53, 123);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 16);
            this.output.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(693, 311);
            this.Controls.Add(this.output);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heat_output);
            this.Controls.Add(this.min_output);
            this.Controls.Add(this.avarage_output);
            this.Controls.Add(this.days_input);
            this.Controls.Add(this.heat_input);
            this.Name = "Form1";
            this.Text = "Júniusi hőmérsékletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heat_input;
        private System.Windows.Forms.TextBox days_input;
        private System.Windows.Forms.TextBox avarage_output;
        private System.Windows.Forms.TextBox min_output;
        private System.Windows.Forms.TextBox heat_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label output;
    }
}

