using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    internal class Drone:IMovable, IChargable
    {
        public int BatteryPercentage {  get; set; }
        public String DroneType { get; set; }

        public void ChargeBattery()
        {
            BatteryPercentage = 100;
        }

        public Drone(string droneType, int batteryPercentage)
        {
            DroneType = droneType;
            BatteryPercentage = batteryPercentage;
        }

        public void Fly()
        {
            Console.WriteLine("Drone has taken off.");
        }

        public void MoveLeft()
        {
            Console.WriteLine("Drone turns left.");
        }

        public void MoveRight()
        {
            Console.WriteLine("Drone turns right.");
        }

    }
}
