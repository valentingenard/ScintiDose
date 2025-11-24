using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScintiDose0._1
{
    internal class DecimalHour
    {
        // Stocke l'heure au format "HH:mm"
        // Convertit "HH:mm" en un décimal d'heures (ex: "03:30" = 3.5).
        private string Hour { get; set; }
        public DecimalHour(string hour)
        {
            Hour = hour;
        }

        public double Result() 
        {
            var hours = Hour.Split(':');
            double h = double.Parse(hours[0], CultureInfo.InvariantCulture);
            double min = double.Parse(hours[1], CultureInfo.InvariantCulture);
            if (h < 0 || min < 0 || min >= 60)
            {
                throw new FormatException("Les minutes ou les heures fournies sont hors limites logiques (min >= 60 ou négatif).");
            }
            return (h + (min / 60));
        }


        

    }
}
