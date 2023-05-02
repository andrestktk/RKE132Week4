Random rnd = new Random();
int cpuRnd, userRnd;
int cpuScore = 0;
int userScore = 0;
for (int i = 0; i < 3; i++)
{
    cpuRnd = rnd.Next(1, 7);
    userRnd = rnd.Next(1, 7);
    if (cpuRnd > userRnd)
    {
        cpuScore++;
    }
    else if (cpuRnd < userRnd)
    {
        userScore++;
    }
    else
    {
        continue; //programm lihtsalt jätkab oma tööd
    }
}