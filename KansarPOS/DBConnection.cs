using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KansarPOS
{
    class DBConnection
    {
        public string MyConnection()
        {
            //string con = "URI=file:C:\\ProjectDev\\KansarPOS\\KansarPOS\\Database\\seppos.db";
            string con = "URI=file:seppos.db";
            return con;
        }
    }
}
