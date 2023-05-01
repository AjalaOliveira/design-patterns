namespace FactoryMethod
{
    public class Dog : IAnimal
    {
        public string GetAnimal()
        {
            return this.GetType().Name;
        }
    }
}
