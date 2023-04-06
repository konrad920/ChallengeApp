using ChallengeApp;
Console.WriteLine("Witaj w moim programie do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeInFile("konrad", "sowizral");
employee.AddGrade(20);
employee.AddGrade(14.4f);
employee.AddGrade('c');
employee.AddGrade("23");

var statistic1 = employee.GetStatistics();
Console.WriteLine(statistic1.Min);
Console.WriteLine(statistic1.Max);
Console.WriteLine($"Cos tam: {statistic1.Averange:N2}");
Console.WriteLine(statistic1.AverangeLetter);

//try
//{
//    supervisor.AddGrade("2+15");
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Exception catched: {e.Message}");
//}

//supervisor.AddGrade("2");
//Console.WriteLine(supervisor.GetStatistics().Averange);

//while (true)
//{
//    Console.WriteLine("Podaj swoją ocenę:");
//    var input = Console.ReadLine();
//    if (input == "q" || input == "Q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Except catched: {e.Message}");
//    }
//}

//var statistic = employee.GetStatistics();
//Console.WriteLine($"Wartosc minimalna1: {statistic.Min}");
//Console.WriteLine($"Wartosc maksymalna: {statistic.Max}");
//Console.WriteLine($"Wartosc średnia: {statistic.Averange:N2}");
//Console.WriteLine($"Zdobyłeś literę: {statistic.AverangeLetter}");