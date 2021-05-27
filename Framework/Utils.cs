using System;

namespace BasicFramework.Framework
{
    public class Utils
    {
        public static int RandomNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}