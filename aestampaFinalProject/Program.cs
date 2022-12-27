// By Abby Estampador
// CS 3020 001
// May 9, 2022

// This is where the whole program starts.
// It creates an instance of DungeonGame
// which then starts the whole game.
namespace aestampaFinalProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DungeonGame game = new DungeonGame();
        }
    }
}