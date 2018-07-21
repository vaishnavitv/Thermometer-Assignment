#region MS Directives
using System;
#endregion

#region Custom Directives
using System.Collections.Generic;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;
#endregion

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
