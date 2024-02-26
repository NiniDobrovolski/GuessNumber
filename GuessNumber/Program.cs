using GuessNumber;

// Generating a random number between 1 and 100
int number = new Random().Next(1,100);

// Declaring variable
string input;
int inputNumber=0,count=0;

// Prompting the user to guess the numbe
Console.WriteLine("X is between 1 and 100. Guess X.");

while (true && inputNumber != number)
{
    try
    {
        // Reading user input
        input = Console.ReadLine();

        // Validating input
        if (!int.TryParse(input, out inputNumber))
        {
            throw new WrongInputException();
        }
        else
        {
            // Parsing user input to an integer
            inputNumber = int.Parse(input);

            // Comparing user input with the generated number
            if (inputNumber > number)
            {
                Console.WriteLine($"X is less than {inputNumber}");
                count++;
            }
            else if(inputNumber < number)
            {
                Console.WriteLine($"X is grater than {inputNumber}");
                count++;
            }
            else
            {
                // Increasing user's guesses if user guesses correct number
                count++;

                // Displaying a congratulatory message if the user guesses the number correctly
                Console.WriteLine($"Congratulations. You have guessed X. \nX = {number} \nattempts : {count}");
            }
        }
    }
    catch (WrongInputException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
