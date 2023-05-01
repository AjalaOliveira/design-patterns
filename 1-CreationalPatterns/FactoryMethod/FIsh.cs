namespace FactoryMethod
{
    public class Fish : IAnimal
    {
        public string GetAnimal()
        {
            return this.GetType().Name;
        }
    }
}
