int input = int.Parse(Console.ReadLine());
int[] array1 = { 1, 1 };


for (int i = 2; i < input; i++)
{
    int[] array2 = new int[array1.Length + 1];
    if (array2[0] == 0 && array2[1] == 0)
    {
        array2[0] = 1;
        array2[1] = 1;
    }
    if (input < array1.Length)
    {
        Console.WriteLine(1);
        return;
    }
    for (int j = 2; j < array2.Length; j++)
    {
        array2[j] = array1[j - 2] + array1[j - 1];
    }
    array1 = array2.ToArray();
}

Console.WriteLine(array1[array1.Length - 1]);


