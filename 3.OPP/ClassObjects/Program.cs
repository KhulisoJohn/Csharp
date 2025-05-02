using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Teacher: {Name}, Subject: {Subject}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student { Name = "John", Age = 33 };
        s.DisplayDetails();

        Teacher t = new Teacher { Name = "Mrs. Smith", Subject = "Math" };
        t.DisplayDetails(); 
    }
}
