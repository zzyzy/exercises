// Repeated String
// https://www.hackerrank.com/challenges/repeated-string

long RepeatedString(string s, long n)
{
    // if (s.Length == 1)
    // {
    //     if (s[0] == 'a')
    //         return n;
    //     else
    //         return 0;
    // }
    // else
    // {
    var count = 0;

    foreach (var c in s)
    {
        if (c == 'a')
            ++count;
    }

    var j = n / s.Length;
    var k = n % s.Length;
    var l = count * j;

    for (var i = 0; i < s.Length && i < k; ++i)
    {
        var c = s[i];
        if (c == 'a')
            ++l;
    }

    return l;
    // }
}

void Main()
{
    var s = "a";
    var n = 100000000000000;
    Console.WriteLine(RepeatedString(s, n));
}

Main();