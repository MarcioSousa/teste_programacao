using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void txtNumeroCarros_TextChanged(object sender, EventArgs e)
        {
            calculaSfVendedor();
        }

        private void calculaSfVendedor()
        {
            double salarioFinal = 0;
            if(txtNumeroCarros.Text != "" && txtSalarioFixo.Text != "" && txtTotalVanda.Text != "" && txtValorRecebe.Text != "")
            {
                salarioFinal = Convert.ToDouble(txtSalarioFixo.Text);
                salarioFinal = salarioFinal + (Convert.ToInt32(txtNumeroCarros.Text) * Convert.ToDouble(txtValorRecebe.Text));
                salarioFinal = salarioFinal + Convert.ToDouble(txtTotalVanda.Text) * 0.05;
            }

            txtSalarioFinalVendedor.Text = salarioFinal.ToString();
        }

        private void txtTotalVanda_TextChanged(object sender, EventArgs e)
        {
            calculaSfVendedor();
        }

        private void txtSalarioFixo_TextChanged(object sender, EventArgs e)
        {
            calculaSfVendedor();
        }

        private void txtValorRecebe_TextChanged(object sender, EventArgs e)
        {
            calculaSfVendedor();
        }
    }
}
