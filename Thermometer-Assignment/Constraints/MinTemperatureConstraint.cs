using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment.Constraints
{
    class MinTemperatureConstraint : ITemperatureConstraint
    {
        protected readonly Temperature freezingTemperature;
        public MinTemperatureConstraint(Temperature freezingTemperature)
        {
            this.freezingTemperature = freezingTemperature;
        }

        public bool IsTriggeredBoiling(Temperature temperature)
        {
            return false;
        }

        public virtual bool IsTriggeredFreezing(Temperature temperature)
        {
            return temperature.CompareTo(freezingTemperature) <= 0;
        }

    }

}
