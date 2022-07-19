
namespace Core.FPS_GAMES
{
    class CSGO
    {
        public static float eDPI = 960;

        public static float InGameSens(float DPI)
        {
            return eDPI / DPI;
        }
    }

    class Valorant
    {
        public static float eDPI = 288;

        public static float InGameSens(float DPI)
        {
            return eDPI / DPI;
        }
    }
}