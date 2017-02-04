using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ulatina.Topicos.Calculadora.Tests
{
    [TestClass]
    public class BusinessLogic
    {
        [TestMethod]
        public void SumarTodosLosElementosEnCero()
        {
            // preparaci[on del escenario
            List<double> miLista = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double elResultadoEsperado = 0.0;
            
            // invoque al método requerido
            var laAccion = new Ulatina.Topicos.Calculadora.Dominio.Acciones.Sumar();
            var elResultadoObtenido = laAccion.RealizarOperacion(miLista);

            // realice las verificaciones de si la invocación devolvió el resultado esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
