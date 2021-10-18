using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.BLL;
using MidtermSample_ASPWebApplication.DAL;
using System.Data.SqlClient;


namespace MidtermSample_ASPWebApplication.DAL
{
    public static class StudentDB
    {
        public static List<Student> GetRecordList()
        {
            List<Student> list = new List<Student>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Students", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                
                Student std;

                while (reader.Read())
                {
                    std = new Student();
                    std.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    std.FirstName = reader["FirstName"].ToString();
                    std.LastName = reader["LastName"].ToString();
                    std.Password = reader["Password"].ToString();
                    list.Add(std);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return list;
        }
        public static Student GetStudentbyId(int studId)
        {
            Student stud = new Student();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conn;
            cmdSelect.CommandText = "SELECT * FROM Students " +
                                    "WHERE StudentNumber = @StudentNumber";
            cmdSelect.Parameters.AddWithValue("@StudentNumber", studId);
            SqlDataReader reader = cmdSelect.ExecuteReader();
            if (reader.Read())
            {
                stud.StudentNumber = studId;
                stud.FirstName = reader["FirstName"].ToString();
                stud.LastName = reader["LastName"].ToString();
                stud.Password = reader["Password"].ToString();
                return stud;
            }

            return null;
        }
    }
}