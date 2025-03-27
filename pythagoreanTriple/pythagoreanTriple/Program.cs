try
{
    Console.WriteLine("Wprowadź pierwszą liczbę: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę: ");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź trzecią liczbę: ");
    int num3 = int.Parse(Console.ReadLine());

    int[] arr = { num1, num2, num3 };
    Array.Sort(arr);

    if (Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2) == Math.Pow(arr[2], 2))
    {
        Console.WriteLine("Z tego wyjdzie trójkąt prostokątny");
    }
    else
    {
        Console.WriteLine("Z tego nie wyjdzie trójkąt prostokątny");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
