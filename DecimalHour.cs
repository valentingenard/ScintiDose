using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
            if (!Hour.Contains(":")) 
                throw new FormatException("Hours and minuts must be separated by : (ex: HH:mm). ");

            var hours = Hour.Split(':');

            if (hours.Length != 2)
                throw new FormatException("Invalid time format. Expected HH:mm");

            if (!int.TryParse(hours[0], out int h) ||
                !int.TryParse(hours[1], out int min))
                throw new FormatException("Invalid numeric format for hours or minutes.");

            if (h < 0 || min < 0 || min >= 60)
                throw new FormatException("Les minutes ou les heures fournies sont hors limites logiques (min >= 60 ou négatif).");
            
            return (h + (min / 60.0));
        }
    }
}
