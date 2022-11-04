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
    public partial class formTablaInventario : Form
    {
        public formTablaInventario()
        {
            InitializeComponent();
        }

        private void btnSalirTablaInventario_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
