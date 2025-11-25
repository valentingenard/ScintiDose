namespace ScintiDose0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecayCalc decay = new DecayCalc("09:30", "07:30", 20);
            Console.WriteLine(decay.Operate());
            Console.ReadKey();
        }
    }
}
