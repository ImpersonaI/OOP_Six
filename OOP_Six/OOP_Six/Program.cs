using System;

namespace OOP_Six
{
    class Program
    {
        static void Main(string[] args)
        {
            Property<int, double, int> property = new Property<int, double, int>("Property", 4, 4, 4, 4, 3.5);
            Property<double, double, double> property1 = new Property<double, double, double>("Property 1", 4.3, 4.3, 4.2, 4.1, 3.2);
            Property<int, int, int> property2 = new Property<int, int, int>("Property 2", 4, 4, 4, 4, 3);
            Property<double, int, double> property3 = new Property<double, int, double>("Property 3", 4.3, 4.3, 4.3, 4.3, 3);

            Console.ReadKey();
        }
    }
}
