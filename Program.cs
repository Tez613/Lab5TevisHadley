void Cat()
{
Console.WriteLine("  ／l、     ");
Console.WriteLine("（ﾟ､ ｡ ７   ");
Console.WriteLine("  l  ~ヽ    ");
Console.WriteLine("  じしf_,)ノ");
    return;
}
Cat();
string Userinput()
{
    Console.WriteLine("Please Give me an Input");
    String Userinput = Console.ReadLine();
    return Userinput;
}
Console.WriteLine(Userinput());
string Input = "true";
while (Input == "true")
{
    Console.WriteLine("Please Pick an Input \n Addition=1 \n Subtraction=2 \n Multiplication=3 \n Division=4 \n Exit=5");
    int casenumber = int.Parse(Console.ReadLine());
    switch (casenumber)
    {
        case 1:
        Console.WriteLine("Addition");
        Console.WriteLine(addition());
        break;
        case 2:
        Console.WriteLine("Subtraction");
        Console.WriteLine(Subtraction());
        break;
        case 3:
        Console.WriteLine("Multiplication");
        Console.WriteLine(Mutiplication());
        break;
        case 4:
        Console.WriteLine("Division");
        Console.WriteLine(Division());
        break;
        case 5:
        Input = "false";
        break;
    }
}
    int addition()
    {
        Console.WriteLine("Please pick a number");
        int Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please pick another number");
        int Number2 = int.Parse(Console.ReadLine());
        int Number3 = Number1 + Number2;

        return Number3;
    }
    int Subtraction()
    {
        Console.WriteLine("Please pick a number");
        int Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please pick another number");
        int Number2 = int.Parse(Console.ReadLine());
        int Number3 = Number1 - Number2;

        return Number3;
    }
    int Mutiplication()
    {
        Console.WriteLine("Please pick a number");
        int Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please pick another number");
        int Number2 = int.Parse(Console.ReadLine());
        int Number3 = Number1 * Number2;

        return Number3;
    }
    int Division()
    {
        Console.WriteLine("Please pick a number");
        int Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("please pick another number");
        int Number2 = int.Parse(Console.ReadLine());
        int Number3 = Number1 / Number2;

        return Number3;
    }
