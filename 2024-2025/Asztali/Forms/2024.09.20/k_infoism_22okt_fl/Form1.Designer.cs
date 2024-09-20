namespace k_infoism_22okt_fl
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
            this.m_output = new System.Windows.Forms.Label();
            this.km_output = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Táv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idő [óra:perc:mp]:";
            // 
            // m_output
            // 
            this.m_output.AutoSize = true;
            this.m_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m_output.Location = new System.Drawing.Point(12, 193);
            this.m_output.Name = "m_output";
            this.m_output.Size = new System.Drawing.Size(156, 20);
            this.m_output.TabIndex = 3;
            this.m_output.Text = "Átlagsebesség [m/s]:";
            // 
            // km_output
            // 
            this.km_output.AutoSize = true;
            this.km_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.km_output.Location = new System.Drawing.Point(12, 150);
            this.km_output.Name = "km_output";
            this.km_output.Size = new System.Drawing.Size(165, 20);
            this.km_output.TabIndex = 2;
            this.km_output.Text = "Átlagsebesség [km/h]:";
            // 
            // distance
            // 
            this.distance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distance.FormattingEnabled = true;
            this.distance.Items.AddRange(new object[] {
            "Mini - 16km",
            "Rövid - 38km ",
            "Pedelec - 54km",
            "Közép - 57km ",
            "Hosszú - 94km"});
            this.distance.Location = new System.Drawing.Point(75, 32);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(177, 21);
            this.distance.TabIndex = 4;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(162, 85);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(90, 20);
            this.time.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 84);
            this.button1.TabIndex = 6;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.m_output);
            this.Controls.Add(this.km_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bükk Maraton 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_output;
        private System.Windows.Forms.Label km_output;
        private System.Windows.Forms.ComboBox distance;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button button1;
    }
}

