using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipment
{
    class Shipment
    {
        ArrayList DbPolozky = new ArrayList();
        public delegate void OnShipmentMade(string Message);
        public event OnShipmentMade TreckingNumberPridane;
        private string trackingNumber;
        public string TrackingNumber
        {
            get
            {
                return trackingNumber;
            }
            set
            {
                trackingNumber = value;

                TreckingNumberPridane?.Invoke(GetInfo());

            }

        }
        public string GetInfo()
        {
            string message = "";
            foreach (Item i in DbPolozky)
            {
                message += i.Nazov + Environment.NewLine;
                message += i.PocetKusov + Environment.NewLine;
                message += i.CenaZaKus +Environment.NewLine;
            }
            return message;
        }
        public void AddItem(Item item)
        {
            DbPolozky.Add(item);
        }

        
        
    }
}
