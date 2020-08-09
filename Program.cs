using System;
using FifthOOP.Models;

namespace FifthOOP {
    class Program {
        static void Main (string[] args) {

            SweetTooth swt1 = new SweetTooth ();
            SpiceHound spy1 = new SpiceHound ();

            Buffet buffet1 = new Buffet ();

            while (!(swt1.IsFull)) {
                IConsumable foditem = buffet1.Serve ();
                swt1.Consume (foditem);
            }

            while (!(spy1.IsFull)) {
                IConsumable foditem = buffet1.Serve ();
                spy1.Consume (foditem);
            }

            int spyKing = spy1.ConsumptionHistory.Count;
            int swtQueen = swt1.ConsumptionHistory.Count;

            if (spyKing > swtQueen) {
                Console.Write ($"SpyKing has comsumed the most with {spyKing} items!");
            } else if (spyKing < swtQueen) {
                Console.Write ($"SwtQueen has comsumed the most with {swtQueen} items!");
            } else {
                Console.Write ($"SwtQueen & SpyKing consumed equal amounts!");
            }
        }
    }
}