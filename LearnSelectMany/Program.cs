using System;
using System.Linq;

class School
{
    public string Name;
    public Student[] Students { get; set; }
}

class Student
{
    public string Name { get; set; }
}


public class Program
{
    public static void Main()
    {
        var schools = new[]
        {
            new School()
                {Name = "A school", Students = new[] {new Student() {Name = "Bob"}, new Student() {Name = "Jack"}}},
            new School()
                {Name = "B school", Students = new[] {new Student() {Name = "Jim"}, new Student() {Name = "John"}}}
        };
        var studentList = schools.Select(s => s.Students);
        foreach (var item in studentList)
        {
            Console.WriteLine(item);
        }
        var allStudents = schools.SelectMany(s => s.Students);
        foreach (var item in allStudents)
        {
            Console.WriteLine(item);
        }
        
        var directory = schools
            .SelectMany(s => s.Students,
                (parent, child) => new {shcoolName=parent.Name,studentName=child.Name});

        foreach (var item in directory)
        {
            Console.WriteLine(item);
        }

        foreach (var student in allStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}