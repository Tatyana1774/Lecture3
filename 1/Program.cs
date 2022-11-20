
string Method4(int count, string text)
{
    string result =String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "x");
Console.WriteLine(res);