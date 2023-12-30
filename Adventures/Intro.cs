namespace Uno
{
	public class Intro
	{
		public static void Quests(string[] args)
		{
			Console.WriteLine("Which Quest do you want?");
			string choice = Console.ReadLine()!;
			string response;

			response = choice switch
			{
				"1" => "Ye rest and recover your health",
				"2" => "Raiding the port town get ye 50 gold doubloons",
				"3" => "The wind is at your back; the open horizon ahead",
				"4" => "T'is but a baby Kraken, but still it eats toy boats",
				_ => "Apologies. I don't know that one."
			};

			Console.WriteLine(response);
		}
	}
}
