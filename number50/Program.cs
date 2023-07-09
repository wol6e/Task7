// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве и возвращает значение этого элемента или
// указывает, что такого элемента нет
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// [1,7]-> на этой позиции числа в массиве нет

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");
int rowx = Prompt("Введите номер строки искомого элеьента: ");
int colx = Prompt("Введите номер столбца искомого элемента: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
numberx(array);

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

void numberx(int[,] array)
{
   if (rowx<=rows && colx<=columns)
   {
        Console.WriteLine($"[{rowx},{colx}] -> {array[rowx,colx]}");
   }
    else
   {
        Console.WriteLine($"[{rows},{colx}] -> этой позиции в массиве нет");
    }
}
