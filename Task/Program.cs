
//Функфия формипрвания массива 
string[] FormationArray(string[] temparray)
{ 
    int index = 0;
    string[] result = new string[temparray.Length];
    foreach (var value in temparray)
    {
        if (value.Length <= 3)
        {
            result[index] = value;
            index++;
        }
    }
    result = result.Where(x => x != null).ToArray();
    return result;
}

string[] myarray = {"hello", "2", "world", ":-)"};
string[] myarray1 = { "1234", "1567", "-2", "computer science" };
string[] myarray2 = {"Russia", "Denmark", "Kazan"};

Console.WriteLine($" [{string.Join(", ", myarray)}] -> [{string.Join(", ", FormationArray(myarray))}]\n");
Console.WriteLine($" [{string.Join(", ", myarray1)}] -> [{string.Join(", ", FormationArray(myarray1))}]\n");
Console.WriteLine($" [{string.Join(", ", myarray2)}] -> [{string.Join(", ", FormationArray(myarray2))}]\n");