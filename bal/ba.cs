using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using bel;
using System.Data;


namespace bal
{
    public class ba
    {
        da d = new da();
        public DataSet getdata()
        {
            return d.getdata();
        }

        public void insertdata(be e)
        {
            d.insertdata(e);
        }
        public void  deletedata(be e)
        {
            d.deletedata(e);
        }
        public be searchdata(be e)
        {
            return d.searchdata(e);
        }

        public int updatedata(be e)
        {
            return d.update(e);
        }
    }
}
