namespace funcionario
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            label1 = new Label();
            txtnome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtsalario = new TextBox();
            txtfuncionario = new TextBox();
            btnsalvar = new Button();
            cbcargo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(107, 26);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(154, 23);
            txtnome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 50);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "cargo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 80);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "salario";
            // 
            // txtsalario
            // 
            txtsalario.Location = new Point(107, 84);
            txtsalario.Name = "txtsalario";
            txtsalario.Size = new Size(100, 23);
            txtsalario.TabIndex = 1;
            // 
            // txtfuncionario
            // 
            txtfuncionario.Location = new Point(41, 125);
            txtfuncionario.Multiline = true;
            txtfuncionario.Name = "txtfuncionario";
            txtfuncionario.Size = new Size(275, 142);
            txtfuncionario.TabIndex = 1;
            // 
            // btnsalvar
            // 
            btnsalvar.Image = (Image)resources.GetObject("btnsalvar.Image");
            btnsalvar.ImageAlign = ContentAlignment.TopCenter;
            btnsalvar.Location = new Point(267, 26);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(49, 49);
            btnsalvar.TabIndex = 2;
            btnsalvar.Text = "Salvar";
            btnsalvar.TextAlign = ContentAlignment.BottomCenter;
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // cbcargo
            // 
            cbcargo.FormattingEnabled = true;
            cbcargo.Items.AddRange(new object[] { "Assistente Administrativo", "Assistente de Designer" });
            cbcargo.Location = new Point(107, 55);
            cbcargo.Name = "cbcargo";
            cbcargo.Size = new Size(154, 23);
            cbcargo.TabIndex = 3;
            // 
            // frmprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 279);
            Controls.Add(cbcargo);
            Controls.Add(btnsalvar);
            Controls.Add(txtfuncionario);
            Controls.Add(txtsalario);
            Controls.Add(txtnome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmprincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnome;
        private Label label2;
        private Label label3;
        private TextBox txtsalario;
        private TextBox txtfuncionario;
        private Button btnsalvar;
        private ComboBox cbcargo;
    }
}
