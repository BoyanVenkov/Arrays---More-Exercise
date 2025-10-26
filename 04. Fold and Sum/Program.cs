int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int operations = inputArray.Length / 2;

int sideOperations = operations / 2;

int[] outputArray = new int[operations];

int count = 0;

int leftCount = sideOperations;

int rightCount = operations;

for (int i = sideOperations - 1; i >= 0; i--)
{
    outputArray[count] = inputArray[i] + inputArray[leftCount];
    leftCount++;
    count++;

}
count = outputArray.Length - sideOperations;
for (int i = inputArray.Length - 1; i >= inputArray.Length - sideOperations; i--)
{

    outputArray[count] = inputArray[i] + inputArray[rightCount];
    rightCount++;
    count++;
}

Console.WriteLine(String.Join(" ", outputArray));