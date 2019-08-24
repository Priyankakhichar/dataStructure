
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Calendar
    {
        /*
        *  Given the month, day, and year, return which day
        *  of the week it falls on according to the Gregorian calendar.
        *  For month, use 1 for January, 2 for February, and so forth.
        *  Returns 0 for Sunday, 1 for Monday, and so forth.
        */
        public Calendar()
        {
            Console.WriteLine("please enter the month");
            int month = Utility.ReadInt();
            Console.WriteLine("please enter the year");
            int year = Utility.ReadInt();
            string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2 && IsLeapYear(year))
            {
                days[month] = 29;
            }
            Console.WriteLine("    " + months[month] + ", " + year);
            //header of calander
            Console.WriteLine(" Su  Mo  Tu  We  Th  Fr  S ");
            int d = Day(month, 1, year);
            // spaces for first row
            for (int i = 0; i < d; i++)
            {
                Console.Write("    ");
            }
           //printing the days of from i to till end
            for (int i = 1; i <= days[month]; i++)
            {
                if (i >= 1 && i < 10)
                {
                    Console.Write("  " + i + " ");
                }
                else
                {
                    Console.Write(" " + i + " ");
                }
                //this logic is for producing cursor to new line
                if (((i + d) % 7 == 0) || (i == days[month]))
                {
                    Console.WriteLine();
                }
            }
        }
        public static int Day(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12 ) % 7;
            return d0;
        }
        //function to check leap year
        public static bool IsLeapYear(int year)
        {
            if(year % 400 == 0 && year % 100 == 0)
            {
                return true;
            }
            else if( year % 100 != 0 && year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
