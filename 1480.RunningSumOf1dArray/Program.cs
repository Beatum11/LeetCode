int[] nums = { 2, 34, 5, 2, 5 };
int[] resultArr = RunningSum(nums);


int[] RunningSum(int[] nums)
{
    for (int i = 1; i < nums.Length; i++)
    {
        nums[i] += nums[i - 1];
    }

    return nums;
}
