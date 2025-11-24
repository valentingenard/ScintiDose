using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScintiDose0._1
{
    internal class DecayCalc
    {
        string Preparationtime {  get; set; }
        string Injectiontime { get; set; }
        double Activity {  get; set; }

        public DecayCalc(string preparationtime, string injectiontime, double activity)
        {
            Preparationtime = preparationtime;
            Injectiontime = injectiontime;
            Activity = activity;
        }

        public double Operate() 
        {

                DecimalHour inj = new DecimalHour(Injectiontime);
                DecimalHour prep = new DecimalHour(Preparationtime);
                if (prep.Result() - inj.Result() > 0) 
                {
                    double elapsed = prep.Result() - inj.Result();
                    //activité à prélever = activité cible * (2)exposant temps/6
                    double activiteInitiale = Activity * Math.Pow(2, (elapsed / 6));
                    return activiteInitiale;
                }
                else { throw new Exception("Elapsed time cannot be negative."); }


        }
    }
}
