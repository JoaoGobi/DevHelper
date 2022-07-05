using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontHelper
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var geraControls = new GeraForm();
            geraControls.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var geraTexto = new GeraTexto();
            geraTexto.Show();
        }
    }
}
