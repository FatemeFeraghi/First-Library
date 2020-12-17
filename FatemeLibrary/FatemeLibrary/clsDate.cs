using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatemeLibrary
{
    public class clsDate
    {
        //Declaration of private field that will hold the values of properties
        private Int16 varDay;
        private Int16 varMonth;
        private Int16 varYear;

        // Constructors, event that is triggered when the object is created with the 'new' keyword
        // Constructor1,without parameters
        public clsDate()
        {
            varDay = 1;
            varMonth = 1;
            varYear = 1;
        }

        // Constructor2,with 1 parameter
        public clsDate(Int16 aDay)
        {
            Day = aDay;
            varMonth = (Int16)DateTime.Today.Month;
            varYear = (Int16)DateTime.Today.Year;
        }

        // Constructor3,with 2 parameter
        public clsDate(Int16 aDay, Int16 aMonth)
        {
            Day = aDay;
            Month = aMonth;
            varYear = (Int16)DateTime.Today.Year;
        }

        // Constructor4,with 3 parameter
        public clsDate(Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Day = aDay;
            Month = aMonth;
            varYear = aYear;
        }

        //Declaration of public access methods to properties to do some validations .To access to real properties we need public properties means Day
        public Int16 Day
        {
            //Access for reading
            get
            {
                return varDay;
            }
            //Access for writting values into our real properties means varDay .this is where we are doing validation
            set
            {
                varDay = (value > 0 && value < 32) ? value : (Int16)DateTime.Today.Day;
            }
        }

        public Int16 Month
        {
            get
            {
                return varMonth;
            }

            set
            {
                varMonth = (value > 0 && value < 13) ? value : (Int16)DateTime.Today.Month;
            }
        }
        public Int16 Year
        {
            get
            {
                return varYear;
            }

            set
            {
                varYear = (value > 0) ? value : (Int16)DateTime.Today.Year;
            }
        }

        public void Initialize(Int16 aDay, Int16 aMonth, Int16 aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        public String toUniversal()
        {
            return Day + "/" + Month + "/" + Year;
        }

        public String toStandard()
        {
            String[] tabDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            DateTime temp = new DateTime(Year, Month, Day);
            String info = tabDays[Convert.ToInt32(temp.DayOfWeek)];

            String[] tabMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            info += tabMonths[Month] + " ";
            info += Day + " , " + Year;
            return info;
        }

    }
}
