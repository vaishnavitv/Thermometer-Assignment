using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment
{
    class ConsoleListener : ITemperatureListener
    {
        public void OnTemperatureChanged(Temperature temperature)
        {
            Console.WriteLine(new string('-', 80));        
            Console.WriteLine("New Temperature Observed: " + temperature);
        }
    }
}
