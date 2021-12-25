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
    public partial class AddMat : Form
    {
        public string modeS = "";
        int item;
        void setMode(string mode)
        {
            if (mode == "add")
            {
                Addbutton.Text = "Добавить";
            }
            else if (mode == "change")
            {

                Addbutton.Text = "Редактировать";
                string Info = "select Title, CountInPack, Unit, CountInStock, Cost, MaterialTypeID from material where id =" + item.ToString() + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmInfo = new MySqlCommand(Info, conn);
                MySqlDataReader inRead;
                cmInfo.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    inRead = cmInfo.ExecuteReader();
                    if (inRead.HasRows)
                    {
                        while (inRead.Read())
                        {
                            NameBox.Text = inRead.GetString(0);
                            TypeBox.Text = inRead.GetString(1);
                            PriceBox.Text = inRead.GetString(2);
                            SkladBox.Text = inRead.GetString(2);
                            PackBox.Text = inRead.GetString(2);
                            EdBox.Text = inRead.GetString(2);

                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public AddMat(string mode, int id)
        {
            InitializeComponent();


            modeS = mode;
            item = id;
            setMode(mode);

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void addbut_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                MessageBox.Show("Введите название материала");
                return;
            }

            if (TypeBox.Text == "")
            {
                MessageBox.Show("Введите тип материала");
                return;
            }

            if (PriceBox.Text == "")
            {
                MessageBox.Show("Введите цену материала");
                return;
            }

            if (SkladBox.Text == "")
            {
                MessageBox.Show("Введите количество материала на складе");
                return;
            }

            if (PackBox.Text == "")
            {
                MessageBox.Show("Введите количество материала в упаковке");
                return;
            }

            if (EdBox.Text == "")
            {
                MessageBox.Show("Введите единицу измерения материала");
                return;
            }



            if (modeS == "add")
            {
                string query = "insert into material(Title, CountInPack, Unit, CountInStock, Cost, MaterialTypeID) values('" + NameBox.Text + "', '" + TypeBox.Text + "', '" + PriceBox.Text + "', '" + SkladBox.Text + "', '" + PackBox.Text + "', '" + EdBox.Text + "');";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Материал добавлен.");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Материал не добавлен.");
                    MessageBox.Show(ex.Message);
                }
            }
            if (modeS == "change")
            {

                string query = "update material set Title ='" + NameBox.Text + "', CountInPack='" + PackBox.Text + "', Unit='" + EdBox.Text + "', CountInStock='" + SkladBox.Text + "', Cost='" + PriceBox.Text + "', MaterialTypeID='" + TypeBox.Text + "' where id = " + item.ToString() + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Материал изменен.");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();


                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Материал не изменен.");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
   