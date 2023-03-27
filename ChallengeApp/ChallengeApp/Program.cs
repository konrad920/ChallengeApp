using ChallengeApp;

var employee = new Employee("jacek", "kowalski");
employee.AddGrade(4000);
employee.AddGrade("adam");
employee.AddGrade(6d);
employee.AddGrade("2");
employee.AddGrade(double.MaxValue);
employee.AddGrade('d');
var statistic = employee.GetStatistics();

Console.WriteLine($"Wartosc minimalna: {statistic.Min}");
Console.WriteLine($"Wartosc maksymalna: {statistic.Max}");
Console.WriteLine($"Wartosc średnia: {statistic.Averange:N2}");