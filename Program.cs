// Написать программу, которая из имеющегося массива строк формируем массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: 
// ["hello", "2", "world", ":-)"] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer sciense"] => ["-2"]
// ["Russia", "Denmark", "Kazan"] => []


Console.Write("Введите длину пользовательского массива: ");
int userArraySize = Convert.ToInt32(Console.ReadLine());

int elementMaxLength = 3;
string[] userarray = new string[userArraySize];
string[] editarray = new string[userarray.Length];

string[] CreateUserArray(string[] array)
{
    int elementNumber = 1;
    for (int i = 0; i < userArraySize; i++)
    {
        Console.Write($"Введите элемент массива {elementNumber}: ");
        array[i] = Console.ReadLine();
        elementNumber++;
    }
    return userarray;
}

string[] CreateEditArray(string[] array, int elementMaxLength)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementMaxLength)
        {
            editarray[i] = array[i];
        }
    }
    return editarray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CreateUserArray(userarray);
CreateEditArray(userarray, elementMaxLength);

Console.WriteLine("Пользовательский массив");
PrintArray(userarray);

Console.WriteLine("Редактированный массив");
PrintArray(editarray);