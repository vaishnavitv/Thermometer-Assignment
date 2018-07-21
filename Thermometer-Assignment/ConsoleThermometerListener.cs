using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermometerAssignment.Interfaces;
using ThermometerAssignment.Subject;

namespace ThermometerAssignment
{
    class ConsoleThermometerListener : IThermometerListener
    {

        string clientName;
        public ConsoleThermometerListener(string clientName)
        {
            this.clientName = clientName;
        }

        public void OnBoiling()
        {
            Console.WriteLine(this.clientName + ": Boiling!");
        }

        public void OnFreezing()
        {
            Console.WriteLine(this.clientName + ": Freezing!");
        }

    }
}
