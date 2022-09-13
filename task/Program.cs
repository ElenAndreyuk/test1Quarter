// Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести 
//с клавиатуры, либо задать на старте выполнения алгоритма. 
//Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "dart", "weider", "obi", "wan", "Kenobi","0"};
int length = array.Length;
string[] array2 = new string[length];
for (int i = 0; i < length; i++)
{
    if (array[i].Length < 4)
    {
        array2[i] = array[i];
    }
}
void PrintArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i] != "")
        {
            Console.Write($"{arr[i]}   ");
        }
    }
}
PrintArray(array2);