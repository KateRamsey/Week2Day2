using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newShop = new Shop();
            var newTruck = new Truck();
            var newRaceCar = new RaceCar();
            var newSedan = new Sedan();

            List<Vehicle> ShopClients = new List<Vehicle>();
            ShopClients.Add(newTruck);
            ShopClients.Add(newRaceCar);
            ShopClients.Add(newSedan);

            Console.ReadLine();
        }
    }

}
