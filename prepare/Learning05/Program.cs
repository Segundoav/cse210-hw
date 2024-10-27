using System;

// Base class for representing assignments
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor initializing student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()

    {
        return $"{_studentName} - {_topic}";
    }

}
// Derived class for math assignments
public class MathAssignment : Assignment

{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)

        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} problems {_problems}";
        }


}

// Derived class for writing assignments
public class WritingAssignment : Assignment

{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)

    {
        _title = title;
    }    

    public string GetWritingInformation()
    {
        return $"{_title} by {GetSummary().Split(" - ")[0]}";

    }
}

// main program
class Program
{
    static void Main(string[] args)

    {
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The causes of World War II");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}