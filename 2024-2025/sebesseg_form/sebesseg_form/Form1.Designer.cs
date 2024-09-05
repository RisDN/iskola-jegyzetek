namespace sebesseg_form
{
    partial class main
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
            this.km = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.pathinput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hourinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedoutput = new System.Windows.Forms.TextBox();
            this.kmperh = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.speedlimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.km.Location = new System.Drawing.Point(263, 88);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(25, 16);
            this.km.TabIndex = 0;
            this.km.Text = "km";
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upload.Location = new System.Drawing.Point(42, 247);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(125, 62);
            this.upload.TabIndex = 1;
            this.upload.Text = "Számol";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // pathinput
            // 
            this.pathinput.Location = new System.Drawing.Point(141, 87);
            this.pathinput.Name = "pathinput";
            this.pathinput.Size = new System.Drawing.Size(100, 20);
            this.pathinput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Megtett út:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Idő:";
            // 
            // hourinput
            // 
            this.hourinput.Location = new System.Drawing.Point(142, 133);
            this.hourinput.Name = "hourinput";
            this.hourinput.Size = new System.Drawing.Size(100, 20);
            this.hourinput.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(264, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "óra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sebesség:";
            // 
            // speedoutput
            // 
            this.speedoutput.Location = new System.Drawing.Point(142, 178);
            this.speedoutput.Name = "speedoutput";
            this.speedoutput.ReadOnly = true;
            this.speedoutput.Size = new System.Drawing.Size(100, 20);
            this.speedoutput.TabIndex = 12;
            // 
            // kmperh
            // 
            this.kmperh.AutoSize = true;
            this.kmperh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kmperh.Location = new System.Drawing.Point(264, 179);
            this.kmperh.Name = "kmperh";
            this.kmperh.Size = new System.Drawing.Size(49, 16);
            this.kmperh.TabIndex = 11;
            this.kmperh.Text = "km/óra";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(210, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // speedlimit
            // 
            this.speedlimit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedlimit.AutoSize = true;
            this.speedlimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedlimit.Location = new System.Drawing.Point(13, 207);
            this.speedlimit.Name = "speedlimit";
            this.speedlimit.Size = new System.Drawing.Size(0, 20);
            this.speedlimit.TabIndex = 15;
            this.speedlimit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 349);
            this.Controls.Add(this.speedlimit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedoutput);
            this.Controls.Add(this.kmperh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathinput);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.km);
            this.Name = "main";
            this.Text = "Sebesség kalkulátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox pathinput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hourinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedoutput;
        private System.Windows.Forms.Label kmperh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label speedlimit;
    }
}

