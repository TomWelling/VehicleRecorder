using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRecorder
{
    class Journey
    {
        

        public Journey()
        {

        }

        public Journey(int k)
        {
            kmtravelled = k;
        }

        public int vehid { get; set; }
        public int kmtravelled { get; set; }

    }
}
