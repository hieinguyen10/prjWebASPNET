using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MidtermSample_ASPWebApplication.DAL;
using MidtermSample_ASPWebApplication.BLL;
using MidtermSample_ASPWebApplication.GUI;
using System.Windows.Forms;

namespace MidtermSample_ASPWebApplication.GUI
{
    public partial class TeacherForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                Student stud = new Student();
                List<Student> list = stud.ListAllStudent();

                foreach (Student s in list)
                {
                    DropDownListStudent.Items.Add(s.StudentNumber + "- " + s.FirstName + ", " + s.LastName);
                }

                Project aprj = new Project();
                List<Project> prjList = aprj.listAllProjects();
                foreach (Project p in prjList)
                {
                    DropDownListProject.Items.Add(p.ProjectCode + "- " + p.ProjectTitle + "- " + p.DueDate);
                }    
            }

        }

        protected void btnListProject_Click(object sender, EventArgs e)
        {
            if (DropDownListProject.Text == "")
            {
                MessageBox.Show("Please select a project", "Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string prj = DropDownListProject.Text.Trim().ToString();
            string[] sep = { ", ", "- " };
            string[] pro = prj.Split(sep , StringSplitOptions.RemoveEmptyEntries); // pro = {prjCode, prjTitle, DueDate}
                                                                                  //          0         1         2
            ProjectAssignment prjAs = new ProjectAssignment();
            List<ProjectAssignment> list = prjAs.listAllProjectAssignment(pro[0].ToString());
            GridViewListInfor.DataSource = list;
            GridViewListInfor.DataBind();
            
        }

        protected void btnListStudent_Click(object sender, EventArgs e)
        {
            if (DropDownListStudent.Text == "")
            {
                MessageBox.Show("Please select a student", "Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string stud = DropDownListStudent.Text.Trim().ToString();
            string[] sep = {"- ", ", " };
            string[] student = stud.Split(sep, StringSplitOptions.RemoveEmptyEntries); // student = {stud, Firstname, Lastname}
                                                                                  //          0         1         2
            ProjectAssignment prjAs = new ProjectAssignment();
            List<ProjectAssignment> list = prjAs.listAllProjectAssignment(Convert.ToInt32(student[0]));
            GridViewListInfor.DataSource = list;
            GridViewListInfor.DataBind();
        }

        protected void btnAssignProject_Click(object sender, EventArgs e)
        {
            string input = DropDownListStudent.SelectedValue;
            string[] field = input.Split(',', '-');
            int id = Convert.ToInt32(field[0]);

            string input2 = DropDownListProject.SelectedValue;
            string[] field2 = input2.Split('-', ',');
            string code = field2[0];

            ProjectAssignment prjAs = new ProjectAssignment();
            List<ProjectAssignment> listPA = prjAs.listAllProjectAssignment();

            foreach (ProjectAssignment pa in listPA)
            {
                if ((id == pa.StudentNumber) && (code == pa.ProjectCode))
                {
                    MessageBox.Show("This project has been assigned for this student.", "Already assigned");
                    return;
                }
            }

            prjAs.StudentNumber = id;
            prjAs.ProjectCode = code;
            prjAs.AssignedDate = CalendarAssignedDate.SelectedDate.ToString();
            prjAs.SubmittedDate = " ";
            prjAs.AssignProject(prjAs);
            MessageBox.Show("Project Assign.", "Confirmation", MessageBoxButtons.OK);
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to remove this Employee ?", "Confirmation",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Response.Redirect("LoginForm.aspx");
            }
        }
    }
}