namespace vonatjegy1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.km_input = new System.Windows.Forms.TextBox();
            this.type_input = new System.Windows.Forms.ComboBox();
            this.kieg_input = new System.Windows.Forms.ComboBox();
            this.price_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menetjegy ára 1 km - 25 Ft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adja meg a km-t egészre kerekítve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menetjegy típúsa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(36, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kiegészítő jegy";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(510, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.Location = new System.Drawing.Point(510, 260);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 42);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // km_input
            // 
            this.km_input.Location = new System.Drawing.Point(348, 92);
            this.km_input.Name = "km_input";
            this.km_input.Size = new System.Drawing.Size(132, 20);
            this.km_input.TabIndex = 6;
            // 
            // type_input
            // 
            this.type_input.FormattingEnabled = true;
            this.type_input.Items.AddRange(new object[] {
            "50%-os kedvezmény",
            "90%-os kedvezmény",
            "Teljes árú"});
            this.type_input.Location = new System.Drawing.Point(195, 139);
            this.type_input.Name = "type_input";
            this.type_input.Size = new System.Drawing.Size(121, 21);
            this.type_input.TabIndex = 7;
            this.type_input.SelectedIndexChanged += new System.EventHandler(this.type_input_SelectedIndexChanged);
            // 
            // kieg_input
            // 
            this.kieg_input.FormattingEnabled = true;
            this.kieg_input.Items.AddRange(new object[] {
            "Nem",
            "Igen"});
            this.kieg_input.Location = new System.Drawing.Point(195, 187);
            this.kieg_input.Name = "kieg_input";
            this.kieg_input.Size = new System.Drawing.Size(121, 21);
            this.kieg_input.TabIndex = 8;
            this.kieg_input.SelectedIndexChanged += new System.EventHandler(this.kieg_input_SelectedIndexChanged);
            // 
            // price_output
            // 
            this.price_output.AutoSize = true;
            this.price_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price_output.ForeColor = System.Drawing.Color.Red;
            this.price_output.Location = new System.Drawing.Point(40, 260);
            this.price_output.Name = "price_output";
            this.price_output.Size = new System.Drawing.Size(0, 25);
            this.price_output.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 362);
            this.Controls.Add(this.price_output);
            this.Controls.Add(this.kieg_input);
            this.Controls.Add(this.type_input);
            this.Controls.Add(this.km_input);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menetjegy 1. verzió";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox km_input;
        private System.Windows.Forms.ComboBox type_input;
        private System.Windows.Forms.ComboBox kieg_input;
        private System.Windows.Forms.Label price_output;
    }
}

