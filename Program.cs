using System;
using Core.FPS_GAMES;
using Core.HelperFunctions;

class Program
{
	static int Main(string[] args)
	{
		HandleArguments(args);

		return 0;
	}

	static void HandleArguments(string[] args)
	{
		if(Helper.BadInputCheck(args))
			return;
		
		float DPI = HandleSecondArg(args[1]);
		if(DPI == 0)
			return;

		switch(args[0])
		{
			case "csgo":
			{
				Console.Write($"in-game sensitivity: ");

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"{ CSGO.InGameSens(DPI) }");

				Console.ResetColor();
				return;
			}

			case "val":
			{
				Console.Write($"in-game sensitivity: ");

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"{ Valorant.InGameSens(DPI) }");

				Console.ResetColor();

				return;
			}

			default:
			{
				Helper.ErrorLog("Unknown arguments!");
				return;
			}
		}
	}

	static float HandleSecondArg(string arg)
	{
		float DPI = 0;
		if(!float.TryParse(arg, out DPI))
		{
			Helper.ErrorLog($"Bad Input: {arg}");
		}

		return DPI;
	}
}