using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Instrument
    {
        public string Model { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }

        public abstract void Sound();
        public static void PrintAllInstruments(Instrument[] ins)
        {
            foreach (Instrument instr in ins)
            {
            Console.WriteLine($"Instrument: { typeof(Instrument).Name } Model: {instr.Model} Price: {instr.Price} Brand: {instr.Brand}");

            }
        }
    }
}
