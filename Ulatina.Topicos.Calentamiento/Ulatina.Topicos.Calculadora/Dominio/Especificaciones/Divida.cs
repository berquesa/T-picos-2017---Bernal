using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Dominio.Especificaciones
{
    public class Divida
    {
        internal double CalcularResultado(IEnumerable<double> laLista)
        {
            double elResultado = 0;
            var laValidacion = new Dominio.Validaciones.RealizarValidaciones();

            if (laValidacion.LaListaContieneAlMenosUnElemento(laLista))
            {
                elResultado = laLista.First();
                var laListaParaRecorrer = laLista.Skip(1);
                foreach (var elItemDeLaLista in laListaParaRecorrer)
                {
                    if (elItemDeLaLista != 0)
                        elResultado /= elItemDeLaLista;
                    else
                        throw new Exception("Ocurrió una división por cero");
                }
            }
            return elResultado;
        }
    }
}