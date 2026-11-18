namespace Primeiroaplicativo
{
    partial class frmtabuada
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.iqua = new System.Windows.Forms.Label();
            this.txttabuada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txttabuada);
            this.panel1.Controls.Add(this.iqua);
            this.panel1.Controls.Add(this.txtnumero);
            this.panel1.Controls.Add(this.btnlimpar);
            this.panel1.Controls.Add(this.btncalcular);
            this.panel1.Location = new System.Drawing.Point(50, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 281);
            this.panel1.TabIndex = 0;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(24, 64);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(24, 103);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 33);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(209, 37);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            // 
            // iqua
            // 
            this.iqua.AutoSize = true;
            this.iqua.Location = new System.Drawing.Point(3, 37);
            this.iqua.Name = "iqua";
            this.iqua.Size = new System.Drawing.Size(10, 13);
            this.iqua.TabIndex = 3;
            this.iqua.Text = "-";
            // 
            // txttabuada
            // 
            this.txttabuada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttabuada.Location = new System.Drawing.Point(122, 67);
            this.txttabuada.Multiline = true;
            this.txttabuada.Name = "txttabuada";
            this.txttabuada.Size = new System.Drawing.Size(217, 145);
            this.txttabuada.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "informe qual tabuadadeseja calcular";
            // 
            // frmtabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmtabuada";
            this.Text = "tabuada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttabuada;
        private System.Windows.Forms.Label iqua;
    }
}