// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using JSonIntro;

Person person = new Person("suhani","pandey",20,156,false,null,'F');

Person person1= new Person("rajip","paudyal",20,177,true,new []{"Talking","Beating"},'M');
Person person2=new Person("Pramesh","Shrestha",20,186,true,new []{"Teaching","Singing--heheeee"},'M');

List<Person> persons= new List<Person>();
persons.Add(person);
persons.Add(person1);
persons.Add(person2);

PersonPersistance persistance = new PersonPersistance();
persistance.StoreObject(persons);
persistance.ReadObject(persons);



