namespace ScintiDose0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DecayCalc decay = new DecayCalc("","",3);
            //DecimalHour heure = new DecimalHour("08:EZ");
            //DecimalHour heure2 = new DecimalHour("09:20");

            DecimalHour heure3 = new DecimalHour("08:20");
            DecimalHour heure4 = new DecimalHour("09:20");

            DecayCalc decay = new DecayCalc("09:30", "07:30", 20);
            Console.WriteLine(decay.Operate());

            //Console.WriteLine(heure2.Result() - heure.Result());
            Console.WriteLine(heure4.Result() - heure3.Result());
            Console.ReadKey();
        }
    }
}
