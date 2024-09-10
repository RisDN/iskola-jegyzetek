namespace veletlenszamok
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
            label1 = new Label();
            min_input = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            max_input = new TextBox();
            label2 = new Label();
            count_input = new TextBox();
            label3 = new Label();
            output_numbers = new Label();
            avarage_output = new Label();
            divide_output = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Alsó határérték:";
            // 
            // min_input
            // 
            min_input.BackColor = Color.FromArgb(255, 192, 192);
            min_input.Location = new Point(179, 44);
            min_input.Name = "min_input";
            min_input.Size = new Size(104, 23);
            min_input.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(313, 200);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 2;
            button1.Text = "Átlag számítás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(313, 268);
            button2.Name = "button2";
            button2.Size = new Size(130, 43);
            button2.TabIndex = 3;
            button2.Text = "Leválogatás";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(313, 33);
            button3.Name = "button3";
            button3.Size = new Size(130, 43);
            button3.TabIndex = 4;
            button3.Text = "Generálás";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // max_input
            // 
            max_input.BackColor = Color.FromArgb(255, 192, 192);
            max_input.Location = new Point(179, 84);
            max_input.Name = "max_input";
            max_input.Size = new Size(104, 23);
            max_input.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 5;
            label2.Text = "Felső határérték:";
            // 
            // count_input
            // 
            count_input.BackColor = Color.FromArgb(255, 192, 192);
            count_input.Location = new Point(179, 124);
            count_input.Name = "count_input";
            count_input.Size = new Size(104, 23);
            count_input.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(28, 124);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 7;
            label3.Text = "Darabszám:";
            // 
            // output_numbers
            // 
            output_numbers.AutoSize = true;
            output_numbers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            output_numbers.ForeColor = Color.Red;
            output_numbers.Location = new Point(28, 165);
            output_numbers.Name = "output_numbers";
            output_numbers.Size = new Size(51, 20);
            output_numbers.TabIndex = 9;
            output_numbers.Text = "label4";
            // 
            // avarage_output
            // 
            avarage_output.AutoSize = true;
            avarage_output.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            avarage_output.ForeColor = Color.FromArgb(0, 192, 0);
            avarage_output.Location = new Point(28, 214);
            avarage_output.Name = "avarage_output";
            avarage_output.Size = new Size(51, 20);
            avarage_output.TabIndex = 10;
            avarage_output.Text = "label4";
            // 
            // divide_output
            // 
            divide_output.AutoSize = true;
            divide_output.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            divide_output.ForeColor = Color.FromArgb(0, 192, 0);
            divide_output.Location = new Point(28, 270);
            divide_output.Name = "divide_output";
            divide_output.Size = new Size(51, 20);
            divide_output.TabIndex = 11;
            divide_output.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(475, 343);
            Controls.Add(divide_output);
            Controls.Add(avarage_output);
            Controls.Add(output_numbers);
            Controls.Add(count_input);
            Controls.Add(label3);
            Controls.Add(max_input);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(min_input);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Véletlen számok - sok gombbal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox min_input;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox max_input;
        private Label label2;
        private TextBox count_input;
        private Label label3;
        private Label output_numbers;
        private Label avarage_output;
        private Label divide_output;
    }
}
