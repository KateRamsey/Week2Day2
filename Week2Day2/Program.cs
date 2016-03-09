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
            var t = new Truck();
            var rc = new RaceCar();
            var s = new Sedan();
            var IffyLube = new Shop<Sedan>();
            var VroomShop = new Shop<RaceCar>();
            var BubbasRepair = new Shop<Truck>();
            List<Vehicle> AllVehicles = new List<Vehicle> {t, rc, s };

            foreach(Vehicle v in AllVehicles)
            {
                Console.WriteLine($"The {v}'s gas tank is empty: {v.GasTankEmpty}");
                Console.WriteLine($"The {v}'s oil is dirty: {v.OilDirty}");
                Console.WriteLine($"The {v}'s tires are old: {v.OldTires}");
                Console.WriteLine();
            }

            IffyLube.ChangeOil(s);
            IffyLube.ChangeTires(s);
            IffyLube.FillUp(s);
            Console.WriteLine();

            VroomShop.ChangeOil(rc);
            VroomShop.ChangeTires(rc);
            VroomShop.FillUp(rc);
            Console.WriteLine();

            BubbasRepair.ChangeOil(t);
            BubbasRepair.ChangeTires(t);
            BubbasRepair.FillUp(t);
            Console.WriteLine();

            foreach (Vehicle v in AllVehicles)
            {
                Console.WriteLine($"The {v}'s gas tank is empty: {v.GasTankEmpty}");
                Console.WriteLine($"The {v}'s oil is dirty: {v.OilDirty}");
                Console.WriteLine($"The {v}'s tires are old: {v.OldTires}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

}
