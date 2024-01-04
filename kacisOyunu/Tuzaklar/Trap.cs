////BACORO DIT ELHADJI LANSAR
////B211200567



//namespace kacisOyunue
//{
//    public partial class Form1 : Form
//    {
//        private List<Tuzaklar> BombList;

//        private List<Tuzaklar> tuzaklarList;

//        private bool isPaused = false;
//        public Timer timer;
//        public int elapsedTimeInSeconds = 0;
//        private PictureBox kosanAdam;
//        private int currentLevel = 12;


//        private int kalanCan;

//        public Form1(string playerName)
//        {

//            InitializeComponent();
//            InitializeTuzaklar();
//            // InitializeInitialTuzaklar();

//            timer = new Timer();
//            timer.Interval = 1000;
//            timer.Tick += Timer_Tick;
//            timer.Start();
//            // Initialisez kalanCan avec la valeur de départ (par exemple, 3 vies)
//            kalanCan = 3;

//            // Mettez à jour l'interface utilisateur avec le nombre initial de vies
//            KalanCan.Text = kalanCan.ToString();



//            OyuncuAdi.Text = playerName;

//            int panelWidth = TasBloklar.Width;
//            int panelHeight = TasBloklar.Height;



//            kosanAdam = new PictureBox
//            {
//                Image = Image.FromFile(@"Images\kosanAdam1.png"),
//                Location = new Point(TasBloklar.Location.X - 60, TasBloklar.Location.Y + 60),
//                Size = new Size(60, 60),
//                BackColor = Color.Transparent,
//                BorderStyle = BorderStyle.None,
//            };
//            Controls.Add(kosanAdam);


//            KeyDown += Form1_KeyDown;
//            this.Activate();
//            this.KeyPreview = true;
//            kosanAdam.BringToFront();

//        }
//        public void Timer_Tick(object sender, EventArgs e)
//        {
//            elapsedTimeInSeconds++;
//            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsedTimeInSeconds);
//            string formattedTime = timeSpan.ToString("mm':'ss");
//            GecenSure.Text = formattedTime;



//        }
//        private void ShowInitialTuzaklar()
//        {
//            Random random = new Random();

//            foreach (var tuzaklar in BombList)
//            {
//                if (random.Next(100) < 10)  // Affichez chaque image avec une probabilité de 10%
//                {
//                    // Changez la position de l'image spécifique aléatoirement
//                    int x, y;

//                    do
//                    {
//                        x = random.Next(TasBloklar.Width);
//                        y = random.Next(TasBloklar.Height);
//                    } while (IsCollision(x, y));

//                    tuzaklar.Location = new Point(x, y);

//                    // Rendez l'image visible
//                    tuzaklar.Visible = true;
//                }
//            }
//        }

//        private void Form1_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (kosanAdam.Location.X == 1100)
//            {
//                return;
//            }

//            if (e.KeyCode == Keys.P)
//            {
//                TogglePause(); // Toggle the pause state when 'P' key is pressed
//                return;
//            }

//            if (isPaused)
//            {
//                // If the game is paused, do not handle other key events
//                return;
//            }

//            int step = 60;

//            int newLeft = kosanAdam.Left;
//            int newTop = kosanAdam.Top;

//            Direction direction = DirectionExtensions.GetDirectionFromKey(e.KeyCode);

//            switch (direction)
//            {
//                case Direction.Up:
//                    if (kosanAdam.Location.Y == 300)
//                    {
//                        return;
//                    }
//                    newTop -= step;
//                    break;

//                case Direction.Left:
//                    if (kosanAdam.Location.X == 440)
//                    {
//                        return;
//                    }
//                    newLeft -= step;
//                    break;

//                case Direction.Down:
//                    if (kosanAdam.Location.Y == 420)
//                    {
//                        return;
//                    }
//                    newTop += step;
//                    break;

//                case Direction.Right:
//                    newLeft += step;
//                    break;
//            }

//            // Update the position of kosanAdam
//            kosanAdam.Left = newLeft;
//            kosanAdam.Top = newTop;

//            CheckTuzaklarCollision();
//            if (kosanAdam.Location.X == 1100)
//            {
//                MessageBox.Show("Tebrikler");
//                Level2Page();
//            }
//            if (kalanCan == 0)
//            {
//                // Si le joueur n'a plus de vies, le jeu est terminé
//                // Affichez le MessageBox et redémarrez le jeu lorsque OK est cliqué
//                CheckGameOver();
//            }
//        }



//        private void TogglePause()
//        {
//            isPaused = !isPaused;

//            if (isPaused)
//            {
//                timer.Stop(); // Pause the timer
//                              // You can add additional pause-related actions here

//                // Display a message when the game is paused
//                MessageBox.Show("Game Paused", "Paused", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            else
//            {
//                timer.Start(); // Resume the timer
//                               // You can add additional resume-related actions here
//            }
//        }


//        private void InitializeTuzaklar()
//        {
//            tuzaklarList = new List<Tuzaklar>();
//            Random random = new Random();

//            int colCount = 10;
//            int rowCount = 3;


//            string[] imagePaths = new string[]
//            {
//        @"Images\trap1.png",
//        @"Images\tuzak2.png",
//        @"Images\trap2.png"
//            };
//            for (int i = 0; i < 10; i++)
//            {
//                int x, y;

//                do
//                {
//                    x = random.Next(colCount) * (TasBloklar.Width / colCount);
//                    y = random.Next(rowCount) * (TasBloklar.Height / rowCount);
//                } while (IsCollision(x, y));

//                string imagePath = imagePaths[random.Next(imagePaths.Length)];
//                Tuzaklar tuzaklar = new Tuzaklar(x, y, imagePath);
//                tuzaklarList.Add(tuzaklar);
//                TasBloklar.Controls.Add(tuzaklar);
//            }
//        }

//        private bool IsCollision(int x, int y)
//        {
//            foreach (var tuzaklar in tuzaklarList)
//            {
//                int distanceX = Math.Abs(x - tuzaklar.Location.X);
//                int distanceY = Math.Abs(y - tuzaklar.Location.Y);

//                if (distanceX < 60 && distanceY < 60)
//                {
//                    return true; // Collision détectée
//                }
//            }

//            return false; // Pas de collision
//        }




//        private void TasBloklar_Paint(object sender, PaintEventArgs e)
//        {

//        }
//        private void CheckTuzaklarCollision()
//        {
//            Point kosanAdamLocation = new Point(kosanAdam.Location.X - 500, kosanAdam.Location.Y - 300);

//            foreach (var tuzaklar in tuzaklarList)
//            {
//                Point tuzaklarLocation = tuzaklar.Location;

//                if (kosanAdamLocation == tuzaklarLocation)
//                {
//                    // Collision détectée avec un tuzak, rendre la PictureBox visible
//                    tuzaklar.Visible = true;
//                    kalanCan--;
//                    KalanCan.Text = kalanCan.ToString();

//                    // Her çarpışmadan sonra oyunun bitip bitmediğini kontrol edin
//                    CheckGameOver();

//                }
//            }
//        }
//        private void CheckGameOver()
//        {
//            if (kalanCan <= 0)
//            {
//                // Le joueur a perdu, affichez un MessageBox
//                MessageBox.Show("Game Over! Click OK to restart.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                // Réinitialisez le jeu
//                RestartGame();
//            }
//        }
//        private void RestartGame()
//        {
//            // Réinitialisez les valeurs nécessaires pour recommencer le jeu
//            kalanCan = 3;
//            elapsedTimeInSeconds = 0;
//            GecenSure.Text = "00:00"; // Mettez à jour si nécessaire

//            // Remplacez cette ligne par l'emplacement initial de votre personnage
//            kosanAdam.Location = new Point(TasBloklar.Location.X - 60, TasBloklar.Location.Y + 60);

//            // Cachez à nouveau les pièges et mettez à jour l'interface utilisateur
//            foreach (var tuzaklar in tuzaklarList)
//            {
//                tuzaklar.Visible = false;
//            }

//            KalanCan.Text = kalanCan.ToString();

//            // Réinitialisez la position des pièges
//            ResetTuzaklarPosition();

//            // Cachez à nouveau les pièges et mettez à jour l'interface utilisateur
//            foreach (var tuzaklar in tuzaklarList)
//            {
//                tuzaklar.Visible = false;
//            }

//            KalanCan.Text = kalanCan.ToString();

//            // Redémarrez le timer
//            timer.Start();
//        }


//        private void ResetTuzaklarPosition()
//        {
//            Random random = new Random();

//            foreach (var tuzaklar in tuzaklarList)
//            {
//                int x, y;

//                do
//                {
//                    x = random.Next(10) * (TasBloklar.Width / 10);
//                    y = random.Next(3) * (TasBloklar.Height / 3);
//                } while (IsCollision(x, y));

//                tuzaklar.Location = new Point(x, y);
//                Visible = false;
//            }
//        }
//        //level2
//        private void Level2Page()
//        {
//            // Réinitialisez les valeurs nécessaires pour recommencer le jeu
//            kalanCan++;
//            KalanCan.Text = kalanCan.ToString();


//            // Remplacez cette ligne par l'emplacement initial de votre personnage
//            kosanAdam.Location = new Point(TasBloklar.Location.X - 60, TasBloklar.Location.Y + 60);

//            // Créez une nouvelle liste de pièges avec de nouvelles positions
//            InitializeInitialTuzaklar();

//            // Cachez à nouveau les pièges et mettez à jour l'interface utilisateur
//            foreach (var tuzaklar in BombList)
//            {
//                tuzaklar.Visible = false;
//            }
//            // Mettez à jour le label LevelBtn
//            LevelBtn.Text = "2";




//        }
//        private void InitializeInitialTuzaklar()
//        {
//            BombList = new List<Tuzaklar>();
//            Random random = new Random();

//            string[] imagePaths = new string[]
//            {
//            @"Images\trap1.png",  // L'image spécifique que vous souhaitez afficher
//            };

//            for (int i = 0; i < 10; i++)
//            {
//                int x, y;

//                do
//                {
//                    x = random.Next(TasBloklar.Width);
//                    y = random.Next(TasBloklar.Height);
//                } while (IsCollision(x, y));

//                string imagePath = imagePaths[0]; // Utilisez la première image de la liste
//                Tuzaklar tuzaklar = new Tuzaklar(x, y, imagePath);
//                BombList.Add(tuzaklar);
//                TasBloklar.Controls.Add(tuzaklar);
//                tuzaklar.Visible = false;  // Initialisé comme non visible au début
//            }
//        }


//    }


//}


