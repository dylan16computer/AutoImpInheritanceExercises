using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Person
    {
        public string Fname{ get; set; }
        public string Lname{ get; set; }
    }
    class Student:Person
    {
        public int StudentID { get; set; }
        public string GetStdtDeets()
        {
            return $"\nFirst Name: {Fname}\nLast Name: {Lname}\nStudent ID: {StudentID}\n";
        }
        public Student(string _fname, string _lname, int _stdid)
        {
            Fname = _fname;
            Lname = _lname;
            StudentID = _stdid;
        }
    }
    class Employee:Person
    {
        public string EmployeeID { get; set; }
    }
    class Teacher:Employee
    {
        public string Office { get; set; }
        public string GetTeachDeets()
        {
            return $"\nFirst Name: {Fname}\nLast Name: {Lname}\nEmployee ID: {EmployeeID}\nOffice: {Office}\n";
        }
        public Teacher(string _fname, string _lname, string _empid, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeID = _empid;
            Office = _office;
        }
    }
}
