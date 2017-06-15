using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRecorder
{
    class Vehicle
    {
        public Journey journey;
        public Service service;
        public FuelPurchase fuelPurchase;
        public PerKmRental perKmRental;


        public Vehicle()
        {

        }

        public Vehicle(int i,string b, string m, string y, string r)
        {
            id = i;
            brand = b;
            model = m;
            year = y;
            reg = r;
            journey = new Journey();
            service = new Service();
            fuelPurchase = new FuelPurchase();
            perKmRental = new PerKmRental();
        }

        public void addjourney(int k)
        {
            if (k > 100)
            {
                service.NeedsService = true;
            }
            journey = new Journey(k + journey.kmtravelled);
            perKmRental = new PerKmRental(k + journey.kmtravelled);

        }

        public void addservices(int tot)
        {
        
            service.NeedsService = false;
            service = new Service(tot + service.TotalServices);
        }

        public void addfuel(double t)
        {
            
            fuelPurchase = new FuelPurchase(t);
        }




        public string brand { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string reg { get; set; }
        public int id { get; set; }

    }
}
