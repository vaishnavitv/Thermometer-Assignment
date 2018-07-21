using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermometerAssignment.Subject
{
    class Temperature : IComparable<Temperature>
    {
        double temperatureValueInCelcius;
        
        private Temperature(double temperatureValueInCelcius)
        {
            this.temperatureValueInCelcius = temperatureValueInCelcius;
        }
        
        private static double ToFarenheit(double temperatureValueInCelcius)
        {
            return (temperatureValueInCelcius * 1.8) + 32.0;
        }

        private static double ToCelcius(double temperatureinFarenheit)
        {
            return (temperatureinFarenheit - 32.0) / 1.8;
        }

        public static Temperature GetTemperatureInCelcius(double temperatureValueInCelcius)
        {
            return new Temperature(temperatureValueInCelcius);
        }

        public static Temperature GetTemperatureInFarenheit(double temperatureValueInFarenheit)
        {
            return new Temperature(ToCelcius(temperatureValueInFarenheit));
        }

        public int CompareTo(Temperature other)
        {
            double c1 = this.Celcius;
            double c2 = other.Celcius;
            if (c1 > c2)
                return 1;
            if (c1 < c2)
                return -1;
            else
                return 0;
        }

        public double Celcius
        {
            get
            {
                return temperatureValueInCelcius;
            }
            
        }

        public double Farenheit
        {
            get
            {
                return ToFarenheit(temperatureValueInCelcius);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} C / {1} F", Celcius, Farenheit);
        }
    }

}
