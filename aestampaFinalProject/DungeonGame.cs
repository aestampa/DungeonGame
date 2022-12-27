// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DungeonGame class
// Initializes the dungeon game and
// its GUI and logic. Afterwards,
// it runs the whole game.
namespace aestampaFinalProject
{
    public class DungeonGame
    {
        // GameGUI and GameLogic
        GameGUI gameGUI;
        GameLogic gameLogic;

        /// <summary>
        /// Constructor to start whole game
        /// </summary>
        public DungeonGame()
        {
            gameGUI = new GameGUI();
            gameLogic = new GameLogic();
            gameLogic.HeroesUpdate += gameGUI.HeroesUpdateHandler;
            gameLogic.EnemiesUpdate += gameGUI.EnemiesUpdateHandler;
            gameLogic.AttackUpdate += gameGUI.StartGameHandler;
            gameLogic.EndGame += gameGUI.GameWon;
            gameLogic.UpdateStats += gameGUI.RetrieveStats;
            gameGUI.RoundUpdater += gameLogic.UpdateNewRound;
            gameGUI.GameOverUpdater += gameLogic.LostGame;
            gameGUI.StartNewGameUpdater += gameLogic.MakeNewGame;
            gameGUI.ScoreUpdater += gameLogic.UpdateNewScores;
            
            gameLogic.InitializeGame();
            Application.Run(gameGUI);
        }
    }
}
