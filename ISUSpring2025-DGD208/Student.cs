namespace ISUSpring2025_DGD208;

public struct Student
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Major { get; init; }
    public float GPA { get; init; }
    public int Year { get; init; }
    public int Credits { get; init; }
    
    // Constructor for convenience
    public Student(int id, string name, string major, float gpa, int year, int credits)
    {
        Id = id;
        Name = name;
        Major = major;
        GPA = gpa;
        Year = year;
        Credits = credits;
    }
}