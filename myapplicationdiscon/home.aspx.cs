using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using bal;
using bel;
namespace myapplicationdiscon
{
    public partial class home : System.Web.UI.Page
    {
        ba b = new ba();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataGrid1.DataSource = b.getdata();
            DataGrid1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            be bee = new be { fname = TextBox2.Text, lname = TextBox3.Text, email = TextBox4.Text, phone = TextBox5.Text };
            b.insertdata(bee);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            be bee = new be { id = Convert.ToInt16(TextBox1.Text) };
            b.deletedata(bee);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            be bee = new be { id = Convert.ToInt16(TextBox1.Text) };
            be dd=b.searchdata(bee);
            TextBox2.Text = dd.fname.ToString();
            TextBox3.Text = dd.lname.ToString();
            TextBox4.Text = dd.ToString();
            TextBox5.Text = dd.ToString();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            be be = new be { id = Convert.ToInt32(TextBox1.Text), fname = TextBox2.Text.ToString(), lname = TextBox3.Text.ToString(), email = TextBox4.Text.ToString(), phone = TextBox5.Text.ToString() };
            int a = b.updatedata(be);
            if (a > 0)
            {
                Response.Write("data updated");
            }
            else
            {
                Response.Write("data not updated");
            }
        }
    }
}