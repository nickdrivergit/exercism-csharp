using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private List<Tuple<int, string>> schoolRoster = new List<Tuple<int,string>>();

    public void SortRoster(List<Tuple<int, string>> roster)
    {
        schoolRoster.Sort((x, y) => {
            int result = x.Item1.CompareTo(y.Item1);
            return result == 0 ? x.Item2.CompareTo(y.Item2) : result;
        });
    }
    
    public void Add(string student, int grade)
    {
        Tuple<int, string> tStudent = new Tuple<int, string>(grade, student);
        schoolRoster.Add(tStudent);
    }

    public IEnumerable<string> Roster()
    {
        SortRoster(schoolRoster);
        List<string> output = new List<string>();
        foreach (Tuple<int,string> student in schoolRoster)
        {
            output.Add(student.Item2);
        }
        return output.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        SortRoster(schoolRoster);
        List<string> output = new List<string>();
        foreach (Tuple<int,string> student in schoolRoster.Where(n => n.Item1 == grade))
        {
            output.Add(student.Item2);
        }
        return output.ToArray();
    }
}