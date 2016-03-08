using System;

namespace Week2Day2
{
    public enum GasType
    {
        Regular,
        HighPerformance,
        Diesel
    }

    public abstract class Vehicle
    {
        public bool GasTankEmpty { get; set; }
        public bool OldTires { get; set; }
        public bool OilDirty { get; set; }
        public string Type { get; set; }
    }
}
