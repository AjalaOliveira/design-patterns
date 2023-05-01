namespace FactoryMethod
{
    public class Cat : IAnimal
    {
        public string GetAnimal()
        {
            return this.GetType().Name;
        }
    }
}
