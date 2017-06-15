using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRecorder
{
    class PerKmRental
    {
        public PerKmRental()
        {

        }

        public PerKmRental(int tot)
        {
            revenue = tot;
        }

        public int revenue { get; set; }

    }
}
