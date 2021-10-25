using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PARCIAL2
{
    public partial class Form1 : Form
    {
        
        public string _NOMBRE_DE_USUARIO { get; set; }

        public Form1()
        {
            InitializeComponent();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CREARCUENTA CREARCUENTA = new CREARCUENTA();
            CREARCUENTA.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Account login = new Account();
            login._NOMBRE_DE_USUARIO = maskedTextBox1.Text;
            login._CONTRASEÑA = maskedTextBox2.Text;



            if (login.login())
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "BIENVENIDO", "USUARIO YA REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login.Insertarlog();
                _NOMBRE_DE_USUARIO = maskedTextBox1.Text;

                Menu Menu = new Menu();
                Menu.Visible = true;
                this.Visible = false;

               
              
            } 
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                   "NOMBBRE DE USUARIO O CONTRASEÑA NO REGISTRADOS ", "ENTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            if (maskedTextBox1.Text == "")
            {
                maskedTextBox1.Focus();
                errorProvider1.SetError(maskedTextBox1, "Escriba un nombre");
            }

            else if (maskedTextBox2.Text == "")
            {
                maskedTextBox1.Focus();
                errorProvider2.SetError(maskedTextBox1, "Escriba un nombre");
            }
           

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

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            integrantes integrantes = new integrantes();
            integrantes.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
 