namespace ScintiDose0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam calculExamen = new Exam("coeur", 75);
            Console.WriteLine($"l'activité que le patient dois recevoir: {calculExamen.Activity()}");
            
            DecayCalc decay = new DecayCalc("09:30", "07:30", calculExamen.Activity());
            Console.WriteLine($"L'activité à préparer à 7h30 pour qu'il ait  {calculExamen.Activity()} à 9h30: {decay.Operate()}");

            Console.ReadKey();
        }
    }
}
