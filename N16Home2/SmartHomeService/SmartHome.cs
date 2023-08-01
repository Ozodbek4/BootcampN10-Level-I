using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16Home2.SmartHomeService
{
    internal class SmartHome
    {
        private bool _isActivated;
        private int _currentTemperature;
        public bool IsActivated { get => _isActivated; }
        public string DeviceName { get; init; }

        protected int ExpectedTemperature;
        protected int CurrentTemperature;
        protected List<SmartHome> Temp = new List<SmartHome>();


        public void Activated()
        {
            this._isActivated = true;
        }

        public void Temperature(int Expected, int Current)
        {
            this.Temp.Add(new SmartHome { ExpectedTemperature = Expected, CurrentTemperature = Current });
        }

        public void DisplayHomeTemperature()
        {
            foreach (SmartHome home in this.Temp)
            {
                Console.WriteLine($"Expected - {home.ExpectedTemperature}, Current - {home.CurrentTemperature}");
            }
        }
    }
}