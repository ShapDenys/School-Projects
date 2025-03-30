try
{
    int[] arr = new int[3];
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Podaj {i + 1} liczbę: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    Array.Sort(arr);

    if (Math.Pow(arr[0], 2) + Math.Pow(arr[1], 2) == Math.Pow(arr[2], 2))
    {
        Console.WriteLine("Wyjdzie trójkąt prostokątny");
    }
    else
    {
        Console.WriteLine("Nie wyjdzie trójkąt prostokątny");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
