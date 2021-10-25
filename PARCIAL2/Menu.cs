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
    public partial class Menu : Form
    {
        public static string _NOMBRE_DE_USUARIO;

        int tipousuario;
        public Menu()
        {
            InitializeComponent();

       

       
        }



    

           
           
        
        
           
        private void button1_Click(object sender, EventArgs e)
        {
            Users Users = new Users();
                Users.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logs logs = new logs();
            logs.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
          
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿DESEA SALIR?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {

                Close();
            }
        }

        private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void iRALLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perfiladmin perfiladmin = new perfiladmin();
            perfiladmin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            perfilusuario perfilusuario = new perfilusuario();
            perfilusuario.Show();
            this.Hide();
        }
       

    }
}
