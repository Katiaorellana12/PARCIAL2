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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Account Account = new Account();



            dataGridView1.Columns.Add("_CODUSER", "CODUSER");
            dataGridView1.Columns.Add("_PRIMER_NOMBRE", "PRIMERNOMBRE");
            dataGridView1.Columns.Add("_PRIMER_APELLIDO", "PRIMERAPELLIDO");
            dataGridView1.Columns.Add("_CORREO", "CORREO");
            dataGridView1.Columns.Add("_FECHA_DE_REGISTRO", "FECHADEREGISTRO");
            dataGridView1.Columns.Add("_NOMBRE_DE_USUARIO", "NOMBREDEUSUARIO");
            dataGridView1.Columns.Add("_CONTRASEÑA", "CONTRASEÑA");

            if (button1.Enabled)
            { 
            MySqlDataReader dataReader = Account.LogWithoutAdmin();

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(

                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5),
                        dataReader.GetValue(6)
                       );
            }
        }

            
            
               


        }
        
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

    }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
    
        }
        
    }
        }
    
    

