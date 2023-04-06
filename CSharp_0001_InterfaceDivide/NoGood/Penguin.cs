using System;

namespace InterfaceDivide_CSharp.NoGood
{
    public class Penguin : Bird, IBird
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
        public int Fly()
        {
            //unnecessary method.
            Console.WriteLine("I can't fly");
            return 0;
        }
        public int Swimming()
        {
            Console.WriteLine("I can swimming");
            return 5;
        }
    }
}
