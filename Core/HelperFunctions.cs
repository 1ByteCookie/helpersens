using System;

namespace Core.HelperFunctions
{
    class Helper
    {
        public static void ArgumentCheck(string[] args)
        {
            Console.WriteLine($"Argument Count: { args.Length }");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument[{ i }]: { args[i] }");
            }
        }
    }
}