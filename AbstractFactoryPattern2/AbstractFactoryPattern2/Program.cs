using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Garage garage = new Garage();
            ExsoticCarFactory factory = new ExsoticCarFactory();
            TunerCarFactory Tfactory = new TunerCarFactory();
            Console.WriteLine(garage.BuildCar(factory));
            Console.WriteLine();
            Console.WriteLine(garage.BuildCar(Tfactory));
            Console.ReadKey();
        }
    }
}
