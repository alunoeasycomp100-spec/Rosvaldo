namespace Primeiroaplicativo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMensagens = new System.Windows.Forms.Label();
            this.btnMostrarMensagem = new System.Windows.Forms.Button();
            this.btnPropiedadesCheckBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagens.Location = new System.Drawing.Point(187, 192);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(0, 39);
            this.lblMensagens.TabIndex = 0;
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMensagem.Location = new System.Drawing.Point(231, 273);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(228, 60);
            this.btnMostrarMensagem.TabIndex = 1;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // btnPropiedadesCheckBox
            // 
            this.btnPropiedadesCheckBox.Location = new System.Drawing.Point(311, 113);
            this.btnPropiedadesCheckBox.Name = "btnPropiedadesCheckBox";
            this.btnPropiedadesCheckBox.Size = new System.Drawing.Size(75, 23);
            this.btnPropiedadesCheckBox.TabIndex = 3;
            this.btnPropiedadesCheckBox.Text = "CheckBox";
            this.btnPropiedadesCheckBox.UseVisualStyleBackColor = true;
            this.btnPropiedadesCheckBox.Click += new System.EventHandler(this.btnPropiedadesCheckBox_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPropiedadesCheckBox);
            this.Controls.Add(this.btnMostrarMensagem);
            this.Controls.Add(this.lblMensagens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Aplicativo em C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagens;
        private System.Windows.Forms.Button btnMostrarMensagem;
        private System.Windows.Forms.Button btnPropiedadesCheckBox;
    }
}

