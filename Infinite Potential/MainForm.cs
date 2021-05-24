using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Infinite_Potential
{
    public partial class MainWindow : Form
    {
        public PlayerData player;
        public MainWindow()
        {
            InitializeComponent();
            player = new PlayerData();
        }

        private void UpdateValues(String which)
        {
            switch (which) {
                case "Food":
                    FoodLabel.Text = "Food: " + player.GetInt("Food");
                    break;
                case "Energy":
                    EnergyLabel.Text = "Energy: " + player.GetInt("Energy") + "/" + player.GetInt("EnergyLim");
                    break;
                default:
                    Debug.Write("Unrecognized update type");
                    break;
            }

        }
        private void EatButton_Click(object sender, EventArgs e)
        {
            player.Eat();
            UpdateValues("Food");
            UpdateValues("Energy");
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            player.Move();
            UpdateValues("Energy");
        }
    }
}
