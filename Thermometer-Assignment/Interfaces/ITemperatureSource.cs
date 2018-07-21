namespace ThermometerAssignment.Interfaces
{
    interface ITemperatureSource
    {
        void RegisterListener(ITemperatureListener temperatureListener);
        bool HasData();
        void EmitData();
    }
}
