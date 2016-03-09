using System;
namespace Week2Day2
{
    public class Truck : Vehicle
    {
        public Truck()
        {
            GasTankEmpty = true;
            OldTires = true;
            OilDirty = true;
            TypeOfGas = GasType.Diesel;
        }

        public override string ToString()
        {
            return "Truck";
        }

    }
}
