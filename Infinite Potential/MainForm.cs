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
            UpdateValues("Init");
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
                case "Init":
                    UpdateValues("Food");
                    UpdateValues("Energy");
                    break;
                default:
                    Debug.Write("Unrecognized update type");
                    break;
            }

        }
        private void EatButton_Click(object sender, EventArgs e)
        {
            int result = player.Eat();
            UpdateValues("Food");
            UpdateValues("Energy");
            ErrorDisplay.Text = result switch
            {
                -1 => "You're too full to eat anymore",
                -2 => "There's nothing left to eat",
                _ => "",
            };
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            int result = player.Move();
            UpdateValues("Energy");
            ErrorDisplay.Text = result switch { 
                -1 => "You have no energy left",
                _ => "",
            };

        }
    }
}
