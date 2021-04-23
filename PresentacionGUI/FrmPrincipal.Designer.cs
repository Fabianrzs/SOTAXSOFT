
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PctRestaurar = new System.Windows.Forms.PictureBox();
            this.PctMinimizar = new System.Windows.Forms.PictureBox();
            this.PctMaximizar = new System.Windows.Forms.PictureBox();
            this.PctSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PctMenu = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.BnfMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnPropietarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConductores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTaxis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BnfSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMenu)).BeginInit();
            this.PnlIzquierdo.SuspendLayout();
            this.BnfMenu.SuspendLayout();
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
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1175, 40);
            this.PnlTitulo.TabIndex = 0;
            // 
            // PctRestaurar
            // 
            this.PctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctRestaurar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.PctRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PctRestaurar.Image")));
            this.PctRestaurar.Location = new System.Drawing.Point(1113, 9);
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
            this.PctMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMinimizar.Image")));
            this.PctMinimizar.Location = new System.Drawing.Point(1085, 9);
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
            this.PctMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMaximizar.Image")));
            this.PctMaximizar.Location = new System.Drawing.Point(1113, 9);
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
            this.PctSalir.Image = ((System.Drawing.Image)(resources.GetObject("PctSalir.Image")));
            this.PctSalir.Location = new System.Drawing.Point(1141, 9);
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
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 40);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(250, 553);
            this.PnlIzquierdo.TabIndex = 1;
            // 
            // BnfMenu
            // 
            this.BnfMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BnfMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BnfMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnfMenu.BackgroundImage")));
            this.BnfMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnfMenu.Controls.Add(this.BtnPropietarios);
            this.BnfMenu.Controls.Add(this.BtnConductores);
            this.BnfMenu.Controls.Add(this.BtnTaxis);
            this.BnfMenu.Controls.Add(this.BtnReportes);
            this.BnfMenu.Controls.Add(this.BtnGastos);
            this.BnfMenu.Controls.Add(this.BtnTarifa);
            this.BnfMenu.Controls.Add(this.BnfSeparator);
            this.BnfMenu.GradientBottomLeft = System.Drawing.Color.DarkCyan;
            this.BnfMenu.GradientBottomRight = System.Drawing.Color.Bisque;
            this.BnfMenu.GradientTopLeft = System.Drawing.Color.SlateGray;
            this.BnfMenu.GradientTopRight = System.Drawing.Color.IndianRed;
            this.BnfMenu.Location = new System.Drawing.Point(12, 19);
            this.BnfMenu.Name = "BnfMenu";
            this.BnfMenu.Quality = 10;
            this.BnfMenu.Size = new System.Drawing.Size(220, 522);
            this.BnfMenu.TabIndex = 0;
            // 
            // BtnPropietarios
            // 
            this.BtnPropietarios.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnPropietarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPropietarios.BorderRadius = 0;
            this.BtnPropietarios.ButtonText = "        PROPIETARIOS";
            this.BtnPropietarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPropietarios.DisabledColor = System.Drawing.Color.Gray;
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
            this.BtnPropietarios.Location = new System.Drawing.Point(14, 417);
            this.BtnPropietarios.Name = "BtnPropietarios";
            this.BtnPropietarios.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnPropietarios.selected = false;
            this.BtnPropietarios.Size = new System.Drawing.Size(181, 54);
            this.BtnPropietarios.TabIndex = 11;
            this.BtnPropietarios.Text = "        PROPIETARIOS";
            this.BtnPropietarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPropietarios.Textcolor = System.Drawing.Color.White;
            this.BtnPropietarios.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnConductores
            // 
            this.BtnConductores.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConductores.BackColor = System.Drawing.Color.Transparent;
            this.BtnConductores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConductores.BorderRadius = 0;
            this.BtnConductores.ButtonText = "        CONDUCTORES";
            this.BtnConductores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConductores.DisabledColor = System.Drawing.Color.Gray;
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
            this.BtnConductores.Location = new System.Drawing.Point(14, 357);
            this.BtnConductores.Name = "BtnConductores";
            this.BtnConductores.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConductores.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConductores.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConductores.selected = false;
            this.BtnConductores.Size = new System.Drawing.Size(181, 54);
            this.BtnConductores.TabIndex = 10;
            this.BtnConductores.Text = "        CONDUCTORES";
            this.BtnConductores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConductores.Textcolor = System.Drawing.Color.White;
            this.BtnConductores.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnTaxis
            // 
            this.BtnTaxis.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnTaxis.BackColor = System.Drawing.Color.Transparent;
            this.BtnTaxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTaxis.BorderRadius = 0;
            this.BtnTaxis.ButtonText = "        TAXIS";
            this.BtnTaxis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTaxis.DisabledColor = System.Drawing.Color.Gray;
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
            this.BtnTaxis.Location = new System.Drawing.Point(14, 297);
            this.BtnTaxis.Name = "BtnTaxis";
            this.BtnTaxis.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnTaxis.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnTaxis.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnTaxis.selected = false;
            this.BtnTaxis.Size = new System.Drawing.Size(181, 54);
            this.BtnTaxis.TabIndex = 9;
            this.BtnTaxis.Text = "        TAXIS";
            this.BtnTaxis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTaxis.Textcolor = System.Drawing.Color.White;
            this.BtnTaxis.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnReportes
            // 
            this.BtnReportes.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnReportes.BackColor = System.Drawing.Color.Transparent;
            this.BtnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReportes.BorderRadius = 0;
            this.BtnReportes.ButtonText = "        REPORTES";
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportes.DisabledColor = System.Drawing.Color.Gray;
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
            this.BtnReportes.Location = new System.Drawing.Point(14, 237);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnReportes.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnReportes.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnReportes.selected = false;
            this.BtnReportes.Size = new System.Drawing.Size(181, 54);
            this.BtnReportes.TabIndex = 8;
            this.BtnReportes.Text = "        REPORTES";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Textcolor = System.Drawing.Color.White;
            this.BtnReportes.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnGastos
            // 
            this.BtnGastos.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnGastos.BackColor = System.Drawing.Color.Transparent;
            this.BtnGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGastos.BorderRadius = 0;
            this.BtnGastos.ButtonText = "        GASTOS";
            this.BtnGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGastos.DisabledColor = System.Drawing.Color.Gray;
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
            this.BtnGastos.Location = new System.Drawing.Point(14, 177);
            this.BtnGastos.Name = "BtnGastos";
            this.BtnGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGastos.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnGastos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnGastos.selected = false;
            this.BtnGastos.Size = new System.Drawing.Size(181, 54);
            this.BtnGastos.TabIndex = 7;
            this.BtnGastos.Text = "        GASTOS";
            this.BtnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGastos.Textcolor = System.Drawing.Color.White;
            this.BtnGastos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnTarifa
            // 
            this.BtnTarifa.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnTarifa.BackColor = System.Drawing.Color.Transparent;
            this.BtnTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTarifa.BorderRadius = 0;
            this.BtnTarifa.ButtonText = "        TARIFAS";
            this.BtnTarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTarifa.DisabledColor = System.Drawing.Color.Gray;
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
            this.BtnTarifa.Location = new System.Drawing.Point(14, 117);
            this.BtnTarifa.Name = "BtnTarifa";
            this.BtnTarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnTarifa.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnTarifa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnTarifa.selected = false;
            this.BtnTarifa.Size = new System.Drawing.Size(181, 54);
            this.BtnTarifa.TabIndex = 6;
            this.BtnTarifa.Text = "        TARIFAS";
            this.BtnTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarifa.Textcolor = System.Drawing.Color.White;
            this.BtnTarifa.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BnfSeparator
            // 
            this.BnfSeparator.BackColor = System.Drawing.Color.Transparent;
            this.BnfSeparator.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BnfSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BnfSeparator.LineThickness = 1;
            this.BnfSeparator.Location = new System.Drawing.Point(14, 94);
            this.BnfSeparator.Name = "BnfSeparator";
            this.BnfSeparator.Size = new System.Drawing.Size(181, 10);
            this.BnfSeparator.TabIndex = 0;
            this.BnfSeparator.Transparency = 255;
            this.BnfSeparator.Vertical = false;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.OldLace;
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(250, 40);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(925, 553);
            this.PnlCentral.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 593);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.PnlTitulo);
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
        private Bunifu.Framework.UI.BunifuFlatButton BtnGastos;
    }
}

