using System;
using System.Collections.Generic;

namespace SecretNumber
{
    public class Number
    {
        private readonly Random _random = new Random();
        public List<int> UserGuesses { get; private set; } = new List<int>();
        public int NumberOfTries { get; private set; } = 0;

        /// <summary>
        /// Returns the random number from a range of numbers provided by the user.
        /// ex.: range(from 0 to 100)
        /// </summary>
        /// <param name="minValue"> starting value in a range </param>
        /// <param name="maxValue"> max value in a range </param>
        /// <returns> a random number from range </returns>
        public int GetRandomNumberInRange(int minValue, int maxValue)
        {
            var randomNumber = _random.Next(minValue, maxValue);
            return randomNumber;
        }


        public int GetRandomNumberWithMessage(string message)
        {
            var number = -1;
            while (number == -1)
            {
                Console.WriteLine(message);
                var valueFromUser = Console.ReadLine();
                number = ConvertStringToInt(valueFromUser);
            }

            return number;
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

        public bool CheckUserGuess(int userGuess, int secretNumber)
        {
            UpdateGuessesAndTries(userGuess);
            if (userGuess != secretNumber)
            {
                if (userGuess > secretNumber)
                {                    
                    Console.WriteLine("Nope, the secret number is less then " + userGuess);
                    return false; 
                        
                }
                else 
                {
                    Console.WriteLine("Nope, the secret number is greater then " + userGuess);
                    return false;
                }
            }
            //user got the number! 
            Console.WriteLine("Congrats! You got the secret number!");
            Console.WriteLine("It took you {0} tries to get the number", NumberOfTries );
            return true;
        }

        private void UpdateGuessesAndTries(int userGuess)
        {
            UserGuesses.Add(userGuess);
            NumberOfTries++;
        }

        public void DisplayAllGuesses()
        {
            var textToDisplay = "The list of all guesses: ";
            foreach (var guess in UserGuesses)
            {
                textToDisplay += guess + " ";
            }
            Console.WriteLine(textToDisplay);
        }
    }
}