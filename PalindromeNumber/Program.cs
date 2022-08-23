
int i = 121;
IsPalindrome(i);


bool IsPalindrome(int x)
{
    string num = Convert.ToString(x);

    char[] numsArr = num.ToCharArray();
    Array.Reverse(numsArr);

    string reverseNum = new string(numsArr);

    if (num == reverseNum)
        return true;
    else
        return false;
}