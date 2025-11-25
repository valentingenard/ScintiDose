using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScintiDose0._1
{
    internal class DecayCalc
    {
        string PreparationTime {  get; }
        string InjectionTime { get; }
        double Activity {  get; }

        public DecayCalc(string preparationTime, string injectionTime, double activity)
        {
            if (string.IsNullOrWhiteSpace(preparationTime))
                throw new ArgumentException("Preparation time cannot be empty.");

            if (string.IsNullOrWhiteSpace(injectionTime))
                throw new ArgumentException("Injection time cannot be empty.");

            if (activity <= 0)
                throw new ArgumentException("Activity must be positive.");

            PreparationTime = preparationTime;
            InjectionTime = injectionTime;
            Activity = activity;
        }

        public double Operate() 
        {

                DecimalHour inj = new DecimalHour(InjectionTime);
                DecimalHour prep = new DecimalHour(PreparationTime);
                double elapsed = prep.Result() - inj.Result();

            if (elapsed < 0) 
                {
                    throw new InvalidOperationException("Elapsed time cannot be negative.");
                }
            return Activity* Math.Pow(2, (elapsed / 6.0));
        }
    }
}
