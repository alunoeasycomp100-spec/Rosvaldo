namespace conversao_de_aplicativo
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
            txtresulatado = new TextBox();
            rbCelcius2 = new RadioButton();
            rbkelvin2 = new RadioButton();
            rbfahrenheit2 = new RadioButton();
            gpsaida = new GroupBox();
            btnconverter = new Button();
            btnlimpar = new Button();
            gpentrada = new GroupBox();
            label2 = new Label();
            rbcelcius1 = new RadioButton();
            rbfahrenheit1 = new RadioButton();
            rbkelvin1 = new RadioButton();
            txtvalor = new TextBox();
            label3 = new Label();
            gpsaida.SuspendLayout();
            gpentrada.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "valor";
            // 
            // txtresulatado
            // 
            txtresulatado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtresulatado.Location = new Point(116, 201);
            txtresulatado.Name = "txtresulatado";
            txtresulatado.Size = new Size(266, 29);
            txtresulatado.TabIndex = 5;
            // 
            // rbCelcius2
            // 
            rbCelcius2.AutoSize = true;
            rbCelcius2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCelcius2.Location = new Point(47, 16);
            rbCelcius2.Name = "rbCelcius2";
            rbCelcius2.Size = new Size(70, 24);
            rbCelcius2.TabIndex = 2;
            rbCelcius2.TabStop = true;
            rbCelcius2.Text = "celcius";
            rbCelcius2.UseVisualStyleBackColor = true;
            // 
            // rbkelvin2
            // 
            rbkelvin2.AutoSize = true;
            rbkelvin2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbkelvin2.Location = new Point(47, 46);
            rbkelvin2.Name = "rbkelvin2";
            rbkelvin2.Size = new Size(66, 24);
            rbkelvin2.TabIndex = 2;
            rbkelvin2.TabStop = true;
            rbkelvin2.Text = "kelvin";
            rbkelvin2.UseVisualStyleBackColor = true;
            // 
            // rbfahrenheit2
            // 
            rbfahrenheit2.AutoSize = true;
            rbfahrenheit2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbfahrenheit2.Location = new Point(47, 70);
            rbfahrenheit2.Name = "rbfahrenheit2";
            rbfahrenheit2.Size = new Size(95, 24);
            rbfahrenheit2.TabIndex = 2;
            rbfahrenheit2.TabStop = true;
            rbfahrenheit2.Text = "fahrenheit";
            rbfahrenheit2.UseVisualStyleBackColor = true;
            // 
            // gpsaida
            // 
            gpsaida.Controls.Add(rbCelcius2);
            gpsaida.Controls.Add(rbfahrenheit2);
            gpsaida.Controls.Add(rbkelvin2);
            gpsaida.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpsaida.Location = new Point(240, 77);
            gpsaida.Name = "gpsaida";
            gpsaida.Size = new Size(160, 100);
            gpsaida.TabIndex = 2;
            gpsaida.TabStop = false;
            gpsaida.Text = "saida";
            // 
            // btnconverter
            // 
            btnconverter.Image = Properties.Resources.conversor;
            btnconverter.ImageAlign = ContentAlignment.TopCenter;
            btnconverter.Location = new Point(125, 236);
            btnconverter.Name = "btnconverter";
            btnconverter.Size = new Size(75, 54);
            btnconverter.TabIndex = 3;
            btnconverter.Text = "converter";
            btnconverter.TextAlign = ContentAlignment.BottomCenter;
            btnconverter.UseVisualStyleBackColor = true;
            btnconverter.Click += btnconverter_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Image = Properties.Resources.vassoura;
            btnlimpar.ImageAlign = ContentAlignment.TopCenter;
            btnlimpar.Location = new Point(231, 236);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 54);
            btnlimpar.TabIndex = 4;
            btnlimpar.Text = "limpar";
            btnlimpar.TextAlign = ContentAlignment.BottomCenter;
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // gpentrada
            // 
            gpentrada.Controls.Add(label2);
            gpentrada.Controls.Add(rbcelcius1);
            gpentrada.Controls.Add(rbfahrenheit1);
            gpentrada.Controls.Add(rbkelvin1);
            gpentrada.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpentrada.Location = new Point(40, 77);
            gpentrada.Name = "gpentrada";
            gpentrada.Size = new Size(160, 100);
            gpentrada.TabIndex = 1;
            gpentrada.TabStop = false;
            gpentrada.Text = "entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // rbcelcius1
            // 
            rbcelcius1.AutoSize = true;
            rbcelcius1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbcelcius1.Location = new Point(47, 16);
            rbcelcius1.Name = "rbcelcius1";
            rbcelcius1.Size = new Size(70, 24);
            rbcelcius1.TabIndex = 2;
            rbcelcius1.TabStop = true;
            rbcelcius1.Text = "celcius";
            rbcelcius1.UseVisualStyleBackColor = true;
            // 
            // rbfahrenheit1
            // 
            rbfahrenheit1.AutoSize = true;
            rbfahrenheit1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbfahrenheit1.Location = new Point(47, 70);
            rbfahrenheit1.Name = "rbfahrenheit1";
            rbfahrenheit1.Size = new Size(95, 24);
            rbfahrenheit1.TabIndex = 2;
            rbfahrenheit1.TabStop = true;
            rbfahrenheit1.Text = "fahrenheit";
            rbfahrenheit1.UseVisualStyleBackColor = true;
            // 
            // rbkelvin1
            // 
            rbkelvin1.AutoSize = true;
            rbkelvin1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbkelvin1.Location = new Point(47, 40);
            rbkelvin1.Name = "rbkelvin1";
            rbkelvin1.Size = new Size(66, 24);
            rbkelvin1.TabIndex = 2;
            rbkelvin1.TabStop = true;
            rbkelvin1.Text = "kelvin";
            rbkelvin1.UseVisualStyleBackColor = true;
            // 
            // txtvalor
            // 
            txtvalor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtvalor.Location = new Point(116, 12);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(266, 29);
            txtvalor.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 201);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "resuoltado";
            // 
            // frmprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 370);
            Controls.Add(label3);
            Controls.Add(gpentrada);
            Controls.Add(btnlimpar);
            Controls.Add(btnconverter);
            Controls.Add(txtvalor);
            Controls.Add(txtresulatado);
            Controls.Add(label1);
            Controls.Add(gpsaida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "conversor de temperatura";
            gpsaida.ResumeLayout(false);
            gpsaida.PerformLayout();
            gpentrada.ResumeLayout(false);
            gpentrada.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtresulatado;
        private RadioButton rbCelcius2;
        private RadioButton rbkelvin2;
        private RadioButton rbfahrenheit2;
        private GroupBox gpsaida;
        private Button btnconverter;
        private Button btnlimpar;
        private GroupBox gpentrada;
        private Label label2;
        private RadioButton rbcelcius1;
        private RadioButton rbfahrenheit1;
        private RadioButton rbkelvin1;
        private TextBox txtvalor;
        private Label label3;
    }
}
