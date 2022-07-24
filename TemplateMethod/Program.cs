using System;
namespace TemplateMethodDesignPattern
{
   //This Abstract Class defines a set of abstract methods that need to be implemented by the Concrete sub Classes.
    public abstract class HouseTemplate
    {
       
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();

        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is built");
        }
    }
   // The Concrete Class implements the operations defined by the Abstract HouseTemplate Class.
   // As we are going to create two types of house : Concrete and Wooden 
   //so we are going to create two concrete classes by implementing the abstract HouseTemplate class.
    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Concrete Pillars with Cement and Sand");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Concrete Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Concrete Windows");
        }
    }
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
        }
        protected override void BuildPillars()
        {
            Console.WriteLine("Building wood Pillars with wood coating");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Wood Windows");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // we are creating an object of house type and calling the BuildHouse method.
            Console.WriteLine("Build a Concrete House\n");
            HouseTemplate houseTemplate = new ConcreteHouse();
            // call the template method
            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("Build a Wooden House\n");
            houseTemplate = new WoodenHouse();
            // call the template method
            houseTemplate.BuildHouse();
            Console.Read();
        }
    }
}