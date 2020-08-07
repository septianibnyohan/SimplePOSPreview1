using System.Windows.Forms;
using System.Data.SQLite;

namespace KansarPOS
{
    public partial class Form1 : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection());
            //cn.Open();
            //MessageBox.Show("Connected");
        }

        private void btnBrand_Click(object sender, System.EventArgs e)
        {
            frmBrandList frm = new frmBrandList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnCategory_Click(object sender, System.EventArgs e)
        {
            frmCategoryList frm = new frmCategoryList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadCategory();
            frm.Show();
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            frmUserAccount frm = new frmUserAccount();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnProduct_Click(object sender, System.EventArgs e)
        {
            frmProductList frm = new frmProductList();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.LoadRecords();
            frm.Show();
            frm.txtSearch.Focus();
        }

        private void btnStockIn_Click(object sender, System.EventArgs e)
        {
            frmStockIn frm = new frmStockIn();
            
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            frm.LoadStockIn();
            
        }
    }
}
