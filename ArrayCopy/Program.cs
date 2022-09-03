int [] CreateArray(int size, int min, int max)
{
    int [] array = new int [size];
    for (int i=0;i<array.Length;i++)
    array[i]=new Random().Next (min,max+1);
    return array;
}
void PrintArray(int[]array)
{
    foreach(var element in array)
    Console.Write($"{element} ");
}
int [] CopyArray(int [] array)
{
    int [] NewArray = new int [array.Length];
    for (int i=0;i<array.Length;i++)
    NewArray[i]=array[i];
    return NewArray;
}
Console.Write("Enter size in array: ");
int size = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter minimum value: ");
int min = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter maximum value: ");
int max = int.Parse(Console.ReadLine()??"0");
int [] Array = CreateArray(size,min,max);
PrintArray(Array);
Console.WriteLine();
int [] NewArray = CopyArray(Array);
PrintArray(NewArray);