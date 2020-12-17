using System;
using System.Collections.Generic;
using System.Text;

namespace FatemeLibrary
{
    public class clsStudent
    {
        private string vName;
        private clsDate vBirthDate;
        private string vNumber;

        public clsStudent(string aNumber, string aName, short aDay, short aMonth, short aYear)
        {
            Name = aName;
            Number = aNumber;
            BirthDate = new clsDate(aDay, aMonth, aYear);
        }

        public clsStudent()
        {
            Name = "Not Defined";
            Number = "Not Defined";
            BirthDate = new clsDate();
        }

        public string Number
        {
            get => default;
            set
            {
            }
        }

        public string Name
        {
            get => vName;
            set
            {
                vName = value;
            }
        }


        public clsDate BirthDate
        {
            get => vBirthDate;
            set
            {
                vBirthDate = value;
            }
        }

        public string Display()
        {
            return "\nNumber: " + Number + "\nName: " + Name + "\nBirthDate: " + BirthDate.toStandard();
        }
    }
}