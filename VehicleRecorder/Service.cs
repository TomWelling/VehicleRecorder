using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRecorder
{
    class Service
    {

        public Service()
        {

        }

        public Service(int tot)
        {
            
            TotalServices = tot;
        }

        public bool NeedsService { get; set; }
        public int TotalServices { get; set; }

    }
}
