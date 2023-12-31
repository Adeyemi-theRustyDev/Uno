namespace Uno.Models;

internal class Person
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public static List<Person> PrePopulate()
    {
        List<Person> people = new()
        {
            new () { Name = "Adeyemi", DateOfBirth = new DateTime(2005, 02, 09) },
            new () { Name = "Mariam",  DateOfBirth = new DateTime(2005, 05, 25) }
        };
        return people;
    }
}



