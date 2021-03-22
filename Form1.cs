using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Now;
            DateTime Za100Dni = datum.AddDays(100);
            MessageBox.Show("Dnesni datum: " + datum);
            MessageBox.Show("Datum za 100 dni: " + Za100Dni);
        }
    }
}
