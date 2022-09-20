int n = 15;
List<string> list = new List<string>();

IList<string> FizzBuzz(int n)
{
    List<string> list = new List<string>();

    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
            list.Add("FizzBuzz");

        else if (i % 3 == 0)
            list.Add("Fizz");

        else if (i % 5 == 0)
            list.Add("Buzz");

        else
            list.Add(i.ToString());
    }

    return list;
}

list = FizzBuzz(n).ToList();