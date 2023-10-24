using Xunit;
using System;
using Vali;

namespace ListaStringTests
{
    public class ListaStringTests
    {
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            ValidacoesString valor = new ValidacoesString("Matriz");

            int result = valor.RetornarQuantidadeCaracteres();

            Assert.Equal(6 , result);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            ValidacoesString valor = new ValidacoesString("Esse é um texto qualquer");

            bool result = valor.ContemCaractere("qualquer");

            Assert.True(result);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            ValidacoesString valor = new ValidacoesString("Esse é um texto qualquer");

            bool result = valor.ContemCaractere("teste");

            Assert.False(result);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            ValidacoesString valor = new ValidacoesString("Começo, meio e fim do texto procurado");

            bool result = valor.ContemCaractere("procurado");
            bool end = valor.TextoTerminaCom("procurado");

            Assert.Equal(result , end);
        }
    }
}