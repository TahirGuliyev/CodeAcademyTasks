using System;

internal class Program
{
	public static void Main(string[] args)
	{
        #region TASK1
        //IEnumerable<int> numbers = Enumerable.Range(1, 100);
        //foreach (var item in numbers)
        //{
        //	Console.WriteLine($"Neqativ: {item}, pozitiv: {item * (-1)}");
        //} 
        #endregion

        #region TASK2
        //Console.WriteLine("String daxil edin: ");
        //string s = Console.ReadLine();
        //Console.WriteLine(Reverse(s)); 
        #endregion

        #region TASK3
        IEnumerable<int> numbers = Enumerable.Range(10, 20);
		foreach (var item in numbers)
		{
			AsalSayi(item);
		}
        #endregion
    }

	#region TASK2
	private static string Reverse(string s)
	{
		char[] charArray = s.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}
	#endregion
	#region TASK3
	private static bool AsalSayi(int number)
	{
		int i;
		for (i = 2; i <= number - 1; i++)
		{
			if (number % i == 0)
			{
				return false;
			}
		}
		if (i == number)
		{
			return true;
		}
		return false;
	} 
	#endregion
}