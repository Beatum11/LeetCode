string z = "Good Day";

string ReverseWords(string s)
{
    string[] words = s.Split(' ');
    string[] finalArr = new string[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        char[] chars = words[i].ToCharArray();
        Array.Reverse(chars);
        finalArr[i] += new string(chars);
    }

    string sFinal = string.Join(' ', finalArr);
    return sFinal;
}

string final = ReverseWords(z);
Console.WriteLine(final);
