
string[] names = { "sipho", "lerato", "aisha", "john", "neo" };
int[] marks = { 82, 45, 91, 76, 38 };

for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] >= 50)
    {
        Console.WriteLine(names[i]);
    }
}