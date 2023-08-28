
using System.ComponentModel.Design;

int score = 200;

if (score >= 88 && score <= 100)
{
    Console.WriteLine("Success AA");
}
else if (score >= 81 && score <= 88)
{
    Console.WriteLine("Success BA");
}
else if (score >= 74 && score <= 81)
{
    Console.WriteLine("Success BB");
}
else if (score >= 67 && score <= 74)
{
    Console.WriteLine("Success CB");
}
else if (score >= 60 && score <= 67)
{
    Console.WriteLine("Success CC");
}
else if (score >= 0 && score <= 60)
{
    Console.WriteLine("Fail FF");
}
else
{
    Console.WriteLine("Invalid Score");
}



