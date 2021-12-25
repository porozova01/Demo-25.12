using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yulya
{
    public partial class MainForm : Form
    {
        void get_Info(ListView List)
        {
            string query = "select material.ID, material.Title, material.CountInPack, material.Unit, material.CountInStock, material.Cost, materialtype.Title from material join materialtype on material.MaterialTypeID=materialtype.ID;";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6) };
                        var listViewItem = new ListViewItem(row);
                        list.Items.Add(listViewItem);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            get_Info(list);
            this.FormClosing += Items_FormClosing;
        }
        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMat add = new AddMat("add", 0);
            add.Show();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string query = "delete from material where id = " + list.Items[list.SelectedIndices[0]].Text + ";";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                this.list.Items.Clear();
                get_Info(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chngbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMat add = new AddMat("change", Convert.ToInt32(Convert.ToString(list.Items[list.SelectedIndices[0]].Text)));
            add.Show();
        }
    }
}
