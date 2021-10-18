using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermSample_ASPWebApplication.DAL;

namespace MidtermSample_ASPWebApplication.BLL
{
    public class ProjectAssignment
    {
        public int StudentNumber { get; set; }
        public string ProjectCode { get; set; }
        public string AssignedDate { get; set; }
        public string SubmittedDate { get; set; }

        public List<ProjectAssignment> listAllProjectAssignment()
        {
            return ProjectAssignmentDB.GetAllProjectAssignments();
        }

        public List<ProjectAssignment> listAllProjectAssignment(string prjCode)
        {
            return ProjectAssignmentDB.GetAllProjectAssignments(prjCode);
        }

        public List<ProjectAssignment> listAllProjectAssignment(int studNumber)
        {
            return ProjectAssignmentDB.GetAllProjectAssignments(studNumber);
        }
        public void AssignProject(ProjectAssignment prjAs)
        {
            ProjectAssignmentDB.AssignedProject(prjAs);
        }
    }
}