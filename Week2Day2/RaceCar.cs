using System;
namespace Week2Day2
{
    public class RaceCar : Vehicle
    {
        public RaceCar()
        {
            GasTankEmpty = true;
            OldTires = true;
            OilDirty = true;
            TypeOfGas = GasType.HighPerformance;
        }
        public override string ToString()
        {
            return "Race Car";
        }
    }
}
