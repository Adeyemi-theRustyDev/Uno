namespace Uno;
public class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new ()
        {
            new () { Name = "Adeyemi", DateOfBirth = new DateTime(2005, 02, 09) },
            new () { Name = "Mariam",  DateOfBirth = new DateTime(2005, 05, 25) }
        };
        foreach (var person in people)
        {
            Console.WriteLine(person.Name);
        }
    }
}

internal class Person
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
}