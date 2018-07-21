using System;
using ThermometerAssignment.Constraints;
using ThermometerAssignment.DataSource;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment
{
    class Program
    {

        static ITemperatureSource setupTemperatureSource()
        {
            return new ArrayDataSource(
               new Temperature[] {
                   Temperature.GetTemperatureInCelcius(0.0),
                   Temperature.GetTemperatureInCelcius(-5.0),
                   Temperature.GetTemperatureInFarenheit(0.0),
                   Temperature.GetTemperatureInCelcius(20.0),
                   Temperature.GetTemperatureInCelcius(30.0),
                   Temperature.GetTemperatureInCelcius(40.0),
                   Temperature.GetTemperatureInCelcius(50.0),
                   Temperature.GetTemperatureInCelcius(35.0),
                   Temperature.GetTemperatureInCelcius(-7.0),
                   Temperature.GetTemperatureInCelcius(-4.0),
               }
            );
        }

        static Thermometer setupThermometer()
        {
            Thermometer thermometer = new Thermometer();
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("John"),
                new MinTemperatureConstraint(Temperature.GetTemperatureInCelcius(-0.5))
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jack"),
                new MaxTemperatureConstraint(Temperature.GetTemperatureInCelcius(50.0))
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jill"),
                new OrTemperatureConstraint(
                    new ITemperatureConstraint[]
                    {
                        new MinTemperatureConstraint(Temperature.GetTemperatureInCelcius(10.0)),
                        new MaxTemperatureConstraint(Temperature.GetTemperatureInCelcius(30.0))
                    }
                )
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jake"),
                new LoweredTemperatureConstraint(Temperature.GetTemperatureInCelcius(-4.0))
            );
            thermometer.RegisterThermometerListener(
                new ConsoleThermometerListener("Jimmy"),
                new RaisedTemperatureConstraint(Temperature.GetTemperatureInCelcius(35.0))
            );
            return thermometer;
        }

        static void Main(string[] args)
        {
            ITemperatureSource source = setupTemperatureSource();
            Thermometer thermometer = new Thermometer();
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
