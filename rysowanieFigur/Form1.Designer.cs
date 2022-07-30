namespace rysowanieFigur
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLinia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.kolor = new System.Windows.Forms.Button();
            this.grubosc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grubosc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 384);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonLinia
            // 
            this.buttonLinia.Location = new System.Drawing.Point(1, 1);
            this.buttonLinia.Name = "buttonLinia";
            this.buttonLinia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLinia.Size = new System.Drawing.Size(75, 23);
            this.buttonLinia.TabIndex = 2;
            this.buttonLinia.Text = "Linia";
            this.buttonLinia.UseVisualStyleBackColor = true;
            this.buttonLinia.Click += new System.EventHandler(this.buttonLinia_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "prostokat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "kolo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kolor
            // 
            this.kolor.BackColor = System.Drawing.Color.Black;
            this.kolor.Location = new System.Drawing.Point(766, 9);
            this.kolor.Margin = new System.Windows.Forms.Padding(0);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(25, 25);
            this.kolor.TabIndex = 5;
            this.kolor.UseVisualStyleBackColor = false;
            this.kolor.Click += new System.EventHandler(this.kolor_Click);
            // 
            // grubosc
            // 
            this.grubosc.Location = new System.Drawing.Point(755, 44);
            this.grubosc.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.grubosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.grubosc.Name = "grubosc";
            this.grubosc.ReadOnly = true;
            this.grubosc.Size = new System.Drawing.Size(36, 20);
            this.grubosc.TabIndex = 6;
            this.grubosc.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.grubosc.Click += new System.EventHandler(this.grubosc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grubosc);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLinia);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grubosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLinia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button kolor;
        private System.Windows.Forms.NumericUpDown grubosc;
    }
}

