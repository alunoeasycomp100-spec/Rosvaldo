namespace Primeiroaplicativo
{
    partial class frmvisualizadorimagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvisualizadorimagem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pblmagens = new System.Windows.Forms.PictureBox();
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.btnmostrarimagem = new System.Windows.Forms.Button();
            this.btnlimparimagem = new System.Windows.Forms.Button();
            this.ofdlmagens = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblmagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primeiroaplicativo.Properties.Resources.moldura2;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pblmagens
            // 
            this.pblmagens.Location = new System.Drawing.Point(104, 73);
            this.pblmagens.Name = "pblmagens";
            this.pblmagens.Size = new System.Drawing.Size(616, 255);
            this.pblmagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblmagens.TabIndex = 1;
            this.pblmagens.TabStop = false;
            this.pblmagens.Click += new System.EventHandler(this.pblmagens_Click);
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Location = new System.Drawing.Point(623, 396);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(59, 17);
            this.rbStretch.TabIndex = 3;
            this.rbStretch.TabStop = true;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.CheckedChanged += new System.EventHandler(this.rbStretch_CheckedChanged);
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Location = new System.Drawing.Point(709, 396);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(58, 17);
            this.rbnormal.TabIndex = 4;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "Normal";
            this.rbnormal.UseVisualStyleBackColor = true;
            this.rbnormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // btnmostrarimagem
            // 
            this.btnmostrarimagem.Location = new System.Drawing.Point(238, 396);
            this.btnmostrarimagem.Name = "btnmostrarimagem";
            this.btnmostrarimagem.Size = new System.Drawing.Size(110, 23);
            this.btnmostrarimagem.TabIndex = 5;
            this.btnmostrarimagem.Text = "mostrar imagem";
            this.btnmostrarimagem.UseVisualStyleBackColor = true;
            this.btnmostrarimagem.Click += new System.EventHandler(this.btnmostrarimagem_Click);
            // 
            // btnlimparimagem
            // 
            this.btnlimparimagem.Location = new System.Drawing.Point(390, 396);
            this.btnlimparimagem.Name = "btnlimparimagem";
            this.btnlimparimagem.Size = new System.Drawing.Size(100, 23);
            this.btnlimparimagem.TabIndex = 6;
            this.btnlimparimagem.Text = "limpar imagem";
            this.btnlimparimagem.UseVisualStyleBackColor = true;
            this.btnlimparimagem.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmvisualizadorimagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimparimagem);
            this.Controls.Add(this.btnmostrarimagem);
            this.Controls.Add(this.rbnormal);
            this.Controls.Add(this.rbStretch);
            this.Controls.Add(this.pblmagens);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmvisualizadorimagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblmagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pblmagens;
        private System.Windows.Forms.RadioButton rbStretch;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.Button btnmostrarimagem;
        private System.Windows.Forms.Button btnlimparimagem;
        private System.Windows.Forms.OpenFileDialog ofdlmagens;
    }
}