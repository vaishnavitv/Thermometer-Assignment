using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment.Constraints
{
    class MaxTemperatureConstraint : ITemperatureConstraint
    {
        protected readonly Temperature boilingTemperature;
        public MaxTemperatureConstraint(Temperature boilingTemperature)
        {
            this.boilingTemperature = boilingTemperature;
        }

        public virtual bool IsTriggeredBoiling(Temperature temperature)
        {
            return temperature.CompareTo(boilingTemperature) >= 0;
        }

        public bool IsTriggeredFreezing(Temperature temperature)
        {
            return false;
        }
    }


}
