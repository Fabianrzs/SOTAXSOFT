
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgDetallesRegistrados = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.REGISTRO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlRegisroPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlRegisroPersona
            // 
            this.PnlRegisroPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlRegisroPersona.BackgroundImage")));
            this.PnlRegisroPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlRegisroPersona.Controls.Add(this.bunifuCustomLabel7);
            this.PnlRegisroPersona.Controls.Add(this.bunifuGradientPanel1);
            this.PnlRegisroPersona.Controls.Add(this.TxtIdentificacionConductor);
            this.PnlRegisroPersona.Controls.Add(this.bunifuSeparator1);
            this.PnlRegisroPersona.Controls.Add(this.label2);
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
            this.TxtIdentificacionConductor.BackColor = System.Drawing.Color.White;
            this.TxtIdentificacionConductor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.BackgroundImage")));
            this.TxtIdentificacionConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacionConductor.ForeColor = System.Drawing.Color.White;
            this.TxtIdentificacionConductor.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.Icon")));
            this.TxtIdentificacionConductor.Location = new System.Drawing.Point(195, 370);
            this.TxtIdentificacionConductor.Name = "TxtIdentificacionConductor";
            this.TxtIdentificacionConductor.Size = new System.Drawing.Size(231, 18);
            this.TxtIdentificacionConductor.TabIndex = 37;
            this.TxtIdentificacionConductor.text = "";
            // 
            // TxtNumeroContacto
            // 
            this.TxtNumeroContacto.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtNumeroContacto.Location = new System.Drawing.Point(242, 226);
            this.TxtNumeroContacto.Name = "TxtNumeroContacto";
            this.TxtNumeroContacto.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroContacto.TabIndex = 35;
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSegundoApellido.Location = new System.Drawing.Point(242, 185);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtSegundoApellido.TabIndex = 34;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPrimerApellido.Location = new System.Drawing.Point(242, 144);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimerApellido.TabIndex = 33;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtSegundoNombre.Location = new System.Drawing.Point(242, 103);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtSegundoNombre.TabIndex = 32;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(29, 187);
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
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(29, 225);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(153, 18);
            this.bunifuCustomLabel5.TabIndex = 30;
            this.bunifuCustomLabel5.Text = "Numero de Contacto";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(121, 198);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(214, 14);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(29, 146);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Pirmer Apellido";
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtPrimerNombre.Location = new System.Drawing.Point(242, 61);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimerNombre.TabIndex = 27;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 105);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(130, 18);
            this.bunifuCustomLabel3.TabIndex = 26;
            this.bunifuCustomLabel3.Text = "Segundo Nombre";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 63);
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificacion";
            // 
            // DtgDetallesRegistrados
            // 
            this.DtgDetallesRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.DtgDetallesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(18, 218);
            this.DtgDetallesRegistrados.Name = "DtgDetallesRegistrados";
            this.DtgDetallesRegistrados.Size = new System.Drawing.Size(439, 120);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(136, 239);
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(522, 124);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(370, 354);
            this.bunifuGradientPanel1.TabIndex = 38;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AccessibleName = "";
            this.bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(115, 11);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(147, 22);
            this.bunifuCustomLabel8.TabIndex = 4;
            this.bunifuCustomLabel8.Text = "Nuevos datos ";
            this.bunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AccessibleName = "";
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(188, 180);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 24);
            this.bunifuCustomLabel7.TabIndex = 39;
            this.bunifuCustomLabel7.Text = "Registros";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnGuardar.Location = new System.Drawing.Point(129, 300);
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
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel REGISTRO;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacionConductor;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
    }
}