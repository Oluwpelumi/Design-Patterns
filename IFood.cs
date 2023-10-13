namespace Design_PatternAssignment
{
    public interface IFood
    {
        void TakeRice();
        void TakeBeans();
    }

    public class GetFoood : IFood
    {
        private Food food = new Food();

        public void TakeRice()
        {
            food.ServeRice("Rice");
        }

        public void TakeBeans()
        {
            food.ServeBeans("Beans");
        }
        public Food BringFood() => food;

    }


    public class Food
    {
        private string food1;
        private string food2;

        public void ServeRice(string food)
        {
            food1 = food;
        }
        public void ServeBeans(string food)
        {
            food2 = food;
        }

        public void Show()
        {
            System.Console.WriteLine($"Food1: {food1}");
            System.Console.WriteLine($"Food2: {food2}");
        }
    }
}

