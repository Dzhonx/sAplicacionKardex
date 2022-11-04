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
    public partial class formInventario : Form
    {
        public formInventario()
        {
            InitializeComponent();
        }

        int lx, ly;
        int sw, sh;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de cerrar el programa?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formEntradas>();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formSalida>();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formProductos>();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formTablaInventario>();
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formKardex>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formClientes>();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularios<formProveedores>();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            // Por implementar...
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // ABRIR FORMULARIOS
        private void AbrirFormularios<formularioAbrir>() where formularioAbrir:Form, new()
        {
            Form Formularios;
            Formularios = panelContenedor.Controls.OfType<formularioAbrir>().FirstOrDefault();
            if(Formularios == null)
            {
                Formularios = new formularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                panelContenedor.Controls.Add(Formularios);
                panelContenedor.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }
        }
    }
}
