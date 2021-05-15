using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Exercicio4
{
    public class PessoaFisica : Pessoa
    {
        private int cpf;

        public PessoaFisica(int cpf, string nome) : base(nome)
        {
            this.cpf = cpf;
        }

        public int getCpf()
        {
            return cpf;
        }

        public void setCpf(int val)
        {
            this.cpf = val;
        }

    }
}
