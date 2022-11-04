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
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
