using System;

namespace SecretNumber
{
    public class Number
    {

        public int GetRandomNumberInRange(int minValue, int maxValue)
        {
            var random = new Random();
            var randomNumber = random.Next(minValue, maxValue);
            return randomNumber;
        }               
    }
}