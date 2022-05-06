using System;

namespace CelaCisla
{
    public class Operace
    {
        /// <summary>
        /// Vrátí součet čísel x a y
        /// </summary>
        /// <param name="x">První sčítanec</param>
        /// <param name="y">Druhý sčítanec</param>
        /// <returns></returns>
        public static int Soucet(int x,int y)
        {
            return x + y;
        }
        /// <summary>
        /// Vrátí celočíselný podíl čísel x a y. V parametru zbytek je zbytek po celočíselném dělení
        /// </summary>
        /// <param name="x">dělenec</param>
        /// <param name="y">dělitel</param>
        /// <param name="zbytek">Zbytek po dělení</param>
        /// <returns></returns>
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
