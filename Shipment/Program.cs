using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipment s = new Shipment();
            Item item = new Item();
            item.Nazov = "polozka";
            item.PocetKusov = 5;
            item.CenaZaKus = 5.4;
            s.AddItem(item);

            item = new Item();
            item.Nazov = "polozka2";
            item.PocetKusov = 10;
            item.CenaZaKus = 2.4;
            s.AddItem(item);

            item = new Item("polozka3", 8, 2.1);
            s.AddItem(item);
            Notifikacia n = new Notifikacia();
            s.TreckingNumberPridane += n.Notify;
            s.TrackingNumber = "145741F";
            Console.ReadLine();
        }
    }
}
