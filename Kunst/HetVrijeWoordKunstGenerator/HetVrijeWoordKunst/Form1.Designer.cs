namespace Kunstbryan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnRechthoek = new System.Windows.Forms.Button();
            this.btnLijn = new System.Windows.Forms.Button();
            this.btnWissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 247);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(33, 272);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(75, 23);
            this.btnCirkel.TabIndex = 1;
            this.btnCirkel.Text = "Cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // btnRechthoek
            // 
            this.btnRechthoek.Location = new System.Drawing.Point(163, 271);
            this.btnRechthoek.Name = "btnRechthoek";
            this.btnRechthoek.Size = new System.Drawing.Size(75, 23);
            this.btnRechthoek.TabIndex = 2;
            this.btnRechthoek.Text = "Rechthoek";
            this.btnRechthoek.UseVisualStyleBackColor = true;
            this.btnRechthoek.Click += new System.EventHandler(this.btnRechthoek_Click);
            // 
            // btnLijn
            // 
            this.btnLijn.Location = new System.Drawing.Point(282, 272);
            this.btnLijn.Name = "btnLijn";
            this.btnLijn.Size = new System.Drawing.Size(75, 23);
            this.btnLijn.TabIndex = 3;
            this.btnLijn.Text = "Lijn";
            this.btnLijn.UseVisualStyleBackColor = true;
            this.btnLijn.Click += new System.EventHandler(this.btnLijn_Click);
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(415, 272);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(75, 23);
            this.btnWissen.TabIndex = 4;
            this.btnWissen.Text = "Wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 307);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnLijn);
            this.Controls.Add(this.btnRechthoek);
            this.Controls.Add(this.btnCirkel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Button btnRechthoek;
        private System.Windows.Forms.Button btnLijn;
        private System.Windows.Forms.Button btnWissen;
    }
}

