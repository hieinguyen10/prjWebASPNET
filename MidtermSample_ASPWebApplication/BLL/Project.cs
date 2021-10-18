using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.DAL;

namespace MidtermSample_ASPWebApplication.BLL
{
    public class Project
    {
        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public string DueDate { get; set; }

        public List<Project> listAllProjects()
        {
            return ProjectDB.GetRecordList();
        }

        public Project GetProject(string projectCode)
        {
            return ProjectDB.GetProject(projectCode);
        }
    }
}