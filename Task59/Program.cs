// Задайте двумерный массив из целых чисел. Напишите 
// программу, которая удалит строкум и столбец, на пересечении 
// которых расположен наименьший элемент массива

using System;
class HelloWorld {
static void Main() {
    int m=10;
    int n=10;
    int [,]arr=GetArray(m,n,0,1000);
    PrintArray(arr);
    Console.WriteLine();
    var index=minindex(arr,m,n);
    int [,]res=remove(arr,m,n,index,Item1,index,Item2);
    PrintArray(res);
    
}

static int[,] GetArray(int m,int n,int min,int max)
{
    int[,] result=new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(min,max);
        }
    }
    return result;
}

static
void PrintArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    }
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
 static (int,int) minindex(int[,] arr,int m,int n)
 {
     int mi=0;
     int mj=0;
     int min=arr[0,0];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            if(min>arr[i,j])
            {
                min=arr[i,j];
                mi=i;
                mj=j;
            }
        }
    }
    return (mi,mj);
 }
    
static int [,] remove(int[,]arr,int m,int n,int i,int j)
{
    int[,]result= new int[m-1,n-1];
    int icorection=0;

    for(int k=0;k<m;++k)
    {
        if(i==k)
        {
            icorection=1;
        }
        int jcorrection=0;
        for(int l=0;l<n;++l)
        {
            if(j==l)
            {
                jcorrection=l;
            }
            result[k-icorection,l-jcorrection]=arr[k,l];
        }
    }
    return result;
}