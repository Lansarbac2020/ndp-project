//using kacisOyunu.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kacisOyunu
{

    public partial class AnaForm : Form
    {
        private List<HighScoreEntry> highScores;
        private const string highScoresFilePath = "highScore.txt";

        public AnaForm()
        {
            InitializeComponent();
        }
        public class HighScoreEntry
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }
        }


        private void oyuncuİsmi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(oyuncuİsmi.Text))
                {
                    Form1 gamepage = new Form1(oyuncuİsmi.Text);
                    gamepage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir oyuncu adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BilgiButtonu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yukarı Ok (İleri), Aşağı Ok (Geri), Sağ Ok (Sağa), Sol Ok (Sola)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            LoadHighScores();
        }
        private void LoadHighScores()
        {
            try
            {
                // Lisez le contenu du fichier texte
                string[] lines = System.IO.File.ReadAllLines(highScoresFilePath);

                // Initialiser la liste des scores
                highScores = new List<HighScoreEntry>();

                // Parcourir chaque ligne du fichier
                foreach (string line in lines)
                {
                    // Divisez la ligne en nom du joueur et score
                    string[] parts = line.Split(':');

                    // Assurez-vous que la ligne est au format attendu
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        // Ajoutez l'entrée de highscore à la liste
                        highScores.Add(new HighScoreEntry { PlayerName = parts[0], Score = score });
                    }
                }

                // Tri des scores par ordre décroissant
                highScores = highScores.OrderByDescending(entry => entry.Score).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des scores : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void HighScoreButton_Click(object sender, EventArgs e)
        {
            ShowHighScores();
        }
        private void ShowHighScores()
        {
            if (highScores != null && highScores.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var entry in highScores)
                {
                    sb.AppendLine($"{entry.PlayerName}: {entry.Score}");
                }

                MessageBox.Show(sb.ToString(), "High Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun score n'est disponible.", "High Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
