using Projeto_Testes;

namespace Testes
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3,2,5)]
        [InlineData(1, 2, 3)]
        public void TestarSoma(int n1, int n2,int result)
        {

            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.Somar(n1,n2);

            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(5,2,3)]
        [InlineData(10,3,7)]
        public void TestarSubtracao(int n1, int n2, int result)
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.Subtrair(n1,n2);

            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(2,5,10)]
        [InlineData(3,7,21)]
        public void TestarMultiplicacao(int n1, int n2, int result)
        {
            Calculadora cal = new Calculadora();

            int resultado = cal.Multiplicar(n1,n2);

            Assert.Equal(result, resultado);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(21,3,7)]
        public void TestarDivisao(int n1, int n2, int result)
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.Dividir(n1, n2);

            Assert.Equal(result, resultado);
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Somar(1, 4);
            calculadora.Somar(1, 2);
            calculadora.Somar(2, 12);
            calculadora.Dividir(4, 2);


            Assert.NotEmpty(calculadora.HistoticoDeOperacoes());
            Assert.Equal(3,calculadora.HistoticoDeOperacoes().Count());
        }
    }
}