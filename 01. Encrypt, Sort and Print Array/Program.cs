int n = int.Parse(Console.ReadLine());
int[] encryptedValues = new int[n];

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int length = input.Length;
    int sum = 0;

    foreach (char c in input)
    {
        char lowerChar = char.ToLower(c);
        if ("aeiou".Contains(lowerChar)) 
        {
            sum += (int)c * length;
        }
        else 
        {
            sum += (int)c / length;
        }
    }

    encryptedValues[i] = sum;
}

Array.Sort(encryptedValues);

foreach (int value in encryptedValues)
{
    Console.WriteLine(value);
}