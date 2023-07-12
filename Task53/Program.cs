// Задайту двумерный массив и напишите программу, которая поменяет 
// местами первую и последнюю строки массива

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows,columns,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
ReplaceRow(array);
PrintArray(array);

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

 void ReplaceRow(int[,] array)
 {
    int temp=0;
    for(int j=0; j<array.GetLength(1); j++)
    {
        temp = array[0,j];
        array[0,j]= array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
 }
    

