#region MS Directives
#endregion

#region Custom Directives
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment.Constraints
{
    class LoweredTemperatureConstraint : FreezingTemperatureConstraint
    {
        Temperature lastTemperature;

        public LoweredTemperatureConstraint(Temperature freezingTemperature) : base(freezingTemperature)
        {
            this.lastTemperature = freezingTemperature;
        }

        public override bool IsTriggeredFreezing(Temperature temperature)
        {
            if (temperature <= lastTemperature)
            {
                this.lastTemperature = temperature;
                return base.IsTriggeredFreezing(temperature);
            }

            this.lastTemperature = temperature;
            return false;
        }
    }


}
