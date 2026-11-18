namespace mediaaluno
{
    partial class frmcalculomedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculomedia));
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txttrabalho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbopesonota1 = new System.Windows.Forms.ComboBox();
            this.cbopesonota2 = new System.Windows.Forms.ComboBox();
            this.cbopesotrabalho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqdeaulas = new System.Windows.Forms.TextBox();
            this.txtqdefaltas = new System.Windows.Forms.TextBox();
            this.txtmediafinal = new System.Windows.Forms.TextBox();
            this.txtaproveitamento = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numnotacorte = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtrecuperacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numnotacorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnota2
            // 
            this.txtnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota2.Location = new System.Drawing.Point(303, 170);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(90, 26);
            this.txtnota2.TabIndex = 2;
            this.txtnota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnota1
            // 
            this.txtnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota1.Location = new System.Drawing.Point(180, 170);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(90, 26);
            this.txtnota1.TabIndex = 0;
            this.txtnota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttrabalho
            // 
            this.txttrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrabalho.Location = new System.Drawing.Point(426, 170);
            this.txttrabalho.Name = "txttrabalho";
            this.txttrabalho.Size = new System.Drawing.Size(90, 26);
            this.txttrabalho.TabIndex = 4;
            this.txttrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "nota 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "nota 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "trabalho";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbopesonota1
            // 
            this.cbopesonota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopesonota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopesonota1.FormattingEnabled = true;
            this.cbopesonota1.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cbopesonota1.Location = new System.Drawing.Point(180, 207);
            this.cbopesonota1.Name = "cbopesonota1";
            this.cbopesonota1.Size = new System.Drawing.Size(90, 28);
            this.cbopesonota1.TabIndex = 1;
            // 
            // cbopesonota2
            // 
            this.cbopesonota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopesonota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopesonota2.FormattingEnabled = true;
            this.cbopesonota2.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cbopesonota2.Location = new System.Drawing.Point(303, 207);
            this.cbopesonota2.Name = "cbopesonota2";
            this.cbopesonota2.Size = new System.Drawing.Size(90, 28);
            this.cbopesonota2.TabIndex = 3;
            // 
            // cbopesotrabalho
            // 
            this.cbopesotrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbopesotrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopesotrabalho.FormattingEnabled = true;
            this.cbopesotrabalho.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cbopesotrabalho.Location = new System.Drawing.Point(426, 207);
            this.cbopesotrabalho.Name = "cbopesotrabalho";
            this.cbopesotrabalho.Size = new System.Drawing.Size(90, 28);
            this.cbopesotrabalho.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "QDE AULAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "QDE FALTAS";
            // 
            // txtqdeaulas
            // 
            this.txtqdeaulas.Location = new System.Drawing.Point(252, 259);
            this.txtqdeaulas.Name = "txtqdeaulas";
            this.txtqdeaulas.Size = new System.Drawing.Size(100, 20);
            this.txtqdeaulas.TabIndex = 6;
            // 
            // txtqdefaltas
            // 
            this.txtqdefaltas.Location = new System.Drawing.Point(252, 290);
            this.txtqdefaltas.Name = "txtqdefaltas";
            this.txtqdefaltas.Size = new System.Drawing.Size(100, 20);
            this.txtqdefaltas.TabIndex = 7;
            // 
            // txtmediafinal
            // 
            this.txtmediafinal.Location = new System.Drawing.Point(195, 340);
            this.txtmediafinal.Name = "txtmediafinal";
            this.txtmediafinal.Size = new System.Drawing.Size(100, 20);
            this.txtmediafinal.TabIndex = 41;
            // 
            // txtaproveitamento
            // 
            this.txtaproveitamento.Location = new System.Drawing.Point(316, 340);
            this.txtaproveitamento.Name = "txtaproveitamento";
            this.txtaproveitamento.Size = new System.Drawing.Size(100, 20);
            this.txtaproveitamento.TabIndex = 40;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Image = global::mediaaluno.Properties.Resources.vassoura;
            this.btnlimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpar.Location = new System.Drawing.Point(318, 389);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(120, 49);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Image = global::mediaaluno.Properties.Resources._1486395290_09_calculator_80565;
            this.btncalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncalcular.Location = new System.Drawing.Point(180, 389);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(115, 49);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "calcular";
            this.btncalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mediaaluno.Properties.Resources.meidaaluno;
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "MÉDIA FINAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "APROVEITAMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "NOTAS DE CORTE";
            // 
            // numnotacorte
            // 
            this.numnotacorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numnotacorte.Location = new System.Drawing.Point(436, 275);
            this.numnotacorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numnotacorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numnotacorte.Name = "numnotacorte";
            this.numnotacorte.Size = new System.Drawing.Size(120, 26);
            this.numnotacorte.TabIndex = 8;
            this.numnotacorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numnotacorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsituacao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(588, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "situaçao";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Location = new System.Drawing.Point(22, 50);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(0, 20);
            this.lblsituacao.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtrecuperacao);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(588, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 116);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "recuperaçao";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtrecuperacao
            // 
            this.txtrecuperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecuperacao.Location = new System.Drawing.Point(26, 38);
            this.txtrecuperacao.Name = "txtrecuperacao";
            this.txtrecuperacao.Size = new System.Drawing.Size(90, 26);
            this.txtrecuperacao.TabIndex = 11;
            this.txtrecuperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmcalculomedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numnotacorte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtmediafinal);
            this.Controls.Add(this.txtaproveitamento);
            this.Controls.Add(this.txtqdefaltas);
            this.Controls.Add(this.txtqdeaulas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbopesotrabalho);
            this.Controls.Add(this.cbopesonota2);
            this.Controls.Add(this.cbopesonota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.txttrabalho);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcalculomedia";
            this.Text = "calculo media";
            this.Load += new System.EventHandler(this.frmcalculomedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numnotacorte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txttrabalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbopesonota1;
        private System.Windows.Forms.ComboBox cbopesonota2;
        private System.Windows.Forms.ComboBox cbopesotrabalho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqdeaulas;
        private System.Windows.Forms.TextBox txtqdefaltas;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtmediafinal;
        private System.Windows.Forms.TextBox txtaproveitamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numnotacorte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtrecuperacao;
    }
}

