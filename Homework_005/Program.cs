// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
void FillArray(int[] arr, int length, int minArg, int maxArg)
{
 for(int i = 0; i < length; i++)
 {
   arr[i] = new Random().Next(minArg, maxArg); 
 }
}
void PrintArray(int[] arr, int length)
{
    for(int i = 0; i < length; i++)
    {
     Console.Write(arr[i] + " ");
    }
}

int len = new Random().Next(10, 30);
int min = 100;
int max = 999;
int[] array = new int[len]; 
Console.WriteLine("Дан массив из " + len + " элементов: ");
FillArray(array, len, min, max+1);
PrintArray(array, len);
Console.WriteLine();
int count1 = 0;
int count2 = 0;
for(int count = 0; count < len; count++)
{
    if(array[count] % 2 == 0)
    {
        count1++;
    }
    else
    {
        count2++;
    }
}
Console.WriteLine("Количество четных чисел в массиве " + count1 + ", а нечетных - " + count2 + ".");