Console.WriteLine("What operation do you want to do");


string command = Console.ReadLine();
double number;
double sum = 0;



while (command != "stop")

{
    

    if (command == "+")
    {
        sum += number;
    }
    else if (command == "-")
    {
        sum -= number;
    }
    else if (command == "*")
    {
        sum *= number;
    }
    else if (command == "/")
    {
        sum /= number;
    }
    else
    {
        break;
    }
    command = Console.ReadLine();

}
Console.WriteLine(sum);







