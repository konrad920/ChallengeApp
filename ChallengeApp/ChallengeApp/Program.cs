using ChallengeApp;

var employee = new Employee("jacek", "kowalski");
employee.AddGrade(4000);
employee.AddGrade("adam");
employee.AddGrade(6d);
employee.AddGrade("2");
employee.AddGrade(double.MaxValue);
employee.AddGrade('d');
var statistic = employee.GetStatistics();
var statistic1 = employee.GetStatistickWithForeach();
var statistic2 = employee.GetStatistickWithFor();
var statistic3 = employee.GetStatistickWithDoWhile();
var statistic4 = employee.GetStatistickWithWhile();

Console.WriteLine($"Wartosc minimalna1: {statistic1.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic1.Max}");
Console.WriteLine($"Wartosc średnia: {statistic1.Averange:N2}");

Console.WriteLine($"Wartosc minimalna2: {statistic2.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic2.Max}");
Console.WriteLine($"Wartosc średnia: {statistic2.Averange:N2}");

Console.WriteLine($"Wartosc minimalna3: {statistic3.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic3.Max}");
Console.WriteLine($"Wartosc średnia: {statistic3.Averange:N2}");

Console.WriteLine($"Wartosc minimalna4: {statistic4.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic4.Max}");
Console.WriteLine($"Wartosc średnia: {statistic4.Averange:N2}");