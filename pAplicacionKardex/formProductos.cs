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
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
