using ChallengeApp;
Console.WriteLine("Witaj w moim programie do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeInMemory("konrad", "sowizral");
var employee1 = new EmployeeInFile("konrad", "sowizral");
employee.GradeAdded += EmployeeGradeAdded;
employee1.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nowa ocene");
}

while (true)
{
    Console.WriteLine("Podaj swoją ocenę:");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee1.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Except catched: {e.Message}");
    }
}

var statistic = employee1.GetStatistics();
Console.WriteLine($"Wartosc minimalna1: {statistic.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic.Max}");
Console.WriteLine($"Wartosc średnia: {statistic.Averange:N2}");
Console.WriteLine($"Zdobyłeś literę: {statistic.AverangeLetter}");