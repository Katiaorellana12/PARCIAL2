using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL2
{
    public partial class integrantes : Form
    {
        public integrantes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
    }
    }
}
