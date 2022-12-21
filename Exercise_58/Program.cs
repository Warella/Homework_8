// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i,k] * secondArray[k,j];
            }
            resultArray[i,j] = sum;
        }
    }
}
int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
int p = InputNumber("Введите значение p: ");
int[,] firstArray = new int[m, n];
CreateArray(firstArray);
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = new int[n, p];
CreateArray(secondArray);
PrintArray(secondArray);
Console.WriteLine();
int[,] resultArray = new int[m, p];
MultiplyMatrix(firstArray, secondArray, resultArray);
PrintArray(resultArray);