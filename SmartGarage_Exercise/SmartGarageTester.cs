using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	/// <summary>
	/// מחלקה סטטית המכילה פונקציות לבדיקת היכולות של המוסך.
	/// המטרה שלכם היא להחליף את הפונקציות המסורבלות בפונקציות פולימורפיות.
	/// </summary>
	public static class SmartGarageTester
	{
		// --- פונקציות יעד חדשות (מכילות רק חתימה והערות) ---
		// --- עליכם לגרום לקוד הבא (שנמצא בהערה) לעבוד ---

		
        /// <summary>
        /// (פונקציה למשימה ד') בודקת מערך פולימורפי של כלי רכב.
        /// הפונקציה הזו מסופקת לכם במלואה כדוגמה.
        /// </summary>
        /// <param name="allVehicles">מערך של כלי רכב (Vehicle).</param>
        public static void TestAllVehicles(Vehicle[] allVehicles)
        {
            Console.WriteLine("\n--- Commencing Vehicle diagnostics ---");
            foreach (var v in allVehicles)
            {
                // קריאה לפעולת בסיס
                Console.WriteLine($"-- Testing {v.ModelName} --");
                
                // קריאה פולימורפית לפעולה אבסטרקטית!
                v.Drive(); 
                
                // קריאה לפעולה רגילה מהבסיס
                v.Refuel(); 
            }
        }

        // -----------------------------------------------------------------
        // --- משימת האתגר המרכזית (מימוש ע"י התלמידים) ---
        // -----------------------------------------------------------------
        //
        // המטרה: 
        // לממש פונקציה המדגימה את הכוח של ממשקים מרובים.
        //
        // קלט: 
        // הפונקציה מקבלת מערך יחיד מסוג IMovable (ממשק X).
        //
        // דרישות מימוש (ה"מה", לא ה"איך"):
        // הפונקציה צריכה לעבור בלולאה על *כל* האיברים במערך 'movables'.
        // 1. עבור *כל* איבר במערך, יש להפעיל את הפעולה MoveRight() שלו. 
        //    (זה בטוח לביצוע, כי אנו יודעים שכל איבר במערך *חייב* לממש IMovable).
        //
        // 2. *בנוסף*, במהלך הלולאה, עליכם לזהות *רק* את האיברים 
        //    ש"במקרה" מממשים *גם* את ממשק IChargeable (ממשק Y).
        //
        // 3. על האיברים שזיהיתם בסעיף 2 (ואך ורק עליהם), 
        //    יש להפעיל את הפעולה ChargeBattery().
        //
        // (רמז: חישבו כיצד לבדוק אם אובייקט מסוים מממש ממשק נוסף בזמן ריצה)

        /// <summary>
        /// (פונקציה למשימה ד') בודקת מערך של אובייקטים זזים (IMovable)
        /// ומפעילה טעינה רק על אלו שגם נטענים (IChargeable).
        /// </summary>
        /// <param name="movables">מערך של אובייקטים המממשים IMovable.</param>
        public static void TestMovablesAndChargeables(IMovable[] movables)
        {
            Console.WriteLine("\n--- Commencing Movable/Chargeable test ---");

            foreach (var m in movables)
            {
                m.MoveRight();
                if (m is IChargable c)
                {
                    c.ChargeBattery();
                }
            }
            

            Console.WriteLine("--- Movable/Chargeable test complete ---");
        }
	}

}
