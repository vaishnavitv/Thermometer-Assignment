#region Custom Directives
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment.Constraints
{
    class RaisedTemperatureConstraint : BoilingTemperatureConstraint
    {
        Temperature lastTemperature;

        public RaisedTemperatureConstraint(Temperature boilingTemperature) : base(boilingTemperature)
        {
            this.lastTemperature = boilingTemperature;
        }

        public override bool IsTriggeredBoiling(Temperature temperature)
        {
            if (temperature >= lastTemperature)
            {
                this.lastTemperature = temperature;
                return base.IsTriggeredBoiling(temperature);
            }

            this.lastTemperature = temperature;
            return false;
        }

    }


}
