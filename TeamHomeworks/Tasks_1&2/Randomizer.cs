using System;
namespace TeamHomeworks.Task1
{
    public class Randomizer
    {
        public static double SetRandomValue()
        {
            Random random = new Random();
            return random.NextDouble() * (5 - 0.5) + 0.5;
        }
    }
}
