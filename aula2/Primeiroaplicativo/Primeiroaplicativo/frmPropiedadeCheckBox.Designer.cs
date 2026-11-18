namespace Primeiroaplicativo
{
    partial class frmPropiedadeCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropiedadeCheckBox));
            this.chkPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkPessoajuridica = new System.Windows.Forms.CheckBox();
            this.pnlPessoaFísica = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pmlPessoaJuridica = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPessoaFísica.SuspendLayout();
            this.pmlPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPessoaFisica
            // 
            this.chkPessoaFisica.AutoSize = true;
            this.chkPessoaFisica.Location = new System.Drawing.Point(381, 122);
            this.chkPessoaFisica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPessoaFisica.Name = "chkPessoaFisica";
            this.chkPessoaFisica.Size = new System.Drawing.Size(113, 24);
            this.chkPessoaFisica.TabIndex = 0;
            this.chkPessoaFisica.Text = "Pessoa Física";
            this.chkPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // chkPessoajuridica
            // 
            this.chkPessoajuridica.AutoSize = true;
            this.chkPessoajuridica.Location = new System.Drawing.Point(381, 256);
            this.chkPessoajuridica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPessoajuridica.Name = "chkPessoajuridica";
            this.chkPessoajuridica.Size = new System.Drawing.Size(119, 24);
            this.chkPessoajuridica.TabIndex = 1;
            this.chkPessoajuridica.Text = "pessoa jurídica";
            this.chkPessoajuridica.UseVisualStyleBackColor = true;
            // 
            // pnlPessoaFísica
            // 
            this.pnlPessoaFísica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPessoaFísica.Controls.Add(this.textBox2);
            this.pnlPessoaFísica.Controls.Add(this.label2);
            this.pnlPessoaFísica.Controls.Add(this.textBox1);
            this.pnlPessoaFísica.Controls.Add(this.label1);
            this.pnlPessoaFísica.Location = new System.Drawing.Point(761, 14);
            this.pnlPessoaFísica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPessoaFísica.Name = "pnlPessoaFísica";
            this.pnlPessoaFísica.Size = new System.Drawing.Size(266, 153);
            this.pnlPessoaFísica.TabIndex = 2;
            this.pnlPessoaFísica.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // pmlPessoaJuridica
            // 
            this.pmlPessoaJuridica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pmlPessoaJuridica.Controls.Add(this.textBox3);
            this.pmlPessoaJuridica.Controls.Add(this.label3);
            this.pmlPessoaJuridica.Controls.Add(this.textBox4);
            this.pmlPessoaJuridica.Controls.Add(this.label4);
            this.pmlPessoaJuridica.Location = new System.Drawing.Point(761, 194);
            this.pmlPessoaJuridica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmlPessoaJuridica.Name = "pmlPessoaJuridica";
            this.pmlPessoaJuridica.Size = new System.Drawing.Size(266, 153);
            this.pmlPessoaJuridica.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 80);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 26);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 22);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 26);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "nome";
            // 
            // frmPropiedadeCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.pmlPessoaJuridica);
            this.Controls.Add(this.pnlPessoaFísica);
            this.Controls.Add(this.chkPessoajuridica);
            this.Controls.Add(this.chkPessoaFisica);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPropiedadeCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPropiedadeCheckBox";
            this.pnlPessoaFísica.ResumeLayout(false);
            this.pnlPessoaFísica.PerformLayout();
            this.pmlPessoaJuridica.ResumeLayout(false);
            this.pmlPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPessoaFisica;
        private System.Windows.Forms.CheckBox chkPessoajuridica;
        private System.Windows.Forms.Panel pnlPessoaFísica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pmlPessoaJuridica;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}