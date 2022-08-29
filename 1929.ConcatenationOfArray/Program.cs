int[] nums = { 1, 2, 3 };

int[] GetConcatenation(int[] nums)
{
    int[] final = nums.Concat(nums).ToArray();
    return final;
}

int[] result = GetConcatenation(nums);
