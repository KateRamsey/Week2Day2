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
            TypeOfGas = GasType.Regular;
        }
        public override string ToString()
        {
            return "Sedan";
        }

    }
}
