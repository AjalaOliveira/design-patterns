namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            Console.WriteLine("Ferrari - Porshe - Mustang");
            Console.WriteLine("Choose your car:	");
            string choice = Console.ReadLine();
            ICar car = factoryMethod.ChooseCar(choice);

            Console.WriteLine($"You've chosen '{car.ShowCarName()}'.");
        }
    }
}