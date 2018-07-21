using ThermometerAssignment.Subject;

namespace ThermometerAssignment.Constraints
{
    class RaisedTemperatureConstraint : MaxTemperatureConstraint
    {
        Temperature lastTemperature;

        public RaisedTemperatureConstraint(Temperature boilingTemperature) : base(boilingTemperature)
        {
            this.lastTemperature = boilingTemperature;
        }

        public override bool IsTriggeredBoiling(Temperature temperature)
        {
            if (temperature.CompareTo(lastTemperature) >= 0)
            {
                this.lastTemperature = temperature;
                return base.IsTriggeredBoiling(temperature);
            }

            this.lastTemperature = temperature;
            return false;
        }

    }


}
