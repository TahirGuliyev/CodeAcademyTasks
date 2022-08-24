using System;

internal class Program
{
	private static void Main(string[] args)
	{
        string[] arr = new string[] { "alma", "armud", "heyva", "nar" };
        FindCharacterInArray(arr, 'a');
    }

    public static int[] FindDublicateElementInArray(int[] arr)
    {
        int[] arr2 = new int[0];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if(arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i] + "=" + arr[j]);
                    Array.Resize(ref arr2, arr2.Length+1);
                    arr2[arr2.Length-1] = arr[i];
                }
            }
        }
        return arr2;
    }

    public static bool FindElementInArray(int numb, int[] arr)
    {
        bool a = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == numb)
            {
                a = true;
            }
        }
        return a;
    }

    public static void PrintArrayWithoutLoop(int[] arr, int indx = 0)
    {
        if (indx > arr.Length-1)
        {
            return;
        }
        else
        {
            Console.WriteLine(arr[indx]);
            indx++;
            PrintArrayWithoutLoop(arr, indx);
        }
    }

    public static void FindCharacterInArray(string[] arr, char character)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i][0] == character)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
