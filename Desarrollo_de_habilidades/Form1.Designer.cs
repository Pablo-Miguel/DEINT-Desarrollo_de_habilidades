namespace Desarrollo_de_habilidades
{
    partial class Form1
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
            this.lblProblema1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.rbGerente = new System.Windows.Forms.RadioButton();
            this.rbSubGerente = new System.Windows.Forms.RadioButton();
            this.rbSecretaria = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProblema1
            // 
            this.lblProblema1.AutoSize = true;
            this.lblProblema1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProblema1.Location = new System.Drawing.Point(342, 19);
            this.lblProblema1.Name = "lblProblema1";
            this.lblProblema1.Size = new System.Drawing.Size(125, 30);
            this.lblProblema1.TabIndex = 0;
            this.lblProblema1.Text = "Problema 1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(381, 96);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 15);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(126, 93);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(249, 23);
            this.tbNombre.TabIndex = 3;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(432, 93);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(249, 23);
            this.tbSalario.TabIndex = 4;
            // 
            // rbGerente
            // 
            this.rbGerente.AutoSize = true;
            this.rbGerente.Location = new System.Drawing.Point(120, 195);
            this.rbGerente.Name = "rbGerente";
            this.rbGerente.Size = new System.Drawing.Size(66, 19);
            this.rbGerente.TabIndex = 5;
            this.rbGerente.TabStop = true;
            this.rbGerente.Text = "Gerente";
            this.rbGerente.UseVisualStyleBackColor = true;
            // 
            // rbSubGerente
            // 
            this.rbSubGerente.AutoSize = true;
            this.rbSubGerente.Location = new System.Drawing.Point(358, 195);
            this.rbSubGerente.Name = "rbSubGerente";
            this.rbSubGerente.Size = new System.Drawing.Size(86, 19);
            this.rbSubGerente.TabIndex = 6;
            this.rbSubGerente.TabStop = true;
            this.rbSubGerente.Text = "SubGerente";
            this.rbSubGerente.UseVisualStyleBackColor = true;
            // 
            // rbSecretaria
            // 
            this.rbSecretaria.AutoSize = true;
            this.rbSecretaria.Location = new System.Drawing.Point(605, 195);
            this.rbSecretaria.Name = "rbSecretaria";
            this.rbSecretaria.Size = new System.Drawing.Size(76, 19);
            this.rbSecretaria.TabIndex = 7;
            this.rbSecretaria.TabStop = true;
            this.rbSecretaria.Text = "Secretaria";
            this.rbSecretaria.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(319, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(166, 33);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbSecretaria);
            this.Controls.Add(this.rbSubGerente);
            this.Controls.Add(this.rbGerente);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblProblema1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProblema1;
        private Label lblNombre;
        private Label lblSalario;
        private TextBox tbNombre;
        private TextBox tbSalario;
        private RadioButton rbGerente;
        private RadioButton rbSubGerente;
        private RadioButton rbSecretaria;
        private Button btnCalcular;
    }
}