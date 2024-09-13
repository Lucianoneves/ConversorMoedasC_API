using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorC
{
    public partial class Form1 : Form
    {

        private readonly ApiConversor apiConversor;
        private readonly ConversorMoedas conversorMoedas;
        public Form1()
        {
            InitializeComponent();

            apiConversor = new ApiConversor();
            conversorMoedas = new ConversorMoedas();
        }

        private async void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                // Certifique-se de que o TextBox existe e está com o nome correto
                decimal valorReais = decimal.Parse(txtValorReais.Text);

                // Obter a cotação do dólar através da API
                decimal cotacaoDolar = await apiConversor.ObterCotacaoDolarAsync();

                // Exibir a cotação do dólar
                lblCotacaoDolar.Text = $"Cotação do dólar: {cotacaoDolar:C2}";

                // Fazer a conversão de reais para dólares
                decimal valorConvertido = conversorMoedas.ConverterReaisParaDolares(valorReais, cotacaoDolar);

                // Exibir o valor convertido
                lblValorConvertido.Text = $"Valor em dólares: {valorConvertido:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

        }
    }
}
