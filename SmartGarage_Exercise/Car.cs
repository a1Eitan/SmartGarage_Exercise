using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;
	

		/// <summary>
		/// מייצגת מכונית בעלת מנוע דלק.
		/// </summary>
		public class Car:Vehicle
		{
			/// <summary>
			/// בנאי ליצירת מכונית חדשה.
			/// </summary>
			/// <param name="model">שם דגם המכונית.</param>
			/// <param name="fuel">כמות הדלק ההתחלתית.</param>
			public Car(string model, int fuel):base(model, fuel)
			{
				ModelName = model;
				// Math.Clamp: פקודה המבטיחה שהערך יישאר בטווח שצוין.
				// במקרה זה, 'fuel' יהיה תמיד בין 0 (המינימום) ל-100 (המקסימום).
				FuelPercentage = Math.Clamp(fuel, 0, 100);
			}

			/// <summary>
			/// מבצע פעולת נסיעה הצורכת דלק.
			/// </summary>
			public override void Drive()
			{
				if (FuelPercentage > 10)
				{
					FuelPercentage -= 10;
					Console.WriteLine($"The car {ModelName} goes 'Vroom Vroom'. Fuel left: {FuelPercentage}%");
				}
				else
				{
					Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
				}
			}

			/// <summary>
			/// מתדלק את המכונית למקסימום.
			/// </summary>
			public void Refuel() {}

			/// <summary>
			/// מזיז את המכונית שמאלה.
			/// </summary>
			public override void MoveLeft()
			{
				Console.WriteLine($"Car {ModelName} turns left.");
			}

			/// <summary>
			/// מזיז את המכונית ימינה.
			/// </summary>
			public override void MoveRight()
			{
				Console.WriteLine($"Car {ModelName} turns right.");
			}
		}

	
