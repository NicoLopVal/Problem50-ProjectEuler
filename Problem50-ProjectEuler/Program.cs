
List<double> allPrimes = new();
allPrimes.Add(2);
double maxLimit = 1000000;


for(double i = 3; i < maxLimit; i += 2)
{
    bool isPrime = true;
    foreach(double prime in allPrimes)
    {
        if(i%prime == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
        allPrimes.Add(i);
}

double maxConsecutivas = 0;
double startConsecutives = 0;
double answer = 0;
for (int i = 0; i < allPrimes.Count; i++)
{
    double sum = 0;
    for (int j = i; j < allPrimes.Count; j++)
    {
        sum += allPrimes[j];
        if (allPrimes.Contains(sum) && j-i > maxConsecutivas)
        {
            maxConsecutivas = j - i + 1;
            startConsecutives = i;
            answer = sum;
        }
    }
}

Console.WriteLine("max consecutive {0}, and is the number {1}", maxConsecutivas,answer);