#region Custom Directives
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment.Constraints
{
    class BoilingTemperatureConstraint : ITemperatureConstraint
    {
        protected readonly Temperature boilingTemperature;
        public BoilingTemperatureConstraint(Temperature boilingTemperature)
        {
            this.boilingTemperature = boilingTemperature;
        }

        public virtual bool IsTriggeredBoiling(Temperature temperature)
        {
            return temperature >= boilingTemperature;
        }

        public bool IsTriggeredFreezing(Temperature temperature)
        {
            return false;
        }
    }


}
