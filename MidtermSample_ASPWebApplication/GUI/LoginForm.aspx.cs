using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MidtermSample_ASPWebApplication.VAL;
using MidtermSample_ASPWebApplication.BLL;
using MidtermSample_ASPWebApplication.DAL;
using MidtermSample_ASPWebApplication.GUI;
using System.Windows.Forms;

namespace MidtermSample_ASPWebApplication.GUI
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate

            string id = TextBoxID.Text.Trim();
            string passWord = TextBoxPassword.Text.Trim();
            // check ID
            if (DropDownList1.SelectedValue != "Student" && DropDownList1.SelectedValue != "Teacher")
            {
                MessageBox.Show("Please choose a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxID.Text = "";
                TextBoxPassword.Text = "";
                TextBoxID.Focus();
                return;
            }
            if ((!(Validation.IsValidId(id))) || (!(Validation.IsValidPassword(passWord))))
            {
                MessageBox.Show("Invalid ID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxID.Text = "";
                TextBoxPassword.Text = "";
                TextBoxID.Focus();
                return;
            }
            
            if (DropDownList1.SelectedValue == "Student")
            {
                Student stud = new Student();
                stud = stud.CheckStudentbyId(Convert.ToInt32(id));
                if (passWord == stud.Password)
                {
                    Session["ID"] = TextBoxID.Text.Trim();
                    MessageBox.Show("Login is sucessful...", "Confirmation", MessageBoxButtons.OK);
     
                    Response.Redirect("StudentForm.aspx");
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxID.Text = "";
                    TextBoxPassword.Text = "";
                    TextBoxID.Focus();
                }
            }
            else
            {
                Teacher tcher = new Teacher();
                tcher = tcher.CheckTeacherbyId(Convert.ToInt32(id));
                if (passWord == tcher.Password)
                {
                    MessageBox.Show("Login is sucessful...", "Confirmation", MessageBoxButtons.OK);

                    Response.Redirect("TeacherForm.aspx");
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxID.Text = "";
                    TextBoxPassword.Text = "";
                    TextBoxID.Focus();
                }
            }

            
        }
    }
}