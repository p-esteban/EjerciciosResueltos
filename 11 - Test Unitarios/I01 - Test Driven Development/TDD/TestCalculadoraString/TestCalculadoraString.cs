using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculadora
{
    [TestClass]
    public class TestCalculadoraString
    {
        [TestMethod]
        public void Add_DeberiaRetorn0_CuandoRecibeEmpty()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            int expected = 0;

            //Act

            int actual = calculadora.Add(string.Empty);

            //Asser
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_DeberiaRetornarNumero_CuandoRecibeNumero()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            int expected = 5;

            //Act
            int actual = calculadora.Add("5");

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Add_DeberiaRetornarSuma_CuandoRecibeDosNumero()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            int expected = 3;

            //Act
            int actual = calculadora.Add("1,2");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_DeberiaRetornarSuma_CuandoRecibeCualquierCantidadDeNumeros()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            int expected = 10;

            //Act
            int actual = calculadora.Add("1,2,3,4");

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_DeberiaRetornarSuma_CuandoRecibeNumerosSeparadosPorSaltoDeLinea()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            int expected = 6;

            //Act
            int actual = calculadora.Add("1\n2,3");

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_DeberiaRetornarSuma_CuandoRecibeCualquierDelimitador()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            int expected = 10;

            //Act
            int actual = calculadora.Add("//.1.2\n3,4");

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_DeberiaLanzarExcepcion_CuandoRecibeNumeroNegativo()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();

            //Act
            int actual = calculadora.Add("//.-1,2\n3.4");


        }
    }
}
