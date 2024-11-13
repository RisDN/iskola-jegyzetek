namespace vonat_centrum_verseny
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
            this.train = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.felso = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.train)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // train
            // 
            this.train.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.train.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.train.ImageLocation = "https://roviden.hu/media/2019/09/mav_flirt_vonat.jpg";
            this.train.Location = new System.Drawing.Point(329, 446);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(102, 167);
            this.train.TabIndex = 0;
            this.train.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // felso
            // 
            this.felso.AutoSize = true;
            this.felso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.felso.ForeColor = System.Drawing.Color.Red;
            this.felso.Location = new System.Drawing.Point(515, 36);
            this.felso.Name = "felso";
            this.felso.Size = new System.Drawing.Size(273, 25);
            this.felso.TabIndex = 2;
            this.felso.Text = "Felsővezeték szakadás!!";
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.car.BackgroundImage = global::vonat_centrum_verseny.Properties.Resources.ferrari_296GTB;
            this.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.car.ImageLocation = "https://extremautosport.hu/wp-content/uploads/2022/06/ferrari-296GTB.png";
            this.car.Location = new System.Drawing.Point(43, 193);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(136, 60);
            this.car.TabIndex = 3;
            this.car.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.car);
            this.Controls.Add(this.felso);
            this.Controls.Add(this.train);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.train)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox train;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label felso;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Button button2;
    }
}

