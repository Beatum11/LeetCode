int n = 11;

string GenerateTheString(int n)
{
    return n % 2 == 0 ? new String('a', n - 1) + 'b' : new String('a', n);
}

string res = GenerateTheString(n);
Console.WriteLine(res);
