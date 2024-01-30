int[] arr = { 2, 4, 7, 3, 9 };
int i = 0;
int max = arr[0];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
Console.WriteLine(max);