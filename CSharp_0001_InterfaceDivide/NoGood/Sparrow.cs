using System;

namespace InterfaceDivide_CSharp.NoGood
{
    public class Sparrow : Bird, IBird
    {
        public int Hunt()
        {
            Consume(Fly());
            Console.WriteLine("Found bug!!");
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
        public int Swimming()
        {
            //unnecessary method.
            Console.WriteLine("I can't swimming");
            return 0;
        }
    }
}
