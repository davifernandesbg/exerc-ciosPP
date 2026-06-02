namespace C_exercicios
{
    partial class frmDolar
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
            this.lblCotacao = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotacao
            // 
            this.lblCotacao.AutoSize = true;
            this.lblCotacao.Location = new System.Drawing.Point(260, 137);
            this.lblCotacao.Name = "lblCotacao";
            this.lblCotacao.Size = new System.Drawing.Size(178, 13);
            this.lblCotacao.TabIndex = 0;
            this.lblCotacao.Text = "Digite a cotação do dolar para reais:";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(312, 180);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(126, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Digite o valor em dolares:";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(308, 223);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(130, 13);
            this.lblReal.TabIndex = 2;
            this.lblReal.Text = "O valor em reais é de R$: ";
            // 
            // txtCotacao
            // 
            this.txtCotacao.Location = new System.Drawing.Point(444, 134);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(100, 20);
            this.txtCotacao.TabIndex = 3;
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(444, 220);
            this.txtReal.Name = "txtReal";
            this.txtReal.ReadOnly = true;
            this.txtReal.Size = new System.Drawing.Size(100, 20);
            this.txtReal.TabIndex = 4;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(444, 177);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(21, 364);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(102, 364);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(183, 364);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblCotacao);
            this.Name = "frmDolar";
            this.Text = "Conversor de Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotacao;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}