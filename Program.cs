using System;
using Design_PatternAssignment;


//Number One
//FACTORY DESIGN PATTERN

// System.Console.WriteLine("Enter the type of drink you want to get (Cocacola, Pepsi, Sprite, Fanta)");
// string drinkType = Console.ReadLine();
// try
// {
//     IDrink drink = DrinkFactory.GetDrink(drinkType);
//     System.Console.WriteLine("Enter the sixe of the drink that you want");
//     int size = int.Parse(Console.ReadLine());
//     drink.DrinkSize(size);
// }
// catch (ArgumentException ex)
// {
//     System.Console.WriteLine(ex.Message);
// }




//Number Two
//ABSTRACT fACTORY DESIGN PATTERN
// IDangoteRefinery factorySouth = new SouthBranch();
// IDangoteRefinery factoryWest = new WestBranch();
// IDangoteRefinery factoryEast = new EastBranch();
// IDangoteRefinery factoryNorth = new NorthBranch();

// IRice riceSouth = factorySouth.ProduceRice();
// IFlour flourSouth = factorySouth.ProduceFlour();
// ICement cementSouth = factorySouth.ProduceCement();

// IRice riceNorth = factoryNorth.ProduceRice();
// IFlour flourNorth = factoryNorth.ProduceFlour();
// ICement cementNorth = factoryNorth.ProduceCement();

// IRice riceWest = factoryWest.ProduceRice();
// IFlour flourWest = factoryWest.ProduceFlour();
// ICement cementWest = factoryWest.ProduceCement();

// IRice riceEast = factoryEast.ProduceRice();
// IFlour flourEast = factoryEast.ProduceFlour();
// ICement cementEast = factoryEast.ProduceCement();

// riceSouth.MakeRiceSouth();
// riceNorth.MakeRiceNorth();
// riceEast.MakeRiceEast();
// riceWest.MakeRiceWest();
// System.Console.WriteLine();

// flourSouth.MakeFlourSouth();
// flourNorth.MakeFlourNorth();
// flourEast.MakeFlourEast();
// flourWest.MakeFlourWest();
// System.Console.WriteLine();

// cementSouth.MakeCementSouth();
// cementNorth.MakeCementNorth();
// cementEast.MakeCementEast();
// cementWest.MakeCementWest();





// Number Three
//BUILDER DESIGN PATTERN

// var builder = new GetFoood();
// builder.TakeRice();
// builder.TakeBeans();

// var food = builder.BringFood();
// food.Show();




//Number Four
// //SINGLETON DESIGN PATTERN
Db db1 = Db.GetInstance();
db1.Category = "Instructors";
db1.DbMethod();

Db db2 = Db.GetInstance();
db2.Category = "Students";
db2.DbMethod();

 public class Db
    {
        private static Db Instance;
        public string Category;
        private Db()
        {
        }

        public static Db GetInstance()
        {
            if(Instance == null)
            {
                Instance = new Db();
            }
            return Instance;
        }
        
        public void DbMethod()
        {
            System.Console.WriteLine($"Db Method called \n This is {Category} Database");
        }
    }






