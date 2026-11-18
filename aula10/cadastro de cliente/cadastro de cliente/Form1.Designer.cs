namespace cadastro_de_cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome2 = new System.Windows.Forms.TextBox();
            this.txtendereço2 = new System.Windows.Forms.TextBox();
            this.txtmostrajuridica = new System.Windows.Forms.TextBox();
            this.txtle = new System.Windows.Forms.TextBox();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnpessoajuridica = new System.Windows.Forms.Button();
            this.btnpessoafisica = new System.Windows.Forms.Button();
            this.gbjuridica = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbfisica = new System.Windows.Forms.GroupBox();
            this.txtmostrafisica = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtendereco1 = new System.Windows.Forms.TextBox();
            this.txtnome1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbjuridica.SuspendLayout();
            this.gbfisica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "cnpj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "le";
            // 
            // txtnome2
            // 
            this.txtnome2.Location = new System.Drawing.Point(95, 0);
            this.txtnome2.Name = "txtnome2";
            this.txtnome2.Size = new System.Drawing.Size(280, 20);
            this.txtnome2.TabIndex = 4;
            // 
            // txtendereço2
            // 
            this.txtendereço2.Location = new System.Drawing.Point(82, 42);
            this.txtendereço2.Name = "txtendereço2";
            this.txtendereço2.Size = new System.Drawing.Size(280, 20);
            this.txtendereço2.TabIndex = 5;
            // 
            // txtmostrajuridica
            // 
            this.txtmostrajuridica.Location = new System.Drawing.Point(30, 132);
            this.txtmostrajuridica.Multiline = true;
            this.txtmostrajuridica.Name = "txtmostrajuridica";
            this.txtmostrajuridica.Size = new System.Drawing.Size(310, 150);
            this.txtmostrajuridica.TabIndex = 2;
            // 
            // txtle
            // 
            this.txtle.Location = new System.Drawing.Point(209, 85);
            this.txtle.Name = "txtle";
            this.txtle.Size = new System.Drawing.Size(100, 20);
            this.txtle.TabIndex = 7;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Location = new System.Drawing.Point(82, 85);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(100, 20);
            this.txtcnpj.TabIndex = 6;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = global::cadastro_de_cliente.Properties.Resources.salvar;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(340, 12);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(106, 54);
            this.btnsalvar.TabIndex = 2;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnpessoajuridica
            // 
            this.btnpessoajuridica.Image = global::cadastro_de_cliente.Properties.Resources.pessoa_juridica;
            this.btnpessoajuridica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpessoajuridica.Location = new System.Drawing.Point(214, 12);
            this.btnpessoajuridica.Name = "btnpessoajuridica";
            this.btnpessoajuridica.Size = new System.Drawing.Size(111, 54);
            this.btnpessoajuridica.TabIndex = 1;
            this.btnpessoajuridica.Text = "pessoajuridica";
            this.btnpessoajuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpessoajuridica.UseVisualStyleBackColor = true;
            this.btnpessoajuridica.Click += new System.EventHandler(this.btnpessoajuridica_Click);
            // 
            // btnpessoafisica
            // 
            this.btnpessoafisica.Image = global::cadastro_de_cliente.Properties.Resources.pessoa_fisica;
            this.btnpessoafisica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpessoafisica.Location = new System.Drawing.Point(94, 12);
            this.btnpessoafisica.Name = "btnpessoafisica";
            this.btnpessoafisica.Size = new System.Drawing.Size(102, 54);
            this.btnpessoafisica.TabIndex = 0;
            this.btnpessoafisica.Text = "pessoa fisica";
            this.btnpessoafisica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpessoafisica.UseVisualStyleBackColor = true;
            this.btnpessoafisica.Click += new System.EventHandler(this.btnpessoafisica_Click);
            // 
            // gbjuridica
            // 
            this.gbjuridica.Controls.Add(this.txtle);
            this.gbjuridica.Controls.Add(this.txtmostrajuridica);
            this.gbjuridica.Controls.Add(this.txtcnpj);
            this.gbjuridica.Controls.Add(this.txtendereço2);
            this.gbjuridica.Controls.Add(this.txtnome2);
            this.gbjuridica.Controls.Add(this.label4);
            this.gbjuridica.Controls.Add(this.label3);
            this.gbjuridica.Controls.Add(this.label2);
            this.gbjuridica.Controls.Add(this.label1);
            this.gbjuridica.Location = new System.Drawing.Point(53, 76);
            this.gbjuridica.Name = "gbjuridica";
            this.gbjuridica.Size = new System.Drawing.Size(396, 297);
            this.gbjuridica.TabIndex = 3;
            this.gbjuridica.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "nome";
            // 
            // gbfisica
            // 
            this.gbfisica.Controls.Add(this.txtmostrafisica);
            this.gbfisica.Controls.Add(this.txtcpf);
            this.gbfisica.Controls.Add(this.txtrg);
            this.gbfisica.Controls.Add(this.txtendereco1);
            this.gbfisica.Controls.Add(this.txtnome1);
            this.gbfisica.Controls.Add(this.label10);
            this.gbfisica.Controls.Add(this.label9);
            this.gbfisica.Controls.Add(this.label8);
            this.gbfisica.Controls.Add(this.label5);
            this.gbfisica.Location = new System.Drawing.Point(48, 72);
            this.gbfisica.Name = "gbfisica";
            this.gbfisica.Size = new System.Drawing.Size(420, 285);
            this.gbfisica.TabIndex = 4;
            this.gbfisica.TabStop = false;
            // 
            // txtmostrafisica
            // 
            this.txtmostrafisica.Location = new System.Drawing.Point(25, 132);
            this.txtmostrafisica.Multiline = true;
            this.txtmostrafisica.Name = "txtmostrafisica";
            this.txtmostrafisica.Size = new System.Drawing.Size(310, 150);
            this.txtmostrafisica.TabIndex = 2;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(214, 85);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 2;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(80, 85);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(100, 20);
            this.txtrg.TabIndex = 2;
            // 
            // txtendereco1
            // 
            this.txtendereco1.Location = new System.Drawing.Point(80, 49);
            this.txtendereco1.Name = "txtendereco1";
            this.txtendereco1.Size = new System.Drawing.Size(280, 20);
            this.txtendereco1.TabIndex = 2;
            // 
            // txtnome1
            // 
            this.txtnome1.Location = new System.Drawing.Point(80, 13);
            this.txtnome1.Name = "txtnome1";
            this.txtnome1.Size = new System.Drawing.Size(280, 20);
            this.txtnome1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "cpf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "rg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "endereço";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.gbjuridica);
            this.Controls.Add(this.gbfisica);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnpessoajuridica);
            this.Controls.Add(this.btnpessoafisica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbjuridica.ResumeLayout(false);
            this.gbjuridica.PerformLayout();
            this.gbfisica.ResumeLayout(false);
            this.gbfisica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpessoafisica;
        private System.Windows.Forms.Button btnpessoajuridica;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome2;
        private System.Windows.Forms.TextBox txtendereço2;
        private System.Windows.Forms.TextBox txtmostrajuridica;
        private System.Windows.Forms.TextBox txtle;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.GroupBox gbjuridica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbfisica;
        private System.Windows.Forms.TextBox txtmostrafisica;
        private System.Windows.Forms.TextBox txtendereco1;
        private System.Windows.Forms.TextBox txtnome1;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcpf;
    }
}

