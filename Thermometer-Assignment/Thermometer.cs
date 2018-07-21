using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermometerAssignment;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment
{
    class Thermometer : ITemperatureListener
    {
        List<Tuple<IThermometerListener, ITemperatureConstraint>> listeners = new List<Tuple<IThermometerListener, ITemperatureConstraint>>();

        public void OnTemperatureChanged(Temperature temperature)
        {
            foreach (var tuple in listeners)
            {
                if (tuple.Item2.IsTriggeredBoiling(temperature))
                {
                    tuple.Item1.OnBoiling();
                }

                if (tuple.Item2.IsTriggeredFreezing(temperature))
                {
                    tuple.Item1.OnFreezing();
                }
            }
        }

        public void RegisterThermometerListener(IThermometerListener thermometerListener, ITemperatureConstraint temperatureConstraint)
        {
            listeners.Add(new Tuple<IThermometerListener, ITemperatureConstraint>(thermometerListener, temperatureConstraint));
        }
    }
}
