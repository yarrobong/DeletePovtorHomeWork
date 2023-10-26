string str = Console.ReadLine();
string result = String.Empty;
for (int i = 0; i < str.Length; i++)
{
    if (!result.Contains(str[i]))
    {
        result = result + str[i];
    }
}
Console.WriteLine(result);