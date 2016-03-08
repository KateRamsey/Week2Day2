namespace Week2Day2
{
    public class Shop<T> where T : Vehicle
    {
        public void ChangeOil(T v)
        {
            v.OilDirty = false;
        }

        public void FillUp (T v)
        {
            v.GasTankEmpty = false;
        }
    }

    public static class ShopExtention
    {
        public static void ChangeTires<T>(this Shop<T> shop, T vehicle) where T : Vehicle
        {
            vehicle.OldTires = false;
        }

    }
}