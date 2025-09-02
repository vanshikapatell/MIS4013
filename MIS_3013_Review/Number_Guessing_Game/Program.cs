Console.WriteLine("Please input the lower bound value <<");
string answer = Console.ReadLine();
int lowerBound = int.Parse(answer);

Console.WriteLine("Please input the upper bound value <<");
answer = Console.ReadLine();
int upperBound = int.Parse(answer);

// data_type variable_name = value
Random r = new Random();

var rando = r.Next(1, 5+1); // generate a random number between 1-5
int guess;
int count = 0;

do
{
	Console.WriteLine("Please guess a number beterrn 1 and 5 << ");
	string usersGuess = Console.ReadLine();
	guess = Convert.ToInt32(usersGuess);
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


