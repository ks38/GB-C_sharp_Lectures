int[] array = { 11, 45, 55, 14, 987, 13, 54 };

int n = array.Length;

int find = 55;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}