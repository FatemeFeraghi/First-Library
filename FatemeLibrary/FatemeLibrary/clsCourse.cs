using System;
using System.Collections.Generic;
using System.Text;

namespace FatemeLibrary
{
    public class clsCourse
    {
        private string vNumber;
        private string vTitle;
        private Dictionary<string,clsStudent> vStudents;

        public clsCourse(string aNumber, string aTitle)
        {
            Number = aNumber;
            Title = aTitle;
            Students = new Dictionary<string, clsStudent>();
        }

        public clsCourse()
        {
            vNumber = vTitle = "Not Defined";
            vStudents = new Dictionary<string, clsStudent>();
        }

        public string Number
        {
            get => vNumber;
            set
            {
                vNumber = value;
            }
        }

        public string Title
        {
            get => vTitle;
            set
            {
                vTitle = value;
            }
        }

        public Dictionary<string,clsStudent> Students
        {
            get => vStudents;
            set
            {
                vStudents = value;
            }
        }

        public string Display()
        {
            string info = "\nCourse Number: " + Number;
            info += "\nCourse Title: " + Title;
            info += "\nThe students of the course: \n";
            foreach(clsStudent st in Students.Values)
            {
                info += st.Display();
            }
            return info;
        }

        public bool AddStudent(clsStudent aStudent)
        {
            if(Students.ContainsKey(aStudent.Number) == false)
            {
                Students.Add(aStudent.Number, aStudent);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function that will find student in the list of student from this course else will return null
        /// </summary>
        public clsStudent FindStudent(string number)
        {
            if(Students.ContainsKey(number))
            {
                return Students[number];
            }
            return null;
        }
    }
}