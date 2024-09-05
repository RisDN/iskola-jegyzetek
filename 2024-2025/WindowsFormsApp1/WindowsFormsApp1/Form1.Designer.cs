namespace WindowsFormsApp1
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
            this.info = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timerOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(95, 216);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(250, 33);
            this.info.TabIndex = 0;
            this.info.Text = "Add meg a neved:";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.output.Location = new System.Drawing.Point(54, 37);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 37);
            this.output.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(141, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mehet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(75, 252);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(285, 20);
            this.inputField.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start Timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerOutput
            // 
            this.timerOutput.AutoSize = true;
            this.timerOutput.Location = new System.Drawing.Point(358, 324);
            this.timerOutput.Name = "timerOutput";
            this.timerOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timerOutput.Size = new System.Drawing.Size(0, 13);
            this.timerOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 375);
            this.Controls.Add(this.timerOutput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label timerOutput;
    }
}

