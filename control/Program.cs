Console.WriteLine("Введите размер массива: ");
string userInput = Console.ReadLine() ?? "";
int sizeArr1 = int.Parse(userInput);
int i = 0;
int sizeArr2 = 0;

string[] array1 = GetArray1(sizeArr1);
SizeArr2(array1);
string[] array2 = GetArray2(sizeArr1, array1);
if (sizeArr1 > 0)
{
    Console.WriteLine($"[\"{String.Join("\", \"", array1)}\"] --> [\"{String.Join("\", \"", array2)}\"] ");
}
else
{
    Console.WriteLine($"[\"{String.Join("\", \"", array1)}\"] --> [\"Нет нужных строк!\"] ");
}

/////////////////////////////////////////////////////
string[] GetArray1(int sizeArr1)
{

    string[] result = new string[sizeArr1];
    for (i = 0; i < sizeArr1; i++)
    {
        Console.WriteLine("Enter strings:");
        string userInput1 = Console.ReadLine() ?? "";
        result[i] = userInput1;
    }
    return result;
}

int SizeArr2(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            sizeArr2 = sizeArr2 + 1;
        }
    }
    return sizeArr2;
}

string[] GetArray2(int sizeArr2, string[] array1)
{
    string[] array2 = new string[sizeArr2];
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}
