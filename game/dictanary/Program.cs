string command = Console.ReadLine();
while (command!= "Travel")
{
    string[] tokens = command.Split(":");
    if (tokens[0]=="Add stop")
    {
        int index = int.Parse(tokens[1]);
        string insertString = tokens[2];
        if (!insertString.Contains(insertString))
        {
            command=command.Insert(index, insertString);
            Console.WriteLine(command);
        }
       
    }
    else if (tokens[0]=="")
    {

    }
    
}
