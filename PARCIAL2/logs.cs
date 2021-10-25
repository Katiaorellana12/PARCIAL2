using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PARCIAL2
{
    public partial class logs : Form
    {
        public logs()
        {
            InitializeComponent();
        }
        private void logs_Load(object sender, EventArgs e)
        {
            filldata();
        }

        public void filldata()
        {

            cleardatagrid();

            Account Account = new Account();
            dataGridView1.Columns.Add("_NOMBRE_DE_USUARIO", "NOMBREDEUSUARIO");
            dataGridView1.Columns.Add("_TIMELOGGEDIN", "TIMELOGGEDIN");

            if (metroToggle1.Checked)
            {
                MySqlDataReader dataReader = Account.getLog();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                        );
                }
            }
            else
            {
                MySqlDataReader dataReader = Account.getLogWithoutAdmin();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                        );


                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void cleardatagrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            filldata();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }

}
