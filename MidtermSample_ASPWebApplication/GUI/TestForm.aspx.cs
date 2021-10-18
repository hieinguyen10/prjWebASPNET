using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;   // use MessageBox
using MidtermSample_ASPWebApplication.DAL;

// use MessageBox


namespace MidtermSample_ASPWebApplication.GUI
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnConnectDB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database Connect is " + UtilityDB.ConnectDB().State.ToString());
        }
    }
}