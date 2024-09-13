namespace ConversorC
{
    partial class Form1
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
            this.lblCotacaoDolar = new System.Windows.Forms.Label();
            this.lblValorConvertido = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtValorReais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCotacaoDolar
            // 
            this.lblCotacaoDolar.AutoSize = true;
            this.lblCotacaoDolar.Location = new System.Drawing.Point(106, 72);
            this.lblCotacaoDolar.Name = "lblCotacaoDolar";
            this.lblCotacaoDolar.Size = new System.Drawing.Size(90, 13);
            this.lblCotacaoDolar.TabIndex = 0;
            this.lblCotacaoDolar.Text = "Cotacao do Dolar";
            // 
            // lblValorConvertido
            // 
            this.lblValorConvertido.AutoSize = true;
            this.lblValorConvertido.Location = new System.Drawing.Point(109, 119);
            this.lblValorConvertido.Name = "lblValorConvertido";
            this.lblValorConvertido.Size = new System.Drawing.Size(76, 13);
            this.lblValorConvertido.TabIndex = 1;
            this.lblValorConvertido.Text = "Valor em Dolar";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(460, 72);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(108, 64);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtValorReais
            // 
            this.txtValorReais.Location = new System.Drawing.Point(169, 229);
            this.txtValorReais.Name = "txtValorReais";
            this.txtValorReais.Size = new System.Drawing.Size(100, 20);
            this.txtValorReais.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor em R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorReais);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblValorConvertido);
            this.Controls.Add(this.lblCotacaoDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotacaoDolar;
        private System.Windows.Forms.Label lblValorConvertido;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtValorReais;
        private System.Windows.Forms.Label label1;
    }
}

