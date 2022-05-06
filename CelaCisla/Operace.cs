using System;

namespace CelaCisla
{
    public class Operace
    {
        public static int Soucet(int x,int y)
        {
            return x + y;
        }
        public static int CelociselnyPodil(int x, int y,out int zbytek)
        {
            zbytek = x % y;
            int podil = x / y;
            return podil;
        }
        public static int Soucin(int x,int y)
        {
            return x * y;
        }
        public static int Rozdil(int x,int y)
        {
            return (x - y);
        }
        public static bool JeLiche(int x)
        {
            bool jeliche = false;
            if (x % 2 != 0) jeliche = true;
            return jeliche;
        }
    }
}
