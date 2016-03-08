using System;
namespace Week2Day2
{
    public class Sedan : Vehicle
    {
        public Sedan()
        {
            GasTankEmpty = true;
            OldTires = true;
            OilDirty = true;
            Type = "Sedan";
            TypeOfGas = GasType.Regular;
        }
    }
}
