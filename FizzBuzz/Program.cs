


using FizzBuzz;
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkBlue;

var tryAgain1 = true;
var tryAgain2 = true;

Console.Clear();

var intro = "Hello! Welcome to the FizzBuzz program!\nRules are simple!\n" +
    "Fizz = divisible by 3\n" +
    "Buzz = divisible by 5\n" +
    "FizzBuzz = divisible by 3 and 5\n" +
    "Please wait while we connect you to the server .";


foreach (var item in intro)
{
    Thread.Sleep(30);
    Console.Write(item);
}

for (int i = 0; i < 4; i++)
{
    Thread.Sleep(500);
    Console.Write(" .");
}

while (tryAgain1)
{

    Console.Clear();

    var input1 = "Please enter a number: ";


    foreach (var item in input1)
    {
        Thread.Sleep(30);
        Console.Write(item);
    }

    var parse = int.TryParse(Console.ReadLine(), out int input);

    var fizzBuzz = new FizzBuzzChecker();

    if (parse == true)
    {
        var answer = fizzBuzz.FizzBuzzCheck(input);
        Console.Write($"The FizzBuzz answer is .");
        for (int i = 0; i < 4; i++)
        {
            Thread.Sleep(500);
            Console.Write(" .");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{answer}!");
        tryAgain1 = false;


    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        var error = "Error: Not an acceptable input!";
        foreach (var item in error)
        {
            Thread.Sleep(30);
            Console.Write(item);
        }
        Console.ForegroundColor = ConsoleColor.White;
        tryAgain2 = true;
        while (tryAgain2)
        {
            Console.WriteLine();
            var tryAgain4 = "Would you like to try again (yes/no): ";
            foreach (var item in tryAgain4)
            {
                Thread.Sleep(30);
                Console.Write(item);
            }
            var tryAgain = Console.ReadLine();
            if (tryAgain == "yes")
            {
                tryAgain1 = true;
                tryAgain2 = false;

            }
            else if (tryAgain == "no")
            {
                tryAgain1 = false;
                tryAgain2 = false;

            }
            else
            {
                tryAgain2 = true;
                var error2 = "Please enter yes/no";
                foreach (var item in error2)
                {
                    Thread.Sleep(30);
                    Console.Write(item);
                }
               

            }
            
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}



Thread.Sleep(1000);
Console.WriteLine();


Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine();
var close = "Closing program .";

foreach (var item in close)
{
    Thread.Sleep(30);
    Console.Write(item);
}

for (int i = 0; i < 4; i++)
{
    Thread.Sleep(500);
    Console.Write(" .");
}
