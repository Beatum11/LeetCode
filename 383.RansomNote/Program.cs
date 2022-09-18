string ransomNote = "aa";
string magazine = "aab";

bool CanConstruct(string ransomNote, string magazine)
{
    List<char> chars = new List<char>();
    int num = 0;

    for (int i = 0; i < magazine.Length; i++)
    {
        //Adding magazine chars to list
        chars.Add(magazine[i]);
    }

    foreach (var c in ransomNote)
    {
        if (chars.Contains(c))
        {
            num++;
            chars.Remove(c);
        }
    }

    if (num == ransomNote.Length)
        return true;
    else
        return false;
}

bool flag = CanConstruct(ransomNote, magazine);
Console.WriteLine(flag);

