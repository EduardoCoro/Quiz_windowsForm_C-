using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exemploCheck
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblSelecionado.Text += DropDownList1.SelectedValue + "</br>";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            Label1.Text = "";

            if (CheckBox1.Checked)
            {
                Label1.Text += CheckBox1.Text + "<br/>";
            }
            if (CheckBox2.Checked)
            {
                Label1.Text += CheckBox2.Text+"<br/>";
            }
            if (CheckBox3.Checked)
            {
                Label1.Text += CheckBox3.Text + "<br/>";
            }
        }
    }
}