#region MS Directives
using System;
#endregion

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
