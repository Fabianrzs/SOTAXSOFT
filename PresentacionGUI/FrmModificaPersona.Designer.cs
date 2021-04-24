
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificaPersona));
            this.PnlRegisroPersona = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TxtIdentificacionConductor = new Bunifu.Framework.UI.BunifuTextbox();
            this.TxtNumeroContacto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtSegundoApellido = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtPrimerApellido = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtSegundoNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPrimerNombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtgDetallesRegistrados = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.REGISTRO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlRegisroPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRegisroPersona
            // 
            this.PnlRegisroPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlRegisroPersona.BackgroundImage")));
            this.PnlRegisroPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlRegisroPersona.Controls.Add(this.TxtIdentificacionConductor);
            this.PnlRegisroPersona.Controls.Add(this.TxtNumeroContacto);
            this.PnlRegisroPersona.Controls.Add(this.TxtSegundoApellido);
            this.PnlRegisroPersona.Controls.Add(this.TxtPrimerApellido);
            this.PnlRegisroPersona.Controls.Add(this.TxtSegundoNombre);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel6);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel5);
            this.PnlRegisroPersona.Controls.Add(this.bunifuSeparator1);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel4);
            this.PnlRegisroPersona.Controls.Add(this.TxtPrimerNombre);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel3);
            this.PnlRegisroPersona.Controls.Add(this.BtnGuardar);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel1);
            this.PnlRegisroPersona.Controls.Add(this.label2);
            this.PnlRegisroPersona.Controls.Add(this.BtnVolver);
            this.PnlRegisroPersona.Controls.Add(this.DtgDetallesRegistrados);
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel2);
            this.PnlRegisroPersona.Controls.Add(this.REGISTRO);
            this.PnlRegisroPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRegisroPersona.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlRegisroPersona.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlRegisroPersona.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlRegisroPersona.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlRegisroPersona.Location = new System.Drawing.Point(0, 0);
            this.PnlRegisroPersona.Name = "PnlRegisroPersona";
            this.PnlRegisroPersona.Quality = 10;
            this.PnlRegisroPersona.Size = new System.Drawing.Size(925, 611);
            this.PnlRegisroPersona.TabIndex = 2;
            // 
            // TxtIdentificacionConductor
            // 
            this.TxtIdentificacionConductor.BackColor = System.Drawing.Color.Silver;
            this.TxtIdentificacionConductor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.BackgroundImage")));
            this.TxtIdentificacionConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacionConductor.ForeColor = System.Drawing.Color.DimGray;
            this.TxtIdentificacionConductor.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.Icon")));
            this.TxtIdentificacionConductor.Location = new System.Drawing.Point(181, 161);
            this.TxtIdentificacionConductor.Name = "TxtIdentificacionConductor";
            this.TxtIdentificacionConductor.Size = new System.Drawing.Size(231, 18);
            this.TxtIdentificacionConductor.TabIndex = 37;
            this.TxtIdentificacionConductor.text = "";
            // 
            // TxtNumeroContacto
            // 
            this.TxtNumeroContacto.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtNumeroContacto.Location = new System.Drawing.Point(732, 397);
            this.TxtNumeroContacto.Name = "TxtNumeroContacto";
            this.TxtNumeroContacto.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroContacto.TabIndex = 35;
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSegundoApellido.Location = new System.Drawing.Point(732, 356);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtSegundoApellido.TabIndex = 34;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPrimerApellido.Location = new System.Drawing.Point(732, 315);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimerApellido.TabIndex = 33;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSegundoNombre.Location = new System.Drawing.Point(732, 274);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtSegundoNombre.TabIndex = 32;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(519, 358);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(129, 18);
            this.bunifuCustomLabel6.TabIndex = 31;
            this.bunifuCustomLabel6.Text = "Segundo Apellido";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(519, 396);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(153, 18);
            this.bunifuCustomLabel5.TabIndex = 30;
            this.bunifuCustomLabel5.Text = "Numero de Contacto";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(574, 196);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(214, 35);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(519, 317);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Pirmer Apellido";
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPrimerNombre.Location = new System.Drawing.Point(732, 232);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimerNombre.TabIndex = 27;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(519, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(130, 18);
            this.bunifuCustomLabel3.TabIndex = 26;
            this.bunifuCustomLabel3.Text = "Segundo Nombre";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "    EDITAR";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = global::PresentacionGUI.Properties.Resources.editar;
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
            this.BtnGuardar.Location = new System.Drawing.Point(753, 561);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(120, 26);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.Text = "    EDITAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.Black;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(519, 234);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 18);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificacion";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnVolver.BackColor = System.Drawing.Color.Transparent;
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.BorderRadius = 0;
            this.BtnVolver.ButtonText = "    CERRAR";
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVolver.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVolver.Iconimage = global::PresentacionGUI.Properties.Resources.volver_flecha;
            this.BtnVolver.Iconimage_right = null;
            this.BtnVolver.Iconimage_right_Selected = null;
            this.BtnVolver.Iconimage_Selected = null;
            this.BtnVolver.IconMarginLeft = 0;
            this.BtnVolver.IconMarginRight = 0;
            this.BtnVolver.IconRightVisible = true;
            this.BtnVolver.IconRightZoom = 0D;
            this.BtnVolver.IconVisible = true;
            this.BtnVolver.IconZoom = 50D;
            this.BtnVolver.IsTab = false;
            this.BtnVolver.Location = new System.Drawing.Point(58, 561);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnVolver.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnVolver.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVolver.selected = false;
            this.BtnVolver.Size = new System.Drawing.Size(120, 26);
            this.BtnVolver.TabIndex = 20;
            this.BtnVolver.Text = "    CERRAR";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolver.Textcolor = System.Drawing.Color.Black;
            this.BtnVolver.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DtgDetallesRegistrados
            // 
            this.DtgDetallesRegistrados.BackgroundColor = System.Drawing.Color.LightGray;
            this.DtgDetallesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(98, 256);
            this.DtgDetallesRegistrados.Name = "DtgDetallesRegistrados";
            this.DtgDetallesRegistrados.Size = new System.Drawing.Size(300, 120);
            this.DtgDetallesRegistrados.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AccessibleName = "";
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(606, 175);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(144, 18);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Datos a modicar";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // REGISTRO
            // 
            this.REGISTRO.AccessibleName = "";
            this.REGISTRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.REGISTRO.AutoSize = true;
            this.REGISTRO.BackColor = System.Drawing.Color.Transparent;
            this.REGISTRO.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRO.Location = new System.Drawing.Point(354, 38);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(188, 38);
            this.REGISTRO.TabIndex = 0;
            this.REGISTRO.Text = "MODIFICA";
            this.REGISTRO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmModificaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.PnlRegisroPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificaPersona";
            this.Text = "FrmModificaPersona";
            this.PnlRegisroPersona.ResumeLayout(false);
            this.PnlRegisroPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVolver;
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel REGISTRO;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacionConductor;
    }
}