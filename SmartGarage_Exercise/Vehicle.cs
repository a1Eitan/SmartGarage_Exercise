using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class Vehicle
    {
        public string ModelName
        {
            get; set;
        }

        /// <summary>
        /// אחוז הדלק הנוכחי (בין 0 ל-100).
        /// </summary>
        public int FuelPercentage
        {
            get; protected set;
        }

        public Vehicle(String modelName, int fuelPercentage)
        {
            ModelName = modelName;
            FuelPercentage = fuelPercentage;
        }

        public abstract void Drive();
        public virtual void Refuel()
        {
            Console.WriteLine($"Refueling {ModelName}...");
            FuelPercentage = 100;
        }

        /// <summary>
        /// מזיז את כלי הרכב שמאלה.
        /// </summary>
        public virtual void MoveLeft()
        {
            Console.WriteLine($"Vehicle {ModelName} turns left.");
        }

        /// <summary>
        /// מזיז את כלי הרכב ימינה.
        /// </summary>
        public virtual void MoveRight()
        {
            Console.WriteLine($"Vehicle {ModelName} turns right.");
        }
    }
}
