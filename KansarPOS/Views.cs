using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KansarPOS
{
    public class Views
    {
        public static string Stockin = @"(SELECT tblStockIn.id, tblStockIn.refno, tblStockIn.pcode, tblProduct.pdesc, tblStockIn.qty, tblStockIn.sdate, tblStockIn.stockinby, tblStockIn.status
                                        FROM tblProduct INNER JOIN
                                                tblStockIn ON tblProduct.pcode = tblStockIn.pcode)";
    }
}
