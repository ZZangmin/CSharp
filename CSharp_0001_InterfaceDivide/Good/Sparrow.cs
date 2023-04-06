using System;

namespace InterfaceDivide_CSharp.Good
{
    public class Sparrow : Bird, IBird, ICanFly
    {
        public int Hunt()
        {
            int consumedFood = Fly();
            Consume(consumedFood);
            Console.WriteLine("Found Bug!!");
            return 1;
        }
        public int Eat(int food)
        {
            Console.WriteLine("Yummy Bug!!");
            Restore(food);
            return Food;
        }
        public int Fly()
        {
            Console.WriteLine("I can fly");
            return 5;
        }
    }
}
