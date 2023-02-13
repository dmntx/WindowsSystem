using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Beverage beverage = new Expresso();
            Console.WriteLine(beverage.getDescription() + ": $ " + beverage.cost());

            Beverage beverage2 = new Decaf();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Chico(beverage2);
            Console.WriteLine(beverage2.getDescription() + ": $" + beverage2.cost());


            Beverage beverage3 = new DarkRoast();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Grande(beverage3);
            Console.WriteLine(beverage3.getDescription() + ": $" + beverage3.cost());

            Beverage beverage4 = new DarkRoast();
            beverage4 = new Mocha(beverage4);
            beverage4 = new Milk(beverage4);
            beverage4 = new Mediano(beverage4);
            Console.WriteLine(beverage4.getDescription() + ": $" + beverage4.cost());

            Beverage beverage5 = new Expresso();
            beverage5 = new Mocha(beverage5);
            beverage5 = new Mocha(beverage5);
            beverage5 = new Milk(beverage5);
            beverage5 = new Grande(beverage5);
            Console.WriteLine(beverage5.getDescription() + "$" + beverage5.cost());

            Console.WriteLine("Nota: Estuvo dificil");*/
            Console.ReadKey();
        }
    }
    public abstract class Interfaz
    {

        /*protected string description = "Bebida desconocida";
        public string size = "Tamaño desconocido";*/

        public abstract string getDescription();

        public abstract string getSize();

        public abstract double cost();

    }

    public abstract class Ventana : Interfaz
    {
        public abstract override double cost();
    }


    public class ScrollingWindow : Ventana
    {

        Beverage beverage;
        public Chico(Beverage _beverage)
        {

            this.beverage = _beverage;
            beverage.size = "Chico";
        }

        public override double cost()
        {
            return beverage.cost();
        }

        public override string getSize()
        {
            return beverage.size;
        }


        public override string getDescription()
        {
            return beverage.getDescription() + " , " + beverage.getSize();
        }
    }

    public abstract class WindowWithBor : Beverage
    {
        public abstract override string getDescription();

    }

    public class WindowWithBorder : Interfaz
    {

        public WindowWithBorder()
        {

            description = "Dark Roast";
            //Console.Write("Dark Roast");

        }

        public override double cost()
        {
            return 0.99;
        }

        public override string getSize()
        {
            return size;
        }
        public override string getDescription()
        {
            return description;
        }
    }

    public class ScrollingWithBorder : Interfaz
    {

        public ScrollingWithBorder()
        {

            //description = "Decaf";
            this.description = "Decaf";
        }

        public override double cost()
        {
            return 1.05;
        }

        public override string getDescription()
        {
            return description;
        }

        public override string getSize()
        {
            return size;
        }
    }

    /*public class Expresso : Beverage
    {

        public Expresso()
        {

            description = "Expresso";
            this.description = "Expresso";

        }

        public override double cost()
        {
            return 1.99;
        }

        public override string getSize()
        {
            return size;
        }

        public override string getDescription()
        {
            return description;
        }
    }

    public class Grande : Size
    {
        Beverage beverage;
        public Grande(Beverage beverage)
        {

            this.beverage = beverage;
            beverage.size = "Grande";

        }

        public override double cost()
        {
            return (beverage.cost()) * 2;
        }


        public override string getDescription()
        {
            return beverage.getDescription() + " , " + beverage.getSize();
        }

        public override string getSize()
        {
            return size;
        }

    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {

            description = "House Blend";

        }

        public override double cost()
        {
            return 0.89;
        }

        public override string getSize()
        {
            return size;
        }

        public override string getDescription()
        {
            return description;
        }
    }

    public class Mediano : Size
    {

        Beverage beverage;

        public Mediano(Beverage _beverage)
        {

            this.beverage = _beverage;
            beverage.size = "Mediano";
            //size = "mediano";

        }

        public override double cost()
        {
            return (beverage.cost()) + (beverage.cost()) * 0.5;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + " , " + beverage.getSize();
        }

        public override string getSize()
        {
            return size;
        }

    }

    public class Milk : CondimentDecorator
    {

        Beverage beverage;

        public Milk(Beverage beverage)
        {

            this.beverage = beverage;

        }
        public override double cost()
        {
            return 0.10 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Milk";
        }

        public override string getSize()
        {
            return size;
        }

    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage _beverage)
        {

            this.beverage = _beverage;


        }
        public override double cost()
        {
            return 0.20 + beverage.cost();
        }

        public override string getDescription()
        {
            //Console.WriteLine("Prueba mocha: ");
            return beverage.getDescription() + ", Mocha";
        }

        public override string getSize()
        {
            return size;
        }

    }

    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {

            this.beverage = beverage;

        }
        public override double cost()
        {
            return 0.15 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override string getSize()
        {
            return size;
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {

            this.beverage = beverage;

        }
        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", whip";
        }

        public override string getSize()
        {
            return size;
        }
    }*/




}
