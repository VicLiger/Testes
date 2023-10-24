using Xunit;
using System;
using Vali;

namespace ListaTests
{
    public class ListaTests
    {
        [Fact] // O atributo Fact define um método de teste xUnit
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange (Preparação)
            ValidacoesLista lista = new ValidacoesLista();

            // Act (Ação)
            List<int> result = lista.RemoverNumerosNegativos();

            // Assert (Asserção)
            Assert.Equal(new List<int> { 1, 3, 5, 9 }, result);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange (Preparação)
            ValidacoesLista lista = new ValidacoesLista();

            bool number = lista.ListaContemDeterminadoNumero(9);

            Assert.True(number);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            ValidacoesLista lista = new ValidacoesLista();

            bool number = lista.ListaContemDeterminadoNumero(10);

            Assert.False(number);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            ValidacoesLista lista = new ValidacoesLista();

            List<int> number = lista.MultiplicarNumerosLista(2);

            Assert.Equal(new List<int> { -16, -8, -2, 2, 6, 10, 18 }, number);

        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            ValidacoesLista lista = new ValidacoesLista();

            int number = lista.RetornarMaiorNumeroLista();

            Assert.Equal(9, number);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
        {
            ValidacoesLista lista = new ValidacoesLista();

            int number = lista.RetornarMenorNumeroLista();

            Assert.Equal(-8, number);
        }
    }
}