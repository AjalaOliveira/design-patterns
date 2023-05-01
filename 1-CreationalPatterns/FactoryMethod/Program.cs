namespace FactoryMethod
{
    public static class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            Console.WriteLine("Choose an animal:");
            Console.WriteLine("1 - Cat");
            Console.WriteLine("2 - Dog");
            Console.WriteLine("3 - Fish");
            string? choice = Console.ReadLine();
            IAnimal animal = factoryMethod.CreateClass(choice);
            Console.WriteLine();
            Console.Write($"You've chosen a '{animal?.GetAnimal()}'.");
            Console.ReadKey();
        }
    }
}
