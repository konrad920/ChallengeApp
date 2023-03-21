using System.Diagnostics.Metrics;

int number = 48465;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

List<int> counters = new List<int>();
for (int i = 0; i < 10; i++)
{
    counters.Add(0);
}

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counters[0]++;
    }
    else if (letter == '1')
    {
        counters[1]++;
    }
    else if (letter == '2')
    {
        counters[2]++;
    }
    else if (letter == '3')
    {
        counters[3]++;
    }
    else if (letter == '4')
    {
        counters[4]++;
    }
    else if (letter == '5')
    {
        counters[5]++;
    }
    else if (letter == '6')
    {
        counters[6]++;
    }
    else if (letter == '7')
    {
        counters[7]++;
    }
    else if (letter == '8')
    {
        counters[8]++;
    }
    else if (letter == '9')
    {
        counters[9]++;
    }
}

for (int i = 0; i < counters.Count; i++)
{
    Console.WriteLine("cyfry " + i + " jest " + counters[i]);
}
