#region Custom Directives
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment.Constraints
{
    class FreezingTemperatureConstraint : ITemperatureConstraint
    {
        protected readonly Temperature freezingTemperature;
        public FreezingTemperatureConstraint(Temperature freezingTemperature)
        {
            this.freezingTemperature = freezingTemperature;
        }

        public bool IsTriggeredBoiling(Temperature temperature)
        {
            return false;
        }

        public virtual bool IsTriggeredFreezing(Temperature temperature)
        {
            return temperature <= freezingTemperature;
        }

    }

}
