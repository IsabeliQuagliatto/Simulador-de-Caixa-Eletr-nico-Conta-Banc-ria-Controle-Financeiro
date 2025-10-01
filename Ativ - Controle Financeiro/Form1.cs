using System.Numerics;

namespace Ativ___Controle_Finaneceiro
{
    public partial class Form1 : Form
    {
        double valor;
        string descr;
        string data;
        double total = 0.0;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
            sw = new StreamWriter("C:\\Users\\Aluno\\Downloads\\ControleFinanceiro.csv");
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            descr = txbDescr.Text;
            data = txbData.Text;

            if (descr == "")
            {
                MessageBox.Show("Campo descri��o n�o pode ser v�zio!");
                return;
            }

            if (data == "")
            {
                MessageBox.Show("Campo data n�o pode ser v�zio!");
                return;
            }

            try
            {
                double valor = double.Parse(txbValor.Text);
                if (valor <= 0.0)
                {
                    MessageBox.Show("Valor inv�lido. Apenas n�meros maiores que Zero s�o aceitos!");
                    return;
                }
                total -= valor;

                sw.WriteLine(txbData.Text + ";" + txbDescr.Text + ";" + "- R$" + txbValor.Text);

                MessageBox.Show("Movimenta��o cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txbValor.Text = "";
            txbDescr.Text = "";
            txbData.Text = "";

            lblSaldo.Text = total.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            sw.WriteLine("\nTotal" + "; ;R$ " + total);
            sw.Close();

            MessageBox.Show("Exportado com sucesso!");
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            descr = txbDescr.Text;
            data = txbData.Text;

            if (descr == "")
            {
                MessageBox.Show("Campo descri��o n�o pode ser v�zio!");
                return;
            }

            if (data == "")
            {
                MessageBox.Show("Campo data n�o pode ser v�zio!");
                return;
            }

            try
            {
                double valor = double.Parse(txbValor.Text);
                if (valor <= 0.0)
                {
                    MessageBox.Show("Valor inv�lido. Apenas n�meros maiores que Zero s�o aceitos!");
                    return;
                }

                total += valor;

                sw.WriteLine(txbData.Text + ";" + txbDescr.Text + ";" + "+ R$" + txbValor.Text);

                MessageBox.Show("Movimenta��o cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txbValor.Text = "";
            txbDescr.Text = "";
            txbData.Text = "";

            lblSaldo.Text = total.ToString("F2");
        }
    }
}
