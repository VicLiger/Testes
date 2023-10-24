using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vali
{
    public class ValidacoesString
    {
        private readonly string valor;

        public ValidacoesString(string valor)
        {
            this.valor = valor;
        }

        public int RetornarQuantidadeCaracteres()
        {
            return valor.Length;
        }

        public bool ContemCaractere(string texto)
        {
            return valor.Contains(texto);
        }

        public bool TextoTerminaCom(string texto)
        {
            return valor.EndsWith(texto);
        }
    }
}
