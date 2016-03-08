using System;

namespace Week2Day2
{
    public class Shop<T> where T : Vehicle
    {
        public void ChangeOil(T v)
        {
            v.OilDirty = false;
            Console.WriteLine($"The {v} had it's oil changed");
        }

        public void FillUp (T v)
        {
            v.GasTankEmpty = false;
            Console.WriteLine($"The {v} had it's tank filled up with {v.TypeOfGas} gas");
        }
    }

    public static class ShopExtention
    {
        public static void ChangeTires<T>(this Shop<T> shop, T vehicle) where T : Vehicle
        {
            vehicle.OldTires = false;
            Console.WriteLine($"The {vehicle} had it's tires changed");
        }

    }
}