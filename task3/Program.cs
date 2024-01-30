//int n = 10;
int[] arr = { 2, 6, 4, 12, 8, 36, 8, 14, 8, 0 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i++;
}