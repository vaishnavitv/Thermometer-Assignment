using System;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment.Constraints
{
    class LoweredTemperatureConstraint : MinTemperatureConstraint
    {
        Temperature lastTemperature;

        public LoweredTemperatureConstraint(Temperature freezingTemperature) : base(freezingTemperature)
        {
            this.lastTemperature = freezingTemperature;
        }

        public override bool IsTriggeredFreezing(Temperature temperature)
        {
            if (temperature.CompareTo(lastTemperature) <= 0)
            {
                this.lastTemperature = temperature;
                return base.IsTriggeredFreezing(temperature);
            }

            this.lastTemperature = temperature;
            return false;
        }
    }


}
