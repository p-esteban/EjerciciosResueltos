using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace CalculadoraStringTest
{
    [TestClass]
    public class CalculadoraStringTest
    {
        [TestMethod]
        public void Retorna_0_Cuando_Recibe_Empty()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            // Act
            int resultado = calculadora.Add("");

            //Assert
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Retorna_Numero_Cuando_Recibe_UnNumero()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            // Act
            int resultado = calculadora.Add("1");

            //Assert
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_DosNumero()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            // Act
            int resultado = calculadora.Add("4,6");

            //Assert
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_CualquierCantidadDeNumeros()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            // Act
            int resultado = calculadora.Add("1\n2,3,4");

            //Assert
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_CualquierDelimitador()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            // Act
            int resultado = calculadora.Add("//.1 .2,3,4");

            //Assert
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Lanza_Excepcion_Cuando_Recibe_NumNegativo()
        {
            //Arrange
            CalculadoraString calculadora = new CalculadoraString();
            // Act
            int resultado = calculadora.Add("//.-1.2,3,4");
        }

    }
}
