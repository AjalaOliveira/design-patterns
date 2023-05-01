namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IAnimal? CreateClass(string personagem)
        {
            switch (personagem)
            {
                case "1": return new Cat();
                case "2": return new Dog();
                case "3": return new Fish();
                default: return null;
            }
        }
    }
}
