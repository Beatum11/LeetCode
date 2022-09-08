int[] nums = { 1, 2, 3, 1 };

bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
                return true;
        }
    }

    return false;
}

bool b = ContainsDuplicate(nums);
