int[] arr = Enumerable.Range(1, 100).ToArray();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (arr[i] % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (arr[i] % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(arr[i]);
    }
}

Console.ReadKey();
