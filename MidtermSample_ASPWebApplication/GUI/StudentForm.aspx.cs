using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MidtermSample_ASPWebApplication.GUI;
using MidtermSample_ASPWebApplication.DAL;
using MidtermSample_ASPWebApplication.BLL;
using System.Windows.Forms;

namespace MidtermSample_ASPWebApplication.GUI
{
    public partial class StudentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int studId = Convert.ToInt32(Session["ID"].ToString());
            
            Student stud = new Student();
            stud = stud.CheckStudentbyId(studId);

            lblStudentId.Text = Session["ID"].ToString();
            lblFirstName.Text = stud.FirstName;
            lblLastName.Text = stud.LastName;

            ProjectAssignment prjAs = new ProjectAssignment();
            List<ProjectAssignment> list = prjAs.listAllProjectAssignment(studId);
            GridView1.DataSource = list;
            GridView1.DataBind();

            
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