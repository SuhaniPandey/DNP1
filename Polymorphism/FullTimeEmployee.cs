namespace ProgrammingSecondSession;

public class FullTimeEmployee: Employer
{
    public double MonthlySalary { get; set; }

    public FullTimeEmployee(string? name, double monthlySalary) : base(name)
    {
        MonthlySalary = monthlySalary;
    }

    public override double GetMonthlySalary()
    {
        Console.WriteLine("Hello Mr/Mrs "+Name+"Your monthly salary is: ");
        return MonthlySalary;
    }
}