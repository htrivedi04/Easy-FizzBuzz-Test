using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestProj_FizzBuzz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FizzBuzz();
    }


    protected void FizzBuzz()
    {
        string msg = "";
        for (int i = 1; i <= 100; i++)
        {
            
            if (i % 3 == 0)
            {
                msg += "Fizz ";
            }
            if (i % 5 == 0)
            {
                msg += "Buzz";
            }
            //else msg = "";
            if (msg == "")
                lblResult.Text += i;
            else lblResult.Text += msg;
            lblResult.Text += "<br/>";
            msg = "";
        }
    }
   
}