// See https://aka.ms/new-console-template for more information

using ProgrammingSecondSession;

Company company= new Company();
Employer employer = new Employer("Suhani");
Employer employer1 = new FullTimeEmployee("Suhani Pandey", 300);
Employer employer2 = new PartTimeEmployee("Rajip Paydyal", 2, 10);


company.HireNewEmployee(employer);
company.HireNewEmployee(employer1);
company.HireNewEmployee(employer2);

Console.WriteLine(employer1.GetMonthlySalary());
Console.WriteLine(employer2.GetMonthlySalary());
Console.WriteLine(company.GetMonthlySalaryTotal());