// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


String[] string_array1;

Console.WriteLine("Введите массив строк");
string stroka = Console.ReadLine();
string_array1 = stroka.Split(", ");

String[] string_array_new = new String[string_array1.Length];
for (int i = 0; i < string_array1.Length;i++)
{   
    if (string_array1[i].Length <= 3)
    {
        string_array_new[i] = string_array1[i];
        Console.Write(string_array_new[i]);
        Console.Write(", ");
    }
}