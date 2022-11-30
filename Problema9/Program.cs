using System;

public static class Globals
{
	public static void afisareDivizori(int x)
	{

		for (int i = 2; i <= x / 2; i++)
		{
			if (x % i == 0)
			{
				Console.Write(i);
				Console.Write(" ");
			}
		}
	}

	internal static void Main()
	{
		Console.Write("Afisati toti divizorii numarului N");
		Console.Write("\n");
		int n;
		Console.Write("N = ");
		n = Convert.ToInt32(Console.ReadLine());
		afisareDivizori(n);
	}
}
