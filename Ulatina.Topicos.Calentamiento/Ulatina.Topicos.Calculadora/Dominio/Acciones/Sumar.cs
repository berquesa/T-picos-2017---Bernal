using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Dominio.Acciones
{
    public class Sumar
    {
        /// <summary>
        /// realiza la operación de suma.
        /// </summary>
        /// <param name="laLista">La lista de los elementos que se desean operar</param>
        /// <returns>Resultado de aplicar el operador a cada uno de los términos de la lista.</returns>
        public double RealizarOperacion(IEnumerable<double> laLista)
        {
            double elResultado = 0;
            Dominio.Especificaciones.Sume laEspecificacion = new Dominio.Especificaciones.Sume();
            elResultado = laEspecificacion.CalcularResultado(laLista);
            return elResultado;
        }

    }
}