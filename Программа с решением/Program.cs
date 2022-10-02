//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[4] {"hello", "22", "world", ":)"};
string[] array2 = new string[array1.Length];

void Array(string[] array1, string[] array2)
{
    int temp = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[temp] = array1[i];
        temp++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Array(array1, array2);
PrintArray(array2);
Console.WriteLine($"[{String.Join(" ", array2)}]");
