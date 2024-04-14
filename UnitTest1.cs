using ProjetoDeEstudo;

namespace TestProjetoDeEstudo
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "14/04/2024";
            Calculadora calc = new Calculadora("14/04/2024");

            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.somar(valor1, valor2);
            
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void TesteSubtrair(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 6, 12)]
        [InlineData(10, 5, 50)]
        public void TesteMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDividirPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.somar(1, 2);
            calc.somar(29, 29);
            calc.somar(30, 30);

            var lista = calc.historico();
            
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}