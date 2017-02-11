using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Dominio.Validaciones
{
    public class RealizarValidaciones
    {
        public bool LaListaContieneAlMenosUnElemento(IEnumerable<double> laLista)
        {
            return (laLista.Count() > 0);
        }

        public bool LaListaNoContieneNingunElemento(IEnumerable<double> laLista)
        {
            return (! LaListaContieneAlMenosUnElemento (laLista));
        }
    }
}