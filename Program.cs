using System;
using Core.FPS_GAMES;

class Program
{
	static int Main(string[] args)
	{
		HandleArguments(args);

		return 0;
	}

	static void HandleArguments(string[] args)
	{
		if(args.Length >= 3)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Too many arguments!");

			Console.ResetColor();
			return;
		}
		else if(args.Length == 0)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Too few arguments!");

			Console.ResetColor();
			return;
		}



		switch(args[0])
		{
			case "csgo":
			{
				float DPI;
				if(!float.TryParse(args[1], out DPI))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"Bad Input: {args[1]}");
					Console.ResetColor();
					return;
				}

				Console.WriteLine($"in-game sensitivity: {CSGO.InGameSens(DPI)}");
				return;
			}

			default:
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Unknown Argument!");
					Console.ResetColor();
					return;
				}
		}
	}
}