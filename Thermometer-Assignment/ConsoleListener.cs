#region MS Directives
using System;
#endregion

#region Custom Directives
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment
{
    class ConsoleListener : ITemperatureListener
    {
        public void OnTemperatureChanged(Temperature temperature)
        {
            Console.WriteLine(new string('-', 80));        
            Console.WriteLine("Temperature Observed: " + temperature);
        }
    }
}
