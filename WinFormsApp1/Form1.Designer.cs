
namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelVoittaja = new System.Windows.Forms.Label();
            this.labelPelaaja2 = new System.Windows.Forms.Label();
            this.labelPelaaja1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pelaaja1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pelaaja2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "alusta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelVoittaja
            // 
            this.labelVoittaja.AutoSize = true;
            this.labelVoittaja.Location = new System.Drawing.Point(244, 68);
            this.labelVoittaja.Name = "labelVoittaja";
            this.labelVoittaja.Size = new System.Drawing.Size(0, 15);
            this.labelVoittaja.TabIndex = 3;
            // 
            // labelPelaaja2
            // 
            this.labelPelaaja2.AutoSize = true;
            this.labelPelaaja2.Location = new System.Drawing.Point(477, 176);
            this.labelPelaaja2.Name = "labelPelaaja2";
            this.labelPelaaja2.Size = new System.Drawing.Size(0, 15);
            this.labelPelaaja2.TabIndex = 4;
            this.labelPelaaja2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPelaaja1
            // 
            this.labelPelaaja1.AutoSize = true;
            this.labelPelaaja1.Location = new System.Drawing.Point(177, 175);
            this.labelPelaaja1.Name = "labelPelaaja1";
            this.labelPelaaja1.Size = new System.Drawing.Size(0, 15);
            this.labelPelaaja1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPelaaja1);
            this.Controls.Add(this.labelPelaaja2);
            this.Controls.Add(this.labelVoittaja);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelVoittaja;
        private System.Windows.Forms.Label labelPelaaja2;
        private System.Windows.Forms.Label labelPelaaja1;
    }
}

