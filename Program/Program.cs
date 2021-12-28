int[] GetArray(int size, int leftBound, int rightBound)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftBound, rightBound);
    }
    return array;
}

void PrintArray(int[] arrayForPrint)
{
    int size = arrayForPrint.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"{arrayForPrint[i]} ");
    }
    System.Console.WriteLine();
}

int CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}

int[] GetEvenElementsArray(int[] arrayForEvenElementsSearch, int count)
{
    int size = arrayForEvenElementsSearch.Length;
    int [] arrayWithEvenElementsOnly = new int [count];
    int k=0;
    for (int i = 0; i < size; i++)
    {
        if (arrayForEvenElementsSearch[i] % 2 == 0)
            {
                arrayWithEvenElementsOnly[k] = arrayForEvenElementsSearch[i];
                k++;
            }
    }
    return arrayWithEvenElementsOnly;
}

int[] arrayForEvenElSearch = GetArray(10, -10, 10);
PrintArray(arrayForEvenElSearch);
int sizeForEvenNumbersArray = CountOfEvenNumbers(arrayForEvenElSearch);
int[] arrayEvenOnly = GetEvenElementsArray(arrayForEvenElSearch, sizeForEvenNumbersArray);
PrintArray(arrayEvenOnly);