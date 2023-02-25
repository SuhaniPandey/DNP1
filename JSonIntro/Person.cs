using System.Text.Json;

namespace JSonIntro;

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public double? Height { get; set; }
    public bool IsMarried { get; set; }
    public string[]? Hobbies { get; set; }
    public char Sex { get; set; }

    public Person(string? firstName, string? lastName, int age, double? height, bool isMarried, string[]? hobbies, char sex)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Height = height;
        IsMarried = isMarried;
        Hobbies = hobbies;
        Sex = sex;
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this,new JsonSerializerOptions()
        {
            WriteIndented = true
        });
    }
}