int[] nums = { 6, 5, 4, 8 };


int[] SmallerNumbersThanCurrent(int[] nums)
{
    int num = 0;
    int[] finalArr = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[i] > nums[j])
                num += 1;
        }

        finalArr[i] = num;
        num = 0;
    }

    return finalArr;
}

int[] final = SmallerNumbersThanCurrent(nums);
