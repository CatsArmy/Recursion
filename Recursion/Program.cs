//Ex1(10,true);
//Ex2();
//Ex10(4,true);
//Ex14();
//Ex15(5,true);
//Ex29(26);
//Ex3(50, true);
Ex16(9, true);
void Ex1(int num = 4, bool debug = false)
{
    int DebugF1(int n)
    {
        if (n == 0)
            return 0;
        int result = DebugF1(n - 1) + n;
        Console.WriteLine($"result {result}, n {n}");
        return result;
    }
    int F1(int n)    /* O(n) */
    {
        if (n == 0)
            return 0;
        return F1(n - 1) + n;
    }
    if (debug)
        DebugF1(num);
    else
        Console.WriteLine(F1(num));
}
void Ex2(int num = 4, bool debug = false)
{
    int DebugF2(int n)
    {
        if (n == 1)
            return 1;
        int result = DebugF2(n - 1) * n;
        Console.WriteLine($"result {result}, n {n}");
        return result;
    }
    int F2(int n)    /* O(n) */
    {
        if (n == 1)
            return 1;
        return F2(n - 1) * n;
    }

    if (debug)
        DebugF2(num);
    else
        Console.WriteLine(F2(num));
}
void Ex10(int num = 4, bool debug = false)
{
    int DebugF10(int n)
    {
        if (n == 1)
            return 0;
        int result;
        if (n % 2 == 0)
        {
            result = DebugF10(n - 1) + (n * n);
            Console.WriteLine($"result {result}, n^2 {n * n}, n {n}");
            return result;
        }
        result = DebugF10(n - 1) + (n * 2);
        Console.WriteLine($"result {result}, n * 2 {n * 2}, n {n}");
        return result;
    }
    int F10(int n)   /* O(n) */
    {
        if (n == 0)
            return 0;
        if (n % 2 == 0)
            return F10(n - 1) + (n * n);
        return F10(n - 1) + n * 2;
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
            return 0;
        if (i < 0)
            return 0;
        int result = DebugF14(arr, i - 1) + arr[i];
        Console.WriteLine($"result {result}, arr[i] {arr[i]}, i {i}");
        return result;
    }
    int F14(int[] arr, int i)   /* O(i) */
    {
        if (arr == null || i > arr.Length)
            return 0;
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
    
    int DebugF15(int[] arr, int i, int posCounter = 0)
    {
        if (arr == null || i > arr.Length)
            return 0;
        if (i < 0)
        {
            Console.WriteLine($"Positive Counter {posCounter}, i {i}");
            return posCounter;
        }
        posCounter += int.IsPositive(arr[i]) ? 1 : 0;
        Console.WriteLine($"Positive Counter {posCounter}, arr[i] {arr[i]}, i {i}");
        return DebugF15(arr, i - 1, posCounter);
    }
    int F15(int[] arr, int i)   /* O(i) */
    {
        if (arr == null || i > arr.Length)
            return 0;
        if (i < 0)
            return 0;
        return int.IsPositive(arr[i]) ? 1 : 0 + F15(arr, i - 1);
    }
    int[] arr = GenerateArray(10);
    PrintArray(arr);

    if (debug)
        DebugF15(arr, num);
    else
        Console.WriteLine(F15(arr, num));
}
void Ex29(int num, bool debug = false)
{
    int F29(int n)
    {
        if (n <= 0) { Console.Write($"a[0]: 1, "); return 1; }
        int result = n + F29(n - 1);
        Console.Write($"a[{n}]: {result}, ");
        return result;
    }
    F29(num);
}

void Ex3(int num, bool debug = false)
{
    int DebugF3(int n)
    {
        if (n % 2 == 0)
            n -= 1;
        if (n == 1)
            return 0;
        int result = n * (n - 2) + DebugF3(n - 2);
        Console.WriteLine($"total result: {result}, current result: {n * n - 2}, n: {n}, n-2: {n - 2}");
        return result;
    }
    int F3(int n)
    {
        if (n % 2 == 0)
            n -= 1;
        if (n == 1)
            return 0;
        return n * (n - 2) + F3(n - 2);
    }
    if (debug)
        DebugF3(num);
    else
        F3(num);
}
void Ex16(int offsetRarity = 5, bool debug = false)
{
    int DebugF16(int[] arr, int n, int i = 0)
    {
        if (!(i < arr.Length) || arr == null || arr.Length < 1)
            return -1;
        Console.WriteLine($"arr[i]: {arr[i]}, i: {i}, n: {n}, arr[i] == n ? {arr[i] == n}");
        if (arr[i] == n)
            return i;
        return DebugF16(arr, n, i + 1);
    }
    int F16(int[] arr, int n, int i = 0)
    {
        if (!(i < arr.Length) || arr == null || arr.Length < 1)
            return -1;
        if (arr[i] == n)
            return i;
        return F16(arr, n, i + 1);
    }
    int[] array = GenerateArray(10, offsetRarity);
    PrintArray(array);
    if (debug)
        Console.WriteLine(DebugF16(array, -1));
    else
        Console.WriteLine(F16(array, -1));
}
/*
public static int Ex12(int n1, int n2, int index)
        {
            int result = 0;
            for(int i = index; i > 0; i--)
            {
                result += n1 * i;
            }
            if (result >= n2)
                return result - (n1 * index);
            return Ex12(n1, n2, index + 1);
        }
void Ex12(int num, int num2,bool debug = false)
{
    int DebugF12(int n1, int n2, int mult)
    {
        int result = n1 * mult;
        Console.WriteLine($"result {result}, n1 {n1}, n2 {n2}, mult {mult}");
        if (result > n2)
            return 0;
        return DebugF12(n1, n2, mult + 1) + result;
    }
    int F12(int n1, int n2, int mult)
    {
        int result = n1 * mult;
        if (result > n2)
            return 0;
       return F12(n1, n2, mult + 1) + result;
    }
    if (debug)
        Console.WriteLine(DebugF12(num, num2, 1));
    else
        Console.WriteLine(F12(num, num2, 1));
}
Ex12(5,25,true);
 */

void PrintArray(int[] array)
{
    string print = "Array: { ";
    foreach (int num in array)
        print += $"{num}, ";
    int i = print.LastIndexOf(",");
    print = print.TrimEnd();
    print = print.Remove(i);
    print += " }";
    Console.WriteLine($"Array Length: {array.Length}");
    Console.WriteLine(print);
}
int[] GenerateArray(int length, int offsetRarity = 2)
{
    Random random = new();
    int RNG(int rarity) => random.Next(rarity) != 1 ? 1 : -1;

    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
        arr[i] = RNG(offsetRarity);
    return arr;
}