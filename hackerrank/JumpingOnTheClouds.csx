// Jumping on the Clouds
// https://www.hackerrank.com/challenges/jumping-on-the-clouds/

int JumpingOnClouds(IEnumerable<int> c)
{
    var l = c.ToArray();
    var i = 0;
    int? p1;
    int? p2;
    var moves = 0;

    for (; i < l.Length;)
    {
        p1 = i + 1 < l.Length ? l[i + 1] : (int?)null;
        p2 = i + 2 < l.Length ? l[i + 2] : (int?)null;

        if (p2 != null && p2.Value == 0)
        {
            i = i + 2;
            ++moves;
        }
        else if (p1 != null && p1.Value == 0)
        {
            i = i + 1;
            ++moves;
        }
        else
        {
            ++i;
        }
    }

    return moves;
}

void Main()
{
    var s = "0 0 1 0 0 1 0"
        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
        .Select(i => Convert.ToInt32(i));
    Console.WriteLine(JumpingOnClouds(s));
}

Main();