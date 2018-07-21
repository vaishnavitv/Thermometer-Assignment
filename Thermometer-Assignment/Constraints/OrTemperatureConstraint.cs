#region MS Directives
using System.Collections.Generic;
#endregion

#region Custom Directives
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment.Constraints
{
    class OrTemperatureConstraint : ITemperatureConstraint
    {
        IEnumerable<ITemperatureConstraint> temperatureConstraints;
        public OrTemperatureConstraint(IEnumerable<ITemperatureConstraint> temperatureConstraints)
        {
            this.temperatureConstraints = temperatureConstraints;
        }

        public bool IsTriggeredBoiling(Temperature temperature)
        {
            foreach (var temperatureConstraint in temperatureConstraints)
            {
                if (temperatureConstraint.IsTriggeredBoiling(temperature))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsTriggeredFreezing(Temperature temperature)
        {
            foreach (var temperatureConstraint in temperatureConstraints)
            {
                if (temperatureConstraint.IsTriggeredFreezing(temperature))
                {
                    return true;
                }
            }

            return false;
        }
    }


}
