
namespace pAplicacionKardex
{
    partial class formInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProveedores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKardex = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSalidas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEntradas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelContenedor);
            this.panel1.Controls.Add(this.panelInferior);
            this.panel1.Controls.Add(this.panelPrincipal);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContenedor.Location = new System.Drawing.Point(236, 86);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(952, 548);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(230, 640);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(970, 60);
            this.panelInferior.TabIndex = 2;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Orange;
            this.panelPrincipal.Controls.Add(this.btnRestaurar);
            this.panelPrincipal.Controls.Add(this.btnMaximizar);
            this.panelPrincipal.Controls.Add(this.btnMinimizar);
            this.panelPrincipal.Controls.Add(this.btnCerrar);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrincipal.Location = new System.Drawing.Point(230, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(970, 80);
            this.panelPrincipal.TabIndex = 1;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(890, 27);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(24, 24);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(890, 27);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(24, 24);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(860, 27);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(920, 27);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMenu.Controls.Add(this.btnConfiguracion);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnKardex);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnSalidas);
            this.panelMenu.Controls.Add(this.btnEntradas);
            this.panelMenu.Controls.Add(this.bunifuImageButton6);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnConfiguracion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.BorderRadius = 0;
            this.btnConfiguracion.ButtonText = "CONFIGURACION";
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfiguracion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Iconimage")));
            this.btnConfiguracion.Iconimage_right = null;
            this.btnConfiguracion.Iconimage_right_Selected = null;
            this.btnConfiguracion.Iconimage_Selected = null;
            this.btnConfiguracion.IconMarginLeft = 0;
            this.btnConfiguracion.IconMarginRight = 0;
            this.btnConfiguracion.IconRightVisible = true;
            this.btnConfiguracion.IconRightZoom = 0D;
            this.btnConfiguracion.IconVisible = true;
            this.btnConfiguracion.IconZoom = 90D;
            this.btnConfiguracion.IsTab = false;
            this.btnConfiguracion.Location = new System.Drawing.Point(12, 477);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnConfiguracion.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnConfiguracion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfiguracion.selected = false;
            this.btnConfiguracion.Size = new System.Drawing.Size(201, 48);
            this.btnConfiguracion.TabIndex = 12;
            this.btnConfiguracion.Text = "CONFIGURACION";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Textcolor = System.Drawing.Color.White;
            this.btnConfiguracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnProveedores.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedores.BorderRadius = 0;
            this.btnProveedores.ButtonText = "PROVEEDORES";
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.DisabledColor = System.Drawing.Color.Gray;
            this.btnProveedores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProveedores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Iconimage")));
            this.btnProveedores.Iconimage_right = null;
            this.btnProveedores.Iconimage_right_Selected = null;
            this.btnProveedores.Iconimage_Selected = null;
            this.btnProveedores.IconMarginLeft = 0;
            this.btnProveedores.IconMarginRight = 0;
            this.btnProveedores.IconRightVisible = true;
            this.btnProveedores.IconRightZoom = 0D;
            this.btnProveedores.IconVisible = true;
            this.btnProveedores.IconZoom = 90D;
            this.btnProveedores.IsTab = false;
            this.btnProveedores.Location = new System.Drawing.Point(12, 423);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnProveedores.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnProveedores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProveedores.selected = false;
            this.btnProveedores.Size = new System.Drawing.Size(201, 48);
            this.btnProveedores.TabIndex = 11;
            this.btnProveedores.Text = "PROVEEDORES";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Textcolor = System.Drawing.Color.White;
            this.btnProveedores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnClientes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(12, 369);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnClientes.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(201, 48);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnKardex
            // 
            this.btnKardex.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnKardex.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKardex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKardex.BorderRadius = 0;
            this.btnKardex.ButtonText = "KARDEX";
            this.btnKardex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKardex.DisabledColor = System.Drawing.Color.Gray;
            this.btnKardex.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKardex.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKardex.Iconimage")));
            this.btnKardex.Iconimage_right = null;
            this.btnKardex.Iconimage_right_Selected = null;
            this.btnKardex.Iconimage_Selected = null;
            this.btnKardex.IconMarginLeft = 0;
            this.btnKardex.IconMarginRight = 0;
            this.btnKardex.IconRightVisible = true;
            this.btnKardex.IconRightZoom = 0D;
            this.btnKardex.IconVisible = true;
            this.btnKardex.IconZoom = 90D;
            this.btnKardex.IsTab = false;
            this.btnKardex.Location = new System.Drawing.Point(12, 315);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnKardex.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnKardex.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKardex.selected = false;
            this.btnKardex.Size = new System.Drawing.Size(201, 48);
            this.btnKardex.TabIndex = 9;
            this.btnKardex.Text = "KARDEX";
            this.btnKardex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKardex.Textcolor = System.Drawing.Color.White;
            this.btnKardex.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardex.Click += new System.EventHandler(this.btnKardex_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnInventario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "TABLA INVENTARIO";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventario.Iconimage")));
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 90D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(12, 261);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnInventario.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(201, 48);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "TABLA INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnProductos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "PRODUCTOS";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = null;
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 90D;
            this.btnProductos.IsTab = false;
            this.btnProductos.Location = new System.Drawing.Point(12, 207);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnProductos.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(201, 48);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Textcolor = System.Drawing.Color.White;
            this.btnProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnSalidas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalidas.BorderRadius = 0;
            this.btnSalidas.ButtonText = "SALIDAS";
            this.btnSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidas.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalidas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalidas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalidas.Iconimage")));
            this.btnSalidas.Iconimage_right = null;
            this.btnSalidas.Iconimage_right_Selected = null;
            this.btnSalidas.Iconimage_Selected = null;
            this.btnSalidas.IconMarginLeft = 0;
            this.btnSalidas.IconMarginRight = 0;
            this.btnSalidas.IconRightVisible = true;
            this.btnSalidas.IconRightZoom = 0D;
            this.btnSalidas.IconVisible = true;
            this.btnSalidas.IconZoom = 90D;
            this.btnSalidas.IsTab = false;
            this.btnSalidas.Location = new System.Drawing.Point(12, 153);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSalidas.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnSalidas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalidas.selected = false;
            this.btnSalidas.Size = new System.Drawing.Size(201, 48);
            this.btnSalidas.TabIndex = 6;
            this.btnSalidas.Text = "SALIDAS";
            this.btnSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidas.Textcolor = System.Drawing.Color.White;
            this.btnSalidas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnEntradas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntradas.BorderRadius = 0;
            this.btnEntradas.ButtonText = "ENTRADAS";
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.DisabledColor = System.Drawing.Color.Gray;
            this.btnEntradas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEntradas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEntradas.Iconimage")));
            this.btnEntradas.Iconimage_right = null;
            this.btnEntradas.Iconimage_right_Selected = null;
            this.btnEntradas.Iconimage_Selected = null;
            this.btnEntradas.IconMarginLeft = 0;
            this.btnEntradas.IconMarginRight = 0;
            this.btnEntradas.IconRightVisible = true;
            this.btnEntradas.IconRightZoom = 0D;
            this.btnEntradas.IconVisible = true;
            this.btnEntradas.IconZoom = 90D;
            this.btnEntradas.IsTab = false;
            this.btnEntradas.Location = new System.Drawing.Point(12, 99);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnEntradas.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnEntradas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEntradas.selected = false;
            this.btnEntradas.Size = new System.Drawing.Size(201, 48);
            this.btnEntradas.TabIndex = 0;
            this.btnEntradas.Text = "ENTRADAS";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.Textcolor = System.Drawing.Color.White;
            this.btnEntradas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(187, 68);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 5;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelPrincipal;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.panelContenedor;
            // 
            // formInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "formInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfiguracion;
        private Bunifu.Framework.UI.BunifuFlatButton btnProveedores;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnKardex;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalidas;
        private Bunifu.Framework.UI.BunifuFlatButton btnEntradas;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}

