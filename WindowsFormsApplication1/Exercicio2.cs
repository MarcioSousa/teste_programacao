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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void Exercicio2_Load(object sender, EventArgs e)
        {
            string frase = "";

            for(int t = 0; t < 10; t++)
            {
                frase += (t+1).ToString() + ", ";
                for(int a = 0; a < 10; a++)
                {
                    frase+= (a+1).ToString() + " ";
                }
                frase+= System.Environment.NewLine;
            }
            txtResultado.Text = frase;

        }
    }
}
