namespace C_exercicios
{
    partial class frmQuadrado
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
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(287, 112);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(123, 13);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Digite o primeiro número:";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(286, 148);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(128, 13);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "Digite o segundo número:";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(287, 188);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(122, 13);
            this.lblN3.TabIndex = 2;
            this.lblN3.Text = "Digite o terceiro número:";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(286, 223);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(117, 13);
            this.lblN4.TabIndex = 3;
            this.lblN4.Text = "Digite o quarto número:";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(287, 259);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(206, 13);
            this.lblSoma.TabIndex = 4;
            this.lblSoma.Text = "A soma dos quadrados desses números é:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(415, 109);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 5;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(415, 145);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 6;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(415, 181);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 20);
            this.txtN3.TabIndex = 7;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(415, 220);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(100, 20);
            this.txtN4.TabIndex = 8;
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(499, 256);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.ReadOnly = true;
            this.txtSoma.Size = new System.Drawing.Size(100, 20);
            this.txtSoma.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 363);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(105, 363);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(186, 363);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Name = "frmQuadrado";
            this.Text = "Soma dos quadrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}