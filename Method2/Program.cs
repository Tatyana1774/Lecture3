
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Text messege");*/

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text messege", 4);
//Method21(msg: "Text messege", count: 4);
Method21(count: 4, msg: "Text messege");
