using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac5_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text.ToUpper();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = TextBox1.Text.ToLower();
        }
    }
}