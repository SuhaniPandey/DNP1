using System.Net.Mime;
using System.Text.Json;

namespace JSonIntro;

public class PersonPersistance
{
    

    public void StoreObject(List<Person> persons)
    {
        string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {    
                WriteIndented = true
            }
        );
        File.WriteAllText("Person.txt",jsonFormatted);
    }

    public void ReadObject(List<Person> persons)
    {
        
        string Text = File.ReadAllText("Person.txt");
        List<Person>? listPerson = JsonSerializer.Deserialize<List<Person>>(Text);
        foreach (var person in listPerson)
        {
            Console.WriteLine(person);
        }
    }
    
}