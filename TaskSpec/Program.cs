string[] textArray = new string[5] {"hello", "2", "world", ":-)", "!"};
string[] modifiedArray = new string[textArray.Length];

void Modified(string[] textArray, string[] modifiedArray)
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