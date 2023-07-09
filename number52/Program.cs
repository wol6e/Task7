// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6 5,6 3,6 3

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows,columns,minValue,maxValue);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
SumColumn();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i =0; i<arr.GetLength(0); i++)  
    {
        for(int j=0; j<arr.GetLength(1); j++)   
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    } 
}

  double SumColumn()
 {
    int[] res = new int[columns];
    int sum = 0;
     for(int j=0; j<columns; j++)
     {
        for (int i = 0; i <rows; i++)
        {
          sum += res[i,j]; 
        }
        return columns;
        var sumr = (double) sum / columns;
        Console.WriteLine(string.Join("  ", sumr));
     }
     return sum;
 }
    