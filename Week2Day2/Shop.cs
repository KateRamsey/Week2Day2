namespace Week2Day2
{
    public class Shop<T> where T : Vehicle
    {
        public void ChangeOil(T v)
        {
            v.OilDirty = false;
        }

        public void FillUp ()
        {

        }
    }

    public static class ShopExtention
    {
        public static void ChangeTires<T>(this Shop<T> shop) where T : Vehicle
        {
            Shop<T>.OldTires = false;
        }

    }
}