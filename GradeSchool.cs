using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private List<Student> roster { get; set; }

    public GradeSchool() => roster = new List<Student>();

    public void Add(string student, int grade) => roster.Add(new Student(student, grade));

    public IEnumerable<string> Roster() => roster.OrderBy(s => s.grade).ThenBy(s => s.student).Select(s => s.student);

    public IEnumerable<string> Grade(int grade) => roster.Where(g => g.grade == grade).OrderBy(o => o.student).Select(s => s.student);
}