using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ulatina.Topicos.AdventureWorks.ModelTests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void ConvertirVeincintoCentimetrosEnPulgadas()
        {
            //preparacion del escenario
            var elProducto = new Model.Product();
            elProducto.SizeUnitMeasureCode = "CM";
            elProducto.Size = "25";
            var elResultadoEsperado = "9.84 in";

            //ejecuto el metodo correspondiente
            var elResultadoActual = elProducto.SizeInInches;

            //verifico la correctitud del resultado
            Assert.AreEqual(elResultadoEsperado, elResultadoActual);
        }
    }
}
