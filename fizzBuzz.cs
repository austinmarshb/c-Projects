
//concatenation method
public void FizzBuzz()
{
    for (int i = 1; i <= 100; i++)
    {
        string output = "";

        if (i % 3 == 0)
            output += "Fizz";
        if (i % 5 == 0)
            output += "Buzz";

        if (output == "")
            output = i.ToString();

        Console.WriteLine(output);
    }
}

//the first try i did with C#
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

