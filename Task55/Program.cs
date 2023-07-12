// Звдвйте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае, если это невозможно, программа
// должна вывести сообщение для пользователя


int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows,columns,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
int[,] turnArray = TurnArray(array);
PrintArray(turnArray);

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

 int[,] TurnArray(int[,] array)
 {
     int[,] turnArray = new int[array.GetLength(1),array.GetLength(0)];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            turnArray[j,i]=array[i,j];
        }
    }
    return turnArray;
 }
    

