string userInput;
int parseOutput;
bool succesfull = false;
bool anotherAttempt = false;



Console.WriteLine("We are going to try Parsing! \nPlease type a number.");
userInput = Console.ReadLine();
succesfull = Int32.TryParse(userInput, out parseOutput);
anotherAttempt = check(succesfull, parseOutput);


while (anotherAttempt)
{
    Console.WriteLine("Let's try this again. Type a number.");
    userInput = Console.ReadLine();
    succesfull = Int32.TryParse(userInput, out parseOutput);
    anotherAttempt = check(succesfull, parseOutput);
}


static bool check(bool succesfull, int parsedText)
{
    if (succesfull)
    {
        Console.WriteLine($"Thanks for typing a number. Your number: {parsedText}");
        Console.ReadLine();
        return false;
    }
    else
    {
        return true;
    }


}



