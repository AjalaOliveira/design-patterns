namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICar? ChooseCar(string personagem)
        {
            switch (personagem)
            {
                case "Ferrari": return new Ferrari();
                case "Porshe": return new Porshe();
                case "Mustang": return new Mustang();
                default: return null;
            }
        }
    }
}