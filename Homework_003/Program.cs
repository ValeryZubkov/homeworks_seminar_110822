// Написать программу замену элементов массива на противоположные

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
     Console.Write(arr[i] + ", ");
    }
}

int len = new Random().Next(10, 30);
int min = new Random().Next(-100, 50);
int max = new Random().Next(50, 200);
int[] array = new int[len]; 
Console.WriteLine("Дан массив из " + len + " элементов: ");
FillArray(array, len, min, max);
PrintArray(array, len);
for(int count = 0; count < len; count++)
{
    array[count] = -array[count];
}
Console.WriteLine();
Console.WriteLine("Этот же массив после замены элементов на противоположные: ");
PrintArray(array, len);