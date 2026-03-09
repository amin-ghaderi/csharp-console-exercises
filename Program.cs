// See https://aka.ms/new-console-template for more information


Console.WriteLine("which music instrument do you like?");
//Console.ReadLine();
string instrument  = Console.ReadLine() ?? "";
Console.WriteLine("Can you play the " + instrument + "?");
string answer  = Console.ReadLine() ?? "";
Console.WriteLine(answer + " ?"+ " NO PROBLEM! " + "I also like the " + instrument + " !");


Console.WriteLine("whats your last name?");
string lastname = Console.ReadLine() ?? "";
Console.WriteLine("whats your first name?");
//Console.ReadLine();
string firstname = Console.ReadLine() ?? "";
Console.WriteLine(firstname.ToUpper() + " " + lastname.ToUpper() + " joined the firm " );



Console.WriteLine("whats your full name?");
//Console.ReadLine();
string fullname = Console.ReadLine() ?? "";
string [] names = fullname.Split(" ");
Console.WriteLine(names[1].ToUpper() +", "+names[0].ToLower() + " " + ": present" );
