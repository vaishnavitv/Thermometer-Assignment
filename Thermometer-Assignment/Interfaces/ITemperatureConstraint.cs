#region Custom Directives
using ThermometerAssignment.Subject;
#endregion


namespace ThermometerAssignment.Interfaces
{
    interface ITemperatureConstraint
    {
        bool IsTriggeredFreezing(Temperature temperature);
        bool IsTriggeredBoiling(Temperature temperature);
    }
}
