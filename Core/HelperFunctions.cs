using System;

namespace Core.HelperFunctions
{
    class Helper
    {
        public static void CheckArgumentCount(string[] args)
        {
            Console.WriteLine($"Argument Count: { args.Length }");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument[{ i }]: { args[i] }");
            }
        }

        public static bool BadInputCheck(string[] args)
        {
            if(args.Length >= 3)
		    {
		    	ErrorLog("Too many arguments!");
		    	return true;
		    }
		    else if(args.Length < 2)
		    {
		    	ErrorLog("Too few arguments!");
		    	return true;
		    }

            return false;
        }

        public static void ErrorLog(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);

            Console.ResetColor();
        }
    }
}