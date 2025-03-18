namespace ISUSpring2025_DGD208;

public class DatabaseOps
{
    private List<Student> _students;
    private List<string> _studentIds = ["Can", "Cin", "Cem"];
    private const float _minGPA = 3.5f;
    
    public DatabaseOps()
    {

    }
    
    public void Run()
    {
        GenerateListOfStudents();
        FilterAndSortStudents(_students);
        Console.WriteLine("---------------");
        FilterAndSortWithLinq(_students);
        Console.WriteLine("---------------");
        FilterAndSortWithLinqShort(_students);
    }

    
    private void GenerateListOfStudents()
    {
        _students = new List<Student>
        {
            new Student(1, "Emma Wilson", "Computer Science", 3.8f, 3, 84),
            new Student(2, "Liam Rodriguez", "Psychology", 3.4f, 2, 51),
            new Student(3, "Olivia Chen", "Computer Science", 4.0f, 4, 112),
            new Student(4, "Noah Patel", "Biology", 3.2f, 1, 28),
            new Student(5, "Sophia Johnson", "English", 3.7f, 3, 90),
            new Student(6, "Jackson Kim", "Psychology", 2.9f, 2, 62),
            new Student(7, "Ava Martinez", "Engineering", 3.9f, 4, 125),
            new Student(8, "Lucas Smith", "Computer Science", 3.5f, 3, 91),
            new Student(9, "Isabella Thompson", "Biology", 3.6f, 2, 59),
            new Student(10, "Ethan Williams", "Engineering", 3.1f, 1, 31)
        };
    }

    public void FilterAndSortStudents(List<Student> students)
    {
        // Step 1: Filter students with GPA > 3.5
        List<Student> filteredStudents = new List<Student>();
        foreach (var student in students)
        {
            if (student.GPA > 3.5)
            {
                filteredStudents.Add(student);
            }
        }

        // Step 2: Sort the filtered list in descending order of GPA
        for (int i = 0; i < filteredStudents.Count - 1; i++)
        {
            for (int j = i + 1; j < filteredStudents.Count; j++)
            {
                if (filteredStudents[i].GPA < filteredStudents[j].GPA)
                {
                    // Swap
                    Student temp = filteredStudents[i];
                    filteredStudents[i] = filteredStudents[j];
                    filteredStudents[j] = temp;
                }
            }
        }
        
        WriteStudentInfo(filteredStudents);
    }

    public void FilterAndSortWithLinq(List<Student> students)
    {
        IEnumerable<Student> filteredStudents = 
            from student in students
            where student.GPA >= 3.5f
            orderby student.GPA descending
            select student;
        
        WriteStudentInfo(filteredStudents.ToList());
    }

    public void FilterAndSortWithLinqShort(List<Student> students)
    {
        IEnumerable<string> query = students.Where(s => s.GPA >= 3.5f)
            .OrderByDescending(s => s.GPA)
            .Select(s => $"{s.Name} with GPA {s.GPA} is stuying {s.Major}");

        foreach (string gpa in query)
        {
            Console.WriteLine(gpa);
        }
    }
    
    private void WriteStudentInfo(List<Student> students)
    {
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{students[i].Name}: {students[i].GPA}");   
        }
    }
}