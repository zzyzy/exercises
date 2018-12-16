int CountingValleys(int n, string s)
{
    const int seaLevel = 0;
    var currentLevel = seaLevel;
    var previousLevel = currentLevel;
    var count = 0;

    foreach (var c in s)
    {
        previousLevel = currentLevel;

        if (c == 'U')
        {
            ++currentLevel;
        }
        else // 'D'
        {
            --currentLevel;
        }

        if (previousLevel < seaLevel &&
            currentLevel == seaLevel)
        {
            ++count;
        }
    }

    return count;
}

void Main()
{
    var s = "UDDDUDUU";
    Console.WriteLine(CountingValleys(s.Length, s));
}

Main();