
namespace PresentacionGUI
{
    partial class FrmModificaPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaPersona));
            this.PnlRegisroPersona = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPrimerNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtNumeroContacto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSegundoApellido = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPrimerApellido = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtSegundoNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgPersonaRegistrada = new System.Windows.Forms.DataGridView();
            this.REGISTRO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtIdentificacion = new Bunifu.Framework.UI.BunifuTextbox();
            this.PnlRegisroPersona.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersonaRegistrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRegisroPersona
            // 
            this.PnlRegisroPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlRegisroPersona.BackgroundImage")));
            this.PnlRegisroPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlRegisroPersona.Controls.Add(this.TxtIdentificacion);
            this.PnlRegisroPersona.Controls.Add(this.bunifuSeparator3);
            this.PnlRegisroPersona.Controls.Add(this.BtnConsultar);
            this.PnlRegisroPersona.Controls.Add(this.bunifuSeparator2);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel7);
            this.PnlRegisroPersona.Controls.Add(this.bunifuGradientPanel1);
            this.PnlRegisroPersona.Controls.Add(this.bunifuSeparator1);
            this.PnlRegisroPersona.Controls.Add(this.label2);
            this.PnlRegisroPersona.Controls.Add(this.DtgPersonaRegistrada);
            this.PnlRegisroPersona.Controls.Add(this.REGISTRO);
            this.PnlRegisroPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRegisroPersona.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlRegisroPersona.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlRegisroPersona.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlRegisroPersona.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlRegisroPersona.Location = new System.Drawing.Point(0, 0);
            this.PnlRegisroPersona.Name = "PnlRegisroPersona";
            this.PnlRegisroPersona.Quality = 10;
            this.PnlRegisroPersona.Size = new System.Drawing.Size(1300, 700);
            this.PnlRegisroPersona.TabIndex = 2;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(133, 430);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(587, 14);
            this.bunifuSeparator3.TabIndex = 41;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConsultar.BorderRadius = 0;
            this.BtnConsultar.ButtonText = "    CONSULTAR";
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnConsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.Iconimage = global::PresentacionGUI.Properties.Resources.consulta;
            this.BtnConsultar.Iconimage_right = null;
            this.BtnConsultar.Iconimage_right_Selected = null;
            this.BtnConsultar.Iconimage_Selected = null;
            this.BtnConsultar.IconMarginLeft = 0;
            this.BtnConsultar.IconMarginRight = 0;
            this.BtnConsultar.IconRightVisible = true;
            this.BtnConsultar.IconRightZoom = 0D;
            this.BtnConsultar.IconVisible = true;
            this.BtnConsultar.IconZoom = 50D;
            this.BtnConsultar.IsTab = false;
            this.BtnConsultar.Location = new System.Drawing.Point(574, 398);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.selected = false;
            this.BtnConsultar.Size = new System.Drawing.Size(120, 26);
            this.BtnConsultar.TabIndex = 40;
            this.BtnConsultar.Text = "    CONSULTAR";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Textcolor = System.Drawing.Color.Black;
            this.BtnConsultar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(478, 68);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(319, 14);
            this.bunifuSeparator2.TabIndex = 30;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AccessibleName = "";
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(379, 140);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 24);
            this.bunifuCustomLabel7.TabIndex = 39;
            this.bunifuCustomLabel7.Text = "Registros";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.BtnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuGradientPanel1.Controls.Add(this.TxtPrimerNombre);
            this.bunifuGradientPanel1.Controls.Add(this.TxtNumeroContacto);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.TxtSegundoApellido);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.TxtPrimerApellido);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.TxtSegundoNombre);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkSlateGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(850, 113);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(396, 479);
            this.bunifuGradientPanel1.TabIndex = 38;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "    GUARDAR";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = global::PresentacionGUI.Properties.Resources.Guardar;
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 50D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(128, 354);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(116, 35);
            this.BtnGuardar.TabIndex = 40;
            this.BtnGuardar.Text = "    GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AccessibleName = "";
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(124, 16);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(147, 22);
            this.bunifuCustomLabel8.TabIndex = 4;
            this.bunifuCustomLabel8.Text = "Nuevos datos ";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPrimerNombre.Location = new System.Drawing.Point(229, 71);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(116, 20);
            this.TxtPrimerNombre.TabIndex = 27;
            // 
            // TxtNumeroContacto
            // 
            this.TxtNumeroContacto.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtNumeroContacto.Location = new System.Drawing.Point(229, 279);
            this.TxtNumeroContacto.Name = "TxtNumeroContacto";
            this.TxtNumeroContacto.Size = new System.Drawing.Size(116, 20);
            this.TxtNumeroContacto.TabIndex = 35;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 73);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 18);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Primer Nombre";
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSegundoApellido.Location = new System.Drawing.Point(229, 227);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(116, 20);
            this.TxtSegundoApellido.TabIndex = 34;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(46, 124);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(130, 18);
            this.bunifuCustomLabel3.TabIndex = 26;
            this.bunifuCustomLabel3.Text = "Segundo Nombre";
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPrimerApellido.Location = new System.Drawing.Point(229, 175);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(116, 20);
            this.TxtPrimerApellido.TabIndex = 33;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(57, 175);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Pirmer Apellido";
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSegundoNombre.Location = new System.Drawing.Point(229, 123);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(116, 20);
            this.TxtSegundoNombre.TabIndex = 32;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(23, 277);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(153, 18);
            this.bunifuCustomLabel5.TabIndex = 30;
            this.bunifuCustomLabel5.Text = "Numero de Contacto";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(47, 226);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(129, 18);
            this.bunifuCustomLabel6.TabIndex = 31;
            this.bunifuCustomLabel6.Text = "Segundo Apellido";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(321, 165);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(214, 14);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificacion";
            // 
            // DtgPersonaRegistrada
            // 
            this.DtgPersonaRegistrada.BackgroundColor = System.Drawing.Color.White;
            this.DtgPersonaRegistrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPersonaRegistrada.Location = new System.Drawing.Point(58, 186);
            this.DtgPersonaRegistrada.Name = "DtgPersonaRegistrada";
            this.DtgPersonaRegistrada.Size = new System.Drawing.Size(739, 187);
            this.DtgPersonaRegistrada.TabIndex = 1;
            this.DtgPersonaRegistrada.DoubleClick += new System.EventHandler(this.DtgPersonaRegistrada_DoubleClick);
            // 
            // REGISTRO
            // 
            this.REGISTRO.AccessibleName = "";
            this.REGISTRO.BackColor = System.Drawing.Color.Transparent;
            this.REGISTRO.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRO.Location = new System.Drawing.Point(543, 33);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(188, 38);
            this.REGISTRO.TabIndex = 0;
            this.REGISTRO.Text = "MODIFICA";
            this.REGISTRO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.White;
            this.TxtIdentificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacion.BackgroundImage")));
            this.TxtIdentificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.TxtIdentificacion.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacion.Icon")));
            this.TxtIdentificacion.Location = new System.Drawing.Point(284, 406);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(231, 18);
            this.TxtIdentificacion.TabIndex = 43;
            this.TxtIdentificacion.text = "";
            // 
            // FrmModificaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlRegisroPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificaPersona";
            this.Text = "FrmModificaPersona";
            this.PnlRegisroPersona.ResumeLayout(false);
            this.PnlRegisroPersona.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersonaRegistrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlRegisroPersona;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtNumeroContacto;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSegundoApellido;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPrimerApellido;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtSegundoNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtPrimerNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtgPersonaRegistrada;
        private Bunifu.Framework.UI.BunifuCustomLabel REGISTRO;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.ErrorProvider Error;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacion;
    }
}