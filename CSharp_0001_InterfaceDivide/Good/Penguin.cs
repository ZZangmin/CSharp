using System;

namespace InterfaceDivide_CSharp.Good
{
    public class Penguin : Bird , IBird, ICanSwimming
    {
        public int Hunt()
        {
            int consumedFood = Swimming();
            Consume(consumedFood);
            Console.WriteLine("Found Fish!!");
            return 10;
        }
        public int Eat(int food)
        {
            Console.WriteLine("Yummy Fish!!");
            Restore(food);
            return Food;
        }
        public int Swimming()
        {
            Console.WriteLine("I can swimming");
            return 5;
        }
    }
}
