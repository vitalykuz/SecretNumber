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


        public int GetRandomNumberWithMessage(string message)
        {
            var convertedValue = -1;
            while (convertedValue == -1)
            {
                Console.WriteLine(message);
                var value = Console.ReadLine();
                convertedValue = ConvertStringToInt(value);
            }

            return convertedValue;
        }

        public int ConvertStringToInt(string stringToConvert)
        {
            var convertedInt = 0;

            if (int.TryParse(stringToConvert, out convertedInt))
            {
                // you know that the parsing attempt was successful
                return convertedInt;
            }
            return -1;
        }

        public void CheckUserGuess(int userGuess, int secretNumber)
        {
            
        }
    }
}