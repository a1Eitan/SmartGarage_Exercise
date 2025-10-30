using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{

	/// <summary>
	/// מייצג רובוט ניקוי חשמלי.
	/// </summary>
	public class CleaningRobot:IMovable, IChargable
	{
		/// <summary>
		/// המספר הסידורי של הרובוט.
		/// </summary>
		public string SerialNumber
		{
			get; set;
		}

		/// <summary>
		/// אחוז הסוללה הנוכחי (בין 0 ל-100).
		/// </summary>
		public int BatteryPercentage
		{
			get; private set;
		}

		/// <summary>
		/// בנאי ליצירת רובוט ניקוי חדש.
		/// </summary>
		/// <param name="serial">המספר הסידורי.</param>
		/// <param name="battery">אחוז הסוללה ההתחלתי.</param>
		public CleaningRobot(string serial, int battery)
		{
			SerialNumber = serial;
			// Math.Clamp: מבטיח שהסוללה תהיה תמיד בטווח 0-100.
			BatteryPercentage = Math.Clamp(battery, 0, 100);
		}

		/// <summary>
		/// מתחיל פעולת ניקוי הצורכת סוללה.
		/// </summary>
		public void StartCleaning()
		{
			if (BatteryPercentage > 20)
			{
				BatteryPercentage -= 20;
				Console.WriteLine($"Robot {SerialNumber} is cleaning 'Zzzzz'. Battery: {BatteryPercentage}%");
			}
			else
			{
				Console.WriteLine($"Robot {SerialNumber} cannot clean. Battery low.");
			}
		}

		/// <summary>
		/// טוען את סוללת הרובוט למקסימום.
		/// </summary>
		public void ChargeBattery()
		{
			Console.WriteLine($"Charging {SerialNumber}...");
			BatteryPercentage = 100;
		}

		/// <summary>
		/// מזיז את הרובוט שמאלה.
		/// </summary>
		public void MoveLeft()
		{
			Console.WriteLine($"Robot {SerialNumber} spins left.");
		}

		/// <summary>
		/// מזיז את הרובוט ימינה.
		/// </summary>
		public void MoveRight()
		{
			Console.WriteLine($"Robot {SerialNumber} spins right.");
		}
	}
}
