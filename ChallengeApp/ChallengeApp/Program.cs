var name = "Ewa";
char sex = 'f';
var age = 33;

if (sex == 'f')
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}
else if (sex == 'm')
{
    if (age >= 18)
    {
        Console.WriteLine("Mężczyzna pełnoletni " + name);
    }
    else 
    {
        Console.WriteLine("Mężczyzna niepełnoletni " + name);
    }
}
else
{
    Console.WriteLine("Nie odpowiedni znak");
}