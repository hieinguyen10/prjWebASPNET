using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.DAL;

namespace MidtermSample_ASPWebApplication.BLL
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public List<Student> ListAllStudent()
        {
            return StudentDB.GetRecordList();
        }

        public Student CheckStudentbyId (int studId)
        {
            return StudentDB.GetStudentbyId(studId);
        }
    }
}