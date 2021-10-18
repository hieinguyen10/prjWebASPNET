using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.BLL;
using MidtermSample_ASPWebApplication.DAL;

namespace MidtermSample_ASPWebApplication.BLL
{
    public class Teacher
    {
        //private int teacherNumber;
        //private string firstName;
        //private string lastName;
        //private string passWord;

        //private int TeacherNumber { get => teacherNumber; set => TeacherNumber = value; }//

        public int TeacherNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public Teacher CheckTeacherbyId(int teacherId)
        {
            return TeacherDB.GetTeacherbyId(teacherId);
        }
    }
}