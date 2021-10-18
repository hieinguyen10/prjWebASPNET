using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.BLL;
using MidtermSample_ASPWebApplication.DAL;
using System.Data.SqlClient;

namespace MidtermSample_ASPWebApplication.DAL
{
    public class ProjectAssignmentDB
    {
        public static List<ProjectAssignment> GetAllProjectAssignments()
        {
            List<ProjectAssignment> prjAssignmentList = new List<ProjectAssignment>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("SELECT * FROM ProjectAssignments", conn);
                SqlDataReader reader = cmdListRecord.ExecuteReader();

                ProjectAssignment prjAssignment;

                while (reader.Read())
                {
                    prjAssignment = new ProjectAssignment();

                    prjAssignment.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    prjAssignment.ProjectCode = reader["ProjectCode"].ToString();
                    prjAssignment.AssignedDate = reader["AssignedDate"].ToString();
                    prjAssignment.SubmittedDate = reader["SubmittedDate"].ToString();

                    prjAssignmentList.Add(prjAssignment);
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
            return prjAssignmentList;
        }

        public static void AssignedProject(ProjectAssignment prjAs)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();

            cmdInsert.CommandText = "INSERT INTO ProjectAssignments (StudentNumber,ProjectCode,AssignedDate,SubmittedDate) " +
                                    "VALUES (@StudentNumber,@ProjectCode,@AssignedDate,@SubmittedDate)";
            cmdInsert.Parameters.AddWithValue("@StudentNumber", prjAs.StudentNumber);
            cmdInsert.Parameters.AddWithValue("@ProjectCode", prjAs.ProjectCode);
            cmdInsert.Parameters.AddWithValue("@AssignedDate", prjAs.AssignedDate);
            cmdInsert.Parameters.AddWithValue("@SubmittedDate", prjAs.SubmittedDate);

            cmdInsert.Connection = conn;
            cmdInsert.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }

        public static List<ProjectAssignment> GetAllProjectAssignments(string prjCode)
        {
            List<ProjectAssignment> prjAssignmentList = new List<ProjectAssignment>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecordbyPrjCode = new SqlCommand();
                cmdListRecordbyPrjCode.Connection = conn;
                cmdListRecordbyPrjCode.CommandText = "SELECT * FROM ProjectAssignments " +
                                                        "WHERE ProjectCode=@ProjectCode";
                cmdListRecordbyPrjCode.Parameters.AddWithValue("@ProjectCode", prjCode);

                SqlDataReader reader = cmdListRecordbyPrjCode.ExecuteReader();

                ProjectAssignment prjAssignment;

                while (reader.Read())
                {
                    prjAssignment = new ProjectAssignment();

                    prjAssignment.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    prjAssignment.ProjectCode = reader["ProjectCode"].ToString();
                    prjAssignment.AssignedDate = reader["AssignedDate"].ToString();
                    prjAssignment.SubmittedDate = reader["SubmittedDate"].ToString();

                    prjAssignmentList.Add(prjAssignment);
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
            return prjAssignmentList;
        }

        public static List<ProjectAssignment> GetAllProjectAssignments(int studNumber)
        {
            List<ProjectAssignment> prjAssignmentList = new List<ProjectAssignment>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecordbyPrjCode = new SqlCommand();
                cmdListRecordbyPrjCode.Connection = conn;
                cmdListRecordbyPrjCode.CommandText = "SELECT * FROM ProjectAssignments " +
                                                        "WHERE StudentNumber=@StudentNumber";
                cmdListRecordbyPrjCode.Parameters.AddWithValue("@StudentNumber", studNumber);

                SqlDataReader reader = cmdListRecordbyPrjCode.ExecuteReader();

                ProjectAssignment prjAssignment;

                while (reader.Read())
                {
                    prjAssignment = new ProjectAssignment();

                    prjAssignment.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    prjAssignment.ProjectCode = reader["ProjectCode"].ToString();
                    prjAssignment.AssignedDate = reader["AssignedDate"].ToString();
                    prjAssignment.SubmittedDate = reader["SubmittedDate"].ToString();

                    prjAssignmentList.Add(prjAssignment);
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
            return prjAssignmentList;
        }
    }
}