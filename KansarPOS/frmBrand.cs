﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KansarPOS
{
    public partial class frmBrand : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        frmBrandList frmlist;
        public frmBrand(frmBrandList flist)
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection());
            frmlist = flist;
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure want to save the brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SQLiteCommand("INSERT INTO tblBrand(Brand) VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.");
                    Clear();
                    frmlist.LoadRecords();
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this brand?", "Update Record", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SQLiteCommand("update tblbrand set brand = @brand where id like '" + lblID.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Brand has been successfully updated.");
                Clear();
                frmlist.LoadRecords();
                this.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
