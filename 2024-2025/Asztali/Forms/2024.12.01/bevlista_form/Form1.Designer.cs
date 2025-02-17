namespace bevlista_form
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
            this.products_output = new System.Windows.Forms.RichTextBox();
            this.product_input = new System.Windows.Forms.TextBox();
            this.product_price_input = new System.Windows.Forms.TextBox();
            this.product_amount_input = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalamount_output = new System.Windows.Forms.Label();
            this.totalcount_output = new System.Windows.Forms.Label();
            this.mostexpensive_output = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fájlban szereplő adatok:";
            // 
            // products_output
            // 
            this.products_output.Location = new System.Drawing.Point(30, 71);
            this.products_output.Name = "products_output";
            this.products_output.ReadOnly = true;
            this.products_output.Size = new System.Drawing.Size(264, 348);
            this.products_output.TabIndex = 1;
            this.products_output.Text = "";
            // 
            // product_input
            // 
            this.product_input.Location = new System.Drawing.Point(404, 71);
            this.product_input.Name = "product_input";
            this.product_input.Size = new System.Drawing.Size(202, 20);
            this.product_input.TabIndex = 2;
            // 
            // product_price_input
            // 
            this.product_price_input.Location = new System.Drawing.Point(404, 114);
            this.product_price_input.Name = "product_price_input";
            this.product_price_input.Size = new System.Drawing.Size(110, 20);
            this.product_price_input.TabIndex = 3;
            // 
            // product_amount_input
            // 
            this.product_amount_input.FormattingEnabled = true;
            this.product_amount_input.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.product_amount_input.Location = new System.Drawing.Point(403, 154);
            this.product_amount_input.Name = "product_amount_input";
            this.product_amount_input.Size = new System.Drawing.Size(96, 21);
            this.product_amount_input.TabIndex = 4;
            this.product_amount_input.Text = "1";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(665, 81);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(99, 127);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Mentés";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tétel fizetendő:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mennyiség:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "db";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Egység ár:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Termék:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ft";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Controls.Add(this.mostexpensive_output);
            this.groupBox1.Controls.Add(this.totalcount_output);
            this.groupBox1.Controls.Add(this.totalamount_output);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(328, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 142);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok";
            // 
            // totalamount_output
            // 
            this.totalamount_output.AutoSize = true;
            this.totalamount_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount_output.Location = new System.Drawing.Point(14, 27);
            this.totalamount_output.Name = "totalamount_output";
            this.totalamount_output.Size = new System.Drawing.Size(102, 20);
            this.totalamount_output.TabIndex = 0;
            this.totalamount_output.Text = "Fizetendő ár:";
            // 
            // totalcount_output
            // 
            this.totalcount_output.AutoSize = true;
            this.totalcount_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcount_output.Location = new System.Drawing.Point(14, 57);
            this.totalcount_output.Name = "totalcount_output";
            this.totalcount_output.Size = new System.Drawing.Size(116, 20);
            this.totalcount_output.TabIndex = 1;
            this.totalcount_output.Text = "Tételek száma:";
            // 
            // mostexpensive_output
            // 
            this.mostexpensive_output.AutoSize = true;
            this.mostexpensive_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostexpensive_output.Location = new System.Drawing.Point(14, 88);
            this.mostexpensive_output.Name = "mostexpensive_output";
            this.mostexpensive_output.Size = new System.Drawing.Size(152, 20);
            this.mostexpensive_output.TabIndex = 2;
            this.mostexpensive_output.Text = "Legdrágább termék:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.product_amount_input);
            this.Controls.Add(this.product_price_input);
            this.Controls.Add(this.product_input);
            this.Controls.Add(this.products_output);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox products_output;
        private System.Windows.Forms.TextBox product_input;
        private System.Windows.Forms.TextBox product_price_input;
        private System.Windows.Forms.ComboBox product_amount_input;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mostexpensive_output;
        private System.Windows.Forms.Label totalcount_output;
        private System.Windows.Forms.Label totalamount_output;
    }
}

