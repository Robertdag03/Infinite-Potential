using System;

namespace Infinite_Potential
{
    public class PlayerData
    {
        private static int food, energy, energyLim;
        public PlayerData()
        {
            InitData();
        }

        private static void InitData()
        {
            food = 5;
            energy = 0;
            energyLim = 1;
        }

        public bool Eat()
        {
            if (food > 0)
            {
                food--;
                energy++;
                return true;
            }
            return false;
        }

        public bool Move()
        {
            if (energy >= 1)
            {
                energy--;
                energyLim++;
                return true;
            }
            return false;
        }

        public int GetInt(String val)
        {
            return val switch
            {
                "Food" => food,
                "Energy" => energy,
                "EnergyLim" => energyLim,
                _ => -1,
            };
        }
    }


}
