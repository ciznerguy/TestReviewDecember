using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReviewDecember
{
    internal class Program
    {
        /*
         חזרה לקראת המבחן ביום חמישי 12/19/2024
        במבחן יבדקו שלושה נושאים עיקריים
        פירוק מספר לספרותיו
        עבודה עם לולאות
        וטבלת מעקב
         */


        // חזרה בנושא פירוק מספר לספרותיו
        // אלה תכניות שיכולות לשמש כתבנית לשאלות אחרות

        // יש לכתוב קטע קוד הקולט מספר שלם ומדפיס את סכום ספרותיו

        public static void Ex1()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {


                sum += num % 10;
            }
            num /= 10;
        }



        // יש לכתוב קטע קוד מספר שלם ומדפיס אם סכום ספרותיו זוגי
        public static void Ex2()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("even sum");

            }
            else
            {
                Console.WriteLine("odd sum");
            }
        }





        // יש לכתוב קטע קוד הקולט מספר שלם ומדפיס את אורך המספר


        public static void Ex3()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;


            }
            Console.WriteLine(count);

        }

        // יש לכתוב קטע קוד הקולט שני מספרים ומחזיר את המספר בעל יותר ספרות מבין 
        // - המספרים. אם אורכם שווה יוחזר 1


        public static void Ex4()
        {
            Console.WriteLine("enter number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            int num2 = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;

            while (num1 > 0)
            {
                count1++;
                num1 /= 10;
            }
            while (num2 > 0)
            {
                count2++;
                num2 /= 10;
            }
            if (count1 > count2)
            {
                Console.WriteLine(num1);
            }
            else if (count2 > count1)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(1);
            }
        }

        // יש לכתוב קטע קוד הקולט שני מספרים ומחזיר כמה מהספרות הן זהות
        // ובאותו מיקום במספר
        // לדוגמא 1357
        // 1247
        // יוחזר 2 מכיוון שהספרות 1 ו 7 זהות ובאותו מיקום

        // יש לכתוב קטע קוד הקולט ציונים של 10 תלמידים
        // התככית תדפיס את הממוצע של כל התלמידים
        // ואת הממוצע של התלמידים שקיבלו מתחת ל-60

        // ערוך את קטע הקוד מעלה כך שלא ידוע כמה תלמידים יש 
        // הקלט ייפסק כאשר נקלט מספר שלילי


        // יש לכתוב קטע קוד מספר שלם ומדפיס אם סכום ספרותיו זוגי



        // יש לכתוב קטע קוד הקולט מספר שלם ומדפיסה את סכום ספרותיו הזוגיות

        // יש לכתוב קטע קוד הקולט מספר שלם ומדפיס את אורך המספר


        // יש לכתוב קטע קוד הקולט שני מספרים ומחזיר את המספר בעל יותר ספרות מבין 
        // - המספרים. אם אורכם שווה יוחזר 1


        // יש לכתוב קטע קוד הקולט שני מספרים ומחזיר כמה מהספרות הן זהות\
        // ובאותו מיקום במספר
        // לדוגמא 1357
        // 1247
        // יוחזר 2 מכיוון שהספרות 1 ו 7 זהות ובאותו מיקום

        // יש לכתוב קטע קוד הקולט ציונים של 10 תלמידים
        // התכהית תדפיס את הממוצע של כל התלמידים
        // ואת הממוצע של התלמידים שקיבלו מתחת ל-60

        // ערוך את קטע הקוד מעלה כך שלא ידוע כמה תלמידים יש 
        // הקלט ייפסק כאשר נקלט מספר שלילי


        // מספר חגיגי" הוא מספר שסכום ספרותיו זוגי"
        // ולפחות 3 ספרות הן זוגיות
        // יש לכתוב תכנית הקולטת מספר ומדפיסה האם הוא חגיגי


        public static void Ex5()

        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int sumDigits = 0;
            int counterEvenDigits = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sumDigits += digit;
                if (digit % 2 == 0)
                {
                    counterEvenDigits++;
                }
                num /= 10;
            }
            if (sumDigits % 2 == 0 && counterEvenDigits >= 3)
            {
                Console.WriteLine("HAGIGI");
            }
            else
            {
                Console.WriteLine("NOT HAGIGI ");
            }
        }


        // יש לכתוב קטע קוד הקולט מספר ומדפיס את הספרה הגדולה ביותר במספר
        static void Main(string[] args)
        {


           // int sum = 0;
            //for (int i = 0; i <= 7; i++)
            //{
                 
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            Ex5();
        }

    }
}
