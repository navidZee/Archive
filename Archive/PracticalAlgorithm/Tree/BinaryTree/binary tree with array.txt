static void Main(string[] args)
{
    int[] arr = new int[] { 50, 30, 63, 44, 24, 13, 7 };
    var finalArrs = BinaryTree(arr);
    foreach (var item in finalArrs.Item1)
    {
        Console.WriteLine(item);
    }
}

static (int[], int[]) BinaryTree(int[] arr)
{
    int[] finalArr_1 = new int[(arr.Length + 1) * 2 + 1];
    int[] finalArr_2 = new int[(arr.Length + 1) * 2 + 1];
    for (int index = 1; index < finalArr_1.Length; index++)
    {
        finalArr_1[index] = -1;
        finalArr_2[index] = -1;
    }

    for (int index = 0; index < arr.Length; index++)
    {
        Insert(ref finalArr_1, arr[index]); // version 1

        bool @continue = true; // version 2
        for (int finalArrIndex = 1; finalArrIndex < finalArr_2.Length && @continue; finalArrIndex++)
        {
            @continue = SetNumberAtFinalIndex(arr[index], ref finalArr_2, finalArrIndex);
        }
    }

    return (finalArr_1, finalArr_2);
}

// version 1
private static bool SetNumberAtFinalIndex(int number, ref int[] finalArr, int finalArrIndex)
{
    bool @continue = true;

    if (finalArr[finalArrIndex] == -1)
    {
        finalArr[finalArrIndex] = number;
        @continue = false;
    }
    else if (finalArr[finalArrIndex] > number) // left side
    {
        @continue = SetNumberAtFinalIndex(number, ref finalArr, finalArrIndex * 2);
    }
    else if (finalArr[finalArrIndex] < number) // right side
    {
        @continue = SetNumberAtFinalIndex(number, ref finalArr, finalArrIndex * 2 + 1);
    }
    else // is duplicate
    {
        @continue = false;
    }

    return @continue;
}

// version 2
static void Insert(ref int[] finalArr, int number)
{
    int index = 1;

    while (true)
    {
        if (finalArr[index] == -1)
        {
            finalArr[index] = number;
            break;
        }
        else if (number < finalArr[index]) // left side
        {
            index = index * 2;
        }
        else if (number > finalArr[index]) // right side
        {
            index = index * 2 + 1;
        }
        else // is duplicate
        {
            break;
        }
    }
}