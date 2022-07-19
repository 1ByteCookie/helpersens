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

		switch(args[0])
		{
			case "csgo":
			{
				float DPI = HandleSecondArg(args[1]);
				Console.Write($"in-game sensitivity: ");

				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine($"{ CSGO.InGameSens(DPI) }");

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
		float DPI;
		if(!float.TryParse(arg, out DPI))
		{
			Helper.ErrorLog($"Bad Input: {arg}");
		}

		return DPI;
	}
}