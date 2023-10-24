using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vali
{
    public class ValidacoesLista
    {
        public readonly List<int> Lista;

        public ValidacoesLista()
        {
            Lista = new List<int>() { -8, -4, -1, 1, 3, 5, 9 };
        }

        public List<int> RemoverNumerosNegativos()
        {
            Lista.RemoveAll(x => x < 0);
            return Lista;
        }

        public bool ListaContemDeterminadoNumero(int valor)
        {
            return Lista.Contains(valor);
        }

        public List<int> MultiplicarNumerosLista(int valor)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Lista[i] *= valor;
            }
            return Lista;
        }

        public int RetornarMaiorNumeroLista()
        {
            int maiorValor = int.MinValue;

            foreach (int valor in Lista)
            {
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }
            return maiorValor;
        }

        public int RetornarMenorNumeroLista()
        {
            int menorValor = int.MaxValue;

            foreach (int valor in Lista)
            {
                if (valor < menorValor)
                {
                    menorValor = valor;
                }
            }
            return menorValor;
        }
    }
}
