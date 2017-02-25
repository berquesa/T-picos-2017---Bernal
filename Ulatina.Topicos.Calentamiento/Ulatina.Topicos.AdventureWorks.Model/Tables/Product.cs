using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulatina.Topicos.AdventureWorks.Model
{
    public partial class Product
    {
        public string SizeInInches
        {
            get
            {
                double laConversion;
                double lasPulgadas;
                string elResultado = string.Empty;
                if (SizeUnitMeasureCode == "CM")
                {
                    if (double.TryParse(Size, out laConversion))
                    {
                        lasPulgadas = Math.Round(laConversion / 2.54, 2);
                        elResultado = string.Format("{0} in", lasPulgadas.ToString());
                    }
                    else
                        elResultado = "error";
                }
                else
                    elResultado = "unidad desconocida";
                return elResultado;
            }
        }

        public string WeigthInKilos
        {
            get
            {
                decimal? losKilos;
                string elResultado = string.Empty;
                switch (WeightUnitMeasureCode)
                {
                    case "":
                        elResultado = Weight.ToString();
                        break;
                    case "G":
                        losKilos = (decimal?) Math.Round((double)Weight / 1000, 2);
                        elResultado = string.Format("{0} kg", losKilos.ToString());
                        break;
                    case "LB":
                        losKilos = (decimal?) Math.Round((double)Weight / 2.20462, 2);
                        elResultado = string.Format("{0} kg", losKilos.ToString());
                        break;
                    default:
                        elResultado = "Unidad Desconocida";
                        break;
                }
                return elResultado;
            }
        }
    }
}
