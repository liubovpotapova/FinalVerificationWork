int[] GetArrayForEvenElementsSearch(int size, int leftBound, int rightBound)
{
    int[] arrayForEvenElementsSearch = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayForEvenElementsSearch[i] = new Random().Next(leftBound, rightBound);
    }
    return arrayForEvenElementsSearch;
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

int SizeOfNewArray(int[] array)
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

int[] arrayForEven = GetArrayForEvenElementsSearch(10, -10, 10);
PrintArray(arrayForEven);
int countOfEven = SizeOfNewArray(arrayForEven);
int[] arrayEven = GetEvenElementsArray(arrayForEven, countOfEven);
PrintArray(arrayEven);