using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lottery!");
            //int x = 10;
            //TestPassOutParameter(ref x);
            //Console.WriteLine(x);
            txWorld world = new txWorld();
            world.SetUpScene();
            const double step = 0.001;
            for (int i = 0; i < 100; i++)
            {
                world.Simulate(step);
                Console.WriteLine("Step:  " + i);
            }

        }

        public static void TestPassOutParameter(ref int x)
        {
            x++;
        }
    }
}
