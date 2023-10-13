namespace Design_PatternAssignment
{
    public interface IDrink
    {
         void DrinkSize(int size);
    }

    public class CocaCola : IDrink
    {
        public void DrinkSize(int size)
        {
            System.Console.WriteLine($"The type of drink you choose is Cocacola and the size is {size}Litre(s)");
        }
    }

    public class Pepsi : IDrink
    {
        public void DrinkSize(int size)
        {
            System.Console.WriteLine($"The type of drink you choose is Pepsi and the size is {size}Litre(s)");
        }
    }

    public class Sprite : IDrink
    {
        public void DrinkSize(int size)
        {
            System.Console.WriteLine($"The type of drink you choose is Sprite and the size is {size}Litre(s)");
        }
    }

    public class Fanta : IDrink
    {
        public void DrinkSize(int size)
        {
            System.Console.WriteLine($"The type of drink you choose is Fanta and the size is {size}Litre(s)");
        }
    }

    public static class DrinkFactory
    {
        public static IDrink GetDrink(string drinkName)
        {
            switch (drinkName.ToLower())
            {
                case "cocacola":
                    return new CocaCola();
                case "pepsi":
                    return new Pepsi();
                case "sprite":
                    return new Sprite();
                case "fanta":
                    return new Fanta();

                default:
                    throw new ArgumentException("Invalid drink type specified");
            }
        }
    }
}