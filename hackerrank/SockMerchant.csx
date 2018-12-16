int SockMerchant(IEnumerable<int> arr)
{
    var set = new HashSet<int>();
    var count = 0;

    foreach (var i in arr)
    {
        if (set.Contains(i))
        {
            ++count;
            set.Remove(i);
        }
        else
        {
            set.Add(i);
        }
    }

    return count;
}

void Main()
{
    var arr = "1 1 3 1 2 1 3 3 3 3 "
        .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
        .Select(i => Convert.ToInt32(i));

    Console.WriteLine(SockMerchant(arr));
}

Main();