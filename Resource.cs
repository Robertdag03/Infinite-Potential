using System;

public class Resource
{
	private string name;
	private int amount, limit;
	private bool limited;
	public Resource(string n, int a, int l)
	{
		name = n;
		amount = a;
		limit = l;
		limited = true;
	}

	public Resource(string n, int a)
    {
		name = n;
		amount = a;
		limited = false;
    }

	public int GetAmount()
    {
		return amount;
    }

	public int GetLimit()
    {
		return limit;
    }

	public string GetText()
    {
        if (limited)
        {
			return name + ": " + amount + "/" + limit;
        }
        else
        {
			return name + ": " + amount;
        }
    }
}
