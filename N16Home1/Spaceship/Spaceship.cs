using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16Home1.Spaceship
{
    internal class Spaceship
    {
        private readonly int _fuel;
        private string _trojectory;
        public string Name { get; init; }
        public int Fuel { get => _fuel; }
        public int Speed { get; set; }
        public string Trojectory { set { _trojectory = value; } }

        public Spaceship(string Name, int Fuel, int Speed, string Trajectory)
        {
            this.Name = Name;
            this._fuel = Fuel;
            this.Speed = Speed;
            this._trojectory = Trajectory;

        }

        public void Display()
        {
            Console.WriteLine($"{Speed} - {_trojectory}");
        }

    }
}
