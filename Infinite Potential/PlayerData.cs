using System;

namespace Infinite_Potential
{
    public class PlayerData
    {
        private static int food, energy, energyLim, money;
        private static PlayerAction eat, move, buyFood;
        public PlayerData()
        {
            InitData();
        }

        private static void InitData()
        {
            food = 5;
            energy = 0;
            energyLim = 1;
            money = 100;
            eat = new PlayerAction(new string[] { "Eat", "Food", "Energy" }, new int[] { 1, 1 });
            move = new PlayerAction(new string[] { "Move", "Energy", "Energy Limit" }, new int[] { 1, 1 });
            buyFood = new PlayerAction(new string[] { "Buy Food", "Money", "Food" }, new int[] { 10, 25});
        }

        public int Eat()
        {
            if (food > 0)
            {
                if(energy != energyLim)
                {
                    food--;
                    energy++;
                    return 1;
                }
                return -1;
            }
            return -2;
        }

        public int Move()
        {
            if (energy >= 1)
            {
                energy--;
                energyLim++;
                return 1;
            }
            return -1;
        }

        public int BuyFood()
        {
            if(money >= 10)
            {
                money -= 10;
                food += 25;
                return 1;
            }
            return -1;
        }

        public int GetInt(String val)
        {
            return val switch
            {
                "Food" => food,
                "Energy" => energy,
                "EnergyLim" => energyLim,
                "Money" => money,
                _ => -1,
            };
        }
    }


}
