string allowed = "ab";
string[] words = { "ad", "bd", "aaab", "baa", "badab" };

int CountConsistentStrings(string allowed, string[] words)
{
    int count = 0;
    foreach (string word in words)
    {
        bool consistentWord = true;

        foreach (char c in word)
        {
            //If index is less than 0 we are moving on to another word.
            if (allowed.IndexOf(c) < 0)
            {
                consistentWord = false;
                break;
            }
        }
        if (consistentWord)
        {
            count++;
        }
    }

    return count;
}

int res = CountConsistentStrings(allowed, words);
Console.WriteLine(res);
