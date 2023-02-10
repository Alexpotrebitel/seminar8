// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int [,] CreateRandomedArray()
{
    Console.WriteLine("введите колличество строк");
 int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("колличество столбцов");
 int colums=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("минимальное значение");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальное значение");
 int maxValue=Convert.ToInt32(Console.ReadLine());
    
int [,] array= new int[rows,colums];
for (int i=0;i<rows;i++)
for (int j=0;j<colums;j++)
    array[i,j] =new Random().Next(minValue,maxValue+1);
return array;
}
void show2darray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
for(int j=0;j<array.GetLength(1);j++)
    Console.Write(array[i,j]+"\t");
    
      Console.WriteLine();  
    }
}

void ChangeRows(int [,]array, int r1, int r2)
{
    if (r1>=0 && r1<array.GetLength(0) &&
    r2>=0 && r2<array.GetLength(0)
    &&r1!=r2)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            int temp = array[r1,j];
            array[r1,j]=array[r2,j];
            array[r2,j]=temp;
            
        }
    }
    
}

int[,] newArray=CreateRandomedArray();
show2darray(newArray);
Console.WriteLine("input a first rows");
int row1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second rows");
int row2=Convert.ToInt32(Console.ReadLine());
ChangeRows(newArray,row1,row2);
show2darray(newArray);
*/
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max number: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
       
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void show2darray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
for(int j=0;j<array.GetLength(1);j++)
    Console.Write(array[i,j]+"\t");
    
      Console.WriteLine();  
    }
}

void TransposedMatrix(int[,] array) 
{
  //  int[,] transposedMatrix=new int[array.GetLength(1),array.GetLength(0)];
for (int i=0; i<array.GetLength(1);i++)
    {
    for (int j=i+1; j<array.GetLength(0);j++)
        {
      //  transposedMatrix[i,j]=array[j,i];
       
      int temp=array[i,j];
       array[i,j]=array[j,i];
            array[j,i]=temp;
        
        }
     
    }
//return transposedMatrix;
}


int[,] InitialArray=CreateRandom2dArray();
show2darray(InitialArray);
Console.WriteLine();
TransposedMatrix(InitialArray);
show2darray(InitialArray);
*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max number: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//rows indexes
    {
        for (int j = 0; j < array.GetLength(1); j++)//columns indexes
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Reverse2dArray(int[,] mas)
{
    if (mas.GetLength(0) != mas.GetLength(1))
    {
        Console.WriteLine("Not Square Array");
        return;
    }
    else
    {
        for (int i = 0; i < mas.GetLength(0) - 1 ; i++)
            for (int j = i+1; j < mas.GetLength(1); j++)
            {
                int temp = mas[i, j];
                mas[i, j] = mas[j, i];
                mas[j, i] = temp;                
            }
    }
}
int[,] mas = CreateRandom2dArray();

Show2dArray(mas);
Reverse2dArray(mas);
Show2dArray(mas);
*/
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max number: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//rows indexes
    {
        for (int j = 0; j < array.GetLength(1); j++)//columns indexes
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[] FindMinrowandColum (int[,] array)
{
    int [] arr=new int[2];
    int min=array[0,0];
     int rowMin=0;
     int colMin=0;
    
for (int i=0; i<array.GetLength(0);i++)
        {
for (int j=0; j<array.GetLength(1);j++)
        {
            if(array[i,j]<min)
            {
                rowMin=i;
                colMin=j;
                min=array[i,j];
                arr=new int[2] {rowMin,colMin};
            }
        }
    }
    return arr;
}   

void RemoveMinElem(int[,] arr,int [] col )
{
    int r=col[0];
    int c=col[1];
    for (int i=0; i <arr.GetLength(0); i++)
    {
if (i==r) continue;
else
{
for (int j=1;j<arr.GetLength(1);j++)
        {
           if (j==c) continue;
           else 
           {
            Console.Write(arr[i,j]+"\t");
           }
        }
        }
        Console.WriteLine();
      
    }
}


int[,] array = CreateRandom2dArray();
Show2dArray(array);*/
//int [] newArr=FindMinrowandColum(array);
//RemoveMinElem(array,newArr);
//Show2dArray(array);
int [] MinArrayIndex(int[,] mas)
{
    int[] indexes=new int[2];
    indexes[0]=0;
    indexes[1]=0;
    for (int i=0;i<mas.GetLength(0);i++)
    for (int j=0;j<mas.GetLength(1); j++)
    {
        if (mas[i,j]<mas[indexes[0],indexes[1]])
        {
            indexes[0]=i;
            indexes[1]=j;
        }
    }
    return indexes;
}
int [,] Remove(int[] indexes, int[,] mas)
{
int[,] resmas=new int [mas.GetLength(0)-1,mas.GetLength(1)-1];
int i2=0;
int j2=0;
for (int i=0; i<mas.GetLength(0);i++)
{
    if (i!=indexes[0])
    {
        for (int j=0; j<mas.GetLength(1); j++)
        {
            if (j!=indexes[1])
            {
                resmas[i2,j2]=mas[i,j];
                j2++;
                
            }
        }
        j2=0;
        i2++;
        }
}
return resmas;

}
int[,] mas = CreateRandom2dArray();
Show2dArray(mas);
int[,] remas = Remove(MinArrayIndex(mas),mas);
Show2dArray(remas);