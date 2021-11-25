using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLogic;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Resultado_con_entrada_de_Valor_12()
        {
            var fb = new FizzBuzzClass();
            int valor = 12;


            var respuesta = fb.PrintNums(valor);

            Assert.AreEqual("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,", respuesta);
        }

        [TestMethod]
        public void Cuando_la_Cantidad_sea_55_el_resultado_debe_ser_Buzz()
        {
            var fb = new FizzBuzzClass();
            int valor = 55;


            var respuesta = fb.Validate(valor);

            Assert.AreEqual("Buzz", respuesta);
        }

        [TestMethod]
        public void Cuando_la_Cantidad_sea_44_el_resultado_debe_ser_Buzz()
        {
            var fb = new FizzBuzzClass();
            int valor = 44;


            var respuesta = fb.Validate(valor);

            Assert.AreEqual("44", respuesta);
        }

        [TestMethod]
        public void Cuando_la_Cantidad_sea_15_el_resultado_debe_ser_Buzz()
        {
            var fb = new FizzBuzzClass();
            int valor = 15;


            var respuesta = fb.Validate(valor);

            Assert.AreEqual("FizzBuzz", respuesta);
        }

        [TestMethod]
        public void Cuando_la_Cantidad_sea_30_el_resultado_debe_ser_Buzz()
        {
            var fb = new FizzBuzzClass();
            int valor = 30;


            var respuesta = fb.Validate(valor);

            Assert.AreEqual("FizzBuzz", respuesta);
        }


        [TestMethod]
        public void Cuando_la_Cantidad_sea_20_el_resultado_debe_ser_Buzz()
        {
            var fb = new FizzBuzzClass();
            int valor = 20;


            var respuesta = fb.Validate(valor);

            Assert.AreEqual("Buzz", respuesta);
        }

        [TestMethod]
        public void Cuando_la_Cantidad_sea_7_el_resultado_debe_ser_Buzz()
        {
            var fb = new FizzBuzzClass();
            int valor = 7;


            var respuesta = fb.Validate(valor);

            Assert.AreEqual("7", respuesta);
        }
    }
}
