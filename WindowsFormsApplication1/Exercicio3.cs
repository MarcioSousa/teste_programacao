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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {
            string resultado = "";
            int aux = 0;
            int[] valores = new int[8] { 5, 1, 4, 2, 7, 8, 3, 6 };

            //FOI RETIRADO -1 DE I, POIS HÁ 8 VETORES, INICIANDO DO 0 ATÉ A 7ª POSIÇÃO DO VETOR.
            //CASO NÃO RETIRE, DÁ ERRO QUE ESTÁ FORA DO ÍNDICE DA MATRIZ (POSIÇÃO 8, QUE NÃO EXISTE)
            for(int i = 8; i >= 5; i--)
            {
                aux = valores[i-1];
                valores[i-1] = valores[8 - (i-1) + 1];
                valores[8 - (i-1) + 1] = aux;
            }

            //AQUI FIQUEI NA DÚVIDA SE DECREMENTARIA 1 DO VETOR.
            //CASO FOSSE:
            //valores[3-1] = valores[1-1];
            //valores[valores[3-1]] = valores[valores[2-1]];
            valores[3] = valores[1];
            valores[valores[3]] = valores[valores[2]];

            //MOSTRANDO O RESULTADO NO OBJETO TEXTBOX
            for(int t = 0; t < valores.Length; t++)
            { 
                resultado += valores[t].ToString() + " ";
            }

            txtResultado.Text = resultado;

        }
    }
}
