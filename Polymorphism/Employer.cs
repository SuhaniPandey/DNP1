namespace ProgrammingSecondSession;

public class Employer
{
    public string? Name { get; set; }

    public Employer(string? name)
    {
        Name = name;
    }

    public virtual double GetMonthlySalary()
    {
        Console.WriteLine("Hello Mr/Mrs"+Name+"Your monthly salary is: ");
        return 0;
    }
    
}