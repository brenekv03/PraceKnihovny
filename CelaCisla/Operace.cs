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
    }
}
