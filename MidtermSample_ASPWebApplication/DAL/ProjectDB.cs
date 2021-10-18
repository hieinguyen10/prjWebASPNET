using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.BLL;
using MidtermSample_ASPWebApplication.DAL;
using System.Data.SqlClient;

namespace MidtermSample_ASPWebApplication.DAL
{
    public static class ProjectDB
    {
        public static Project GetProject (string pCode)
        {
            Project prj = new Project();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conn;

            cmdSelect.CommandText = "SELECT * FROM Projects " +
                                    "WHERE ProjectCode = @ProjectCode";
            cmdSelect.Parameters.AddWithValue("ProjectCode", pCode);
            SqlDataReader reader = cmdSelect.ExecuteReader();

            if (reader.Read())
            {
                prj.ProjectCode = reader["ProjectCode"].ToString();
                prj.ProjectTitle = reader["ProjectTitle"].ToString();
                prj.DueDate = reader["DueDate"].ToString();
                return prj;
            }

            return null;
        }
        public static List<Project> GetRecordList()
        {
            List<Project> prjList = new List<Project>();
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("SELECT * FROM Projects", conn);
                SqlDataReader sqlReadRecord = cmdListRecord.ExecuteReader();

                Project prj;

                while (sqlReadRecord.Read())
                {
                    prj = new Project();
                    prj.ProjectCode = sqlReadRecord["ProjectCode"].ToString();
                    prj.ProjectTitle = sqlReadRecord["ProjectTitle"].ToString();
                    prj.DueDate = sqlReadRecord["DueDate"].ToString();
                    prjList.Add(prj);
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

            return prjList;
        }
    }
}