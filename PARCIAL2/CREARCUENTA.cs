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
    public partial class CREARCUENTA : Form
    {
        public CREARCUENTA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            if (maskedTextBox5.Text != maskedTextBox6.Text)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Las contraseñas no son iguales", "Nueva cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if  (maskedTextBox1.Text == "")
            {
                maskedTextBox1.Focus();
                errorProvider1.SetError(maskedTextBox1, "Escriba un nombre");
            }
            else if (maskedTextBox2.Text == "")
            {
                maskedTextBox2.Focus();
                errorProvider1.SetError(maskedTextBox2, "Escriba un apellido");
            }
            else if (maskedTextBox3.Text == "")
            {
                maskedTextBox3.Focus();
                errorProvider1.SetError(maskedTextBox3, "Escriba un correo");
            }
            else if (maskedTextBox4.Text == "")
            {
                maskedTextBox4.Focus();
                errorProvider1.SetError(maskedTextBox4, "Escriba un usuario");
            }
            else if (maskedTextBox5.Text == "")
            {
                maskedTextBox5.Focus();
                errorProvider1.SetError(maskedTextBox5, "Escriba una contraseña");
            }
            else if (maskedTextBox6.Text == "")
            {
                maskedTextBox6.Focus();
                errorProvider1.SetError(maskedTextBox6, "Escriba una contraseña");
            }
            else
            {
                Account Account = new Account();
          
                Account.getAll();
                Account._PRIMER_NOMBRE = maskedTextBox1.Text;
                Account._PRIMER_APELLIDO = maskedTextBox2.Text;
                Account._CORREO = maskedTextBox3.Text;
                Account._FECHA_DE_REGISTRO = DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss");
                Account._NOMBRE_DE_USUARIO = maskedTextBox4.Text;
                Account._CONTRASEÑA = maskedTextBox5.Text;
                Account.REGISTRARCUENTA();
               
                MetroFramework.MetroMessageBox.Show(this,
                    "Usuario registrado", "Nueva cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();

               

            }
        }
       
    }
}
