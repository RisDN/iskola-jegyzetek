namespace gondoltamegyszamot
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
            this.newGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guess_btn = new System.Windows.Forms.Button();
            this.guess_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surrenderBtn = new System.Windows.Forms.Button();
            this.feedbackOutput = new System.Windows.Forms.TextBox();
            this.to_guess = new System.Windows.Forms.Label();
            this.number_of_guesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameBtn.Location = new System.Drawing.Point(329, 241);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(118, 34);
            this.newGameBtn.TabIndex = 1;
            this.newGameBtn.Text = "Új Játék";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 és 50 között gondoltam egy számra, találd ki melyik az!";
            // 
            // guess_btn
            // 
            this.guess_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guess_btn.Location = new System.Drawing.Point(329, 83);
            this.guess_btn.Name = "guess_btn";
            this.guess_btn.Size = new System.Drawing.Size(118, 32);
            this.guess_btn.TabIndex = 3;
            this.guess_btn.Text = "Tippelek";
            this.guess_btn.UseVisualStyleBackColor = true;
            this.guess_btn.Click += new System.EventHandler(this.guess_btn_Click);
            // 
            // guess_input
            // 
            this.guess_input.Location = new System.Drawing.Point(213, 90);
            this.guess_input.Name = "guess_input";
            this.guess_input.ReadOnly = true;
            this.guess_input.Size = new System.Drawing.Size(110, 20);
            this.guess_input.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = " Szerinted melyik az?";
            // 
            // surrenderBtn
            // 
            this.surrenderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surrenderBtn.Location = new System.Drawing.Point(54, 241);
            this.surrenderBtn.Name = "surrenderBtn";
            this.surrenderBtn.Size = new System.Drawing.Size(118, 32);
            this.surrenderBtn.TabIndex = 6;
            this.surrenderBtn.Text = "Feladom";
            this.surrenderBtn.UseVisualStyleBackColor = true;
            // 
            // feedbackOutput
            // 
            this.feedbackOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feedbackOutput.Location = new System.Drawing.Point(54, 171);
            this.feedbackOutput.Name = "feedbackOutput";
            this.feedbackOutput.ReadOnly = true;
            this.feedbackOutput.Size = new System.Drawing.Size(389, 24);
            this.feedbackOutput.TabIndex = 7;
            this.feedbackOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // to_guess
            // 
            this.to_guess.AutoSize = true;
            this.to_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.to_guess.Location = new System.Drawing.Point(482, 64);
            this.to_guess.Name = "to_guess";
            this.to_guess.Size = new System.Drawing.Size(50, 16);
            this.to_guess.TabIndex = 8;
            this.to_guess.Text = "label3";
            // 
            // number_of_guesses
            // 
            this.number_of_guesses.AutoSize = true;
            this.number_of_guesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number_of_guesses.Location = new System.Drawing.Point(482, 176);
            this.number_of_guesses.Name = "number_of_guesses";
            this.number_of_guesses.Size = new System.Drawing.Size(50, 16);
            this.number_of_guesses.TabIndex = 9;
            this.number_of_guesses.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 323);
            this.Controls.Add(this.number_of_guesses);
            this.Controls.Add(this.to_guess);
            this.Controls.Add(this.feedbackOutput);
            this.Controls.Add(this.surrenderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guess_input);
            this.Controls.Add(this.guess_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newGameBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Játék: Gondoltam egy számra...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guess_btn;
        private System.Windows.Forms.TextBox guess_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button surrenderBtn;
        private System.Windows.Forms.TextBox feedbackOutput;
        private System.Windows.Forms.Label to_guess;
        private System.Windows.Forms.Label number_of_guesses;
    }
}

