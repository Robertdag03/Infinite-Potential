using System;

public class Player
{
	public Resource food, energy, money;
	public Player()
	{
		food = new Resource("food", 5);
		energy = new Resource("energy", 0, 1);
		money = new Resource("money", 100)
	}
}
