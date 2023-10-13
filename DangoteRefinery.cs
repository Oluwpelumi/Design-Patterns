namespace Design_PatternAssignment
{
    public interface IDangoteRefinery
    {
        IRice ProduceRice();
        IFlour ProduceFlour();
        ICement ProduceCement();
    }

    public class SouthBranch : IDangoteRefinery
    {
        public IRice ProduceRice()
        {
            return new Rice();
        }
        public IFlour ProduceFlour()
        {
            return new Flour();
        } 
        public ICement ProduceCement()
        {
            return new Cement();
        } 
    }

    public class NorthBranch : IDangoteRefinery
    {
        public IRice ProduceRice()
        {
            return new Rice();
        }
        public IFlour ProduceFlour()
        {
            return new Flour();
        } 
        public ICement ProduceCement()
        {
            return new Cement();
        }  
    }

    public class WestBranch : IDangoteRefinery
    {
        public IRice ProduceRice()
        {
            return new Rice();
        }
        public IFlour ProduceFlour()
        {
            return new Flour();
        } 
        public ICement ProduceCement()
        {
            return new Cement();
        } 
    }

    public class EastBranch : IDangoteRefinery
    {
        public IRice ProduceRice()
        {
            return new Rice();
        }
        public IFlour ProduceFlour()
        {
            return new Flour();
        } 
        public ICement ProduceCement()
        {
            return new Cement();
        } 
    }

    public interface IRice
    {
        void MakeRiceSouth();
        void MakeRiceNorth();
        void MakeRiceWest();
        void MakeRiceEast();
    }
    public class Rice : IRice
    {
        public void MakeRiceSouth()
        {
            System.Console.WriteLine("Manufacturing Of Rice from South");
        }
        public void MakeRiceNorth()
        {
            System.Console.WriteLine("Manufacturing Of Rice from North");
        }
        public void MakeRiceWest()
        {
            System.Console.WriteLine("Manufacturing Of Rice from West");
        }
        public void MakeRiceEast()
        {
            System.Console.WriteLine("Manufacturing Of Rice from East");
        }
    }
    public interface IFlour
    {
        void MakeFlourSouth();
        void MakeFlourNorth();
        void MakeFlourWest();
        void MakeFlourEast();
    }
    public class Flour : IFlour
    {
        public void MakeFlourSouth()
        {
            System.Console.WriteLine("Manufacturing Of Flour from South");
        }
        public void MakeFlourNorth()
        {
            System.Console.WriteLine("Manufacturing Of Flour from North");
        }
        public void MakeFlourWest()
        {
            System.Console.WriteLine("Manufacturing Of Flour from West");
        }
        public void MakeFlourEast()
        {
            System.Console.WriteLine("Manufacturing Of Flour from East");
        }
    }
    public interface ICement
    {
        void MakeCementSouth();
        void MakeCementNorth();
        void MakeCementWest();
        void MakeCementEast();
    }
    public class Cement : ICement
    {
        public void MakeCementSouth()
        {
            System.Console.WriteLine("Manufacturing Of Cement from South");
        }
        public void MakeCementNorth()
        {
            System.Console.WriteLine("Manufacturing Of Cement from North");
        }
        public void MakeCementWest()
        {
            System.Console.WriteLine("Manufacturing Of Cement from West");
        }
        public void MakeCementEast()
        {
            System.Console.WriteLine("Manufacturing Of Cement from East");
        }
    }
}