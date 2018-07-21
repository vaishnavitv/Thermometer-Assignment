using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermometerAssignment.Interfaces
{
    interface ITemperatureSource
    {
        void RegisterListener(ITemperatureListener temperatureListener);
        bool HasData();
        void EmitData();
    }
}
