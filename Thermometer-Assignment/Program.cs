#region MS Directives
using System;
#endregion

#region Custom Directives
using ThermometerAssignment.Constraints;
using ThermometerAssignment.DataSource;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;
#endregion

namespace ThermometerAssignment
{
    class Program
    {
        static ITemperatureSource setupTemperatureSource()
        {
            return new ArrayDataSource(
               new Temperature[] {
                   Temperature.InCelcius(0.0),
                   Temperature.InCelcius(-5.0),
                   Temperature.InFarenheit(0.0),
                   Temperature.InCelcius(20.0),
                   Temperature.InCelcius(30.0),
                   Temperature.InCelcius(40.0),
                   Temperature.InCelcius(50.0),
                   Temperature.InCelcius(35.0),
                   Temperature.InCelcius(-7.0),
                   Temperature.InCelcius(-4.0),
               }
            );
        }

        static Thermometer setupThermometer()
        {
            Thermometer thermometer = new Thermometer();
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("John"),
                new FreezingTemperatureConstraint(Temperature.InCelcius(-0.5))
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jack"),
                new BoilingTemperatureConstraint(Temperature.InCelcius(50.0))
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jill"),
                new OrTemperatureConstraint(
                    new ITemperatureConstraint[]
                    {
                        new FreezingTemperatureConstraint(Temperature.InCelcius(10.0)),
                        new BoilingTemperatureConstraint(Temperature.InCelcius(30.0))
                    }
                )
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jake"),
                new LoweredTemperatureConstraint(Temperature.InCelcius(-4.0))
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jimmy"),
                new RaisedTemperatureConstraint(Temperature.InCelcius(35.0))
            );
            return thermometer;
        }

        static void Main(string[] args)
        {
            ITemperatureSource source = setupTemperatureSource();
            source.RegisterListener(new ConsoleListener());
            source.RegisterListener(setupThermometer());

            while (source.HasData())
            {
                source.EmitData();
            }
            Console.ReadLine();
        }
    }
}
