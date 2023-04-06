using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDivide_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NoGood.IBird[] ng_birds = { new NoGood.Sparrow(), new NoGood.Penguin() };
            foreach(var bird in ng_birds)
            {
                var food = bird.Hunt();
                bird.Eat(food);
            }

            Good.IBird[] g_birds = { new Good.Sparrow(), new Good.Penguin() };
            foreach (var g_bird in g_birds)
            {
                var food = g_bird.Hunt();
                g_bird.Eat(food);
            }
        }
    }
}
