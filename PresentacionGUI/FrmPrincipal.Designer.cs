
namespace PresentacionGUI
{
    partial class FrmPrincipal
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PctRestaurar = new System.Windows.Forms.PictureBox();
            this.PctMinimizar = new System.Windows.Forms.PictureBox();
            this.PctMaximizar = new System.Windows.Forms.PictureBox();
            this.PctSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PctMenu = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.BnfMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PnlMenuPropietarios = new System.Windows.Forms.Panel();
            this.BtnEliminarPropietario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnModificarPropietario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarPropietario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarPropietario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlMenuConductores = new System.Windows.Forms.Panel();
            this.BtnEliminarCondutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnModificarCondutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarCondutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarCondutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnPropietarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlMenuTaxis = new System.Windows.Forms.Panel();
            this.BtnEliminarTaxi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnModificarTaxi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarTaxi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarTaxi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConductores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlMenuGatos = new System.Windows.Forms.Panel();
            this.BtnModificarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTaxis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlMenuTarifas = new System.Windows.Forms.Panel();
            this.BtnModificarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BnfSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.ElpMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TrnIda = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TrnRegreso = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMenu)).BeginInit();
            this.PnlIzquierdo.SuspendLayout();
            this.BnfMenu.SuspendLayout();
            this.PnlMenuPropietarios.SuspendLayout();
            this.PnlMenuConductores.SuspendLayout();
            this.PnlMenuTaxis.SuspendLayout();
            this.PnlMenuGatos.SuspendLayout();
            this.PnlMenuTarifas.SuspendLayout();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.PnlTitulo.Controls.Add(this.PctRestaurar);
            this.PnlTitulo.Controls.Add(this.PctMinimizar);
            this.PnlTitulo.Controls.Add(this.PctMaximizar);
            this.PnlTitulo.Controls.Add(this.PctSalir);
            this.PnlTitulo.Controls.Add(this.label1);
            this.PnlTitulo.Controls.Add(this.PctMenu);
            this.TrnRegreso.SetDecoration(this.PnlTitulo, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlTitulo, BunifuAnimatorNS.DecorationType.None);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1314, 40);
            this.PnlTitulo.TabIndex = 0;
            // 
            // PctRestaurar
            // 
            this.PctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctRestaurar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TrnIda.SetDecoration(this.PctRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.PctRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PctRestaurar.Image")));
            this.PctRestaurar.Location = new System.Drawing.Point(1252, 9);
            this.PctRestaurar.Name = "PctRestaurar";
            this.PctRestaurar.Size = new System.Drawing.Size(22, 22);
            this.PctRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctRestaurar.TabIndex = 4;
            this.PctRestaurar.TabStop = false;
            this.PctRestaurar.Visible = false;
            this.PctRestaurar.Click += new System.EventHandler(this.PctRestaurar_Click);
            // 
            // PctMinimizar
            // 
            this.PctMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMinimizar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TrnIda.SetDecoration(this.PctMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PctMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMinimizar.Image")));
            this.PctMinimizar.Location = new System.Drawing.Point(1224, 9);
            this.PctMinimizar.Name = "PctMinimizar";
            this.PctMinimizar.Size = new System.Drawing.Size(22, 22);
            this.PctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMinimizar.TabIndex = 3;
            this.PctMinimizar.TabStop = false;
            this.PctMinimizar.Click += new System.EventHandler(this.PctMinimizar_Click);
            // 
            // PctMaximizar
            // 
            this.PctMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMaximizar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TrnIda.SetDecoration(this.PctMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.PctMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMaximizar.Image")));
            this.PctMaximizar.Location = new System.Drawing.Point(1252, 9);
            this.PctMaximizar.Name = "PctMaximizar";
            this.PctMaximizar.Size = new System.Drawing.Size(22, 22);
            this.PctMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMaximizar.TabIndex = 2;
            this.PctMaximizar.TabStop = false;
            this.PctMaximizar.Click += new System.EventHandler(this.PctMaximizar_Click);
            // 
            // PctSalir
            // 
            this.PctSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctSalir.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TrnIda.SetDecoration(this.PctSalir, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctSalir, BunifuAnimatorNS.DecorationType.None);
            this.PctSalir.Image = ((System.Drawing.Image)(resources.GetObject("PctSalir.Image")));
            this.PctSalir.Location = new System.Drawing.Point(1280, 9);
            this.PctSalir.Name = "PctSalir";
            this.PctSalir.Size = new System.Drawing.Size(22, 22);
            this.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSalir.TabIndex = 1;
            this.PctSalir.TabStop = false;
            this.PctSalir.Click += new System.EventHandler(this.PctSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.TrnIda.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // PctMenu
            // 
            this.PctMenu.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TrnIda.SetDecoration(this.PctMenu, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctMenu, BunifuAnimatorNS.DecorationType.None);
            this.PctMenu.Image = ((System.Drawing.Image)(resources.GetObject("PctMenu.Image")));
            this.PctMenu.Location = new System.Drawing.Point(12, 9);
            this.PctMenu.Name = "PctMenu";
            this.PctMenu.Size = new System.Drawing.Size(22, 22);
            this.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMenu.TabIndex = 0;
            this.PctMenu.TabStop = false;
            this.PctMenu.Click += new System.EventHandler(this.PctMenu_Click);
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.IndianRed;
            this.PnlIzquierdo.Controls.Add(this.BnfMenu);
            this.TrnRegreso.SetDecoration(this.PnlIzquierdo, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlIzquierdo, BunifuAnimatorNS.DecorationType.None);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 40);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(250, 687);
            this.PnlIzquierdo.TabIndex = 1;
            // 
            // BnfMenu
            // 
            this.BnfMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BnfMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BnfMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnfMenu.BackgroundImage")));
            this.BnfMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnfMenu.Controls.Add(this.PnlMenuPropietarios);
            this.BnfMenu.Controls.Add(this.PnlMenuConductores);
            this.BnfMenu.Controls.Add(this.BtnPropietarios);
            this.BnfMenu.Controls.Add(this.PnlMenuTaxis);
            this.BnfMenu.Controls.Add(this.BtnConductores);
            this.BnfMenu.Controls.Add(this.PnlMenuGatos);
            this.BnfMenu.Controls.Add(this.BtnTaxis);
            this.BnfMenu.Controls.Add(this.BtnReportes);
            this.BnfMenu.Controls.Add(this.BtnGastos);
            this.BnfMenu.Controls.Add(this.PnlMenuTarifas);
            this.BnfMenu.Controls.Add(this.BtnTarifa);
            this.BnfMenu.Controls.Add(this.BnfSeparator);
            this.TrnRegreso.SetDecoration(this.BnfMenu, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.BnfMenu, BunifuAnimatorNS.DecorationType.None);
            this.BnfMenu.GradientBottomLeft = System.Drawing.Color.DarkCyan;
            this.BnfMenu.GradientBottomRight = System.Drawing.Color.Bisque;
            this.BnfMenu.GradientTopLeft = System.Drawing.Color.SlateGray;
            this.BnfMenu.GradientTopRight = System.Drawing.Color.IndianRed;
            this.BnfMenu.Location = new System.Drawing.Point(12, 19);
            this.BnfMenu.Name = "BnfMenu";
            this.BnfMenu.Quality = 10;
            this.BnfMenu.Size = new System.Drawing.Size(222, 656);
            this.BnfMenu.TabIndex = 0;
            // 
            // PnlMenuPropietarios
            // 
            this.PnlMenuPropietarios.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuPropietarios.Controls.Add(this.BtnEliminarPropietario);
            this.PnlMenuPropietarios.Controls.Add(this.BtnModificarPropietario);
            this.PnlMenuPropietarios.Controls.Add(this.BtnConsultarPropietario);
            this.PnlMenuPropietarios.Controls.Add(this.BtnRegistrarPropietario);
            this.TrnRegreso.SetDecoration(this.PnlMenuPropietarios, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuPropietarios, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuPropietarios.Location = new System.Drawing.Point(0, 494);
            this.PnlMenuPropietarios.Name = "PnlMenuPropietarios";
            this.PnlMenuPropietarios.Size = new System.Drawing.Size(177, 162);
            this.PnlMenuPropietarios.TabIndex = 17;
            this.PnlMenuPropietarios.Visible = false;
            // 
            // BtnEliminarPropietario
            // 
            this.BtnEliminarPropietario.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnEliminarPropietario.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarPropietario.BorderRadius = 0;
            this.BtnEliminarPropietario.ButtonText = "ELIMINAR";
            this.BtnEliminarPropietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnEliminarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnEliminarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.BtnEliminarPropietario.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarPropietario.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarPropietario.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarPropietario.Iconimage")));
            this.BtnEliminarPropietario.Iconimage_right = null;
            this.BtnEliminarPropietario.Iconimage_right_Selected = null;
            this.BtnEliminarPropietario.Iconimage_Selected = null;
            this.BtnEliminarPropietario.IconMarginLeft = 0;
            this.BtnEliminarPropietario.IconMarginRight = 0;
            this.BtnEliminarPropietario.IconRightVisible = true;
            this.BtnEliminarPropietario.IconRightZoom = 0D;
            this.BtnEliminarPropietario.IconVisible = true;
            this.BtnEliminarPropietario.IconZoom = 44D;
            this.BtnEliminarPropietario.IsTab = false;
            this.BtnEliminarPropietario.Location = new System.Drawing.Point(3, 121);
            this.BtnEliminarPropietario.Name = "BtnEliminarPropietario";
            this.BtnEliminarPropietario.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarPropietario.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnEliminarPropietario.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnEliminarPropietario.selected = false;
            this.BtnEliminarPropietario.Size = new System.Drawing.Size(171, 38);
            this.BtnEliminarPropietario.TabIndex = 16;
            this.BtnEliminarPropietario.Text = "ELIMINAR";
            this.BtnEliminarPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarPropietario.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnEliminarPropietario.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPropietario.Click += new System.EventHandler(this.BtnEliminarPropietario_Click);
            // 
            // BtnModificarPropietario
            // 
            this.BtnModificarPropietario.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnModificarPropietario.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificarPropietario.BorderRadius = 0;
            this.BtnModificarPropietario.ButtonText = "MODIFICAR";
            this.BtnModificarPropietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnModificarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnModificarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.BtnModificarPropietario.DisabledColor = System.Drawing.Color.Gray;
            this.BtnModificarPropietario.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnModificarPropietario.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnModificarPropietario.Iconimage")));
            this.BtnModificarPropietario.Iconimage_right = null;
            this.BtnModificarPropietario.Iconimage_right_Selected = null;
            this.BtnModificarPropietario.Iconimage_Selected = null;
            this.BtnModificarPropietario.IconMarginLeft = 0;
            this.BtnModificarPropietario.IconMarginRight = 0;
            this.BtnModificarPropietario.IconRightVisible = true;
            this.BtnModificarPropietario.IconRightZoom = 0D;
            this.BtnModificarPropietario.IconVisible = true;
            this.BtnModificarPropietario.IconZoom = 44D;
            this.BtnModificarPropietario.IsTab = false;
            this.BtnModificarPropietario.Location = new System.Drawing.Point(3, 77);
            this.BtnModificarPropietario.Name = "BtnModificarPropietario";
            this.BtnModificarPropietario.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnModificarPropietario.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnModificarPropietario.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnModificarPropietario.selected = false;
            this.BtnModificarPropietario.Size = new System.Drawing.Size(171, 38);
            this.BtnModificarPropietario.TabIndex = 15;
            this.BtnModificarPropietario.Text = "MODIFICAR";
            this.BtnModificarPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarPropietario.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnModificarPropietario.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarPropietario.Click += new System.EventHandler(this.BtnModificarPropietario_Click);
            // 
            // BtnConsultarPropietario
            // 
            this.BtnConsultarPropietario.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConsultarPropietario.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultarPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultarPropietario.BorderRadius = 0;
            this.BtnConsultarPropietario.ButtonText = "CONSULTAR";
            this.BtnConsultarPropietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnConsultarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnConsultarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultarPropietario.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultarPropietario.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarPropietario.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsultarPropietario.Iconimage")));
            this.BtnConsultarPropietario.Iconimage_right = null;
            this.BtnConsultarPropietario.Iconimage_right_Selected = null;
            this.BtnConsultarPropietario.Iconimage_Selected = null;
            this.BtnConsultarPropietario.IconMarginLeft = 0;
            this.BtnConsultarPropietario.IconMarginRight = 0;
            this.BtnConsultarPropietario.IconRightVisible = true;
            this.BtnConsultarPropietario.IconRightZoom = 0D;
            this.BtnConsultarPropietario.IconVisible = true;
            this.BtnConsultarPropietario.IconZoom = 44D;
            this.BtnConsultarPropietario.IsTab = false;
            this.BtnConsultarPropietario.Location = new System.Drawing.Point(3, 39);
            this.BtnConsultarPropietario.Name = "BtnConsultarPropietario";
            this.BtnConsultarPropietario.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarPropietario.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultarPropietario.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultarPropietario.selected = false;
            this.BtnConsultarPropietario.Size = new System.Drawing.Size(171, 38);
            this.BtnConsultarPropietario.TabIndex = 14;
            this.BtnConsultarPropietario.Text = "CONSULTAR";
            this.BtnConsultarPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConsultarPropietario.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnConsultarPropietario.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarPropietario.Click += new System.EventHandler(this.BtnConsultarPropietario_Click);
            // 
            // BtnRegistrarPropietario
            // 
            this.BtnRegistrarPropietario.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnRegistrarPropietario.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarPropietario.BorderRadius = 0;
            this.BtnRegistrarPropietario.ButtonText = "REGISTRAR";
            this.BtnRegistrarPropietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnRegistrarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnRegistrarPropietario, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrarPropietario.DisabledColor = System.Drawing.Color.White;
            this.BtnRegistrarPropietario.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarPropietario.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarPropietario.Iconimage")));
            this.BtnRegistrarPropietario.Iconimage_right = null;
            this.BtnRegistrarPropietario.Iconimage_right_Selected = null;
            this.BtnRegistrarPropietario.Iconimage_Selected = null;
            this.BtnRegistrarPropietario.IconMarginLeft = 0;
            this.BtnRegistrarPropietario.IconMarginRight = 0;
            this.BtnRegistrarPropietario.IconRightVisible = true;
            this.BtnRegistrarPropietario.IconRightZoom = 0D;
            this.BtnRegistrarPropietario.IconVisible = true;
            this.BtnRegistrarPropietario.IconZoom = 44D;
            this.BtnRegistrarPropietario.IsTab = false;
            this.BtnRegistrarPropietario.Location = new System.Drawing.Point(3, 1);
            this.BtnRegistrarPropietario.Name = "BtnRegistrarPropietario";
            this.BtnRegistrarPropietario.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarPropietario.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarPropietario.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarPropietario.selected = false;
            this.BtnRegistrarPropietario.Size = new System.Drawing.Size(171, 38);
            this.BtnRegistrarPropietario.TabIndex = 13;
            this.BtnRegistrarPropietario.Text = "REGISTRAR";
            this.BtnRegistrarPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistrarPropietario.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnRegistrarPropietario.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarPropietario.Click += new System.EventHandler(this.BtnRegistrarPropietario_Click);
            // 
            // PnlMenuConductores
            // 
            this.PnlMenuConductores.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuConductores.Controls.Add(this.BtnEliminarCondutor);
            this.PnlMenuConductores.Controls.Add(this.BtnModificarCondutor);
            this.PnlMenuConductores.Controls.Add(this.BtnConsultarCondutor);
            this.PnlMenuConductores.Controls.Add(this.BtnRegistrarCondutor);
            this.TrnRegreso.SetDecoration(this.PnlMenuConductores, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuConductores, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuConductores.Location = new System.Drawing.Point(19, 455);
            this.PnlMenuConductores.Name = "PnlMenuConductores";
            this.PnlMenuConductores.Size = new System.Drawing.Size(177, 162);
            this.PnlMenuConductores.TabIndex = 19;
            this.PnlMenuConductores.Visible = false;
            // 
            // BtnEliminarCondutor
            // 
            this.BtnEliminarCondutor.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnEliminarCondutor.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCondutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarCondutor.BorderRadius = 0;
            this.BtnEliminarCondutor.ButtonText = "ELIMINAR";
            this.BtnEliminarCondutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnEliminarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnEliminarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.BtnEliminarCondutor.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarCondutor.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarCondutor.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCondutor.Iconimage")));
            this.BtnEliminarCondutor.Iconimage_right = null;
            this.BtnEliminarCondutor.Iconimage_right_Selected = null;
            this.BtnEliminarCondutor.Iconimage_Selected = null;
            this.BtnEliminarCondutor.IconMarginLeft = 0;
            this.BtnEliminarCondutor.IconMarginRight = 0;
            this.BtnEliminarCondutor.IconRightVisible = true;
            this.BtnEliminarCondutor.IconRightZoom = 0D;
            this.BtnEliminarCondutor.IconVisible = true;
            this.BtnEliminarCondutor.IconZoom = 44D;
            this.BtnEliminarCondutor.IsTab = false;
            this.BtnEliminarCondutor.Location = new System.Drawing.Point(3, 121);
            this.BtnEliminarCondutor.Name = "BtnEliminarCondutor";
            this.BtnEliminarCondutor.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarCondutor.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnEliminarCondutor.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCondutor.selected = false;
            this.BtnEliminarCondutor.Size = new System.Drawing.Size(171, 38);
            this.BtnEliminarCondutor.TabIndex = 16;
            this.BtnEliminarCondutor.Text = "ELIMINAR";
            this.BtnEliminarCondutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarCondutor.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnEliminarCondutor.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCondutor.Click += new System.EventHandler(this.BtnEliminarCondutor_Click);
            // 
            // BtnModificarCondutor
            // 
            this.BtnModificarCondutor.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnModificarCondutor.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarCondutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificarCondutor.BorderRadius = 0;
            this.BtnModificarCondutor.ButtonText = "MODIFICAR";
            this.BtnModificarCondutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnModificarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnModificarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.BtnModificarCondutor.DisabledColor = System.Drawing.Color.Gray;
            this.BtnModificarCondutor.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnModificarCondutor.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnModificarCondutor.Iconimage")));
            this.BtnModificarCondutor.Iconimage_right = null;
            this.BtnModificarCondutor.Iconimage_right_Selected = null;
            this.BtnModificarCondutor.Iconimage_Selected = null;
            this.BtnModificarCondutor.IconMarginLeft = 0;
            this.BtnModificarCondutor.IconMarginRight = 0;
            this.BtnModificarCondutor.IconRightVisible = true;
            this.BtnModificarCondutor.IconRightZoom = 0D;
            this.BtnModificarCondutor.IconVisible = true;
            this.BtnModificarCondutor.IconZoom = 44D;
            this.BtnModificarCondutor.IsTab = false;
            this.BtnModificarCondutor.Location = new System.Drawing.Point(3, 77);
            this.BtnModificarCondutor.Name = "BtnModificarCondutor";
            this.BtnModificarCondutor.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnModificarCondutor.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnModificarCondutor.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnModificarCondutor.selected = false;
            this.BtnModificarCondutor.Size = new System.Drawing.Size(171, 38);
            this.BtnModificarCondutor.TabIndex = 15;
            this.BtnModificarCondutor.Text = "MODIFICAR";
            this.BtnModificarCondutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarCondutor.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnModificarCondutor.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCondutor.Click += new System.EventHandler(this.BtnModificarCondutor_Click);
            // 
            // BtnConsultarCondutor
            // 
            this.BtnConsultarCondutor.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConsultarCondutor.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultarCondutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultarCondutor.BorderRadius = 0;
            this.BtnConsultarCondutor.ButtonText = "CONSULTAR";
            this.BtnConsultarCondutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnConsultarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnConsultarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultarCondutor.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultarCondutor.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarCondutor.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsultarCondutor.Iconimage")));
            this.BtnConsultarCondutor.Iconimage_right = null;
            this.BtnConsultarCondutor.Iconimage_right_Selected = null;
            this.BtnConsultarCondutor.Iconimage_Selected = null;
            this.BtnConsultarCondutor.IconMarginLeft = 0;
            this.BtnConsultarCondutor.IconMarginRight = 0;
            this.BtnConsultarCondutor.IconRightVisible = true;
            this.BtnConsultarCondutor.IconRightZoom = 0D;
            this.BtnConsultarCondutor.IconVisible = true;
            this.BtnConsultarCondutor.IconZoom = 44D;
            this.BtnConsultarCondutor.IsTab = false;
            this.BtnConsultarCondutor.Location = new System.Drawing.Point(3, 39);
            this.BtnConsultarCondutor.Name = "BtnConsultarCondutor";
            this.BtnConsultarCondutor.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarCondutor.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultarCondutor.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultarCondutor.selected = false;
            this.BtnConsultarCondutor.Size = new System.Drawing.Size(171, 38);
            this.BtnConsultarCondutor.TabIndex = 14;
            this.BtnConsultarCondutor.Text = "CONSULTAR";
            this.BtnConsultarCondutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConsultarCondutor.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnConsultarCondutor.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarCondutor.Click += new System.EventHandler(this.BtnConsultarCondutor_Click);
            // 
            // BtnRegistrarCondutor
            // 
            this.BtnRegistrarCondutor.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnRegistrarCondutor.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarCondutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarCondutor.BorderRadius = 0;
            this.BtnRegistrarCondutor.ButtonText = "REGISTRAR";
            this.BtnRegistrarCondutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnRegistrarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnRegistrarCondutor, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrarCondutor.DisabledColor = System.Drawing.Color.White;
            this.BtnRegistrarCondutor.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarCondutor.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarCondutor.Iconimage")));
            this.BtnRegistrarCondutor.Iconimage_right = null;
            this.BtnRegistrarCondutor.Iconimage_right_Selected = null;
            this.BtnRegistrarCondutor.Iconimage_Selected = null;
            this.BtnRegistrarCondutor.IconMarginLeft = 0;
            this.BtnRegistrarCondutor.IconMarginRight = 0;
            this.BtnRegistrarCondutor.IconRightVisible = true;
            this.BtnRegistrarCondutor.IconRightZoom = 0D;
            this.BtnRegistrarCondutor.IconVisible = true;
            this.BtnRegistrarCondutor.IconZoom = 44D;
            this.BtnRegistrarCondutor.IsTab = false;
            this.BtnRegistrarCondutor.Location = new System.Drawing.Point(3, 1);
            this.BtnRegistrarCondutor.Name = "BtnRegistrarCondutor";
            this.BtnRegistrarCondutor.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarCondutor.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarCondutor.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarCondutor.selected = false;
            this.BtnRegistrarCondutor.Size = new System.Drawing.Size(171, 38);
            this.BtnRegistrarCondutor.TabIndex = 13;
            this.BtnRegistrarCondutor.Text = "REGISTRAR";
            this.BtnRegistrarCondutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistrarCondutor.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnRegistrarCondutor.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCondutor.Click += new System.EventHandler(this.BtnRegistrarCondutor_Click);
            // 
            // BtnPropietarios
            // 
            this.BtnPropietarios.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnPropietarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPropietarios.BorderRadius = 0;
            this.BtnPropietarios.ButtonText = "      PROPIETARIOS";
            this.BtnPropietarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnPropietarios, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnPropietarios, BunifuAnimatorNS.DecorationType.None);
            this.BtnPropietarios.DisabledColor = System.Drawing.Color.Maroon;
            this.BtnPropietarios.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPropietarios.Iconimage")));
            this.BtnPropietarios.Iconimage_right = null;
            this.BtnPropietarios.Iconimage_right_Selected = null;
            this.BtnPropietarios.Iconimage_Selected = null;
            this.BtnPropietarios.IconMarginLeft = 0;
            this.BtnPropietarios.IconMarginRight = 0;
            this.BtnPropietarios.IconRightVisible = true;
            this.BtnPropietarios.IconRightZoom = 0D;
            this.BtnPropietarios.IconVisible = true;
            this.BtnPropietarios.IconZoom = 50D;
            this.BtnPropietarios.IsTab = false;
            this.BtnPropietarios.Location = new System.Drawing.Point(19, 341);
            this.BtnPropietarios.Name = "BtnPropietarios";
            this.BtnPropietarios.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.selected = false;
            this.BtnPropietarios.Size = new System.Drawing.Size(181, 33);
            this.BtnPropietarios.TabIndex = 11;
            this.BtnPropietarios.Text = "      PROPIETARIOS";
            this.BtnPropietarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPropietarios.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnPropietarios.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPropietarios.Click += new System.EventHandler(this.BtnPropietarios_Click);
            // 
            // PnlMenuTaxis
            // 
            this.PnlMenuTaxis.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuTaxis.Controls.Add(this.BtnEliminarTaxi);
            this.PnlMenuTaxis.Controls.Add(this.BtnModificarTaxi);
            this.PnlMenuTaxis.Controls.Add(this.BtnConsultarTaxi);
            this.PnlMenuTaxis.Controls.Add(this.BtnRegistrarTaxi);
            this.TrnRegreso.SetDecoration(this.PnlMenuTaxis, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuTaxis, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuTaxis.Location = new System.Drawing.Point(3, 287);
            this.PnlMenuTaxis.Name = "PnlMenuTaxis";
            this.PnlMenuTaxis.Size = new System.Drawing.Size(177, 162);
            this.PnlMenuTaxis.TabIndex = 18;
            this.PnlMenuTaxis.Visible = false;
            // 
            // BtnEliminarTaxi
            // 
            this.BtnEliminarTaxi.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnEliminarTaxi.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarTaxi.BorderRadius = 0;
            this.BtnEliminarTaxi.ButtonText = "ELIMINAR";
            this.BtnEliminarTaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnEliminarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnEliminarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.BtnEliminarTaxi.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminarTaxi.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarTaxi.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarTaxi.Iconimage")));
            this.BtnEliminarTaxi.Iconimage_right = null;
            this.BtnEliminarTaxi.Iconimage_right_Selected = null;
            this.BtnEliminarTaxi.Iconimage_Selected = null;
            this.BtnEliminarTaxi.IconMarginLeft = 0;
            this.BtnEliminarTaxi.IconMarginRight = 0;
            this.BtnEliminarTaxi.IconRightVisible = true;
            this.BtnEliminarTaxi.IconRightZoom = 0D;
            this.BtnEliminarTaxi.IconVisible = true;
            this.BtnEliminarTaxi.IconZoom = 44D;
            this.BtnEliminarTaxi.IsTab = false;
            this.BtnEliminarTaxi.Location = new System.Drawing.Point(3, 121);
            this.BtnEliminarTaxi.Name = "BtnEliminarTaxi";
            this.BtnEliminarTaxi.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnEliminarTaxi.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnEliminarTaxi.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnEliminarTaxi.selected = false;
            this.BtnEliminarTaxi.Size = new System.Drawing.Size(171, 38);
            this.BtnEliminarTaxi.TabIndex = 16;
            this.BtnEliminarTaxi.Text = "ELIMINAR";
            this.BtnEliminarTaxi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarTaxi.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnEliminarTaxi.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarTaxi.Click += new System.EventHandler(this.BtnEliminarTaxi_Click);
            // 
            // BtnModificarTaxi
            // 
            this.BtnModificarTaxi.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnModificarTaxi.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificarTaxi.BorderRadius = 0;
            this.BtnModificarTaxi.ButtonText = "MODIFICAR";
            this.BtnModificarTaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnModificarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnModificarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.BtnModificarTaxi.DisabledColor = System.Drawing.Color.Gray;
            this.BtnModificarTaxi.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnModificarTaxi.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnModificarTaxi.Iconimage")));
            this.BtnModificarTaxi.Iconimage_right = null;
            this.BtnModificarTaxi.Iconimage_right_Selected = null;
            this.BtnModificarTaxi.Iconimage_Selected = null;
            this.BtnModificarTaxi.IconMarginLeft = 0;
            this.BtnModificarTaxi.IconMarginRight = 0;
            this.BtnModificarTaxi.IconRightVisible = true;
            this.BtnModificarTaxi.IconRightZoom = 0D;
            this.BtnModificarTaxi.IconVisible = true;
            this.BtnModificarTaxi.IconZoom = 44D;
            this.BtnModificarTaxi.IsTab = false;
            this.BtnModificarTaxi.Location = new System.Drawing.Point(3, 81);
            this.BtnModificarTaxi.Name = "BtnModificarTaxi";
            this.BtnModificarTaxi.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnModificarTaxi.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnModificarTaxi.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnModificarTaxi.selected = false;
            this.BtnModificarTaxi.Size = new System.Drawing.Size(171, 38);
            this.BtnModificarTaxi.TabIndex = 15;
            this.BtnModificarTaxi.Text = "MODIFICAR";
            this.BtnModificarTaxi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarTaxi.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnModificarTaxi.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarTaxi.Click += new System.EventHandler(this.BtnModificarTaxi_Click);
            // 
            // BtnConsultarTaxi
            // 
            this.BtnConsultarTaxi.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConsultarTaxi.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultarTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultarTaxi.BorderRadius = 0;
            this.BtnConsultarTaxi.ButtonText = "CONSULTAR";
            this.BtnConsultarTaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnConsultarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnConsultarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultarTaxi.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultarTaxi.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarTaxi.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsultarTaxi.Iconimage")));
            this.BtnConsultarTaxi.Iconimage_right = null;
            this.BtnConsultarTaxi.Iconimage_right_Selected = null;
            this.BtnConsultarTaxi.Iconimage_Selected = null;
            this.BtnConsultarTaxi.IconMarginLeft = 0;
            this.BtnConsultarTaxi.IconMarginRight = 0;
            this.BtnConsultarTaxi.IconRightVisible = true;
            this.BtnConsultarTaxi.IconRightZoom = 0D;
            this.BtnConsultarTaxi.IconVisible = true;
            this.BtnConsultarTaxi.IconZoom = 44D;
            this.BtnConsultarTaxi.IsTab = false;
            this.BtnConsultarTaxi.Location = new System.Drawing.Point(3, 41);
            this.BtnConsultarTaxi.Name = "BtnConsultarTaxi";
            this.BtnConsultarTaxi.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarTaxi.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultarTaxi.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultarTaxi.selected = false;
            this.BtnConsultarTaxi.Size = new System.Drawing.Size(171, 38);
            this.BtnConsultarTaxi.TabIndex = 14;
            this.BtnConsultarTaxi.Text = "CONSULTAR";
            this.BtnConsultarTaxi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConsultarTaxi.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnConsultarTaxi.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarTaxi.Click += new System.EventHandler(this.BtnConsultarTaxi_Click);
            // 
            // BtnRegistrarTaxi
            // 
            this.BtnRegistrarTaxi.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnRegistrarTaxi.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarTaxi.BorderRadius = 0;
            this.BtnRegistrarTaxi.ButtonText = "REGISTRAR";
            this.BtnRegistrarTaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnRegistrarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnRegistrarTaxi, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrarTaxi.DisabledColor = System.Drawing.Color.White;
            this.BtnRegistrarTaxi.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTaxi.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarTaxi.Iconimage")));
            this.BtnRegistrarTaxi.Iconimage_right = null;
            this.BtnRegistrarTaxi.Iconimage_right_Selected = null;
            this.BtnRegistrarTaxi.Iconimage_Selected = null;
            this.BtnRegistrarTaxi.IconMarginLeft = 0;
            this.BtnRegistrarTaxi.IconMarginRight = 0;
            this.BtnRegistrarTaxi.IconRightVisible = true;
            this.BtnRegistrarTaxi.IconRightZoom = 0D;
            this.BtnRegistrarTaxi.IconVisible = true;
            this.BtnRegistrarTaxi.IconZoom = 44D;
            this.BtnRegistrarTaxi.IsTab = false;
            this.BtnRegistrarTaxi.Location = new System.Drawing.Point(3, 1);
            this.BtnRegistrarTaxi.Name = "BtnRegistrarTaxi";
            this.BtnRegistrarTaxi.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTaxi.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTaxi.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTaxi.selected = false;
            this.BtnRegistrarTaxi.Size = new System.Drawing.Size(171, 38);
            this.BtnRegistrarTaxi.TabIndex = 13;
            this.BtnRegistrarTaxi.Text = "REGISTRAR";
            this.BtnRegistrarTaxi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistrarTaxi.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnRegistrarTaxi.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarTaxi.Click += new System.EventHandler(this.BtnRegistrarTaxi_Click);
            // 
            // BtnConductores
            // 
            this.BtnConductores.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConductores.BackColor = System.Drawing.Color.Transparent;
            this.BtnConductores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConductores.BorderRadius = 0;
            this.BtnConductores.ButtonText = "      CONDUCTORES";
            this.BtnConductores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnConductores, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnConductores, BunifuAnimatorNS.DecorationType.None);
            this.BtnConductores.DisabledColor = System.Drawing.Color.Maroon;
            this.BtnConductores.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConductores.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConductores.Iconimage")));
            this.BtnConductores.Iconimage_right = null;
            this.BtnConductores.Iconimage_right_Selected = null;
            this.BtnConductores.Iconimage_Selected = null;
            this.BtnConductores.IconMarginLeft = 0;
            this.BtnConductores.IconMarginRight = 0;
            this.BtnConductores.IconRightVisible = true;
            this.BtnConductores.IconRightZoom = 0D;
            this.BtnConductores.IconVisible = true;
            this.BtnConductores.IconZoom = 50D;
            this.BtnConductores.IsTab = false;
            this.BtnConductores.Location = new System.Drawing.Point(19, 300);
            this.BtnConductores.Name = "BtnConductores";
            this.BtnConductores.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConductores.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConductores.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConductores.selected = false;
            this.BtnConductores.Size = new System.Drawing.Size(181, 33);
            this.BtnConductores.TabIndex = 10;
            this.BtnConductores.Text = "      CONDUCTORES";
            this.BtnConductores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConductores.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnConductores.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConductores.Click += new System.EventHandler(this.BtnConductores_Click);
            // 
            // PnlMenuGatos
            // 
            this.PnlMenuGatos.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuGatos.Controls.Add(this.BtnModificarGastos);
            this.PnlMenuGatos.Controls.Add(this.BtnConsultarGastos);
            this.PnlMenuGatos.Controls.Add(this.BtnRegistrarGastos);
            this.TrnRegreso.SetDecoration(this.PnlMenuGatos, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuGatos, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuGatos.Location = new System.Drawing.Point(33, 210);
            this.PnlMenuGatos.Name = "PnlMenuGatos";
            this.PnlMenuGatos.Size = new System.Drawing.Size(177, 115);
            this.PnlMenuGatos.TabIndex = 16;
            this.PnlMenuGatos.Visible = false;
            // 
            // BtnModificarGastos
            // 
            this.BtnModificarGastos.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnModificarGastos.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificarGastos.BorderRadius = 0;
            this.BtnModificarGastos.ButtonText = "MODIFICAR";
            this.BtnModificarGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnModificarGastos, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnModificarGastos, BunifuAnimatorNS.DecorationType.None);
            this.BtnModificarGastos.DisabledColor = System.Drawing.Color.Gray;
            this.BtnModificarGastos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnModificarGastos.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnModificarGastos.Iconimage")));
            this.BtnModificarGastos.Iconimage_right = null;
            this.BtnModificarGastos.Iconimage_right_Selected = null;
            this.BtnModificarGastos.Iconimage_Selected = null;
            this.BtnModificarGastos.IconMarginLeft = 0;
            this.BtnModificarGastos.IconMarginRight = 0;
            this.BtnModificarGastos.IconRightVisible = true;
            this.BtnModificarGastos.IconRightZoom = 0D;
            this.BtnModificarGastos.IconVisible = true;
            this.BtnModificarGastos.IconZoom = 44D;
            this.BtnModificarGastos.IsTab = false;
            this.BtnModificarGastos.Location = new System.Drawing.Point(2, 77);
            this.BtnModificarGastos.Name = "BtnModificarGastos";
            this.BtnModificarGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnModificarGastos.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnModificarGastos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnModificarGastos.selected = false;
            this.BtnModificarGastos.Size = new System.Drawing.Size(175, 38);
            this.BtnModificarGastos.TabIndex = 15;
            this.BtnModificarGastos.Text = "MODIFICAR";
            this.BtnModificarGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarGastos.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnModificarGastos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarGastos.Click += new System.EventHandler(this.BtnModificarGastos_Click);
            // 
            // BtnConsultarGastos
            // 
            this.BtnConsultarGastos.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConsultarGastos.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultarGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultarGastos.BorderRadius = 0;
            this.BtnConsultarGastos.ButtonText = "CONSULTAR";
            this.BtnConsultarGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnConsultarGastos, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnConsultarGastos, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultarGastos.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultarGastos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarGastos.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsultarGastos.Iconimage")));
            this.BtnConsultarGastos.Iconimage_right = null;
            this.BtnConsultarGastos.Iconimage_right_Selected = null;
            this.BtnConsultarGastos.Iconimage_Selected = null;
            this.BtnConsultarGastos.IconMarginLeft = 0;
            this.BtnConsultarGastos.IconMarginRight = 0;
            this.BtnConsultarGastos.IconRightVisible = true;
            this.BtnConsultarGastos.IconRightZoom = 0D;
            this.BtnConsultarGastos.IconVisible = true;
            this.BtnConsultarGastos.IconZoom = 44D;
            this.BtnConsultarGastos.IsTab = false;
            this.BtnConsultarGastos.Location = new System.Drawing.Point(2, 39);
            this.BtnConsultarGastos.Name = "BtnConsultarGastos";
            this.BtnConsultarGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarGastos.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultarGastos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultarGastos.selected = false;
            this.BtnConsultarGastos.Size = new System.Drawing.Size(175, 38);
            this.BtnConsultarGastos.TabIndex = 14;
            this.BtnConsultarGastos.Text = "CONSULTAR";
            this.BtnConsultarGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConsultarGastos.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnConsultarGastos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarGastos.Click += new System.EventHandler(this.BtnConsultarGastos_Click);
            // 
            // BtnRegistrarGastos
            // 
            this.BtnRegistrarGastos.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnRegistrarGastos.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarGastos.BorderRadius = 0;
            this.BtnRegistrarGastos.ButtonText = "REGISTRAR";
            this.BtnRegistrarGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnRegistrarGastos, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnRegistrarGastos, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrarGastos.DisabledColor = System.Drawing.Color.White;
            this.BtnRegistrarGastos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarGastos.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarGastos.Iconimage")));
            this.BtnRegistrarGastos.Iconimage_right = null;
            this.BtnRegistrarGastos.Iconimage_right_Selected = null;
            this.BtnRegistrarGastos.Iconimage_Selected = null;
            this.BtnRegistrarGastos.IconMarginLeft = 0;
            this.BtnRegistrarGastos.IconMarginRight = 0;
            this.BtnRegistrarGastos.IconRightVisible = true;
            this.BtnRegistrarGastos.IconRightZoom = 0D;
            this.BtnRegistrarGastos.IconVisible = true;
            this.BtnRegistrarGastos.IconZoom = 44D;
            this.BtnRegistrarGastos.IsTab = false;
            this.BtnRegistrarGastos.Location = new System.Drawing.Point(2, 1);
            this.BtnRegistrarGastos.Name = "BtnRegistrarGastos";
            this.BtnRegistrarGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarGastos.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarGastos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarGastos.selected = false;
            this.BtnRegistrarGastos.Size = new System.Drawing.Size(175, 38);
            this.BtnRegistrarGastos.TabIndex = 13;
            this.BtnRegistrarGastos.Text = "REGISTRAR";
            this.BtnRegistrarGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistrarGastos.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnRegistrarGastos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarGastos.Click += new System.EventHandler(this.BtnRegistrarGastos_Click);
            // 
            // BtnTaxis
            // 
            this.BtnTaxis.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnTaxis.BackColor = System.Drawing.Color.Transparent;
            this.BtnTaxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTaxis.BorderRadius = 0;
            this.BtnTaxis.ButtonText = "      TAXIS";
            this.BtnTaxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnTaxis, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnTaxis, BunifuAnimatorNS.DecorationType.None);
            this.BtnTaxis.DisabledColor = System.Drawing.Color.Maroon;
            this.BtnTaxis.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTaxis.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnTaxis.Iconimage")));
            this.BtnTaxis.Iconimage_right = null;
            this.BtnTaxis.Iconimage_right_Selected = null;
            this.BtnTaxis.Iconimage_Selected = null;
            this.BtnTaxis.IconMarginLeft = 0;
            this.BtnTaxis.IconMarginRight = 0;
            this.BtnTaxis.IconRightVisible = true;
            this.BtnTaxis.IconRightZoom = 0D;
            this.BtnTaxis.IconVisible = true;
            this.BtnTaxis.IconZoom = 55D;
            this.BtnTaxis.IsTab = false;
            this.BtnTaxis.Location = new System.Drawing.Point(19, 259);
            this.BtnTaxis.Name = "BtnTaxis";
            this.BtnTaxis.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnTaxis.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnTaxis.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnTaxis.selected = false;
            this.BtnTaxis.Size = new System.Drawing.Size(181, 33);
            this.BtnTaxis.TabIndex = 9;
            this.BtnTaxis.Text = "      TAXIS";
            this.BtnTaxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTaxis.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnTaxis.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTaxis.Click += new System.EventHandler(this.BtnTaxis_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnReportes.BackColor = System.Drawing.Color.Transparent;
            this.BtnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReportes.BorderRadius = 0;
            this.BtnReportes.ButtonText = "      REPORTES";
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnReportes, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnReportes, BunifuAnimatorNS.DecorationType.None);
            this.BtnReportes.DisabledColor = System.Drawing.Color.Maroon;
            this.BtnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnReportes.Iconimage")));
            this.BtnReportes.Iconimage_right = null;
            this.BtnReportes.Iconimage_right_Selected = null;
            this.BtnReportes.Iconimage_Selected = null;
            this.BtnReportes.IconMarginLeft = 0;
            this.BtnReportes.IconMarginRight = 0;
            this.BtnReportes.IconRightVisible = true;
            this.BtnReportes.IconRightZoom = 0D;
            this.BtnReportes.IconVisible = true;
            this.BtnReportes.IconZoom = 50D;
            this.BtnReportes.IsTab = false;
            this.BtnReportes.Location = new System.Drawing.Point(19, 218);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnReportes.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnReportes.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnReportes.selected = false;
            this.BtnReportes.Size = new System.Drawing.Size(181, 33);
            this.BtnReportes.TabIndex = 8;
            this.BtnReportes.Text = "      REPORTES";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnReportes.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnGastos
            // 
            this.BtnGastos.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnGastos.BackColor = System.Drawing.Color.Transparent;
            this.BtnGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGastos.BorderRadius = 0;
            this.BtnGastos.ButtonText = "      GASTOS";
            this.BtnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnGastos, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnGastos, BunifuAnimatorNS.DecorationType.None);
            this.BtnGastos.DisabledColor = System.Drawing.Color.Maroon;
            this.BtnGastos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGastos.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGastos.Iconimage")));
            this.BtnGastos.Iconimage_right = null;
            this.BtnGastos.Iconimage_right_Selected = null;
            this.BtnGastos.Iconimage_Selected = null;
            this.BtnGastos.IconMarginLeft = 0;
            this.BtnGastos.IconMarginRight = 0;
            this.BtnGastos.IconRightVisible = true;
            this.BtnGastos.IconRightZoom = 0D;
            this.BtnGastos.IconVisible = true;
            this.BtnGastos.IconZoom = 50D;
            this.BtnGastos.IsTab = false;
            this.BtnGastos.Location = new System.Drawing.Point(19, 177);
            this.BtnGastos.Name = "BtnGastos";
            this.BtnGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGastos.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnGastos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnGastos.selected = false;
            this.BtnGastos.Size = new System.Drawing.Size(181, 33);
            this.BtnGastos.TabIndex = 7;
            this.BtnGastos.Text = "      GASTOS";
            this.BtnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGastos.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnGastos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGastos.Click += new System.EventHandler(this.BtnGastos_Click);
            // 
            // PnlMenuTarifas
            // 
            this.PnlMenuTarifas.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuTarifas.Controls.Add(this.BtnModificarTarifa);
            this.PnlMenuTarifas.Controls.Add(this.BtnConsultarTarifa);
            this.PnlMenuTarifas.Controls.Add(this.BtnRegistrarTarifa);
            this.TrnRegreso.SetDecoration(this.PnlMenuTarifas, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuTarifas, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuTarifas.Location = new System.Drawing.Point(45, 165);
            this.PnlMenuTarifas.Name = "PnlMenuTarifas";
            this.PnlMenuTarifas.Size = new System.Drawing.Size(177, 115);
            this.PnlMenuTarifas.TabIndex = 12;
            this.PnlMenuTarifas.Visible = false;
            // 
            // BtnModificarTarifa
            // 
            this.BtnModificarTarifa.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnModificarTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificarTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificarTarifa.BorderRadius = 0;
            this.BtnModificarTarifa.ButtonText = "MODIFICAR";
            this.BtnModificarTarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnModificarTarifa, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnModificarTarifa, BunifuAnimatorNS.DecorationType.None);
            this.BtnModificarTarifa.DisabledColor = System.Drawing.Color.Gray;
            this.BtnModificarTarifa.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnModificarTarifa.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnModificarTarifa.Iconimage")));
            this.BtnModificarTarifa.Iconimage_right = null;
            this.BtnModificarTarifa.Iconimage_right_Selected = null;
            this.BtnModificarTarifa.Iconimage_Selected = null;
            this.BtnModificarTarifa.IconMarginLeft = 0;
            this.BtnModificarTarifa.IconMarginRight = 0;
            this.BtnModificarTarifa.IconRightVisible = true;
            this.BtnModificarTarifa.IconRightZoom = 0D;
            this.BtnModificarTarifa.IconVisible = true;
            this.BtnModificarTarifa.IconZoom = 44D;
            this.BtnModificarTarifa.IsTab = false;
            this.BtnModificarTarifa.Location = new System.Drawing.Point(2, 77);
            this.BtnModificarTarifa.Name = "BtnModificarTarifa";
            this.BtnModificarTarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnModificarTarifa.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnModificarTarifa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnModificarTarifa.selected = false;
            this.BtnModificarTarifa.Size = new System.Drawing.Size(175, 38);
            this.BtnModificarTarifa.TabIndex = 15;
            this.BtnModificarTarifa.Text = "MODIFICAR";
            this.BtnModificarTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarTarifa.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnModificarTarifa.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarTarifa.Click += new System.EventHandler(this.BtnModificarTarifa_Click);
            // 
            // BtnConsultarTarifa
            // 
            this.BtnConsultarTarifa.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConsultarTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultarTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultarTarifa.BorderRadius = 0;
            this.BtnConsultarTarifa.ButtonText = "CONSULTAR";
            this.BtnConsultarTarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnConsultarTarifa, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnConsultarTarifa, BunifuAnimatorNS.DecorationType.None);
            this.BtnConsultarTarifa.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultarTarifa.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarTarifa.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnConsultarTarifa.Iconimage")));
            this.BtnConsultarTarifa.Iconimage_right = null;
            this.BtnConsultarTarifa.Iconimage_right_Selected = null;
            this.BtnConsultarTarifa.Iconimage_Selected = null;
            this.BtnConsultarTarifa.IconMarginLeft = 0;
            this.BtnConsultarTarifa.IconMarginRight = 0;
            this.BtnConsultarTarifa.IconRightVisible = true;
            this.BtnConsultarTarifa.IconRightZoom = 0D;
            this.BtnConsultarTarifa.IconVisible = true;
            this.BtnConsultarTarifa.IconZoom = 44D;
            this.BtnConsultarTarifa.IsTab = false;
            this.BtnConsultarTarifa.Location = new System.Drawing.Point(2, 39);
            this.BtnConsultarTarifa.Name = "BtnConsultarTarifa";
            this.BtnConsultarTarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultarTarifa.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultarTarifa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultarTarifa.selected = false;
            this.BtnConsultarTarifa.Size = new System.Drawing.Size(175, 38);
            this.BtnConsultarTarifa.TabIndex = 14;
            this.BtnConsultarTarifa.Text = "CONSULTAR";
            this.BtnConsultarTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConsultarTarifa.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnConsultarTarifa.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarTarifa.Click += new System.EventHandler(this.BtnConsultarTarifa_Click);
            // 
            // BtnRegistrarTarifa
            // 
            this.BtnRegistrarTarifa.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnRegistrarTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarTarifa.BorderRadius = 0;
            this.BtnRegistrarTarifa.ButtonText = "REGISTRAR";
            this.BtnRegistrarTarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnRegistrarTarifa, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnRegistrarTarifa, BunifuAnimatorNS.DecorationType.None);
            this.BtnRegistrarTarifa.DisabledColor = System.Drawing.Color.White;
            this.BtnRegistrarTarifa.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTarifa.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarTarifa.Iconimage")));
            this.BtnRegistrarTarifa.Iconimage_right = null;
            this.BtnRegistrarTarifa.Iconimage_right_Selected = null;
            this.BtnRegistrarTarifa.Iconimage_Selected = null;
            this.BtnRegistrarTarifa.IconMarginLeft = 0;
            this.BtnRegistrarTarifa.IconMarginRight = 0;
            this.BtnRegistrarTarifa.IconRightVisible = true;
            this.BtnRegistrarTarifa.IconRightZoom = 0D;
            this.BtnRegistrarTarifa.IconVisible = true;
            this.BtnRegistrarTarifa.IconZoom = 44D;
            this.BtnRegistrarTarifa.IsTab = false;
            this.BtnRegistrarTarifa.Location = new System.Drawing.Point(2, 1);
            this.BtnRegistrarTarifa.Name = "BtnRegistrarTarifa";
            this.BtnRegistrarTarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTarifa.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTarifa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarTarifa.selected = false;
            this.BtnRegistrarTarifa.Size = new System.Drawing.Size(175, 38);
            this.BtnRegistrarTarifa.TabIndex = 13;
            this.BtnRegistrarTarifa.Text = "REGISTRAR";
            this.BtnRegistrarTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegistrarTarifa.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnRegistrarTarifa.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarTarifa.Click += new System.EventHandler(this.BtnRegistrarTarifa_Click);
            // 
            // BtnTarifa
            // 
            this.BtnTarifa.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTarifa.BorderRadius = 0;
            this.BtnTarifa.ButtonText = "      TARIFAS";
            this.BtnTarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.BtnTarifa, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.BtnTarifa, BunifuAnimatorNS.DecorationType.None);
            this.BtnTarifa.DisabledColor = System.Drawing.Color.Maroon;
            this.BtnTarifa.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTarifa.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnTarifa.Iconimage")));
            this.BtnTarifa.Iconimage_right = null;
            this.BtnTarifa.Iconimage_right_Selected = null;
            this.BtnTarifa.Iconimage_Selected = null;
            this.BtnTarifa.IconMarginLeft = 0;
            this.BtnTarifa.IconMarginRight = 0;
            this.BtnTarifa.IconRightVisible = true;
            this.BtnTarifa.IconRightZoom = 0D;
            this.BtnTarifa.IconVisible = true;
            this.BtnTarifa.IconZoom = 50D;
            this.BtnTarifa.IsTab = false;
            this.BtnTarifa.Location = new System.Drawing.Point(19, 136);
            this.BtnTarifa.Name = "BtnTarifa";
            this.BtnTarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnTarifa.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnTarifa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnTarifa.selected = false;
            this.BtnTarifa.Size = new System.Drawing.Size(181, 33);
            this.BtnTarifa.TabIndex = 6;
            this.BtnTarifa.Text = "      TARIFAS";
            this.BtnTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarifa.Textcolor = System.Drawing.Color.LightCyan;
            this.BtnTarifa.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarifa.Click += new System.EventHandler(this.BtnTarifa_Click);
            // 
            // BnfSeparator
            // 
            this.BnfSeparator.BackColor = System.Drawing.Color.Transparent;
            this.TrnRegreso.SetDecoration(this.BnfSeparator, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.BnfSeparator, BunifuAnimatorNS.DecorationType.None);
            this.BnfSeparator.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BnfSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BnfSeparator.LineThickness = 1;
            this.BnfSeparator.Location = new System.Drawing.Point(19, 94);
            this.BnfSeparator.Name = "BnfSeparator";
            this.BnfSeparator.Size = new System.Drawing.Size(181, 10);
            this.BnfSeparator.TabIndex = 0;
            this.BnfSeparator.Transparency = 255;
            this.BnfSeparator.Vertical = false;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.White;
            this.PnlCentral.Controls.Add(this.PctLogo);
            this.TrnRegreso.SetDecoration(this.PnlCentral, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlCentral, BunifuAnimatorNS.DecorationType.None);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(250, 40);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1064, 687);
            this.PnlCentral.TabIndex = 2;
            // 
            // PctLogo
            // 
            this.PctLogo.AccessibleName = "";
            this.PctLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrnIda.SetDecoration(this.PctLogo, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctLogo, BunifuAnimatorNS.DecorationType.None);
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(301, 155);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(462, 280);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctLogo.TabIndex = 0;
            this.PctLogo.TabStop = false;
            // 
            // ElpMenu
            // 
            this.ElpMenu.ElipseRadius = 7;
            this.ElpMenu.TargetControl = this.BnfMenu;
            // 
            // TrnIda
            // 
            this.TrnIda.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TrnIda.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.TrnIda.DefaultAnimation = animation1;
            // 
            // TrnRegreso
            // 
            this.TrnRegreso.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.TrnRegreso.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.TrnRegreso.DefaultAnimation = animation2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 727);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.PnlTitulo);
            this.TrnRegreso.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMenu)).EndInit();
            this.PnlIzquierdo.ResumeLayout(false);
            this.BnfMenu.ResumeLayout(false);
            this.PnlMenuPropietarios.ResumeLayout(false);
            this.PnlMenuConductores.ResumeLayout(false);
            this.PnlMenuTaxis.ResumeLayout(false);
            this.PnlMenuGatos.ResumeLayout(false);
            this.PnlMenuTarifas.ResumeLayout(false);
            this.PnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctMenu;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.PictureBox PctSalir;
        private System.Windows.Forms.PictureBox PctRestaurar;
        private System.Windows.Forms.PictureBox PctMinimizar;
        private System.Windows.Forms.PictureBox PctMaximizar;
        private Bunifu.Framework.UI.BunifuGradientPanel BnfMenu;
        private Bunifu.Framework.UI.BunifuSeparator BnfSeparator;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTarifa;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPropietarios;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConductores;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTaxis;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReportes;
        private Bunifu.Framework.UI.BunifuElipse ElpMenu;
        private BunifuAnimatorNS.BunifuTransition TrnIda;
        private BunifuAnimatorNS.BunifuTransition TrnRegreso;
        private System.Windows.Forms.Panel PnlMenuTarifas;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGastos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistrarTarifa;
        private Bunifu.Framework.UI.BunifuFlatButton BtnModificarTarifa;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultarTarifa;
        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.Panel PnlMenuGatos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnModificarGastos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultarGastos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistrarGastos;
        private System.Windows.Forms.Panel PnlMenuPropietarios;
        private Bunifu.Framework.UI.BunifuFlatButton BtnModificarPropietario;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultarPropietario;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistrarPropietario;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarPropietario;
        private System.Windows.Forms.Panel PnlMenuTaxis;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarTaxi;
        private Bunifu.Framework.UI.BunifuFlatButton BtnModificarTaxi;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultarTaxi;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistrarTaxi;
        private System.Windows.Forms.Panel PnlMenuConductores;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminarCondutor;
        private Bunifu.Framework.UI.BunifuFlatButton BtnModificarCondutor;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultarCondutor;
        private Bunifu.Framework.UI.BunifuFlatButton BtnRegistrarCondutor;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

