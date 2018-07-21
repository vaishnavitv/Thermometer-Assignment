using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment.Interfaces
{
    interface ITemperatureListener
    {
        void OnTemperatureChanged(Temperature temperature);
    }
}
