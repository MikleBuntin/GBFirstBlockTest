
string[] array1 = {"hello", "2", ":-)", "world", "34", "5"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
int max = 3; //Количество символов

string[] GetNewArray(string[] array, int max)
{
    string[] newArray = new string[0];
        for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < max + 1)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }
    return newArray;
}

void PrintNewArray(string[] oldArray)
{
string[] newArray = GetNewArray(oldArray, max);

Console.WriteLine("Old array: ");
Console.Write($"[");
for(int i = 0; i < oldArray.GetLength(0); i++)
    {
        Console.Write($"{oldArray[i]} ");
    }
Console.Write($"]");
Console.WriteLine();
Console.WriteLine("New array: ");
Console.Write($"[");
for(int i = 0; i < newArray.GetLength(0); i++)
    {
        Console.Write($"{newArray[i]}  ");
    }
    Console.Write($"]");
    Console.WriteLine();
}

PrintNewArray(array1);
PrintNewArray(array2);
PrintNewArray(array3);