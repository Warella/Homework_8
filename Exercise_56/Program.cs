// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] CreateArray(int rows, int columns, int left_range, int rigth_range)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = new Random().Next(left_range, rigth_range);
        }
    }
    return matrix;
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
int FindRowSum (int[,] array, int i)
{
    int sumRow = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i,j];
    }
    return sumRow;
}
int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
int[,] array = CreateArray(m, n, 10, 100);
PrintArray(array);
int sumLine = FindRowSum(array, 0);
int minSumLine = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = FindRowSum(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");