internal class Student
{
    internal Student(string student, int grade)
    {
        this.student = student;
        this.grade = grade;
    }

    internal string student { get; set; }
    internal int grade { get; set; }
}
