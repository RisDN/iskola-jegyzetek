namespace valutavalto
{
    partial class Deviza
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
            this.dev_input = new System.Windows.Forms.TextBox();
            this.dev_name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviza rövid kódja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deviza neve:";
            // 
            // dev_input
            // 
            this.dev_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dev_input.Location = new System.Drawing.Point(218, 46);
            this.dev_input.MaxLength = 3;
            this.dev_input.Name = "dev_input";
            this.dev_input.Size = new System.Drawing.Size(57, 20);
            this.dev_input.TabIndex = 4;
            this.dev_input.TextChanged += new System.EventHandler(this.dev_input_TextChanged);
            // 
            // dev_name
            // 
            this.dev_name.Location = new System.Drawing.Point(218, 93);
            this.dev_name.Name = "dev_name";
            this.dev_name.Size = new System.Drawing.Size(124, 20);
            this.dev_name.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = global::valutavalto.Properties.Resources.elvet;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(241, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Elvet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = global::valutavalto.Properties.Resources.oke;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(71, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Deviza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 283);
            this.Controls.Add(this.dev_name);
            this.Controls.Add(this.dev_input);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Deviza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devizanemek rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dev_input;
        private System.Windows.Forms.TextBox dev_name;
    }
}