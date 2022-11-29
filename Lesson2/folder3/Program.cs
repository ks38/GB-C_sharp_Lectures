void FillArray(int[] argument)
{
    int length = argument.Length;
    int i = 0;
    while (i < length)
    {
        argument[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] argum)
{
    int count = argum.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(argum[position] + " ");
        position++;
    }
}

int IndexOf(int[] argu, int find)
{
    int position = -1;
    for (int i = 0; i < argu.Length; i++)
    {
        if (argu[i] == find)
        {
            position = i;
            break;
        }
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine("\n");
int pos = IndexOf(array, 4);
Console.WriteLine(pos);