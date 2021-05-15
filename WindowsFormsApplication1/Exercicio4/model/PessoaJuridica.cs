using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Exercicio4
{
    public class PessoaJuridica : Pessoa
    {
        private int cnpj;

        public PessoaJuridica(int cnpj, string nome) : base(nome)
        {
            this.cnpj = cnpj;
        }

        public int getCnpj()
        {
            return cnpj;
        }

        public void setCnpj(int val)
        {
            this.cnpj = val;
        }

    }
}
