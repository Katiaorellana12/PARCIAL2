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
    public partial class perfilusuario : Form
    {
        public perfilusuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void perfilusuario_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

           




            }
        }
    }
    

