namespace _2048
{
    public class MyRandom : IRandom
    {
        private readonly Random _random = new Random();
        public int Next(int minValue, int maxValue) => _random.Next(minValue, maxValue);
        public int Next(int maxValue) => _random.Next(maxValue);
    }
}
