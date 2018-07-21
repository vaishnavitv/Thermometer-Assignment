using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment.DataSource
{
    class ArrayDataSource : ITemperatureSource
    {
        IEnumerator<Temperature> iterator;
        List<ITemperatureListener> listeners = new List<ITemperatureListener>();

        public ArrayDataSource(IEnumerable<Temperature> iterator)
        {
            this.iterator = iterator.GetEnumerator();
        }

        public void EmitData()
        {
            Temperature temperature = iterator.Current;
            foreach(var listener in listeners)
            {
                listener.OnTemperatureChanged(temperature);
            }

        }

        public bool HasData()
        {
            return iterator.MoveNext();
        }

        public void RegisterListener(ITemperatureListener temperatureListener)
        {
            listeners.Add(temperatureListener);
        }
    }
}
