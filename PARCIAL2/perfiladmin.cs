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
    public partial class perfiladmin : Form
    {
         public static string _CONTRASEÑA;
        public perfiladmin()
        {
            InitializeComponent();

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         

           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        








        }

        private void perfiladmin_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
