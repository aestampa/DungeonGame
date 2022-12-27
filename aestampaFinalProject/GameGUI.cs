// By Abby Estampador
// CS 3020 001
// May 9, 2022

// GameGUI class
// This class controls the GUI and
// its game features.
namespace aestampaFinalProject
{
    public partial class GameGUI : Form
    {
        // Picture boxes of heroes and enemies
        PictureBox[] heroPBs = new PictureBox[3];
        PictureBox[] enemyPBs = new PictureBox[3];

        // List of chosen heroes and enemies
        List<Hero> heroes = new List<Hero>();
        List<Enemy> enemies = new List<Enemy>();

        // Current turn variable
        int currentTurn = 0;

        // Random number selector
        Random random = new Random();

        // List of entities in order for turns
        List<Entity> turns = new List<Entity>();

        // Event handlers
        public event EventHandler<NewRoundEventArgs>? RoundUpdater;
        public event EventHandler<GameOverEventArgs>? GameOverUpdater;
        public event EventHandler<StartNewGameEventArgs>? StartNewGameUpdater;
        public event EventHandler<UpdateScoreEventArgs>? ScoreUpdater;

        /// <summary>
        /// Constructor
        /// </summary>
        public GameGUI()
        {
            InitializeComponent();
            InitializePBs();
        }

        /// <summary>
        /// Initialize picture boxes of heroes and enemies
        /// </summary>
        private void InitializePBs()
        {
            instructions.Hide(); // Hide instructions
            charGuide.Hide(); // Hide character guide
            playAgainButton.Hide(); // Hide "Play Again" button

            // Initialize picture boxes
            heroPBs[0] = warrior;
            heroPBs[1] = mage;
            heroPBs[2] = cleric;
            enemyPBs[0] = bandit1;
            enemyPBs[1] = ogre;
            enemyPBs[2] = dragon;

            // Ensure that their backcolor is transparent
            for (int i = 0; i < 3; i++)
            {
                heroPBs[i].BackColor = Color.Transparent;
                enemyPBs[i].BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// Event handler to update heroes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HeroesUpdateHandler(object ?sender, HeroesUpdateEventArgs e)
        {
            InitializePBs(); // Initialize picture boxes

            // Show picture boxes and initialize them with sprites
            for (int i = 0; i < e.Heroes.Count; i++)
            {
                heroPBs[i].Show();
                heroPBs[i].Image = e.Heroes[i].MySprite;
            }

            // Retrieve hero list from GameLogic and copy them to GUI's hero list
            heroes = e.Heroes;

            // If there are no other heroes, hide other picture boxes
            for (int i = 0; i < 3; i++)
            {
                if (heroPBs[i].Image == null)
                {
                    heroPBs[i].Hide();
                }
            }
        }

        /// <summary>
        /// Event handler to update enemies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnemiesUpdateHandler(object? sender, EnemiesUpdateEventArgs e)
        {
            // Initialize enemy picture boxes to a sprite and show them
            for (int i = 0; i < e.EnemyEncounter.Count; i++)
            {
                enemyPBs[i].Show();
                enemyPBs[i].Image = e.EnemyEncounter[i].MySprite;
            }

            // If no other enemies exist, hide the other picture boxes
            for (int i = 0; i < 3; i++)
            {
                if (enemyPBs[i].Image == null)
                {
                    enemyPBs[i].Hide();
                }
            }

            // Copy GameLogic's hero list to GUI's hero list
            enemies = e.EnemyEncounter;
        }

        /// <summary>
        /// Event Handler to start the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartGameHandler(object? sender, StartThisGame e)
        {

            // Copy EventArgs's list of turns to GUI's list of turns
            turns = e.TurnOrder;

            // Show round number
            statusLabel.Text = "Round " + (e.CurrentRound + 1);

            // Initialize and show all heroes' HP points and skill points
            warriorHealthLabel.Text = "HP Points: 100.00";
            mageHealthLabel.Text = "HP Points: 100.00";
            clericHealthLabel.Text = "HP Points: 100.00";

            warriorSkillLabel.Text = "Skill Points: 100.00";
            mageSkillLabel.Text = "Skill Points: 100.00";
            clericSkillLabel.Text = "Skill Points: 100.00";

            // Here, everyone will start taking turns based on the list of turns
            TakeTurns(e.TurnOrder);
        }

        /// <summary>
        /// Retrieve statistics from GameLogic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RetrieveStats(object? sender, UpdateStatsEventArgs e)
        {
            UpdateStatisticsLabel(e.GamesWon, e.GamesLost, e.NumRounds, e.CurrentScore, e.HighScore);
        }

        /// <summary>
        /// Update statistics in menu strip
        /// </summary>
        /// <param name="numWins"></param>
        /// <param name="numLosses"></param>
        /// <param name="numRounds"></param>
        /// <param name="currentScore"></param>
        /// <param name="highScore"></param>
        public void UpdateStatisticsLabel(int numWins, int numLosses, int numRounds, double currentScore, double highScore)
        {
            // Initialize win:loss ratio label
            winLossRatio.Text = numWins + ":" + numLosses;

            // Set scores
            currentScoreLabel.Text = "" + currentScore;
            highScoreLabel.Text = "" + highScore;

            // Set highest number of rounds won
            roundsWonLabel.Text = "" + numRounds;
        }

        /// <summary>
        /// Each entity will take turns here
        /// </summary>
        /// <param name="turnOrder"></param>
        private void TakeTurns(List<Entity> turnOrder)
        {
            // Process events on GUI
            HoldUp();
            
            // Reset currentTurn variable if it exceeds number of elements in list of turns
            if (currentTurn >= turns.Count || currentTurn < 0)
            {
                currentTurn = 0;
            }

            // Take down defense
            turns[currentTurn].IsDefending = false;

            // If hero has the current turn, show all the action buttons for user to select from
            if (turnOrder[currentTurn] is Hero && turnOrder[currentTurn].Health > 0)
            {
                // If hero has enough skill points, show special button
                if (turnOrder[currentTurn].SkillPoints > 10)
                {
                    specialButton.Show();
                }

                // Show other buttons
                defendButton.Show();
                attackButton.Show();

                // Update label to say which hero's turn it is
                UpdateLabel(turnOrder[currentTurn]);
            }
            else if (turnOrder[currentTurn].Health > 0) // If enemy has the current turn
            {
                EnemyTurn(turnOrder[currentTurn]);
            }
            else // If the entity with the current turn is dead, proceed to next entity and recall this method
            {
                currentTurn++;
                TakeTurns(turnOrder);
            }
        }


        /// <summary>
        /// Update label saying whose turn it is
        /// </summary>
        /// <param name="person"></param>
        private void UpdateLabel(Entity person)
        {
            // Update label saying whose turn it is
            if (person is Warrior)
            {
                statusLabel.Text = "Warrior's Turn: Pick an Action";
                warrior.BackColor = Color.Yellow;
            } else if (person is Mage)
            {
                statusLabel.Text = "Mage's Turn: Pick an Action";
                mage.BackColor = Color.Yellow;
            } else
            {
                statusLabel.Text = "Cleric's Turn: Pick an Action";
                cleric.BackColor = Color.Yellow;
            }
            person.IsDefending = false; // For every round of turns, the hero stops defending if they already are
        }

        /// <summary>
        /// EventHandler for if a person clicks on the attack button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttackButton_Click(object ?sender, EventArgs e)
        {
            // Hide action buttons
            specialButton.Hide();
            defendButton.Hide();
            attackButton.Hide();
            
            // Prompt user for an enemy target
            statusLabel.Text = "Click on a Target";

            // User will select a target by clicking on a picture box
            for (int i = 0; i < 3; i++)
            {
                enemyPBs[i].Click += SelectEnemy;
            }
        }

        /// <summary>
        /// EventHandler for if a user clicks on the defend button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefendButton_Click(object ?sender, EventArgs e)
        {
            // Hide action buttons
            specialButton.Hide();
            defendButton.Hide();
            attackButton.Hide();

            // Display message saying which hero on defense
            if (turns[currentTurn] is Warrior)
            {
                statusLabel.Text = "Warrior is Defending";
                warrior.BackColor = Color.Aqua;
                heroes[0].IsDefending = true;
                HoldUp();
                RefreshGUI();
            }
            else if (turns[currentTurn] is Mage)
            {
                statusLabel.Text = "Mage is Defending";
                mage.BackColor = Color.Aqua;
                heroes[1].IsDefending = true;
                HoldUp();
                RefreshGUI();
            }
            else
            {
                statusLabel.Text = "Cleric is Defending";
                cleric.BackColor = Color.Aqua;
                heroes[2].IsDefending = true;
                HoldUp();
                RefreshGUI();
            }
        }

        /// <summary>
        /// EventHandler for if the user clicks on the special button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpecialButton_Click(object ?sender, EventArgs e)
        {
            // Hide action buttons
            specialButton.Hide();
            defendButton.Hide();
            attackButton.Hide();

            // Decrease a hero's skill points by 25 plus their intelligence
            turns[currentTurn].SkillPoints -= 25 + turns[currentTurn].Intelligence;

            // Display message corresponding to a hero's special attack
            // and decrement the enemies' health by hero's hit points.
            // Afterward, update hero's skill points.
            if (turns[currentTurn] is Warrior)
            {
                // Perform warrior's special attack
                statusLabel.Text = turns[currentTurn].PowerMove;
                for (int i = 0; i < enemies.Count; i++)
                {
                    enemyPBs[i].BackColor = Color.Red;
                    enemies[i].Health -= turns[currentTurn].HitPoints;
                }

                // Update warrior's skill points
                if (turns[currentTurn].SkillPoints < 0)
                {
                    turns[currentTurn].SkillPoints = 0;
                }
                warriorSkillLabel.Text = "Skill Points: " + (turns[currentTurn].SkillPoints);
            }
            else if (turns[currentTurn] is Mage)
            {
                // Perform mage's special attack
                statusLabel.Text = turns[currentTurn].PowerMove;
                for (int i = 0; i < enemies.Count; i++)
                {
                    enemyPBs[i].BackColor = Color.Red;
                    enemies[i].Health -= turns[currentTurn].HitPoints;
                }

                // Update mage's skill points
                if (turns[currentTurn].SkillPoints < 0)
                {
                    turns[currentTurn].SkillPoints = 0;
                }
                mageSkillLabel.Text = "Skill Points: " + (turns[currentTurn].SkillPoints);
            }
            else
            {
                // Perform cleric's special attack
                statusLabel.Text = turns[currentTurn].PowerMove;
                for (int i = 0; i < heroes.Count; i++)
                {
                    heroPBs[i].BackColor = Color.HotPink;
                }

                // Raise everyone's health
                double healthRaised = turns[currentTurn].Intelligence * (turns[currentTurn].Strength * 2.5);
                for (int i = 0; i < 3; i++)
                {
                    if (heroes[i].Health > 0)
                        heroes[i].Health += healthRaised;
                }
                warriorHealthLabel.Text = "HP Points: " + heroes[0].Health;
                mageHealthLabel.Text = "HP Points: " + heroes[1].Health;
                clericHealthLabel.Text = "HP Points: " + heroes[2].Health;

                // Update cleric's skill points
                if (turns[currentTurn].SkillPoints < 0)
                {
                    turns[currentTurn].SkillPoints = 0;
                }
                clericSkillLabel.Text = "Skill Points: " + (turns[currentTurn].SkillPoints);
            }

            // Refresh GUI
            HoldUp();
            RefreshGUI();
        }

        /// <summary>
        /// EventHandler after user clicks on an enemy to attack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEnemy(object ?sender, EventArgs e)
        {
            // Convert object sender to a picture box
            PictureBox picture = sender as PictureBox;
            picture.BackColor = Color.Red;
            
            // Decrement selected enemy's health by hero's hit points
            for (int i = 0; i < enemies.Count; i++)
            {
                if (picture.Image == enemies[i].MySprite)
                {
                    statusLabel.Text = turns[currentTurn].Attack + enemies[i].Name;
                    HoldUp();
                    enemies[i].Health -= turns[currentTurn].HitPoints;
                    if (enemies[i] is Ogre)
                    {
                        // Weak to magic, so magic attacks do more damage
                        enemies[i].Health -= turns[currentTurn].Intelligence * 4;
                    }
                    else if (enemies[i] is Dragon)
                    {
                        // Strong against both physical and magic attacks,
                        // so dragon does not take that much damage from those
                        enemies[i].Health += (turns[currentTurn].Intelligence * 3 + turns[currentTurn].Strength * 3);
                    } else
                    {
                        // Bandit is weak to both physical and magic damage,
                        // so they take more damage from those
                        enemies[i].Health -= (turns[currentTurn].Intelligence * 3 + turns[currentTurn].Strength * 3);
                    }

                    // If enemy is defending, take that into account for health
                    if (enemies[i].IsDefending)
                    {
                        enemies[i].Health += enemies[i].Defense * 2.5;
                        enemies[i].IsDefending = false;
                    }

                    break;
                }
            }

            // Unsubscribe event handler from all enemy picture boxes
            for (int i = 0; i < 3; i++)
            {
                enemyPBs[i].Click -= SelectEnemy;
            }

            // Refresh GUI
            Application.DoEvents();
            RefreshGUI();
        }

        /// <summary>
        /// When it is currently an enemy's turn
        /// </summary>
        /// <param name="enemy"></param>
        private void EnemyTurn(Entity enemy)
        {
            // Randomize the enemy's action
            int action = random.Next(3);

            // Highlight enemy picture box
            PictureBox enemyPicture = enemyPBs[0];
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemy.MySprite == enemyPBs[i].Image)
                {
                    enemyPicture = enemyPBs[i];
                    break;
                }
            }
            enemyPicture.BackColor = Color.Yellow;
            enemy.IsDefending = false;

            // Find random hero target if enemy chooses to attack
            bool targetFound = false;
            int randomTarget = 0;
            while (!targetFound)
            {
                randomTarget = random.Next(3);

                if (enemy.SkillPoints < 25)
                {
                    randomTarget = random.Next(2);
                }

                if (heroes[randomTarget].Health > 0)
                {
                    targetFound = true;
                }
            }

            // Display message showing whose turn it is
            statusLabel.Text = enemy.Name + "'s Turn ";
            HoldUp();

            // Execute enemy's chosen action
            switch (action)
            {
                case 0: // If enemy chooses to attack
                    statusLabel.Text = enemy.Attack + heroes[randomTarget].Name;
                    heroPBs[randomTarget].BackColor = Color.Red;

                    // Decrement hero's health by enemy's hit points
                    if (!heroes[randomTarget].IsDefending) // If hero is not defending, do not reduce damage
                    {
                        heroes[randomTarget].Health -= enemy.HitPoints;
                    } // If hero is defending, dreduce damage
                    else
                    {
                        if (heroes[randomTarget].Defense > enemy.HitPoints)
                        {
                            heroes[randomTarget].Health -= enemy.HitPoints - heroes[randomTarget].Defense;
                            heroes[randomTarget].IsDefending = false;
                        }
                    }

                    // Edit hero's health based on their natural defense
                    if (heroes[randomTarget] is Warrior)
                    {
                        // Warrior has high physical defense but is weak to magic
                        heroes[randomTarget].Health += turns[randomTarget].Strength * 1.5;
                        heroes[randomTarget].Health -= turns[randomTarget].Intelligence * 1.5;
                    } else if (heroes[randomTarget] is Mage)
                    {
                        // Mage has low physical defense but high magic defense
                        heroes[randomTarget].Health -= turns[randomTarget].Strength * 1.5;
                        heroes[randomTarget].Health += turns[randomTarget].Intelligence * 1.5;
                    } else
                    {
                        // Cleric has medium defense to both physical and magical attacks
                        heroes[randomTarget].Health += turns[randomTarget].Strength;
                        heroes[randomTarget].Health += turns[randomTarget].Intelligence;
                    }

                    // Update hero's health to 0 if it is negative
                    if (heroes[randomTarget].Health < 0)
                    {
                        heroes[randomTarget].Health = 0;
                    }

                    // Update HP Points label for corresponding hero
                    if (heroes[randomTarget] is Warrior && heroPBs[0].Visible)
                    {
                        warriorHealthLabel.Text = "HP Points: " + heroes[randomTarget].Health;
                    } else if (heroes[randomTarget] is Mage && heroPBs[1].Visible)
                    {
                        mageHealthLabel.Text = "HP Points: " + heroes[randomTarget].Health;
                    } else if (heroes[randomTarget] is Cleric && heroPBs[2].Visible)
                    {
                        clericHealthLabel.Text = "HP Points: " + heroes[randomTarget].Health;
                    }

                    break;
                case 1: // If enemy chooses to defend
                    // Display message saying enemy is defending
                    statusLabel.Text = enemy.Name + " Is Defending";

                    // Set IsDefending boolean to true
                    enemy.IsDefending = true;

                    // Highlight enemy picture box
                    enemyPicture.BackColor = Color.Aqua;
                    break;
                case 2: // If enemy chooses to do a special attack
                    // Display message showing corresponding enemy's special attack
                    statusLabel.Text = enemy.PowerMove;

                    // Update all heroes' health due to damage
                    for (int i = 0; i < heroes.Count; i++)
                    {
                        // Decrement hero's health by enemy's hit points
                        if (!heroes[i].IsDefending) // If hero is not defending, do not reduce damage
                        {
                            heroes[i].Health -= enemy.HitPoints;
                        } // If hero is defending, reduce damage
                        else
                        {
                            if (heroes[i].Defense > enemy.HitPoints)
                            {
                                heroes[i].Health -= enemy.HitPoints - heroes[i].Defense;
                                heroes[i].IsDefending = false;
                            }
                        }
                        heroPBs[i].BackColor = Color.Red;
                    }

                    // Edit heroes' health based on their natural defense
                    if (heroes[randomTarget] is Warrior)
                    {
                        // Warrior has high physical defense but is weak to magic
                        heroes[randomTarget].Health += turns[randomTarget].Strength * 1.5;
                        heroes[randomTarget].Health -= turns[randomTarget].Intelligence * 1.5;
                    }
                    else if (heroes[randomTarget] is Mage)
                    {
                        // Mage has low physical defense but high magic defense
                        heroes[randomTarget].Health -= turns[randomTarget].Strength * 1.5;
                        heroes[randomTarget].Health += turns[randomTarget].Intelligence * 1.5;
                    }
                    else
                    {
                        // Cleric has medium defense to both physical and magical attacks
                        heroes[randomTarget].Health += turns[randomTarget].Strength * 1;
                        heroes[randomTarget].Health += turns[randomTarget].Intelligence * 1;
                    }

                    // If hero is defending, take that into account for health
                    if (heroes[randomTarget].IsDefending)
                    {
                        heroes[randomTarget].Health += heroes[randomTarget].Defense * 2.5;
                        heroes[randomTarget].IsDefending = false;
                    }

                    // Update hero's health to 0 if it is negative
                    for (int i = 0; i < 3; i++)
                    {
                        if (heroes[i].Health < 0)
                        {
                            heroes[i].Health = 0;
                        }
                    }

                    // Update HP points label for all heroes
                    warriorHealthLabel.Text = "HP Points: " + heroes[0].Health;
                    mageHealthLabel.Text = "HP Points: " + heroes[1].Health;
                    clericHealthLabel.Text = "HP Points: " + heroes[2].Health;

                    break;
            }

            // Refresh GUI
            HoldUp();
            RefreshGUI();
        }

        /// <summary>
        /// Check if an enemy is dead
        /// </summary>
        private void CheckEnemies()
        {
            // Find which enemy is dead
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Health <= 0 && enemyPBs[i].Visible)
                {
                    enemyPBs[i].Hide(); // Hide enemy picture box
                    statusLabel.Text = enemies[i].Name + " has been defeated."; // Display message saying who was defeated
                    UpdateScores(false, enemies[i]); // Update stats
                    HoldUp(); // Refesh GUI
                }
            }
        }

        /// <summary>
        /// Check if a hero is dead
        /// </summary>
        private void CheckHeroes()
        {
            // Find which hero is dead
            for (int i = 0; i < heroes.Count; i++)
            {
                if (heroes[i].Health <= 0 && heroPBs[i].Visible)
                {
                    heroPBs[i].Hide(); // Hide hero picture box
                    statusLabel.Text = heroes[i].Name + " has been defeated."; // Display message saying who was defeated
                    HoldUp(); // Refresh GUI
                }
            }
        }

        /// <summary>
        /// Refreshes GUI events and pause for a moment
        /// </summary>
        private void HoldUp()
        {
            Application.DoEvents();
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Helps circulate the turns
        /// </summary>
        private void RefreshGUI()
        {
            // Increment current turns variable
            currentTurn++;

            // Reset all picture boxes' backcolors
            for (int i = 0; i < heroes.Count; i++)
            {
                if (enemyPBs[i].BackColor != Color.Aqua)
                {
                    enemyPBs[i].BackColor = Color.Transparent;
                }

                if (heroPBs[i].BackColor != Color.Aqua)
                {
                    heroPBs[i].BackColor = Color.Transparent;
                }
            }

            // Check if any enemies or heroes are dead
            CheckEnemies();
            CheckHeroes();

            // Check if all heroes are dead
            int count = 0; // Number of heroes dead
            for (int i = 0; i < heroes.Count; i++)
            {
                if (!heroPBs[i].Visible)
                {
                    count++;
                }
            }

            // Check if all enemies are daed
            int count2 = 0; // Number of enemies dead
            for (int i = 0; i < heroes.Count; i++)
            {
                if (!enemyPBs[i].Visible)
                {
                    count2++;
                }
            }

            // Initiate GameOver if all heroes are dead
            if (count == 3)
            {
                GameOver();
                playAgainButton.Show();
                LoseGame();
            } else if (count2 == 3) // Initiate next round if all enemies are dead
            {
                RoundWon();
            } else // Else continue the game
            {
                TakeTurns(turns);
            }
        }

        /// <summary>
        /// Display message saying user lost the game
        /// </summary>
        private void GameOver()
        {
            statusLabel.Text = "GAME OVER";
        }

        /// <summary>
        /// Display message saying user won a round
        /// </summary>
        private void RoundWon()
        {
            statusLabel.Text = "Round won!";
            UpdateScores(true, null);
            StartNewRound();
        }

        /// <summary>
        /// Update scores
        /// </summary>
        /// <param name="finishedRound"></param>
        /// <param name="isAnyoneDead"></param>
        private void UpdateScores(bool finishedRound, Enemy? isAnyoneDead)
        {
            UpdateScoreEventArgs e = new UpdateScoreEventArgs(finishedRound, isAnyoneDead);
            ScoreUpdate(this, e);
        }

        /// <summary>
        /// Calculate scores in GameLogic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ScoreUpdate(object? sender, UpdateScoreEventArgs e)
        {
            ScoreUpdater?.Invoke(sender, e);   
        }

        /// <summary>
        /// Initialize an EventArgs to start a new round
        /// </summary>
        private void StartNewRound()
        {
            NewRoundEventArgs e = new NewRoundEventArgs();
            RoundUpdate(this, e);
        }

        /// <summary>
        /// Jump to GameLogic to start a new round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void RoundUpdate(object? sender, NewRoundEventArgs e)
        {
            RoundUpdater?.Invoke(sender, e);
        }

        /// <summary>
        /// Evnet handler for if a game is won
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GameWon(object? sender, GameWonEventArgs e)
        {
            statusLabel.Text = e.WinMessage; // Let user know they won the game
            playAgainButton.Show(); // Prompt user if they want to play again
        }

        /// <summary>
        /// Initializes an EventArgs if a game is lost
        /// </summary>
        private void LoseGame()
        {
            GameOverEventArgs e = new GameOverEventArgs();
            EndTheGame(this, e);
        }

        /// <summary>
        /// Jumps to GameLogic to end a game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void EndTheGame(object? sender, GameOverEventArgs e)
        {
            GameOverUpdater?.Invoke(sender, e);
        }

        /// <summary>
        /// Prepares a new game by initializing EventArgs
        /// </summary>
        private void StartNewGame()
        {
            StartNewGameEventArgs e = new StartNewGameEventArgs();
            StartTheGame(this, e);
        }

        /// <summary>
        /// Jumps to GameLogic to start another game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void StartTheGame(object? sender, StartNewGameEventArgs e)
        {
            StartNewGameUpdater?.Invoke(sender, e);
        }

        /// <summary>
        /// Event handler for if the user clicks on the "Play Again" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            playAgainButton.Hide();
            StartNewGame();
        }

        /// <summary>
        /// Event handler for if the user clicks on the instructions button on menu strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (instructions.Visible || charGuide.Visible)
            {
                instructions.Hide(); // Hide instructions
                charGuide.Hide(); // Hide character guide
            }
            
            instructions.Show(); // Show instructions
        }

        /// <summary>
        /// Event handler for if the user clicks on the character guide button on menu strip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (instructions.Visible || charGuide.Visible)
            {
                instructions.Hide(); // Hide instructions
                charGuide.Hide(); // Hide character guide
            }
            
            charGuide.Show(); // Show character guide
        }
    }
}