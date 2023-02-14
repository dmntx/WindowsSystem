using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Interfaz ventana = new Ventana();
            ventana = new ScrollingWindow(ventana);
            ventana = new BorderToWindow(ventana);

            Interfaz ventanaSinScroll = new Ventana();
            ventanaSinScroll = new BorderToWindow(ventanaSinScroll);

            Interfaz ventanaSinBorde = new Ventana();
            ventanaSinBorde = new ScrollingWindow(ventanaSinBorde);

            Interfaz ventanaConMuchasFunciones = new Ventana();
            ventanaConMuchasFunciones = new ScrollingWindow(ventanaConMuchasFunciones);
            ventanaConMuchasFunciones = new BorderToWindow(ventanaConMuchasFunciones);
            ventanaConMuchasFunciones = new FuncionAdd(ventanaConMuchasFunciones);
            ventanaConMuchasFunciones = new FuncionAdd(ventanaConMuchasFunciones);
            ventanaConMuchasFunciones = new FuncionAdd(ventanaConMuchasFunciones);


            //ventana = new BorderToWindow(ventana);
            Console.WriteLine("Ventana 1: " + ventana.getDescription());
            Console.WriteLine("Ventana 2: " + ventanaSinScroll.getDescription());
            Console.WriteLine("Ventana 3: " + ventanaSinBorde.getDescription());
            Console.WriteLine("Ventana 4: " + ventanaConMuchasFunciones.getDescription());

            //ventana = new BorderToWindow(ventana);
            Console.ReadKey();
        }
    }
    public abstract class Interfaz //Beverage o bevida
    {

        public string description = " ";

        public abstract string getDescription();

    }

    public abstract class Funcion : Interfaz //tamaaño size : beverage
    {
        public abstract override string getDescription();
    }


    public class ScrollingWindow : Funcion //Medida chico : size
    {

        Interfaz pantalla;
        public ScrollingWindow(Interfaz _pantalla)
        {
            this.pantalla = _pantalla;
            pantalla.description += "Scrolling de pantalla,";
        }

        public override string getDescription()
        {
            return pantalla.getDescription();
        }
    }

    public abstract class FuncionBorder : Interfaz
    {
        public abstract override string getDescription();
    }
    
    public class BorderToWindow : FuncionBorder
    {
        Interfaz Border;
        public BorderToWindow(Interfaz _Border)
        {
            this.Border = _Border;
            //Border.description += "Borde de ventana";
        }
        public override string getDescription()
        {
            return Border.getDescription() + " Borde de ventana,";
        }
    }

    public class Ventana : Interfaz
    {
        public Ventana()
        {
            description = "Ventana con: ";
        }
        public override string getDescription()
        {
            return description;
        }
    }

    public abstract class FuncionAdicional : Interfaz
    {
        public abstract override string getDescription();
    }

    public class FuncionAdd : FuncionAdicional
    {
        Interfaz FuncionN;
        public FuncionAdd(Interfaz _func)
        {

            this.FuncionN = _func;
        }

        public override string getDescription()
        {
            return FuncionN.getDescription() + " Funcion adicional,";
        }
    }

}