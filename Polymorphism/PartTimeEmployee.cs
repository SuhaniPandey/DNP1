namespace ProgrammingSecondSession;

public class PartTimeEmployee:Employer
{
    public double HourlyWage { get; set; }
    public int HoursPerWage { get; set; }

    public PartTimeEmployee(string? name, double hourlyWage, int hoursPerWage) : base(name)
    {
        HourlyWage = hourlyWage;
        HoursPerWage = hoursPerWage;
    }

    public override double GetMonthlySalary()
    {
        Console.WriteLine("Hello Mr/Mrs "+Name+"Your monthly salary is: ");
        return HourlyWage*HoursPerWage;
    }
}