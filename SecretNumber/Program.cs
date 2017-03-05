/*
 * Lab 1 - Guess a number

    Requirements

    You are required to produce a working console program that generates a random "secret" number 
    between 1 and 100 and asks the user to guess it. The user will enter a number and the program 
    will take one of the following actions:

    If the number entered by the user is greater or less than the secret number, the program will display 
    an informative message and allow the user to continue trying.

    If the number entered by the user equals the secret number, the program will display 
    a success message showing how many tries were needed to guess the number.
    
    Additional functionality

    You can optionally add the following functionality to the program:

    The program will save the last 5 scores (number of tries) and display them on demand.
    The program will allow the user to select the range of numbers to consider when generating the random 
    secret number.
    The program will measure the time that the user takes to guess the secret number, and display it 
    along the score.
   
    Hints

    Use the class System.Random to generate the secret number.
    Use System.DateTime to measure time.
    You might use List<int> or Queue<int> in System.Collections.Generic to store a list of past values.
    Feel free to discuss on the UTS Online Discussion Boards if you get stuck.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberClass = new Number();

            var minValue = numberClass.GetRandomNumberWithMessage("Please provide a minimum value to generate a random number: ");
            var maxValue = numberClass.GetRandomNumberWithMessage("Please provide a maximum value to generate a random number: ");

            var secretNumber = numberClass.GetRandomNumberInRange(minValue, maxValue);
            Console.WriteLine("Secret Number is : {0}",secretNumber);

            var userGuess = numberClass.GetRandomNumberWithMessage("Try to guess the secret number: ");

            numberClass.CheckUserGuess(userGuess, secretNumber);


            Console.ReadLine();
        } 
    }
}
