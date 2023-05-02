
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu ha genereated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumbre = Int32.Parse(Console.ReadLine());

    if (userNumbre == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops, try again!");
    }
}

Console.WriteLine("Have a nice day!");
