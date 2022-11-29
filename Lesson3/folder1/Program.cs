void Method1()
{
    System.Console.WriteLine("Some text");
}

Method1();

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Some text2");


void Method3(string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
        System.Console.WriteLine(msg);
    }
}
Method3("Some text2", 3);

int Method4(){
    return DateTime.Now.Year;
}
System.Console.WriteLine(Method4());

string Method5(int count, char symbol) {
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += symbol;
    }
    return result;
}
System.Console.WriteLine(Method5(5, 'A'));
