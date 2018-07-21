#region MS Directives
using System;
#endregion

namespace ThermometerAssignment.Subject
{
    class Temperature
    {
        double temperatureValueInCelcius;
        
        private Temperature(double temperatureValueInCelcius)
        {
            this.temperatureValueInCelcius = temperatureValueInCelcius;
        }

        /// <summary>
        /// Instantiate Temperation in Celcius
        /// </summary>
        /// <param name="temperatureValueInCelcius">temperatureValueInCelcius</param>
        /// <returns>Temperature object</returns>
        public static Temperature InCelcius(double temperatureValueInCelcius)
        {
            return new Temperature(temperatureValueInCelcius);
        }

        /// <summary>
        /// Instantiate Temperation in Farenheit
        /// </summary>
        /// <param name="temperatureValueInCelcius">temperatureValueInCelcius</param>
        /// <returns>Temperature object</returns>
        public static Temperature InFarenheit(double temperatureValueInFarenheit)
        {
            return new Temperature(ToCelcius(temperatureValueInFarenheit));
        }

        public static bool operator <(Temperature x, Temperature y)
        {
            return x.Celcius < y.Celcius;
        }

        public static bool operator <=(Temperature x, Temperature y)
        {
            return x.Celcius <= y.Celcius;
        }

        public static bool operator >(Temperature x, Temperature y)
        {
            return x.Celcius > y.Celcius;
        }

        public static bool operator >=(Temperature x, Temperature y)
        {
            return x.Celcius >= y.Celcius;
        }

        public static bool operator ==(Temperature x, Temperature y)
        {
            return x.Celcius == y.Celcius;
        }

        public static bool operator !=(Temperature x, Temperature y)
        {
            return x.Celcius != y.Celcius;
        }

        public override bool Equals(Object temperature)
        {
            if (temperature.GetType() == typeof(Temperature))
            {
                return this == ((Temperature)temperature); 
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Celcius.GetHashCode();
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

        private static double ToFarenheit(double temperatureValueInCelcius)
        {
            return (temperatureValueInCelcius * 1.8) + 32.0;
        }

        private static double ToCelcius(double temperatureinFarenheit)
        {
            return (temperatureinFarenheit - 32.0) / 1.8;
        }
    }

}
