int input = int.Parse(Console.ReadLine());
int[] array1 = { 1 };
Console.WriteLine(1);

for (int i = 1; i <= input - 1; i++)
{

    int[] array2 = new int [array1.Length + 1];
    array2[0] = 1;
    array2[array2.Length -1] = 1;
    if (array2.Length > 2)
    {
        for (int j = 1; j < array2.Length - 1; j++)
        {
            array2[j] = array1[j - 1] + array1[j];
        }
    }
    array1 = array2.ToArray();
    Console.WriteLine(String.Join(" ", array1));
}