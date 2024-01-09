namespace RandomNumberGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();          // Instantiates a random object called "random"
            int num = random.Next(1,7);            // Generates a random number within a set range (1-6 in this case)
            double number = random.NextDouble();   // Generates a random number between 0 - 1
            
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
