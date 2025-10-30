using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	/// <summary>
	/// מייצג אופנוע בעל מנוע דלק.
	/// </summary>
	public class Motorcycle:Vehicle, IMovable
	{

		/// <summary>
		/// בנאי ליצירת אופנוע חדש.
		/// </summary>
		/// <param name="model">שם דגם האופנוע.</param>
		/// <param name="fuel">כמות הדלק ההתחלתית.</param>
		public Motorcycle(string model, int fuel):base(model, fuel)
		{
			ModelName = model;
			// Math.Clamp: מבטיח שהדלק יהיה תמיד בטווח 0-100.
			FuelPercentage = Math.Clamp(fuel, 0, 100);
		}

		/// <summary>
		/// מבצע פעולת נסיעה הצורכת דלק (בצורה שונה ממכונית).
		/// </summary>
		public override void Drive()
		{
			if (FuelPercentage > 5)
			{
				FuelPercentage -= 5;
				Console.WriteLine($"The motorcycle {ModelName} goes 'Neeeeow'. Fuel left: {FuelPercentage}%");
			}
			else
			{
				Console.WriteLine($"The motorcycle {ModelName} cannot drive. No fuel.");
			}
		}

		/// <summary>
		/// מתדלק את האופנוע למקסימום.
		/// </summary>
		public void Refuel() {}

		/// <summary>
		/// מזיז את האופנוע שמאלה.
		/// </summary>
		public override void MoveLeft()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans left.");
		}

		/// <summary>
		/// מזיז את האופנוע ימינה.
		/// </summary>
		public override void MoveRight()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans right.");
		}
	}

}
