namespace valutavalto
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adatokRögzítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devizanemekRögzítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.árfolyamokRögzítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valutaváltásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatokRögzítéseToolStripMenuItem,
            this.valutaváltásToolStripMenuItem,
            this.statisztikaToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adatokRögzítéseToolStripMenuItem
            // 
            this.adatokRögzítéseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devizanemekRögzítéseToolStripMenuItem,
            this.árfolyamokRögzítéseToolStripMenuItem});
            this.adatokRögzítéseToolStripMenuItem.Name = "adatokRögzítéseToolStripMenuItem";
            this.adatokRögzítéseToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.adatokRögzítéseToolStripMenuItem.Text = "Adatok rögzítése";
            // 
            // devizanemekRögzítéseToolStripMenuItem
            // 
            this.devizanemekRögzítéseToolStripMenuItem.Name = "devizanemekRögzítéseToolStripMenuItem";
            this.devizanemekRögzítéseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.devizanemekRögzítéseToolStripMenuItem.Text = "Devizanemek rögzítése";
            this.devizanemekRögzítéseToolStripMenuItem.Click += new System.EventHandler(this.devizanemekRögzítéseToolStripMenuItem_Click);
            // 
            // árfolyamokRögzítéseToolStripMenuItem
            // 
            this.árfolyamokRögzítéseToolStripMenuItem.Name = "árfolyamokRögzítéseToolStripMenuItem";
            this.árfolyamokRögzítéseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.árfolyamokRögzítéseToolStripMenuItem.Text = "Árfolyamok rögzítése";
            // 
            // valutaváltásToolStripMenuItem
            // 
            this.valutaváltásToolStripMenuItem.Name = "valutaváltásToolStripMenuItem";
            this.valutaváltásToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.valutaváltásToolStripMenuItem.Text = "Valutaváltás";
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.statisztikaToolStripMenuItem.Text = "Statisztika";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adatokRögzítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devizanemekRögzítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem árfolyamokRögzítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valutaváltásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

