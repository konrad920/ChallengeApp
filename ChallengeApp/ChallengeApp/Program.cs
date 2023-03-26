using ChallengeApp;

var employee = new Employee("jacek", "kowalski");
employee.AddGrade(3.5f);
employee.AddGrade(-2.4f);
employee.AddGrade(6);
var statistic = employee.GetStatistics();

Console.WriteLine($"Wartosc minimalna: {statistic.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic.Max}");
Console.WriteLine($"Wartosc średnia: {statistic.Averange:N2}");