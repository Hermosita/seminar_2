// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int[] numbers = new int[15];
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] array)
{
for(int i = 0; i < array.Length; i++)

array[i] = new Random().Next(0, 20); }

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}





 
 
            

