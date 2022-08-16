using System;

namespace _3.L
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
            Console.ReadKey();
        }
    }
    public abstract class Fruit
    {
        /// <summary>
        /// 
        /// Virtual methods have an implementation and provide the derived 
        /// classes with the option of overriding it. 
        /// 
        /// Abstract methods do not provide an implementation and forces the 
        /// derived classes to override the method.
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
