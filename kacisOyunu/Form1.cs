//BACORO DIT ELHADJI LANSAR
//B211200567

using kacisOyunu.Enum;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace kacisOyunu
{
 
    public partial class Form1 : Form
    {

        private Timer enemySpawnTimer;
        private Timer enemyMoveTimer;
        private List<PictureBox> enemyList;
        private Timer bombVisibilityTimer;
        private List<PictureBox> bombList;
        private List<Tuzaklar> tuzaklarList;
        private bool isPaused = false;
        public Timer timer;
        public int elapsedTimeInSeconds = 0;
        private PictureBox kosanAdam;
        private int score = 0;
        private int totalScore = 0;
        private string highscoreFilePath = "highscore.txt";



        // Déclarez une liste pour stocker les PictureBox des ennemis





        private int kalanCan;

        public Form1(string playerName)
        {

            InitializeComponent();
            InitializeTuzaklar();
           // InitializeInitialTuzaklar();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            // Initialisez kalanCan avec la valeur de départ (par exemple, 3 vies)
            kalanCan = 3;

            // Mettez à jour l'interface utilisateur avec le nombre initial de vies
            KalanCan.Text = kalanCan.ToString();

        

            OyuncuAdi.Text = playerName;

            int panelWidth = TasBloklar.Width;
            int panelHeight = TasBloklar.Height;

      

            kosanAdam = new PictureBox
            {
                Image = Image.FromFile(@"Images\kosanAdam1.png"),
                Location = new Point(TasBloklar.Location.X-60, TasBloklar.Location.Y+60),
                Size = new Size(60, 60),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
            };
            Controls.Add(kosanAdam);
          

            KeyDown += Form1_KeyDown;
            this.Activate();
            this.KeyPreview = true;
            kosanAdam.BringToFront();
           
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTimeInSeconds++;
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTimeInSeconds);
            string formattedTime = timeSpan.ToString("mm':'ss");
            GecenSure.Text = formattedTime;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (kosanAdam.Location.X == 1100)
            {
                return;
            }

                if (e.KeyCode == Keys.P)
            {
                TogglePause(); // Toggle the pause state when 'P' key is pressed
                return;
            }

            if (isPaused)
            {
                // If the game is paused, do not handle other key events
                return;
            }

            int step = 60;

            int newLeft = kosanAdam.Left;
            int newTop = kosanAdam.Top;

            Direction direction = DirectionExtensions.GetDirectionFromKey(e.KeyCode);

            switch (direction)
            {
                case Direction.Up:
                    if (kosanAdam.Location.Y == 300)
                    {
                        return;
                    }
                    newTop -= step;
                    break;

                case Direction.Left:
                    if (kosanAdam.Location.X == 440)
                    {
                        return;
                    }
                    newLeft -= step;
                    break;

                case Direction.Down:
                    if (kosanAdam.Location.Y == 420)
                    {
                        return;
                    }
                    newTop += step;
                    break;

                case Direction.Right:
                    newLeft += step;
                    break;
            }

            // Update the position of kosanAdam
            kosanAdam.Left = newLeft;
            kosanAdam.Top = newTop;

            CheckTuzaklarCollision();
            if (LevelBtn.Text=="1" && kosanAdam.Location.X == 1100)
            {
                MessageBox.Show("BIRINCI SEVIYEYI TAMAMLADINIZ", "TEBRIKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Level2Page();

            }
            if (kalanCan == 0)
            {
                // Si le joueur n'a plus de vies, le jeu est terminé
                // Affichez le MessageBox et redémarrez le jeu lorsque OK est cliqué
                CheckGameOver();
            }
            if (LevelBtn.Text == "2" && kosanAdam.Location.X == 1100)
            {
                MessageBox.Show("IKINCI SEVIYEYI TAMAMLADINIZ", "TEBRIKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can add any additional actions or logic here
                Level3Page();
            }
            if (LevelBtn.Text == "3" && kosanAdam.Location.X == 1100)
            {
                MessageBox.Show("Game finish", "TEBRIKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can add any additional actions or logic here
                EndGame();

            }

        }
        private void TogglePause()
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                timer.Stop(); // Pause the timer
                              // You can add additional pause-related actions here

                // Display a message when the game is paused
                MessageBox.Show("Game Paused", "Paused", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                timer.Start(); // Resume the timer
                               // You can add additional resume-related actions here
            }
        }


        private void InitializeTuzaklar()
        {
            tuzaklarList = new List<Tuzaklar>();
            Random random = new Random();

            int colCount = 10;
            int rowCount = 3;


            string[] imagePaths = new string[]
            {
        @"Images\trap1.png",
        @"Images\tuzak2.png",
        @"Images\trap2.png"
            };
            for (int i = 0; i < 10; i++)
            {
                int x, y;

                do
                {
                    x = random.Next(colCount) * (TasBloklar.Width / colCount);
                    y = random.Next(rowCount) * (TasBloklar.Height / rowCount);
                } while (IsCollision(x, y));

                string imagePath = imagePaths[random.Next(imagePaths.Length)];
                Tuzaklar tuzaklar = new Tuzaklar(x, y, imagePath);
                tuzaklarList.Add(tuzaklar);
                TasBloklar.Controls.Add(tuzaklar);
            }
        }

        private bool IsCollision(int x, int y)
        {
            foreach (var tuzaklar in tuzaklarList)
            {
                int distanceX = Math.Abs(x - tuzaklar.Location.X);
                int distanceY = Math.Abs(y - tuzaklar.Location.Y);

                if (distanceX < 60 && distanceY < 60)
                {
                    return true; // Collision détectée
                }
            }

            return false; // Pas de collision
        }
    



    private void TasBloklar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CheckTuzaklarCollision()
        {
            Point kosanAdamLocation = new Point(kosanAdam.Location.X-500,kosanAdam.Location.Y-300);

            foreach (var tuzaklar in tuzaklarList)
            {
                Point tuzaklarLocation = tuzaklar.Location;

                if (kosanAdamLocation ==  tuzaklarLocation)
                {
                    // Collision détectée avec un tuzak, rendre la PictureBox visible
                    tuzaklar.Visible = true;
                    kalanCan--;
                    KalanCan.Text = kalanCan.ToString();
                    int collisionPenalty = 50; // Vous pouvez ajuster le nombre de points en conséquence
                    score -= collisionPenalty;

                    // Her çarpışmadan sonra oyunun bitip bitmediğini kontrol edin
                    CheckGameOver();

                }
            }
            if (LevelBtn.Text == "2")
            {
                // Check for collisions with bombs
                foreach (var bomb in bombList)
                {
                    Point bombLocation = bomb.Location;

                    if (kosanAdamLocation == bombLocation )
                    {
                        // Collision detected with a visible bomb, decrease kalanCan and check game over
                        kalanCan--;
                        KalanCan.Text = kalanCan.ToString();
                        int collisionPenalty = 50; // Vous pouvez ajuster le nombre de points en conséquence
                        score -= collisionPenalty;
                        CheckGameOver();
                    }
                }
            }
            if (LevelBtn.Text == "3")
            {
                // Check for collisions with bombs
                foreach (var enemy in enemyList)
                {
                    Point enemyLocation = enemy.Location;

                    if (kosanAdamLocation == enemyLocation)
                    {
                        // Collision detected with a visible bomb, decrease kalanCan and check game over
                        kalanCan--;
                        KalanCan.Text = kalanCan.ToString();
                        int collisionPenalty = 50; // Vous pouvez ajuster le nombre de points en conséquence
                        score -= collisionPenalty;
                        


                    }
                }
            }
        }
        private void CheckGameOver()
        {
            if (kalanCan <= 0)
            {
                // Le joueur a perdu, affichez un MessageBox
                MessageBox.Show("Game Over! Click OK to restart.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialisez le jeu
                RestartGame();
            }
        }
        private void RestartGame()
        {
            // Réinitialisez les valeurs nécessaires pour recommencer le jeu
            kalanCan = 3;
            KalanCan.Text = kalanCan.ToString();

            // Remplacez cette ligne par l'emplacement initial de votre personnage
            kosanAdam.Location = new Point(TasBloklar.Location.X - 60, TasBloklar.Location.Y + 60);

            // Cachez à nouveau les pièges et mettez à jour l'interface utilisateur
            foreach (var tuzaklar in tuzaklarList)
            {
                tuzaklar.Visible = false;
            }

            /*oreach()*/
            // Réinitialisez la position des pièges
            ResetTuzaklarPosition();    
        }


        private void ResetTuzaklarPosition()
        {
            Random random = new Random();

            foreach (var tuzaklar in tuzaklarList)
            {
                int x, y;

                do
                {
                    x = random.Next(10) * (TasBloklar.Width / 10);
                    y = random.Next(3) * (TasBloklar.Height / 3);
                } while (IsCollision(x, y));

                tuzaklar.Location = new Point(x, y);
               // Visible = false;
            }
        }
        //level2
        private void Level2Page()
        {

            // Réinitialisez les valeurs nécessaires pour recommencer le jeu
            kalanCan++;
            KalanCan.Text = kalanCan.ToString();
            // Calculez le score pour avoir complété le niveau 1
            // Calculez le score pour avoir complété le niveau 1
            int levelScore = kalanCan * 500 + (1000 - elapsedTimeInSeconds);

            // Ajoutez le score du niveau actuel au totalScore
            totalScore += levelScore;
            // Remplacez cette ligne par l'emplacement initial de votre personnage
            kosanAdam.Location = new Point(TasBloklar.Location.X - 60, TasBloklar.Location.Y + 60);
            // Affichez le MessageBox "Tebrikler" et attendez la réponse du joueur
    
            
           
            MessageBox.Show($"Level Score: {levelScore}", "Level Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Sauvegardez le highscore à la fin du niveau 2
            SaveHighscore(OyuncuAdi.Text, totalScore);
            // Initialize bomb-related components
            InitializeBombs();

            // Start the timer to toggle bomb visibility every 3 seconds
            bombVisibilityTimer = new Timer();
            bombVisibilityTimer.Interval = 3000; // 3 seconds
            bombVisibilityTimer.Tick += BombVisibilityTimer_Tick;
            bombVisibilityTimer.Start();

            // Supprimez les tuzaklar de la liste
            foreach (var tuzaklar in tuzaklarList)
            {
                // Supprimez la PictureBox du conteneur (TasBloklar)
                TasBloklar.Controls.Remove(tuzaklar);
            }

            // Videz la liste des tuzaklar
            tuzaklarList.Clear();

            // Si le joueur clique sur "OK", initialisez BombList

            // Mettez à jour le label LevelBtn
            // Cachez à nouveau les pièges et mettez à jour l'interface utilisateur

            LevelBtn.Text = "2";
            PuanLabel.Text = "$levelScore";




            // Refresh the form or the specific controls to reflect the updated LevelBtn text
            this.Refresh();

            // Update the UI with the new value of kalanCan (just to be safe)
            KalanCan.Text = kalanCan.ToString();


        }
        private void InitializeBombs()
        {
            bombList = new List<PictureBox>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int x, y;

                do
                {
                    x = random.Next(10) * (TasBloklar.Width / 10);
                    y = random.Next(3) * (TasBloklar.Height / 3);
                } while (IsCollisionBomb(x, y) || IsCollision(x, y)); // Check for collisions with existing bombs and traps


                PictureBox bomb = new PictureBox
                {
                    Image = Image.FromFile(@"Images\bombtrap.png"), // Replace with the actual path to your bomb image
                    Location = new Point(x, y),
                    Size = new Size(60, 60),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.None,
                    Visible = false, // Bombs are initially invisible
                };

                bombList.Add(bomb);
                TasBloklar.Controls.Add(bomb);
            }
        }

        private bool IsCollisionBomb(int x, int y)
        {
            foreach (var bomb in bombList)
            {
                int distanceX = Math.Abs(x - bomb.Location.X);
                int distanceY = Math.Abs(y - bomb.Location.Y);

                if (distanceX < 60 && distanceY < 60)
                {
                    return true; // Collision detected with a bomb
                }
            }

            foreach (var tuzaklar in tuzaklarList)
            {
                int distanceX = Math.Abs(x - tuzaklar.Location.X);
                int distanceY = Math.Abs(y - tuzaklar.Location.Y);

                if (distanceX < 60 && distanceY < 60)
                {
                    return true; // Collision detected with a trap
                }
            }

            return false; // No collision with bombs or traps
        }


        private void BombVisibilityTimer_Tick(object sender, EventArgs e)
        {
            // Update bomb positions
            UpdateBombPositions();

            // Toggle visibility of bombs every 3 seconds
            foreach (var bomb in bombList)
            {
                bomb.Visible = !bomb.Visible;
            }
        }
        private void UpdateBombPositions()
        {
            Random random = new Random();

            foreach (var bomb in bombList)
            {
                int x, y;

                do
                {
                    x = random.Next(10) * (TasBloklar.Width / 10);
                    y = random.Next(3) * (TasBloklar.Height / 3);
                } while (IsCollisionBomb(x, y) || IsCollision(x, y)); // Check for collisions with existing bombs and traps

                bomb.Location = new Point(x, y);
            }
        }
        //level3
        private void Level3Page()
        {
            // Calculez le score pour avoir complété le niveau 2
            // Calculez le score pour avoir complété le niveau 2
            int levelScore = kalanCan * 500 + (1000 - elapsedTimeInSeconds);
            score=
            // Ajoutez le score du niveau actuel au totalScore
            totalScore += levelScore;
            // Affichez le score actuel
            MessageBox.Show($"Level Score: {levelScore}", "Level Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Sauvegardez le highscore à la fin du niveau 2
            SaveHighscore(OyuncuAdi.Text, totalScore);
            LevelBtn.Text = "3";
            PuanLabel.Text = "$levelScore";
            kosanAdam.Location = new Point(TasBloklar.Location.X - 60, TasBloklar.Location.Y + 60);
            // Ajouter une vie supplémentaire
            kalanCan++;
            KalanCan.Text = kalanCan.ToString(); 

            // Ajouter des soldats ennemis

            // Supprimez les bombes de la liste
            foreach (var bomb in bombList)
            {
                // Supprimez la PictureBox du conteneur (TasBloklar)
                TasBloklar.Controls.Remove(bomb);
            }

            // Videz la liste des bombes
            bombList.Clear();

            // Supprimez la logique des bombes (timers, etc.)
             if (bombVisibilityTimer != null)
                bombVisibilityTimer.Stop();
            InitializeEnemies();

            // Démarrer le timer pour faire apparaître des ennemis toutes les 2 secondes
            enemySpawnTimer = new Timer();
            enemySpawnTimer.Interval = 2000; // 2 seconds
            enemySpawnTimer.Tick += EnemySpawnTimer_Tick;
            enemySpawnTimer.Start();

            // Démarrer le timer pour faire avancer les ennemis toutes les secondes
            enemyMoveTimer = new Timer();
            enemyMoveTimer.Interval = 1000; // 1 second
            enemyMoveTimer.Tick += EnemyMoveTimer_Tick;
            enemyMoveTimer.Start();
        }

        private void InitializeEnemies()
        {
            enemyList = new List<PictureBox>();
            Random random = new Random();

            int colCount = 10;
            int rowCount = 3;

            string[] enemyImagePaths = new string[]
            {
        @"Images\enemy.png",
                // Add more image paths if necessary
            };

            for (int i = 0; i < 5; i++) // Adjust the number of enemies
            {
                int x, y;

                do
                {
                    x = random.Next(colCount) * (TasBloklar.Width / colCount);
                    y = random.Next(rowCount) * (TasBloklar.Height / rowCount);
                } while (IsEnemyCollision(x, y) || IsCollision(x, y) || IsTrapCollision(x, y)); // Ensure no collision with enemies, traps, or existing bombs

                string enemyImagePath = enemyImagePaths[random.Next(enemyImagePaths.Length)];
                PictureBox enemy = new PictureBox
                {
                    Image = Image.FromFile(enemyImagePath),
                    Location = new Point(x, y),
                    Size = new Size(60, 60),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.None,
                };

                enemyList.Add(enemy);
                TasBloklar.Controls.Add(enemy);
            }
        }

        private bool IsEnemyCollision(int x, int y)
        {
            foreach (var enemy in enemyList)
            {
                int distanceX = Math.Abs(x - enemy.Location.X);
                int distanceY = Math.Abs(y - enemy.Location.Y);

                if (distanceX < 60 && distanceY < 60)
                {
                    return true; // Collision détectée avec un ennemi
                }
            }

            foreach (var tuzaklar in tuzaklarList)
            {
                int distanceX = Math.Abs(x - tuzaklar.Location.X);
                int distanceY = Math.Abs(y - tuzaklar.Location.Y);

                if (distanceX < 60 && distanceY < 60)
                {
                    return true; // Collision détectée avec un piège
                }
            }

            return false; // Pas de collision avec les ennemis ou les pièges
        }

        private void EnemySpawnTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = TasBloklar.Left - 60;
            int y = random.Next(TasBloklar.Height);

            string enemyImagePath = @"Images\enemy.png";
            PictureBox enemy = new PictureBox
            {
                Image = Image.FromFile(enemyImagePath),
                Location = new Point(x, y),
                Size = new Size(60, 60),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
            };

            // Ajoutez l'ennemi à la liste
            enemyList.Add(enemy);

            // Ajoutez l'ennemi au conteneur TasBloklar
            TasBloklar.Controls.Add(enemy);
        }

        private void EnemyMoveTimer_Tick(object sender, EventArgs e)
        {
            foreach (var enemy in enemyList)
            {
                enemy.Left -= 60; // Move to the left by default

                // Check if the enemy is still within the TasBloklar container
                if (enemy.Right < TasBloklar.Left)
                {
                    // If the enemy is out of bounds, remove it
                    TasBloklar.Controls.Remove(enemy);
                    enemyList.Remove(enemy);
                    break; // Exit the loop after removal to avoid errors
                }

                // Ensure the enemy stays within the right boundary of the TasBloklar container
                if (enemy.Right > TasBloklar.Right)
                {
                    enemy.Left = TasBloklar.Right - enemy.Width;
                }
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (enemySpawnTimer != null)
                enemySpawnTimer.Stop();

            if (enemyMoveTimer != null)
                enemyMoveTimer.Stop();
        }
        private bool IsTrapCollision(int x, int y)
        {
            foreach (var tuzaklar in tuzaklarList)
            {
                int distanceX = Math.Abs(x - tuzaklar.Location.X);
                int distanceY = Math.Abs(y - tuzaklar.Location.Y);

                if (distanceX < 60 && distanceY < 60)
                {
                    return true; // Collision detected with a trap
                }
            }

            return false; // No collision with traps
        }
        //High score
        private void SaveHighscore(string playerName, int score)
        {
            try
            {
                // Construisez la chaîne au format "NomDuJoueur:Highscore"
                string highscoreEntry = $"{playerName}:{score}";

                // Écrivez le highscore dans le fichier texte
                System.IO.File.WriteAllText(highscoreFilePath, highscoreEntry);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement du highscore : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (string playerName, int score) LoadHighscore()
        {
            try
            {
                // Lisez le contenu du fichier texte
                string highscoreEntry = System.IO.File.ReadAllText(highscoreFilePath);

                // Divisez la chaîne en nom du joueur et highscore
                string[] parts = highscoreEntry.Split(':');

                // Assurez-vous que la chaîne est au format attendu
                if (parts.Length == 2 && int.TryParse(parts[1], out int loadedHighscore))
                {
                    return (parts[0], loadedHighscore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement du highscore : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // En cas d'erreur, retournez un tuple par défaut
            return ("", 0);
        }



        private void EndGame()
        {
            // Chargez le highscore et le nom du joueur depuis le fichier
            (string savedPlayerName, int savedHighscore) = LoadHighscore();

            // Vérifiez si le highscore actuel est plus élevé que le highscore stocké
            if (totalScore > savedHighscore)
            {
                // Demandez au joueur son nom
                string playerName = OyuncuAdi.Text;

                // Mettez à jour le highscore dans le fichier avec le nom du joueur
                SaveHighscore(playerName, totalScore);

                MessageBox.Show($"Nouveau Highscore!\nJoueur: {playerName}\nTotal Score: {totalScore}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Game Finished!\nPlayer: {savedPlayerName}\nTotal Score: {totalScore}\nHighscore: {savedHighscore}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Sauvegardez le highscore à la fin du niveau
            SaveHighscore(OyuncuAdi.Text, totalScore);

            // Fermez le formulaire (arrêtez le jeu)
            this.Close();
        }

        private void BilgiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PuanLabel_Click(object sender, EventArgs e)
        {

        }
    }
    //level3


}

