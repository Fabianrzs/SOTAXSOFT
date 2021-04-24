
namespace PresentacionGUI
{
    partial class FrmModificarDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarDetalle));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.CalendarFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPlaca = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtgDetallesRegistrados = new System.Windows.Forms.DataGridView();
            this.REGISTRO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtDetalle = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtTarifaGasto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.TxtDetalle);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.TxtTarifaGasto);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.CalendarFecha);
            this.bunifuGradientPanel1.Controls.Add(this.BtnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.TxtPlaca);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.DtgDetallesRegistrados);
            this.bunifuGradientPanel1.Controls.Add(this.REGISTRO);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MistyRose;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(925, 611);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // CalendarFecha
            // 
            this.CalendarFecha.BackColor = System.Drawing.Color.Transparent;
            this.CalendarFecha.BorderRadius = 0;
            this.CalendarFecha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CalendarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CalendarFecha.FormatCustom = null;
            this.CalendarFecha.Location = new System.Drawing.Point(555, 336);
            this.CalendarFecha.Name = "CalendarFecha";
            this.CalendarFecha.Size = new System.Drawing.Size(303, 36);
            this.CalendarFecha.TabIndex = 28;
            this.CalendarFecha.Value = new System.DateTime(2021, 4, 23, 23, 33, 21, 664);
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
            this.BtnGuardar.Iconimage = global::PresentacionGUI.Properties.Resources.editar2;
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
            this.BtnGuardar.Location = new System.Drawing.Point(727, 531);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(186, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Placa";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.BackColor = System.Drawing.Color.Silver;
            this.TxtPlaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtPlaca.BackgroundImage")));
            this.TxtPlaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPlaca.Icon = ((System.Drawing.Image)(resources.GetObject("TxtPlaca.Icon")));
            this.TxtPlaca.Location = new System.Drawing.Point(261, 138);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(110, 18);
            this.TxtPlaca.TabIndex = 22;
            this.TxtPlaca.text = "";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "    CERRAR";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::PresentacionGUI.Properties.Resources.volver_flecha;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(43, 531);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(120, 26);
            this.bunifuFlatButton1.TabIndex = 20;
            this.bunifuFlatButton1.Text = "    CERRAR";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DtgDetallesRegistrados
            // 
            this.DtgDetallesRegistrados.BackgroundColor = System.Drawing.Color.LightGray;
            this.DtgDetallesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(114, 233);
            this.DtgDetallesRegistrados.Name = "DtgDetallesRegistrados";
            this.DtgDetallesRegistrados.Size = new System.Drawing.Size(300, 120);
            this.DtgDetallesRegistrados.TabIndex = 1;
            // 
            // REGISTRO
            // 
            this.REGISTRO.AccessibleName = "";
            this.REGISTRO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.REGISTRO.AutoSize = true;
            this.REGISTRO.BackColor = System.Drawing.Color.Transparent;
            this.REGISTRO.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRO.Location = new System.Drawing.Point(352, 36);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(188, 38);
            this.REGISTRO.TabIndex = 0;
            this.REGISTRO.Text = "MODIFICA";
            this.REGISTRO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(552, 296);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(57, 18);
            this.bunifuCustomLabel4.TabIndex = 33;
            this.bunifuCustomLabel4.Text = "Detalle";
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtDetalle.Location = new System.Drawing.Point(678, 294);
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(100, 20);
            this.TxtDetalle.TabIndex = 32;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(552, 251);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 18);
            this.bunifuCustomLabel3.TabIndex = 31;
            this.bunifuCustomLabel3.Text = "Gasto";
            // 
            // TxtTarifaGasto
            // 
            this.TxtTarifaGasto.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTarifaGasto.Location = new System.Drawing.Point(678, 234);
            this.TxtTarifaGasto.Name = "TxtTarifaGasto";
            this.TxtTarifaGasto.Size = new System.Drawing.Size(100, 20);
            this.TxtTarifaGasto.TabIndex = 30;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(552, 233);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 18);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "Tarifa ";
            // 
            // FrmModificarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarDetalle";
            this.Text = "FrmModificarDetalle";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel REGISTRO;
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuTextbox TxtPlaca;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuDatepicker CalendarFecha;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDetalle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTarifaGasto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}