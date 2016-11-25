using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverk_Jol_2016
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int MaximumValue)
        {
            return _generator.Next(minimumValue, MaximumValue + 1);
        }
    }
}
