// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void CompletionArray(int[] arr)
{
    for(int i =0; i < arr.Length; i ++)
    {
        arr[i] = new Random().Next(1,101);
    }
}
void PrintArr(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] myArr=new int[sizeArr];
CompletionArray(myArr);
PrintArr(myArr)  ;
