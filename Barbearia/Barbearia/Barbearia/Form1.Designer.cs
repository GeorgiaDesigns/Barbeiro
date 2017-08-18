namespace Barbearia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadeiraBarbeiro = new System.Windows.Forms.Button();
            this.cliente1 = new System.Windows.Forms.Button();
            this.cliente2 = new System.Windows.Forms.Button();
            this.cliente5 = new System.Windows.Forms.Button();
            this.cliente4 = new System.Windows.Forms.Button();
            this.cliente3 = new System.Windows.Forms.Button();
            this.abriFecha = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(390, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cadeiraBarbeiro
            // 
            this.cadeiraBarbeiro.Location = new System.Drawing.Point(46, 193);
            this.cadeiraBarbeiro.Name = "cadeiraBarbeiro";
            this.cadeiraBarbeiro.Size = new System.Drawing.Size(85, 79);
            this.cadeiraBarbeiro.TabIndex = 1;
            this.cadeiraBarbeiro.UseVisualStyleBackColor = true;
            // 
            // cliente1
            // 
            this.cliente1.Location = new System.Drawing.Point(46, 22);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(71, 62);
            this.cliente1.TabIndex = 2;
            this.cliente1.UseVisualStyleBackColor = true;
            // 
            // cliente2
            // 
            this.cliente2.Location = new System.Drawing.Point(134, 22);
            this.cliente2.Name = "cliente2";
            this.cliente2.Size = new System.Drawing.Size(67, 62);
            this.cliente2.TabIndex = 3;
            this.cliente2.UseVisualStyleBackColor = true;
            // 
            // cliente5
            // 
            this.cliente5.Location = new System.Drawing.Point(394, 21);
            this.cliente5.Name = "cliente5";
            this.cliente5.Size = new System.Drawing.Size(69, 63);
            this.cliente5.TabIndex = 4;
            this.cliente5.UseVisualStyleBackColor = true;
            // 
            // cliente4
            // 
            this.cliente4.Location = new System.Drawing.Point(309, 22);
            this.cliente4.Name = "cliente4";
            this.cliente4.Size = new System.Drawing.Size(64, 62);
            this.cliente4.TabIndex = 5;
            this.cliente4.UseVisualStyleBackColor = true;
            // 
            // cliente3
            // 
            this.cliente3.Location = new System.Drawing.Point(222, 22);
            this.cliente3.Name = "cliente3";
            this.cliente3.Size = new System.Drawing.Size(66, 62);
            this.cliente3.TabIndex = 6;
            this.cliente3.UseVisualStyleBackColor = true;
            // 
            // abriFecha
            // 
            this.abriFecha.AutoSize = true;
            this.abriFecha.Location = new System.Drawing.Point(387, 110);
            this.abriFecha.Name = "abriFecha";
            this.abriFecha.Size = new System.Drawing.Size(0, 13);
            this.abriFecha.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(284, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Fechar Barbearia";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(284, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "Abrir Barbearia";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.abriFecha);
            this.Controls.Add(this.cliente3);
            this.Controls.Add(this.cliente4);
            this.Controls.Add(this.cliente5);
            this.Controls.Add(this.cliente2);
            this.Controls.Add(this.cliente1);
            this.Controls.Add(this.cadeiraBarbeiro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadeiraBarbeiro;
        private System.Windows.Forms.Button cliente1;
        private System.Windows.Forms.Button cliente2;
        private System.Windows.Forms.Button cliente5;
        private System.Windows.Forms.Button cliente4;
        private System.Windows.Forms.Button cliente3;
        private System.Windows.Forms.Label abriFecha;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}

