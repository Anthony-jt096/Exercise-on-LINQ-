
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student("Alice", 20, "A"),
            new Student("Bob", 22, "B"),
            new Student("Charlie", 20, "A"),
            new Student("David", 21, "C"),
            new Student("Eve", 22, "B"),
            new Student("Frank", 23, "C")
        };

        // Perform queries using LINQ
        PerformQueries(students);
    }

    static void PerformQueries(List<Student> students)
    {
        // 1. Finding all students with a specific grade
        var gradeAStudents = students.Where(s => s.Grade == "A").ToList();
        Console.WriteLine("Students with Grade A:");
        foreach (var student in gradeAStudents)
        {
            Console.WriteLine(student.Name);
        }

        // 2. Sorting students by age
        var sortedByAge = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nStudents sorted by Age:");
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"{student.Name} - {student.Age}");
        }

        // 3. Grouping students by grade
        var groupedByGrade = students.GroupBy(s => s.Grade);
        Console.WriteLine("\nStudents grouped by Grade:");
        foreach (var group in groupedByGrade)
        {
            Console.WriteLine($"Grade {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine($"  {student.Name}");
            }
        }

        // 4. Selecting specific properties
        var studentNames = students.Select(s => s.Name).ToList();
        Console.WriteLine("\nStudent Names:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}
