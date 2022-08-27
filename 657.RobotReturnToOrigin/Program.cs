string moves = "UD";

int[] ReturnToOrigign(string moved)
{
    int[] loc = { 0, 0 };
    char[] chars = moved.ToCharArray();

    foreach (char c in chars)
    {
        switch (c)
        {
            case 'U':
                loc[1] += 1;
                break;

            case 'D':
                loc[1] -= 1;
                break;

            case 'L':
                loc[0] -= 1;
                break;

            case 'R':
                loc[0] += 1;
                break;

            default:
                break;
        }
    }

    return loc;
}

bool JudgeCircle(string moves)
{
    int[] final = ReturnToOrigign(moves);

    if (final[0] == 0 && final[1] == 0)
        return true;
    else
        return false;
}

bool final = JudgeCircle(moves);
Console.WriteLine(final);
