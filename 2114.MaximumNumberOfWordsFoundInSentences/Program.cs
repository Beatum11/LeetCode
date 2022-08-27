string[] sentences = { "alice and bob love leetcode", "i think so too",
    "this is great thanks very much" };


int MostWordsFound(string[] sentences)
{
    int[] nums = new int[sentences.Length];

    for (int i = 0; i < sentences.Length; i++)
    {
        string[] words = sentences[i].Split(' ');
        nums[i] += words.Length;
    }

    int finalNum = nums.Max();
    return finalNum;
}

int final = MostWordsFound(sentences);
Console.WriteLine(final);
