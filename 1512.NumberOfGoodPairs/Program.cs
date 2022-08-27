int[] nums = { 1, 1, 1, 1 };

int NumIdenticalPairs(int[] nums)
{
    int res = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                res++;
            }
        }
    }

    return res;
}

int res = NumIdenticalPairs(nums);
Console.WriteLine(res);
