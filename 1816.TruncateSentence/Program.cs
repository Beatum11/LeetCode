string s = "Hello how are you bitch";
int k = 4;

string TruncateSentence(string s, int k)
{
    string[] final = new string[k];
    string[] arr = s.Split(' ');

    for (int i = 0; i < final.Length; i++)
    {
        final[i] = arr[i];
    }

    string c = string.Join(' ', final);
    return c;
}

string final = TruncateSentence(s, k);
Console.WriteLine(final);