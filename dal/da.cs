using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using bel;

namespace dal
{
    public class da
    {
        SqlConnection con;

        SqlConnection getconnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
            return con;
        }

        SqlDataAdapter dap;
        DataSet ds;
        DataRow dr;
        SqlCommandBuilder cb;

        public DataSet getdata()
        {
            dap = new SqlDataAdapter("select * from addbook ", getconnection());
            ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        public void insertdata(be b)
        {
            dap = new SqlDataAdapter("select * from addbook ", getconnection());
            cb = new SqlCommandBuilder(dap);
            ds = new DataSet();
            dap.Fill(ds);
            dr = ds.Tables[0].NewRow();
            dr[1] = b.fname;
            dr[2] = b.lname;
            dr[3] = b.email;
            dr[4] = b.phone;
            ds.Tables[0].Rows.Add(dr);
            dap.Update(ds);
            cb = new SqlCommandBuilder(dap);
        }

        public void deletedata(be b)
        {
            dap = new SqlDataAdapter("select * from addbook ", getconnection());
            ds = new DataSet();
            dap.Fill(ds);
            for( int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == b.id.ToString())
                {
                    ds.Tables[0].Rows[i].Delete();
                }
            }
            dap.Update(ds);
            cb = new SqlCommandBuilder(dap);
        }
        public be searchdata(be b)
        {
            be brr = new be();
            dap = new SqlDataAdapter("select * from addbook ", getconnection());
            ds = new DataSet();
            dap.Fill(ds);
            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == b.id.ToString())
                {
                    brr.fname = ds.Tables[0].Rows[i][1].ToString();
                    brr.lname = ds.Tables[0].Rows[i][2].ToString();
                    brr.email = ds.Tables[0].Rows[i][3].ToString();
                    brr.phone = ds.Tables[0].Rows[i][4].ToString();
                }
               
            }
            dap.Update(ds);
            cb = new SqlCommandBuilder(dap);
            return brr;

        }
        public int update (be b)
        {
            int flag = 0;
            be brr = new be();
            dap = new SqlDataAdapter("select * from addbook ", getconnection());
            ds = new DataSet();
            dap.Fill(ds);
            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                if (ds.Tables[0].Rows[i][0].ToString() == b.id.ToString())
                {
                    ds.Tables[0].Rows[i][1] = b.fname.ToString();
                    ds.Tables[0].Rows[i][2] = b.lname.ToString();
                    ds.Tables[0].Rows[i][3] = b.email.ToString();
                    ds.Tables[0].Rows[i][4] = b.phone.ToString();
                    flag = 1;
                }
                else
                {
                    return flag;
                }
                
            }
            dap.Update(ds);
            cb = new SqlCommandBuilder(dap);

            return flag;

        }
    }
}
