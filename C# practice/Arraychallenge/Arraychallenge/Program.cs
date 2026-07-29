

int[] marks = { 82, 75, 91, 68, 88 };
int totalMarks = 0;

for (int i=0; i<marks.Length; i++)
{
    Console.WriteLine(marks[i]);
    totalMarks = totalMarks + marks[i];
}
Console.WriteLine($"total marks: {totalMarks}" );