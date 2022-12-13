//  РЕШЕНИЕ ЗАДАЧИ

string [] FillingStringArray(int sizeArray)
{
    Console.WriteLine($"Enter {sizeArray} string elements of the array:");
    string [] array = new string[sizeArray];
    string temp = string.Empty;
    int sizeNewArray = 0;
    for(int i = 0; i < sizeArray; i++)
    {
        temp = Console.ReadLine();
        array[i] = temp;
        if(temp.Length <= 3) sizeNewArray++;
    }

    string [] newArray = new string[sizeNewArray];
    for(int i = 0, j = 0; i < sizeArray; i++, j++)
    {
        temp = array[i];
        if(temp.Length <=3) newArray[j] = temp;
        else j--;
    }
    return newArray;
}

void PrintStringArray(string [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("\b\b]");    
}

Console.WriteLine("Enter the size of the array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
PrintStringArray(FillingStringArray(sizeArray));
