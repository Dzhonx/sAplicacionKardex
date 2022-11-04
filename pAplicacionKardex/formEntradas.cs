using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAplicacionKardex
{
    public partial class formEntradas : Form
    {
        public formEntradas()
        {
            InitializeComponent();
        }

        private void btnSalirEntrada_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
