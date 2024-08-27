int[] numbers = [1, 2, 3, 4, 5, 6];

//Print Normally
Console.WriteLine("Iterate and print normally");
foreach (var n in numbers)
    Console.WriteLine(n);

//Length
Console.WriteLine("Effect of Length");
Console.WriteLine("Length: " + numbers.Length);

//IndexOf()
Console.WriteLine("Effect of IndexOf(4)");
var index = Array.IndexOf(numbers, 4);
Console.WriteLine(index);

//Clear()
Array.Clear(numbers, 0, 2);
Console.WriteLine("Effect of Clear(array, starting index, how many places)");
foreach (var n in numbers)
    Console.WriteLine(n);

//Copy()
Console.WriteLine("Effect of Copy(array, new array, how many to copy)");
int[] another = new int[3];
Array.Copy(numbers, another, 3);
foreach(var n in another)
    Console.WriteLine(n);

//Sort()
Console.WriteLine("Effect of Sort()");
Array.Sort(numbers);
foreach (var n in numbers)
    Console.WriteLine(n);

//Reverse()
Console.WriteLine("Effect of Reverse()");
Array.Reverse(numbers);
foreach (var n in numbers)
    Console.WriteLine(n);
