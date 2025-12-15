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

        public DecayCalc(string injectionTime, string preparationTime, double activity)
        {
            if (string.IsNullOrWhiteSpace(preparationTime))
                throw new ArgumentException("DecayCalc: Preparation time cannot be empty.");

            if (string.IsNullOrWhiteSpace(injectionTime))
                throw new ArgumentException("DecayCalc: Injection time cannot be empty.");

            if (activity <= 0)
                throw new ArgumentException("DecayCalc: Activity must be positive.");

            PreparationTime = preparationTime;
            InjectionTime = injectionTime;
            Activity = activity; 
        }

        public double Operate() 
        {

                DecimalHour inj = new DecimalHour(InjectionTime);
                DecimalHour prep = new DecimalHour(PreparationTime);
                double elapsed =  inj.Result() - prep.Result();

            if (elapsed < 0) 
                {
                    throw new InvalidOperationException("DecayCalc: Elapsed time cannot be negative.");
                }

            double decayFactor = Math.Pow(2, elapsed / 6.0);
            return Activity * decayFactor;
        }

        public double OperateThirtyMinutsLess()
        {
            DecimalHour inj = new DecimalHour(InjectionTime);
            DecimalHour prep = new DecimalHour(PreparationTime);
            double elapsed = (inj.Result()-0.5) - prep.Result();

            if (elapsed < 0)
            {
                throw new InvalidOperationException("DecayCalc: Elapsed time cannot be negative.");
            }

            double decayFactor = Math.Pow(2, elapsed / 6.0);
            return Activity * decayFactor;
        }
    }
}
