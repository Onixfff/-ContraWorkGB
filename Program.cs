string[] array = {"Мир", "Как дела?", "321", "Это", "Привет!"};
string[] newArray = new string[0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newArray = GrowsAnArray(newArray, 1);
        newArray[newArray.Length - 1] = array[i];
    }
}

System.Console.WriteLine(ConvertToString(array));
System.Console.WriteLine(ConvertToString(newArray));

string[] GrowsAnArray(string[] array, int add)
{
    string[] newArray = new string[array.Length + 1];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }

    return array = newArray;
}

string ConvertToString(string[] array)
{
    return $"[{String.Join(", ", array)}]";
}