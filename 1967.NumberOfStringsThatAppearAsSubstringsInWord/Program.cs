string[] patterns = { "ab", "b", "c" };
string word = "aaaaabbbbb";

int NumOfStrings(string[] patterns, string word)
{
    int res = 0;

    foreach (string pattern in patterns)
    {
        if (word.Contains(pattern))
            res++;
    }

    return res;
}

int res = NumOfStrings(patterns, word);
Console.WriteLine(res);
