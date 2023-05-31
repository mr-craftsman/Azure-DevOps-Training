using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WApp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNumber1.Text);
            int b = Convert.ToInt32(txtNumber1.Text);

            int result = a + b ;

            lblResult.Text = result.ToString();

        }
    }
}