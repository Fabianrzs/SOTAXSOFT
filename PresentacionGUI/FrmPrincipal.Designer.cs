﻿
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
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
            this.PnlMenuTarifas = new System.Windows.Forms.Panel();
            this.BtnModificarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlMenuGatos = new System.Windows.Forms.Panel();
            this.BtnModificarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnConsultarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnRegistrarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.ElpMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TrnIda = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TrnRegreso = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PnlMenuRepostes = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMenu)).BeginInit();
            this.PnlIzquierdo.SuspendLayout();
            this.BnfMenu.SuspendLayout();
            this.PnlMenuTarifas.SuspendLayout();
            this.PnlMenuGatos.SuspendLayout();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.PnlMenuRepostes.SuspendLayout();
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
            this.PnlTitulo.Size = new System.Drawing.Size(1175, 40);
            this.PnlTitulo.TabIndex = 0;
            // 
            // PctRestaurar
            // 
            this.PctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctRestaurar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TrnIda.SetDecoration(this.PctRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctRestaurar, BunifuAnimatorNS.DecorationType.None);
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
            this.TrnIda.SetDecoration(this.PctMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctMinimizar, BunifuAnimatorNS.DecorationType.None);
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
            this.TrnIda.SetDecoration(this.PctMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctMaximizar, BunifuAnimatorNS.DecorationType.None);
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
            this.TrnIda.SetDecoration(this.PctSalir, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.PctSalir, BunifuAnimatorNS.DecorationType.None);
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
            this.PnlIzquierdo.Size = new System.Drawing.Size(250, 611);
            this.PnlIzquierdo.TabIndex = 1;
            // 
            // BnfMenu
            // 
            this.BnfMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BnfMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BnfMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnfMenu.BackgroundImage")));
            this.BnfMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnfMenu.Controls.Add(this.PnlMenuGatos);
            this.BnfMenu.Controls.Add(this.BtnPropietarios);
            this.BnfMenu.Controls.Add(this.BtnConductores);
            this.BnfMenu.Controls.Add(this.PnlMenuTarifas);
            this.BnfMenu.Controls.Add(this.BtnTaxis);
            this.BnfMenu.Controls.Add(this.BtnReportes);
            this.BnfMenu.Controls.Add(this.BtnGastos);
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
            this.BnfMenu.Size = new System.Drawing.Size(222, 580);
            this.BnfMenu.TabIndex = 0;
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
            // PnlMenuTarifas
            // 
            this.PnlMenuTarifas.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuTarifas.Controls.Add(this.BtnModificarTarifa);
            this.PnlMenuTarifas.Controls.Add(this.BtnConsultarTarifa);
            this.PnlMenuTarifas.Controls.Add(this.BtnRegistrarTarifa);
            this.TrnRegreso.SetDecoration(this.PnlMenuTarifas, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuTarifas, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuTarifas.Location = new System.Drawing.Point(45, 163);
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
            // PnlMenuGatos
            // 
            this.PnlMenuGatos.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuGatos.Controls.Add(this.BtnModificarGastos);
            this.PnlMenuGatos.Controls.Add(this.BtnConsultarGastos);
            this.PnlMenuGatos.Controls.Add(this.BtnRegistrarGastos);
            this.TrnRegreso.SetDecoration(this.PnlMenuGatos, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuGatos, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuGatos.Location = new System.Drawing.Point(42, 208);
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
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.OldLace;
            this.PnlCentral.Controls.Add(this.PnlMenuRepostes);
            this.PnlCentral.Controls.Add(this.PctLogo);
            this.TrnRegreso.SetDecoration(this.PnlCentral, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlCentral, BunifuAnimatorNS.DecorationType.None);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(250, 40);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(925, 611);
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
            this.PctLogo.Location = new System.Drawing.Point(343, 170);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(204, 230);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.TrnIda.DefaultAnimation = animation4;
            // 
            // TrnRegreso
            // 
            this.TrnRegreso.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.TrnRegreso.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.TrnRegreso.DefaultAnimation = animation3;
            // 
            // PnlMenuRepostes
            // 
            this.PnlMenuRepostes.BackColor = System.Drawing.Color.Transparent;
            this.PnlMenuRepostes.Controls.Add(this.bunifuFlatButton1);
            this.PnlMenuRepostes.Controls.Add(this.bunifuFlatButton2);
            this.PnlMenuRepostes.Controls.Add(this.bunifuFlatButton3);
            this.TrnRegreso.SetDecoration(this.PnlMenuRepostes, BunifuAnimatorNS.DecorationType.None);
            this.TrnIda.SetDecoration(this.PnlMenuRepostes, BunifuAnimatorNS.DecorationType.None);
            this.PnlMenuRepostes.Location = new System.Drawing.Point(60, 196);
            this.PnlMenuRepostes.Name = "PnlMenuRepostes";
            this.PnlMenuRepostes.Size = new System.Drawing.Size(177, 115);
            this.PnlMenuRepostes.TabIndex = 17;
            this.PnlMenuRepostes.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "MODIFICAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 44D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(2, 77);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(175, 38);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "MODIFICAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightCyan;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "CONSULTAR";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 44D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(2, 39);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(175, 38);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "CONSULTAR";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.LightCyan;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "REGISTRAR";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrnIda.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.TrnRegreso.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 44D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(2, 1);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(175, 38);
            this.bunifuFlatButton3.TabIndex = 13;
            this.bunifuFlatButton3.Text = "REGISTRAR";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.LightCyan;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 651);
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
            this.PnlMenuTarifas.ResumeLayout(false);
            this.PnlMenuGatos.ResumeLayout(false);
            this.PnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.PnlMenuRepostes.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PnlMenuRepostes;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}

