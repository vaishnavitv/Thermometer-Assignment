#region Custom Directives
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment.Interfaces
{
    interface ITemperatureListener
    {
        void OnTemperatureChanged(Temperature temperature);
    }
}
