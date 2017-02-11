using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Dominio.Especificaciones
{
    public class Multiplique
    {
        internal double CalcularResultado(IEnumerable<double> laLista)
        {
            double elResultado = 1;

            var laValidacion = new Dominio.Validaciones.RealizarValidaciones();
            if (laValidacion.LaListaNoContieneNingunElemento(laLista))
                elResultado = 0;

            foreach (var elItemDeLaLista in laLista)
            {
                elResultado *= elItemDeLaLista;
            }
            return elResultado;
        }
    }
}