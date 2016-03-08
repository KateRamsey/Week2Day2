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
            Type = "Race Car";
            TypeOfGas = GasType.HighPerformance;
        }
    }
}
