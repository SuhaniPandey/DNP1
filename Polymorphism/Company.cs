using System.Collections;

namespace ProgrammingSecondSession;

public class Company
{
    public List<Employer> Employees= new List<Employer>();

    public double GetMonthlySalaryTotal()
    {
        double total = 0;
        foreach (Employer employer in Employees)
        {
             total+=employer.GetMonthlySalary();
        }

        return total;
    }

    public void HireNewEmployee(Employer employer)
    {
        Console.WriteLine("Yes! the employer is added");
        Employees.Add(employer);
    }
}