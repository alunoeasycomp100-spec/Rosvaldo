namespace controle_de_frota
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkm = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncaminhao = new System.Windows.Forms.Button();
            this.btncarros = new System.Windows.Forms.Button();
            this.lbleixo = new System.Windows.Forms.Label();
            this.txteixos = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcaminhao = new System.Windows.Forms.TextBox();
            this.txtcarro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "placa";
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Location = new System.Drawing.Point(80, 134);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(21, 13);
            this.lblkm.TabIndex = 1;
            this.lblkm.Text = "km";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(139, 67);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(213, 20);
            this.txtmodelo.TabIndex = 2;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(139, 98);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(213, 20);
            this.txtplaca.TabIndex = 3;
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(139, 134);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(100, 20);
            this.txtkm.TabIndex = 4;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = global::controle_de_frota.Properties.Resources.enveolpe_ico;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(277, 12);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 40);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncaminhao
            // 
            this.btncaminhao.Image = global::controle_de_frota.Properties.Resources.caminhao_ico;
            this.btncaminhao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncaminhao.Location = new System.Drawing.Point(164, 12);
            this.btncaminhao.Name = "btncaminhao";
            this.btncaminhao.Size = new System.Drawing.Size(96, 40);
            this.btncaminhao.TabIndex = 1;
            this.btncaminhao.Text = "caminhao";
            this.btncaminhao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncaminhao.UseVisualStyleBackColor = true;
            this.btncaminhao.Click += new System.EventHandler(this.btncaminhao_Click);
            // 
            // btncarros
            // 
            this.btncarros.Image = global::controle_de_frota.Properties.Resources.carro_ico;
            this.btncarros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncarros.Location = new System.Drawing.Point(83, 12);
            this.btncarros.Name = "btncarros";
            this.btncarros.Size = new System.Drawing.Size(75, 40);
            this.btncarros.TabIndex = 0;
            this.btncarros.Text = "carros";
            this.btncarros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncarros.UseVisualStyleBackColor = true;
            this.btncarros.Click += new System.EventHandler(this.btncarros_Click);
            // 
            // lbleixo
            // 
            this.lbleixo.AutoSize = true;
            this.lbleixo.Location = new System.Drawing.Point(274, 134);
            this.lbleixo.Name = "lbleixo";
            this.lbleixo.Size = new System.Drawing.Size(31, 13);
            this.lbleixo.TabIndex = 1;
            this.lbleixo.Text = "eixos";
            this.lbleixo.Visible = false;
            // 
            // txteixos
            // 
            this.txteixos.Location = new System.Drawing.Point(325, 134);
            this.txteixos.Name = "txteixos";
            this.txteixos.Size = new System.Drawing.Size(100, 20);
            this.txteixos.TabIndex = 5;
            this.txteixos.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::controle_de_frota.Properties.Resources.caminhao_ico;
            this.pictureBox3.Location = new System.Drawing.Point(277, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::controle_de_frota.Properties.Resources.carro_ico;
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtcaminhao
            // 
            this.txtcaminhao.Location = new System.Drawing.Point(277, 218);
            this.txtcaminhao.Multiline = true;
            this.txtcaminhao.Name = "txtcaminhao";
            this.txtcaminhao.Size = new System.Drawing.Size(249, 168);
            this.txtcaminhao.TabIndex = 8;
            // 
            // txtcarro
            // 
            this.txtcarro.Location = new System.Drawing.Point(12, 218);
            this.txtcarro.Multiline = true;
            this.txtcarro.Name = "txtcarro";
            this.txtcarro.Size = new System.Drawing.Size(248, 168);
            this.txtcarro.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcarro);
            this.Controls.Add(this.txtcaminhao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txteixos);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.lbleixo);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btncaminhao);
            this.Controls.Add(this.btncarros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncarros;
        private System.Windows.Forms.Button btncaminhao;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.Label lbleixo;
        private System.Windows.Forms.TextBox txteixos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcaminhao;
        private System.Windows.Forms.TextBox txtcarro;
    }
}

