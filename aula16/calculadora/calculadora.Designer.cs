namespace calculadora
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            txthistorico = new TextBox();
            txtvisor = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnvirgula = new Button();
            btn0 = new Button();
            btnlimpar = new Button();
            btnbackspace = new Button();
            btnmais = new Button();
            btnmenos = new Button();
            btnvezes = new Button();
            btndivide = new Button();
            btnraiz = new Button();
            btnigual = new Button();
            SuspendLayout();
            // 
            // txthistorico
            // 
            txthistorico.Location = new Point(12, 12);
            txthistorico.Name = "txthistorico";
            txthistorico.Size = new Size(298, 23);
            txthistorico.TabIndex = 0;
            txthistorico.TextAlign = HorizontalAlignment.Right;
            // 
            // txtvisor
            // 
            txtvisor.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtvisor.Location = new Point(12, 41);
            txtvisor.Name = "txtvisor";
            txtvisor.Size = new Size(298, 43);
            txtvisor.TabIndex = 0;
            txtvisor.Text = "0";
            txtvisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 90);
            btn7.Name = "btn7";
            btn7.Size = new Size(44, 43);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += clicoubotao;
            // 
            // btn8
            // 
            btn8.Location = new Point(62, 90);
            btn8.Name = "btn8";
            btn8.Size = new Size(44, 43);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += clicoubotao;
            // 
            // btn9
            // 
            btn9.Location = new Point(112, 90);
            btn9.Name = "btn9";
            btn9.Size = new Size(44, 43);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += clicoubotao;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 139);
            btn4.Name = "btn4";
            btn4.Size = new Size(44, 43);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += clicoubotao;
            // 
            // btn5
            // 
            btn5.Location = new Point(62, 139);
            btn5.Name = "btn5";
            btn5.Size = new Size(44, 43);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += clicoubotao;
            // 
            // btn6
            // 
            btn6.Location = new Point(112, 139);
            btn6.Name = "btn6";
            btn6.Size = new Size(44, 43);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += clicoubotao;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 188);
            btn1.Name = "btn1";
            btn1.Size = new Size(44, 43);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += clicoubotao;
            // 
            // btn2
            // 
            btn2.Location = new Point(62, 188);
            btn2.Name = "btn2";
            btn2.Size = new Size(44, 43);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += clicoubotao;
            // 
            // btn3
            // 
            btn3.Location = new Point(112, 188);
            btn3.Name = "btn3";
            btn3.Size = new Size(44, 43);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += clicoubotao;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(112, 237);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(44, 43);
            btnvirgula.TabIndex = 1;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += clicoubotao;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 237);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 43);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += clicoubotao;
            // 
            // btnlimpar
            // 
            btnlimpar.BackColor = Color.Red;
            btnlimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpar.ForeColor = SystemColors.Menu;
            btnlimpar.Location = new Point(199, 90);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(44, 43);
            btnlimpar.TabIndex = 1;
            btnlimpar.Text = "C";
            btnlimpar.UseVisualStyleBackColor = false;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnbackspace
            // 
            btnbackspace.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbackspace.Location = new Point(249, 90);
            btnbackspace.Name = "btnbackspace";
            btnbackspace.Size = new Size(44, 43);
            btnbackspace.TabIndex = 1;
            btnbackspace.Text = "<-";
            btnbackspace.UseVisualStyleBackColor = true;
            btnbackspace.Click += btnbackspace_Click;
            // 
            // btnmais
            // 
            btnmais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmais.Location = new Point(199, 139);
            btnmais.Name = "btnmais";
            btnmais.Size = new Size(44, 43);
            btnmais.TabIndex = 1;
            btnmais.Text = "+";
            btnmais.UseVisualStyleBackColor = true;
            btnmais.Click += btnsoma_Click;
            // 
            // btnmenos
            // 
            btnmenos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenos.Location = new Point(249, 139);
            btnmenos.Name = "btnmenos";
            btnmenos.Size = new Size(44, 43);
            btnmenos.TabIndex = 1;
            btnmenos.Text = "-";
            btnmenos.UseVisualStyleBackColor = true;
            btnmenos.Click += btnmenos_Click;
            // 
            // btnvezes
            // 
            btnvezes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvezes.Location = new Point(199, 188);
            btnvezes.Name = "btnvezes";
            btnvezes.Size = new Size(44, 43);
            btnvezes.TabIndex = 1;
            btnvezes.Text = "*";
            btnvezes.UseVisualStyleBackColor = true;
            btnvezes.Click += btnvezes_Click;
            // 
            // btndivide
            // 
            btndivide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndivide.Location = new Point(249, 188);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(44, 43);
            btndivide.TabIndex = 1;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btndivide_Click;
            // 
            // btnraiz
            // 
            btnraiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnraiz.Location = new Point(199, 237);
            btnraiz.Name = "btnraiz";
            btnraiz.Size = new Size(44, 43);
            btnraiz.TabIndex = 1;
            btnraiz.Text = "R²";
            btnraiz.UseVisualStyleBackColor = true;
            btnraiz.Click += btnraiz_Click;
            // 
            // btnigual
            // 
            btnigual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnigual.Location = new Point(249, 237);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(44, 43);
            btnigual.TabIndex = 1;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(322, 300);
            Controls.Add(btnvirgula);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btnigual);
            Controls.Add(btndivide);
            Controls.Add(btnmenos);
            Controls.Add(btnbackspace);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btnraiz);
            Controls.Add(btnvezes);
            Controls.Add(btn5);
            Controls.Add(btnmais);
            Controls.Add(btn4);
            Controls.Add(btnlimpar);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtvisor);
            Controls.Add(txthistorico);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "calculadora";
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txthistorico;
        private TextBox txtvisor;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnvirgula;
        private Button btn0;
        private Button btnlimpar;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button btnbackspace;
        private Button btnmais;
        private Button btnmenos;
        private Button btnvezes;
        private Button btndivide;
        private Button btnraiz;
        private Button btnigual;
    }
}
