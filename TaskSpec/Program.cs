// Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символам

string[] textArray = new string[5] {"hello", "2", "world", ":-)", "!"};
string[] modifiedArray = new string[textArray.Length];

void Filter(string[] textArray, string[] modifiedArray)
{
    int count = 0;
    for(int i = 0; i < textArray.Length; i++)
    {
        if(textArray[i].Length <= 3)
        {
            modifiedArray[count] = textArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Filter(textArray, modifiedArray);
PrintArray(modifiedArray);
