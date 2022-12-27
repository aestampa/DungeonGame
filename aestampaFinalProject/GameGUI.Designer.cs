namespace aestampaFinalProject
{
    partial class GameGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameGUI));
            this.ogre = new System.Windows.Forms.PictureBox();
            this.battleLogo = new System.Windows.Forms.Label();
            this.actionsBox = new System.Windows.Forms.GroupBox();
            this.specialButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.warriorLabel = new System.Windows.Forms.Label();
            this.mageLabel = new System.Windows.Forms.Label();
            this.clericLabel = new System.Windows.Forms.Label();
            this.warriorHealthLabel = new System.Windows.Forms.Label();
            this.mageHealthLabel = new System.Windows.Forms.Label();
            this.clericHealthLabel = new System.Windows.Forms.Label();
            this.warriorSkillLabel = new System.Windows.Forms.Label();
            this.mageSkillLabel = new System.Windows.Forms.Label();
            this.clericSkillLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAbbyEstampadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cS3020001ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.may92022ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spritesAndGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatByChristopherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winLossRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winLossRatio = new System.Windows.Forms.ToolStripMenuItem();
            this.currentScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentScoreLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.roundsWonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundsWonLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleric = new System.Windows.Forms.PictureBox();
            this.warrior = new System.Windows.Forms.PictureBox();
            this.mage = new System.Windows.Forms.PictureBox();
            this.dragon = new System.Windows.Forms.PictureBox();
            this.bandit1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.RichTextBox();
            this.charGuide = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ogre)).BeginInit();
            this.actionsBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cleric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ogre
            // 
            this.ogre.BackColor = System.Drawing.Color.Transparent;
            this.ogre.Location = new System.Drawing.Point(628, 374);
            this.ogre.Name = "ogre";
            this.ogre.Size = new System.Drawing.Size(64, 64);
            this.ogre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ogre.TabIndex = 0;
            this.ogre.TabStop = false;
            // 
            // battleLogo
            // 
            this.battleLogo.AutoSize = true;
            this.battleLogo.BackColor = System.Drawing.Color.Transparent;
            this.battleLogo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.battleLogo.ForeColor = System.Drawing.Color.White;
            this.battleLogo.Location = new System.Drawing.Point(615, 49);
            this.battleLogo.Name = "battleLogo";
            this.battleLogo.Size = new System.Drawing.Size(75, 18);
            this.battleLogo.TabIndex = 2;
            this.battleLogo.Text = "Battle Logo";
            // 
            // actionsBox
            // 
            this.actionsBox.BackColor = System.Drawing.Color.Transparent;
            this.actionsBox.Controls.Add(this.specialButton);
            this.actionsBox.Controls.Add(this.defendButton);
            this.actionsBox.Controls.Add(this.attackButton);
            this.actionsBox.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.actionsBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionsBox.Location = new System.Drawing.Point(22, 37);
            this.actionsBox.Name = "actionsBox";
            this.actionsBox.Size = new System.Drawing.Size(197, 129);
            this.actionsBox.TabIndex = 3;
            this.actionsBox.TabStop = false;
            this.actionsBox.Text = "Actions";
            // 
            // specialButton
            // 
            this.specialButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.specialButton.Location = new System.Drawing.Point(59, 95);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(75, 23);
            this.specialButton.TabIndex = 2;
            this.specialButton.Text = "Special";
            this.specialButton.UseVisualStyleBackColor = false;
            this.specialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // defendButton
            // 
            this.defendButton.BackColor = System.Drawing.Color.ForestGreen;
            this.defendButton.Location = new System.Drawing.Point(59, 61);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(75, 23);
            this.defendButton.TabIndex = 1;
            this.defendButton.Text = "Defend";
            this.defendButton.UseVisualStyleBackColor = false;
            this.defendButton.Click += new System.EventHandler(this.DefendButton_Click);
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.OrangeRed;
            this.attackButton.Location = new System.Drawing.Point(59, 26);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 0;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // warriorLabel
            // 
            this.warriorLabel.AutoSize = true;
            this.warriorLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.warriorLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warriorLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warriorLabel.Location = new System.Drawing.Point(306, 49);
            this.warriorLabel.Name = "warriorLabel";
            this.warriorLabel.Size = new System.Drawing.Size(54, 18);
            this.warriorLabel.TabIndex = 4;
            this.warriorLabel.Text = "Warrior";
            // 
            // mageLabel
            // 
            this.mageLabel.AutoSize = true;
            this.mageLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.mageLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mageLabel.Location = new System.Drawing.Point(306, 95);
            this.mageLabel.Name = "mageLabel";
            this.mageLabel.Size = new System.Drawing.Size(42, 18);
            this.mageLabel.TabIndex = 5;
            this.mageLabel.Text = "Mage";
            // 
            // clericLabel
            // 
            this.clericLabel.AutoSize = true;
            this.clericLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.clericLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clericLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clericLabel.Location = new System.Drawing.Point(306, 144);
            this.clericLabel.Name = "clericLabel";
            this.clericLabel.Size = new System.Drawing.Size(43, 18);
            this.clericLabel.TabIndex = 6;
            this.clericLabel.Text = "Cleric";
            // 
            // warriorHealthLabel
            // 
            this.warriorHealthLabel.AutoSize = true;
            this.warriorHealthLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.warriorHealthLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warriorHealthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warriorHealthLabel.Location = new System.Drawing.Point(367, 49);
            this.warriorHealthLabel.Name = "warriorHealthLabel";
            this.warriorHealthLabel.Size = new System.Drawing.Size(111, 18);
            this.warriorHealthLabel.TabIndex = 7;
            this.warriorHealthLabel.Text = "HP Points: 100.00";
            // 
            // mageHealthLabel
            // 
            this.mageHealthLabel.AutoSize = true;
            this.mageHealthLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.mageHealthLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mageHealthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mageHealthLabel.Location = new System.Drawing.Point(367, 95);
            this.mageHealthLabel.Name = "mageHealthLabel";
            this.mageHealthLabel.Size = new System.Drawing.Size(111, 18);
            this.mageHealthLabel.TabIndex = 8;
            this.mageHealthLabel.Text = "HP Points: 100.00";
            // 
            // clericHealthLabel
            // 
            this.clericHealthLabel.AutoSize = true;
            this.clericHealthLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.clericHealthLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clericHealthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clericHealthLabel.Location = new System.Drawing.Point(367, 144);
            this.clericHealthLabel.Name = "clericHealthLabel";
            this.clericHealthLabel.Size = new System.Drawing.Size(111, 18);
            this.clericHealthLabel.TabIndex = 9;
            this.clericHealthLabel.Text = "HP Points: 100.00";
            // 
            // warriorSkillLabel
            // 
            this.warriorSkillLabel.AutoSize = true;
            this.warriorSkillLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.warriorSkillLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warriorSkillLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warriorSkillLabel.Location = new System.Drawing.Point(367, 64);
            this.warriorSkillLabel.Name = "warriorSkillLabel";
            this.warriorSkillLabel.Size = new System.Drawing.Size(120, 18);
            this.warriorSkillLabel.TabIndex = 10;
            this.warriorSkillLabel.Text = "Skill Points: 100.00";
            // 
            // mageSkillLabel
            // 
            this.mageSkillLabel.AutoSize = true;
            this.mageSkillLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.mageSkillLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mageSkillLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mageSkillLabel.Location = new System.Drawing.Point(367, 111);
            this.mageSkillLabel.Name = "mageSkillLabel";
            this.mageSkillLabel.Size = new System.Drawing.Size(120, 18);
            this.mageSkillLabel.TabIndex = 11;
            this.mageSkillLabel.Text = "Skill Points: 100.00";
            // 
            // clericSkillLabel
            // 
            this.clericSkillLabel.AutoSize = true;
            this.clericSkillLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.clericSkillLabel.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clericSkillLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clericSkillLabel.Location = new System.Drawing.Point(367, 159);
            this.clericSkillLabel.Name = "clericSkillLabel";
            this.clericSkillLabel.Size = new System.Drawing.Size(120, 18);
            this.clericSkillLabel.TabIndex = 12;
            this.clericSkillLabel.Text = "Skill Points: 100.00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byAbbyEstampadorToolStripMenuItem,
            this.cS3020001ToolStripMenuItem,
            this.may92022ToolStripMenuItem,
            this.spritesAndGameToolStripMenuItem,
            this.formatByChristopherToolStripMenuItem,
            this.malecToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // byAbbyEstampadorToolStripMenuItem
            // 
            this.byAbbyEstampadorToolStripMenuItem.Name = "byAbbyEstampadorToolStripMenuItem";
            this.byAbbyEstampadorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.byAbbyEstampadorToolStripMenuItem.Text = "By Abby Estampador";
            // 
            // cS3020001ToolStripMenuItem
            // 
            this.cS3020001ToolStripMenuItem.Name = "cS3020001ToolStripMenuItem";
            this.cS3020001ToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.cS3020001ToolStripMenuItem.Text = "CS 3020 001";
            // 
            // may92022ToolStripMenuItem
            // 
            this.may92022ToolStripMenuItem.Name = "may92022ToolStripMenuItem";
            this.may92022ToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.may92022ToolStripMenuItem.Text = "May 9, 2022";
            // 
            // spritesAndGameToolStripMenuItem
            // 
            this.spritesAndGameToolStripMenuItem.Name = "spritesAndGameToolStripMenuItem";
            this.spritesAndGameToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.spritesAndGameToolStripMenuItem.Text = "Sprites and Game";
            // 
            // formatByChristopherToolStripMenuItem
            // 
            this.formatByChristopherToolStripMenuItem.Name = "formatByChristopherToolStripMenuItem";
            this.formatByChristopherToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.formatByChristopherToolStripMenuItem.Text = "Format by Christopher";
            // 
            // malecToolStripMenuItem
            // 
            this.malecToolStripMenuItem.Name = "malecToolStripMenuItem";
            this.malecToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.malecToolStripMenuItem.Text = "Malec";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winLossRatioToolStripMenuItem,
            this.currentScoreToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.roundsWonToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // winLossRatioToolStripMenuItem
            // 
            this.winLossRatioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.winLossRatio});
            this.winLossRatioToolStripMenuItem.Name = "winLossRatioToolStripMenuItem";
            this.winLossRatioToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.winLossRatioToolStripMenuItem.Text = "Win:Loss Ratio";
            // 
            // winLossRatio
            // 
            this.winLossRatio.Name = "winLossRatio";
            this.winLossRatio.Size = new System.Drawing.Size(98, 24);
            this.winLossRatio.Text = "0:0";
            // 
            // currentScoreToolStripMenuItem
            // 
            this.currentScoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentScoreLabel});
            this.currentScoreToolStripMenuItem.Name = "currentScoreToolStripMenuItem";
            this.currentScoreToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.currentScoreToolStripMenuItem.Text = "Current Score";
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(86, 24);
            this.currentScoreLabel.Text = "0";
            // 
            // highScoreToolStripMenuItem
            // 
            this.highScoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoreLabel});
            this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.highScoreToolStripMenuItem.Text = "High Score";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(86, 24);
            this.highScoreLabel.Text = "0";
            // 
            // roundsWonToolStripMenuItem
            // 
            this.roundsWonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roundsWonLabel});
            this.roundsWonToolStripMenuItem.Name = "roundsWonToolStripMenuItem";
            this.roundsWonToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.roundsWonToolStripMenuItem.Text = "# Rounds Won";
            // 
            // roundsWonLabel
            // 
            this.roundsWonLabel.Name = "roundsWonLabel";
            this.roundsWonLabel.Size = new System.Drawing.Size(86, 24);
            this.roundsWonLabel.Text = "0";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.characterGuideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.InstructionsToolStripMenuItem_Click);
            // 
            // characterGuideToolStripMenuItem
            // 
            this.characterGuideToolStripMenuItem.Name = "characterGuideToolStripMenuItem";
            this.characterGuideToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.characterGuideToolStripMenuItem.Text = "Character Guide";
            this.characterGuideToolStripMenuItem.Click += new System.EventHandler(this.CharacterGuideToolStripMenuItem_Click);
            // 
            // cleric
            // 
            this.cleric.BackColor = System.Drawing.Color.Transparent;
            this.cleric.Location = new System.Drawing.Point(34, 273);
            this.cleric.Name = "cleric";
            this.cleric.Size = new System.Drawing.Size(64, 64);
            this.cleric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cleric.TabIndex = 14;
            this.cleric.TabStop = false;
            // 
            // warrior
            // 
            this.warrior.BackColor = System.Drawing.Color.Transparent;
            this.warrior.Image = global::aestampaFinalProject.Properties.Resources.Fighter;
            this.warrior.Location = new System.Drawing.Point(126, 318);
            this.warrior.Name = "warrior";
            this.warrior.Size = new System.Drawing.Size(64, 64);
            this.warrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.warrior.TabIndex = 15;
            this.warrior.TabStop = false;
            // 
            // mage
            // 
            this.mage.BackColor = System.Drawing.Color.Transparent;
            this.mage.Image = ((System.Drawing.Image)(resources.GetObject("mage.Image")));
            this.mage.Location = new System.Drawing.Point(34, 374);
            this.mage.Name = "mage";
            this.mage.Size = new System.Drawing.Size(64, 64);
            this.mage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mage.TabIndex = 16;
            this.mage.TabStop = false;
            // 
            // dragon
            // 
            this.dragon.BackColor = System.Drawing.Color.Transparent;
            this.dragon.Location = new System.Drawing.Point(626, 273);
            this.dragon.Name = "dragon";
            this.dragon.Size = new System.Drawing.Size(64, 64);
            this.dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dragon.TabIndex = 17;
            this.dragon.TabStop = false;
            // 
            // bandit1
            // 
            this.bandit1.BackColor = System.Drawing.Color.Transparent;
            this.bandit1.Location = new System.Drawing.Point(556, 318);
            this.bandit1.Name = "bandit1";
            this.bandit1.Size = new System.Drawing.Size(64, 64);
            this.bandit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bandit1.TabIndex = 18;
            this.bandit1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.Coral;
            this.statusLabel.Location = new System.Drawing.Point(341, 247);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 21);
            this.statusLabel.TabIndex = 22;
            this.statusLabel.Text = "label1";
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.playAgainButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playAgainButton.Location = new System.Drawing.Point(341, 327);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(105, 37);
            this.playAgainButton.TabIndex = 23;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructions.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.instructions.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.instructions.Location = new System.Drawing.Point(519, 27);
            this.instructions.Name = "instructions";
            this.instructions.ReadOnly = true;
            this.instructions.Size = new System.Drawing.Size(281, 210);
            this.instructions.TabIndex = 24;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // charGuide
            // 
            this.charGuide.BackColor = System.Drawing.SystemColors.MenuText;
            this.charGuide.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.charGuide.ForeColor = System.Drawing.SystemColors.Window;
            this.charGuide.Location = new System.Drawing.Point(519, 27);
            this.charGuide.Name = "charGuide";
            this.charGuide.ReadOnly = true;
            this.charGuide.Size = new System.Drawing.Size(269, 210);
            this.charGuide.TabIndex = 25;
            this.charGuide.Text = resources.GetString("charGuide.Text");
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.charGuide);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bandit1);
            this.Controls.Add(this.dragon);
            this.Controls.Add(this.mage);
            this.Controls.Add(this.warrior);
            this.Controls.Add(this.cleric);
            this.Controls.Add(this.clericSkillLabel);
            this.Controls.Add(this.mageSkillLabel);
            this.Controls.Add(this.warriorSkillLabel);
            this.Controls.Add(this.clericHealthLabel);
            this.Controls.Add(this.mageHealthLabel);
            this.Controls.Add(this.warriorHealthLabel);
            this.Controls.Add(this.clericLabel);
            this.Controls.Add(this.mageLabel);
            this.Controls.Add(this.warriorLabel);
            this.Controls.Add(this.actionsBox);
            this.Controls.Add(this.battleLogo);
            this.Controls.Add(this.ogre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameGUI";
            this.Text = "The Struggles Along the Oregon Trail";
            ((System.ComponentModel.ISupportInitialize)(this.ogre)).EndInit();
            this.actionsBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cleric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ogre;
        private Label battleLogo;
        private GroupBox actionsBox;
        private Button specialButton;
        private Button defendButton;
        private Button attackButton;
        private Label warriorLabel;
        private Label mageLabel;
        private Label clericLabel;
        private Label warriorHealthLabel;
        private Label mageHealthLabel;
        private Label clericHealthLabel;
        private Label warriorSkillLabel;
        private Label mageSkillLabel;
        private Label clericSkillLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private PictureBox cleric;
        private PictureBox warrior;
        private PictureBox mage;
        private PictureBox dragon;
        private PictureBox bandit1;
        private PictureBox pictureBox1;
        private Label statusLabel;
        private Button playAgainButton;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem winLossRatioToolStripMenuItem;
        private ToolStripMenuItem winLossRatio;
        private RichTextBox instructions;
        private ToolStripMenuItem instructionsToolStripMenuItem;
        private ToolStripMenuItem byAbbyEstampadorToolStripMenuItem;
        private ToolStripMenuItem cS3020001ToolStripMenuItem;
        private ToolStripMenuItem may92022ToolStripMenuItem;
        private ToolStripMenuItem characterGuideToolStripMenuItem;
        private ToolStripMenuItem currentScoreToolStripMenuItem;
        private ToolStripMenuItem highScoreToolStripMenuItem;
        private ToolStripMenuItem roundsWonToolStripMenuItem;
        private ToolStripMenuItem currentScoreLabel;
        private ToolStripMenuItem highScoreLabel;
        private ToolStripMenuItem roundsWonLabel;
        private ToolStripMenuItem spritesAndGameToolStripMenuItem;
        private ToolStripMenuItem formatByChristopherToolStripMenuItem;
        private ToolStripMenuItem malecToolStripMenuItem;
        private RichTextBox charGuide;
    }
}