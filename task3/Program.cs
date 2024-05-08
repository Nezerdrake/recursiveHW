void Main()
{
    int[] myArray = { 10, 20, 30, 40, 50 };

    Console.WriteLine("Элементы массива, начиная с конца:");
    PrintArrayReverse(myArray, myArray.Length - 1);
}

void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }
}

Main();