using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.DAL;
using MidtermSample_ASPWebApplication.BLL;
using System.Data.SqlClient;

namespace MidtermSample_ASPWebApplication.DAL
{
    public static class TeacherDB
    {
        public static Teacher GetTeacherbyId(int teacherId)
        {
            Teacher tcher = new Teacher();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conn;
            cmdSelect.CommandText = "SELECT * FROM Teachers " +
                                    "WHERE TeacherNumber = @TeacherNumber";
            cmdSelect.Parameters.AddWithValue("@TeacherNumber", teacherId);
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader.Read())
            {
                tcher.TeacherNumber = teacherId;
                tcher.FirstName = reader["FirstName"].ToString();
                tcher.LastName = reader["LastName"].ToString();
                tcher.Password = reader["Password"].ToString();
                return tcher;
            }

            return null;
        }


    }
}