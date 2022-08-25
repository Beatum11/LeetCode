string[] commands = { "X++", "X--", "++X", "--X" };

int i = FinalValueAfterOperations(commands);

int FinalValueAfterOperations(string[] operations)
{
    int x = 0;

    for (int i = 0; i < operations.Length; i++)
    {
        switch (operations[i])
        {
            case "X++":
                x += 1;
                break;

            case "++X":
                x += 1;
                break;

            case "X--":
                x -= 1;
                break;

            case "--X":
                x -= 1;
                break;

            default:
                break;
        }
    }

    return x;
}
