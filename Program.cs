namespace ScintiDose0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string categorieExamen = "coeur";
            //string categorieExamen = "ventriculographie";

            string categorieExamen = "osseuse";
            int poidsPatient = 75;
            string heureInjection = "09:30";
            string heurePreparation = "07:30";

            Exam calculExamen = new Exam(categorieExamen, poidsPatient);

            double lowerDose = Math.Round(calculExamen.ActivityP25(),2);
            double midDose = Math.Round(calculExamen.ActivityP50(), 2);
            double higherDose = Math.Round(calculExamen.ActivityP75(), 2);

            Console.WriteLine($"Activité de produit \"{categorieExamen}\" à administrer à {heureInjection} pour un patient de {poidsPatient}Kg:\r\nMinimum {lowerDose}mci   |   Idéalement {midDose}mci   |   Maximum : {higherDose}mci \r\n");

            DecayCalc lowerDosePreparation = new DecayCalc(heureInjection, heurePreparation, lowerDose);
            DecayCalc midDosePreparation = new DecayCalc(heureInjection, heurePreparation, midDose);
            DecayCalc higherDosePreparation = new DecayCalc(heureInjection, heurePreparation, higherDose);

            Console.WriteLine($"L'activité idéale à préparer à {heurePreparation} pour qu'il ait  {midDose} à {heureInjection}: {Math.Round(midDosePreparation.Operate(), 2)}mCi.\r\nL'activité minimale à préparer: {Math.Round(lowerDosePreparation.Operate(), 2)}mCi. Activité maximale: {Math.Round(higherDosePreparation.Operate(), 2)}mCi.");
            
            Console.ReadKey();
        }
    }
}
