using FizzBuzzTDD;
namespace FizzBuzzXUnitTest
{
    //Escribir una funcion que al pasarle un numero:
    //Muestra "fizz" si es multiplo de 3
    //Muestra "buzz" si es multiplo de 5
    //muestra "fizzbuzz" si es multiplo de 3 y 5
    //Muestra el numero si no es multiplo de ninguno de los anteriores
    public class FizzBuzzXUnitTests
    {
        private FizzBuzz fizzBuzz;

        public FizzBuzzXUnitTests()
        {
            fizzBuzz = new FizzBuzz();
        }
        [Fact]
        public void fizzbuzz_InputNumber1_Returns1()
        {
            var valor = 1;
            var resultado = fizzBuzz.Obtener(valor);

            Assert.Equal("1" , resultado);
        }

        [Fact]
        public void fizzbuzz_InputNumber2_Returns2()
        {
            var valor = 2;
            var resultado = fizzBuzz.Obtener(valor);

            Assert.Equal("2" , resultado);
        }

        [Fact]
        public void fizzbuzz_IntputNumber3_RetornsFizz()
        {
            var valor = 3;
            var resultado = fizzBuzz.Obtener(valor);

            Assert.Equal("fizz" , resultado);
        }

        // [Fact]
        // public void fizzbuzz_InputNumber4_Returns4()
        // {
        //     var valor = 4;
        //     var resultado = fizzBuzz.Obtener(valor);
        //
        //     Assert.Equal("4", resultado);
        // }

        [Theory]
        [InlineData(6, "fizz")]
        [InlineData(9, "fizz")]
        [InlineData(12, "fizz")]
        public void fizzbuzz_InputMultiplosDeTres_Returnsfizz(int valor, string expectedResult)
        {
            var resultado = fizzBuzz.Obtener(valor);

            Assert.Equal(expectedResult, resultado);
        }

        [Fact]
        public void fizzbuzz_InputNumber5_Returnsbuzz()
        {
            var result = fizzBuzz.Obtener(5);

            Assert.Equal("buzz", result);
        }

        [Theory]
        [InlineData(10, "buzz")]
        [InlineData(20, "buzz")]
        public void fizzbuzz_InputMultiplosDeCinco_Returnsbuzz(int valor, string expectedResult)
        {
            var resultado = fizzBuzz.Obtener(valor);

            Assert.Equal(expectedResult, resultado);
        }

        [Fact]
        public void fizzbuzz_InputMultiploDeTresYCinco_Returnsfizzbuzz()
        {
            var resultado = fizzBuzz.Obtener(15);
            Assert.Equal("fizzbuzz", resultado);
        }
    }
}
