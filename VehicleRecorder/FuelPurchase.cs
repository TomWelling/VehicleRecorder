using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRecorder
{
    class FuelPurchase
    {

        public FuelPurchase()
        {

        }

        public FuelPurchase(double tot)
        {
            Economy = tot;
        }

        public double Economy { get; set; }


    }
}
