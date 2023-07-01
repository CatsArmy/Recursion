Ex1();
Ex2();
Ex10();
Ex14();
Ex15();
void Ex1(int num = 4, bool debug = false)
{
    int DebugF1(int n, int i = 1)
    {
        if (i > n)
            return 0;
        int result = DebugF1(n, i + 1) + i;
        Console.WriteLine($"result {result}, i {i}");
        return result;
    }
    int F1(int n, int i = 1)    /* Log(n) */
    {
        if (i > n)
            return 0;
        return F1(n, i + 1) + i;
    }
    if (debug)
        DebugF1(num);
    else
        Console.WriteLine(F1(num));
}
void Ex2(int num = 4, bool debug = false)
{
    int DebugF2(int n, int i = 1)
    {
        if (i > n)
            return 1;
        int result = DebugF2(n, i + 1) * i;
        Console.WriteLine($"result {result}, i {i}");
        return result;
    }
    int F2(int n, int i = 1)    /* Log(n) */
    {
        if (i > n)
            return 0;
        return F2(n, i + 1) * i;
    }

    if (debug)
        DebugF2(num);
    else
        Console.WriteLine(F2(num));
}
void Ex10(int num = 4, bool debug = false)
{
    int DebugF10(int n, int i = 1)
    {
        if (i > n)
            return 0;
        int result;
        if (i % 2 == 0)
        {
            result = DebugF10(n, i + 1) + i * i;
            Console.WriteLine($"result {result}, i * i {i * i}, i {i}");
            return result;
        }
        result = F10(n, i + 1) + i * 2;
        Console.WriteLine($"result {result}, i * 2 {i * 2}, i {i}");
        return result;
    }
    int F10(int n, int i = 1)   /* Log(n) */
    {
        if (i > n)
            return 0;
        if (i % 2 == 0)
            return F10(n, i + 1) + i * i;
        return F10(n, i + 1) + i * 2;
    }
    if (debug)
        DebugF10(num);
    else
        Console.WriteLine(F10(num));
}
void Ex14(int num = 5, bool debug = false)
{
    int DebugF14(int[] arr, int i)
    {
        if (arr == null || i > arr.Length)
            return -1;
        if (i < 0)
            return 0;
        int result = DebugF14(arr, i - 1) + arr[i];
        Console.WriteLine($"result {result}, arr[i] {arr[i]}, i {i}");
        return result;
    }
    int F14(int[] arr, int i)   /* Log(n) */
    {
        if (arr == null || i > arr.Length)
            return -1;
        if (i < 0)
            return 0;
        return F14(arr, i - 1) + arr[i];
    }
    int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    if (debug)
        DebugF14(arr, num);
    else
        Console.WriteLine(F14(arr, num));
}
void Ex15(int num = 5, bool debug = false)
{
    void PrintArray(int[] array)
    {
        string print = "Array: { ";
        foreach (int num in array)
            print += $"{num}, ";
        int i = print.LastIndexOf(",");
        print.TrimEnd();
        print = print.Remove(i);
        print += " }";
        Console.WriteLine($"Array Length: {array.Length}");
        Console.WriteLine(print);
    }
    int DebugF15(int[] arr, int i, int posCounter = 0)
    {
        if (arr == null || i > arr.Length)
            return -1;
        if (i < 0)
        {
            Console.WriteLine($"Positive Counter {posCounter}, i {i}");
            return posCounter;
        }
        posCounter += int.IsPositive(arr[i]) ? 1 : 0;
        Console.WriteLine($"Positive Counter {posCounter}, arr[i] {arr[i]}, i {i}");
        return DebugF15(arr, i - 1, posCounter);
    }
    int F15(int[] arr, int i, int posCounter = 0)   /* Log(n) */
    {
        if (arr == null || i > arr.Length)
            return -1;
        if (i < 0)
            return posCounter;
        return F15(arr, i - 1, posCounter += int.IsPositive(arr[i]) ? 1 : 0);
    }
    Random random = new();
    int RNG() => random.Next(2) == 1 ? 1 : -1;
    int[] arr = { RNG(), RNG(), RNG(), RNG(), RNG(), RNG(), RNG(), RNG(), RNG(), RNG() };
    PrintArray(arr);

    if (debug)
        DebugF15(arr, num);
    else
        Console.WriteLine(F15(arr, num));
}