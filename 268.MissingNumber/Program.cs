int[] nums = { 3, 0, 1 };

int MissingNumber(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();

    for (int i = 0; i <= nums.Length; i++)
    {
        //Dictionary with right amount of numbers
        dict.Add(i, 1);
    }

    foreach (var item in nums)
    {
        if (dict.ContainsKey(item))
            dict.Remove(item);
    }
    return dict.Keys.First();
}
