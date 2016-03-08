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

            IffyLube.ChangeOil(s);
            IffyLube.ChangeTires(s);
            IffyLube.FillUp(s);



            Console.ReadLine();
        }
    }

}
