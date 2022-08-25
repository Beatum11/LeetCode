string jewels = "aA";
string stones = "aAAbbbb";

int i = NumJewelsInStones(jewels, stones);


int NumJewelsInStones(string jewels, string stones)
{
    int num = 0;

    char[] jArr = jewels.ToCharArray();
    char[] stArr = stones.ToCharArray();

    for (int i = 0; i < jArr.Length; i++)
    {
        for (int j = 0; j < stArr.Length; j++)
        {
            if (jArr[i] == stArr[j])
                num++;
        }
    }

    return num;
}
