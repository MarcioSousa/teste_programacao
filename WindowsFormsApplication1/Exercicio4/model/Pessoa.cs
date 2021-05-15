using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Exercicio4
{
    public class Pessoa
    {
        private string nome;

        public Pessoa(String nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(String val)
        {
            this.nome = val;
        }

    }
}
