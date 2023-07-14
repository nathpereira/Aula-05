using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05_MaqdeComida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bntCoca_Click(object sender, EventArgs e)
        {
            double produto = 5;
            double valor = double.Parse(txtValor.Text);
            double conta = valor - produto;
            if ( conta < 0)
            {
                MessageBox.Show("Você não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnFantaLaranja_Click(object sender, EventArgs e)
        {
            double produto = 7;
            double valor = double.Parse(txtValor.Text);
            double conta = valor - produto;
            if (conta < 0)
            {
                MessageBox.Show("Você não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnFantaUva_Click(object sender, EventArgs e)
        {
            double produto = 5.50;
            double valor = double.Parse(txtValor.Text);
            double conta = valor - produto;
            if (conta < 0)
            {
                MessageBox.Show("Você não tem saldo suficiente");
            }
            else
            {
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }
    }
}
