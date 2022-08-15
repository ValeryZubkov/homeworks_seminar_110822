// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
Console.WriteLine("Дан массив: ");
int[] array = new int[12];
int sumPositiv = 0;
int sumNegativ = 0;
for(int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.WriteLine(array[i] + " ");
    if(array[i] > 0)
    {
    sumPositiv = sumPositiv + array[i];
    }
    else
    {
    sumNegativ = sumNegativ + array[i];  
    }  
}
Console.WriteLine("Сумма положительных элементов массива равно: " + sumPositiv);
Console.WriteLine("Сумма отрицательных элементов массива равно: " + sumNegativ);

