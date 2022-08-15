// Определить, присутствует ли в заданном массиве, некоторое число
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
int min = new Random().Next(-100, 50);
int max = new Random().Next(50, 200);
int[] array = new int[len]; 
Console.WriteLine("Дан массив из " + len + " элементов: ");
FillArray(array, len, min, max+1);
PrintArray(array, len);
Console.WriteLine();
Console.WriteLine("Введите число для проверки присутствия его в данном массиве: ");
int find = int.Parse(Console.ReadLine() ?? "0");
bool k = false; 
for(int count = 0; count < len; count++)
{
    if(array[count] == find)
    {
        Console.WriteLine("Введенное Вами число " + array[count] + " присутствует в данном массиве! Индекс данного элемента - " + count + ".");
        k = true;
        break;
    }
}
if(k == false)
{
    Console.WriteLine("Введенное Вами число ОТСУТСТВУЕТ в данном массиве!");
}