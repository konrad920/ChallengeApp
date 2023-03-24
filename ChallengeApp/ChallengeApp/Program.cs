using ChallengeApp;

var employ1 = new Employee("jacek", "kowalski", 32);
var employ2 = new Employee("Zuzia", "ładna", 21);
var employ3 = new Employee("MaCiek", "Józefek", 25);

int[] pointsOfFirstEmployee = {9, 9, 9, 9, 9};
int[] pointsOfSecondEmployee = { 1, 9, 6, 7, 2 };
int[] pointsOfThirdEmployee = { 6, 8, 3, 2, 4 };

for (int i = 0; i < 5;  i++)
{
    employ1.AddPoints(pointsOfFirstEmployee[i]);
    employ2.AddPoints(pointsOfSecondEmployee[i]);
    employ3.AddPoints(pointsOfThirdEmployee[i]);
}

List <Employee> employes = new List<Employee>()
{
    employ1, employ2, employ3
};


int theBestScore = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employ in employes)
{
    if (employ.Score > theBestScore)
    {
        EmployeeWithMaxResult = employ;
        theBestScore = employ.Score;
    }
}

Console.WriteLine("Najwiecej punktów: " + EmployeeWithMaxResult.Score + " osiagnął, " + EmployeeWithMaxResult.Name 
   + " " + EmployeeWithMaxResult.Surname + " lat " + EmployeeWithMaxResult.Age);