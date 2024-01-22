Console.Write("Name: ");
string name = Console.ReadLine()!;
string mssg = name switch
{
    "Yemi" => "Were, wetin you dey find?",
    "Adeyemi" => "Tf is you?",
    "Az" => "so you sef dey here",
    "Rusty" => "Mf, what's you on?",
    "all" => "We is one",
    _ => "Storm off!"
};

Console.WriteLine(mssg);