
using System.Reflection.Metadata;

for (int i = 0; i < int.MaxValue; i++)
{
    Console.WriteLine("Please input the lower bound value <<");
    string answer = Console.ReadLine();
    int lowerBound = 0;
    lowerBound = ValidateInput(answer, "Invalid input for lower bound, please try again");

    //try
    //{
    //	lowerBound = int.Parse(answer);
    //}
    //catch (FormatException ex)
    //{
    //	Console.WriteLine("Please enter an integer");
    //}
    //catch (OverflowException ex)
    //{
    //	Console.WriteLine("Your value exceeds the limits");
    //}
    //catch (Exception ex)
    //{
    //	Console.WriteLine("I don't know what went wrong")
    //}

    Console.WriteLine("Please input the upper bound value <<");
    answer = Console.ReadLine();
    // int upperBound = int.Parse(answer);
    int upperBound = ValidateInput(answer, "Invalid input for upper bound, please try again");


    // data_type variable_name = value
    Random r = new Random();

    var rando = r.Next(1, 5 + 1); // generate a random number between 1-5
    int guess;
    int count = 0;

    do
    {
        Console.WriteLine($"Please guess a number between {lowerBound} and {upperBound} << ");
        string usersGuess = Console.ReadLine();
        guess = ValidateInput(usersGuess, "Invalid input for guess, please try again");
        count++;

        Console.WriteLine($"You guessed {usersGuess}");

        Console.WriteLine($"Generated a random number with the value {rando}");
        // Console.WriteLine("Generated a random number with the value " + rando + "");

        //   if (rando == guess)
        //{
        //	Console.WriteLine("Congratulations you guessed correctly!");
        //}
        //else
        //{
        //	Console.WriteLine("Sorry you guessed incorrectly");
        //} 
        if (rando != guess)
        {
            if (guess > rando)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, you guessed too high");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sorry, you guessed too low");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    } while (guess != rando);

    Console.WriteLine($"Congratulations you guessed correctly and it only took {count} attempts!");

    Console.WriteLine("Do you want to try your luck again? yes or no <<");
    answer = Console.ReadLine();

    if (answer != "yes") // answer == "no" << same thing)
    {
        break;
    }
}

Console.WriteLine("Thank you for playing our game, come back soon!");


static int ValidateInput(string a, string msg)
{
    int result;
    while (int.TryParse(a, out result) == false)
    {
        Console.WriteLine(msg);
        a = Console.ReadLine();
    }

    return result;
}