// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GameLogic Class
// Logic behind the GUI. This calculates
// some statistics such as scores and
// randomizes a list of enemies.
namespace aestampaFinalProject
{
    public class GameLogic
    {
        // Event Handlers
        public event EventHandler<HeroesUpdateEventArgs>? HeroesUpdate;
        public event EventHandler<EnemiesUpdateEventArgs>? EnemiesUpdate;
        public event EventHandler<StartThisGame>? AttackUpdate;
        public event EventHandler<GameWonEventArgs>? EndGame;
        public event EventHandler<UpdateStatsEventArgs>? UpdateStats;

        // List of heroes, selected enemies, and turn order
        List<Hero> heroList = new List<Hero>();
        List<Enemy> enemyEncounter = new List<Enemy>();
        List<Entity> turnOrder = new List<Entity>();

        // Random number
        Random random = new Random();

        // Number of rounds, wins, and losses
        int roundCount = 0;
        int winCount = 0;
        int lossCount = 0;
        int totalRounds = 0;

        // Scores
        double currentScore = 0;
        double highScore = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public GameLogic()
        { }

        /// <summary>
        /// Initialize a game / round
        /// </summary>
        public void InitializeGame()
        {
            HeroesAssemble();
            GenerateEncounter();
            SetTurnOrder();
            HeroesTurn();
        }

        #region methods
        /// <summary>
        /// Initializes a list of heroes per round
        /// </summary>
        private void HeroesAssemble()
        {
            heroList.Add(new Warrior());
            heroList.Add(new Mage());
            heroList.Add(new Cleric());
            HeroesUpdated();
        }

        /// <summary>
        /// Initializes of list of enemy encounters per round
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void GenerateEncounter()
        {
            enemyEncounter.Clear();
            int numBandits = 0; // Game should have at least two bandits and/or one other enemy
            int encounterSize = random.Next(3);
            for (int i = 0; i <= encounterSize; i++)
            {
                int randomEnemy = random.Next(3);
                if (numBandits >= 2)
                {
                    randomEnemy = random.Next(1, 3);
                }
                switch (randomEnemy)
                {
                    case 0: enemyEncounter.Add(new Bandit()); numBandits++; break;
                    case 1: enemyEncounter.Add(new Ogre()); break;
                    case 2: enemyEncounter.Add(new Dragon()); break;
                    default: throw new Exception("Math Hard t(>-<t)");
                }
            }
            EnemiesUpdated();
        }

        /// <summary>
        /// Sorts a list of turns each entity based on speed
        /// </summary>
        private void SetTurnOrder()
        {
            turnOrder.Clear();
            turnOrder.AddRange(heroList);
            turnOrder.AddRange(enemyEncounter);
            turnOrder = turnOrder.OrderByDescending(x => x.Speed).ToList();
        }

        #endregion
        #region Events Related

        // Heroes related
        /// <summary>
        /// Initialize a list of heroes
        /// </summary>
        private void HeroesUpdated()
        {
            HeroesUpdateEventArgs e = new HeroesUpdateEventArgs(heroList);
            OnHeroesUpdate(this, e);
        }

        /// <summary>
        /// Send to list of heroes to GameGUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnHeroesUpdate(object? sender, HeroesUpdateEventArgs e)
        {
            HeroesUpdate?.Invoke(sender, e);
        }

        /// <summary>
        /// Initialize an EventArgs to start a new game / round
        /// </summary>
        private void HeroesTurn()
        {
            StartThisGame e = new StartThisGame(turnOrder, roundCount);
            TurnUpdate(this, e);
        }

        /// <summary>
        /// Send list of turns to GameGUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void TurnUpdate(object? sender, StartThisGame e)
        {
            AttackUpdate?.Invoke(sender, e);
        }

        // Enemies related
        /// <summary>
        /// Initialize list of selected enemies
        /// </summary>
        private void EnemiesUpdated()
        {
            EnemiesUpdateEventArgs e = new EnemiesUpdateEventArgs(enemyEncounter);
            OnEnemiesUpdate(this, e);
        }

        /// <summary>
        /// Send list of selected enemies to GameGUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnEnemiesUpdate(object? sender, EnemiesUpdateEventArgs e)
        {
            EnemiesUpdate?.Invoke(sender, e);
        }

        /// <summary>
        /// Start a new round once user wins a round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateNewRound(object? sender, NewRoundEventArgs e)
        {
            roundCount++; // Increment number of rounds
            if (roundCount < 3) // If user has not won game yet
            {
                EmptyLists(); // Empty all lists in GameLogic
                InitializeGame(); // Reinitialize game
            } else // If user has won game
            {
                winCount++; // Increment number of wins
                SendScores(); // Update stats
                WinGame(); // End game with a win
            }
        }

        /// <summary>
        /// Calculate statistics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateNewScores(object? sender, UpdateScoreEventArgs e)
        {
            // Update score based on enemies defeated
            if (e.EnemyDied != null)
            {
                if (e.EnemyDied is Bandit)
                {
                    currentScore += 100;
                }
                else if (e.EnemyDied is Ogre)
                {
                    currentScore += 250;
                }
                else
                {
                    currentScore += 500;
                }
            }

            // Update score based on if a round was finished
            if (e.NewRound)
            {
                currentScore += 1000;
                totalRounds++;
            }

            // Update high score if current score is higher than or equal to high score
            if (currentScore >= highScore)
            {
                highScore = currentScore;
            }

            // Update stats
            SendScores();
        }

        /// <summary>
        /// Increment number of losses if user loses a game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LostGame(object? sender, GameOverEventArgs e)
        {
            lossCount++;
            SendScores();
            currentScore = 0;
        }

        /// <summary>
        /// Start a new game if user either wins or loses game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeNewGame(object? sender, StartNewGameEventArgs e)
        {
            roundCount = 0;
            EmptyLists();
            InitializeGame();
        }

        /// <summary>
        /// Reinitialize all lists in GameLogic
        /// </summary>
        private void EmptyLists()
        {
            heroList = new List<Hero>();
            enemyEncounter = new List<Enemy>();
            turnOrder = new List<Entity>();
        }

        /// <summary>
        /// Initialize an EventArgs when the user wins a game
        /// </summary>
        private void WinGame()
        {
            GameWonEventArgs e = new GameWonEventArgs();
            currentScore += 5000;
            if (currentScore >= highScore)
                highScore = currentScore;

            SendScores();
            EndTheGame(this, e);
        }

        /// <summary>
        /// Tell GameGUI that the user won a game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void EndTheGame(object? sender, GameWonEventArgs e)
        {
            EndGame?.Invoke(sender, e);
        }
        
        /// <summary>
        /// Send scores to GUI
        /// </summary>
        private void SendScores()
        {
            UpdateStatsEventArgs e = new UpdateStatsEventArgs(currentScore, highScore, winCount, lossCount, totalRounds);
            SendTheScores(this, e);
        }
        
        /// <summary>
        /// Update stats in GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void SendTheScores(object? sender, UpdateStatsEventArgs e)
        {
            UpdateStats?.Invoke(sender, e);
        }

        #endregion
    }
}
