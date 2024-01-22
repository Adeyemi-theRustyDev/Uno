namespace uno.Classes;
public class Octopus
{
    public string Color { get; set; } = "Purple";
    public void Arms() {
        string color =  Color;
        void Fingers() => Console.WriteLine($"Color of fingers are: {color}");
        Fingers();
    }

}