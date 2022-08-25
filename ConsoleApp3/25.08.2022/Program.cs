using ConsoleApp3;

internal class Program
{
	public static void Main(string[] args)
	{
		Guitar ins = new Guitar()
		{
			Brand = "Ibanez",
			Model = "BMC",
			Color = "Black",
			Material = "Wood"
		};
        Flute ins2 = new Flute()
        {
            Brand = "Emerson",
            Model = "Jupiter",
            Color = "Silver",
            Material = "Wood"
        };
        Instrument ins3 = new Piano()
        {
            Brand = "Yamaha",
            Model = "B series",
            Color = "White",
            Material = "Wood"
        };
        Instrument[] instruments = new Instrument[3];
        instruments[0] = ins;
        instruments[1] = ins2;
        instruments[2] = ins3;

        Instrument.PrintAllInstruments(instruments);
    }
}