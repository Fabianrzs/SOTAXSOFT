
namespace PresentacionGUI
{
    partial class FrmRegistraDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistraDetalle));
            this.PnlRegistroDetalle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtDetalle = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtTarifaGastos = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlaca = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtgDetallesRegistrados = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CalendarFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.REGISTRO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlRegistroDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRegistroDetalle
            // 
            this.PnlRegistroDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlRegistroDetalle.BackgroundImage")));
            this.PnlRegistroDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlRegistroDetalle.Controls.Add(this.bunifuCustomLabel4);
            this.PnlRegistroDetalle.Controls.Add(this.TxtDetalle);
            this.PnlRegistroDetalle.Controls.Add(this.bunifuCustomLabel3);
            this.PnlRegistroDetalle.Controls.Add(this.BtnGuardar);
            this.PnlRegistroDetalle.Controls.Add(this.TxtTarifaGastos);
            this.PnlRegistroDetalle.Controls.Add(this.bunifuCustomLabel1);
            this.PnlRegistroDetalle.Controls.Add(this.label2);
            this.PnlRegistroDetalle.Controls.Add(this.TxtPlaca);
            this.PnlRegistroDetalle.Controls.Add(this.BtnVolver);
            this.PnlRegistroDetalle.Controls.Add(this.DtgDetallesRegistrados);
            this.PnlRegistroDetalle.Controls.Add(this.bunifuCustomLabel2);
            this.PnlRegistroDetalle.Controls.Add(this.CalendarFecha);
            this.PnlRegistroDetalle.Controls.Add(this.REGISTRO);
            this.PnlRegistroDetalle.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlRegistroDetalle.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlRegistroDetalle.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlRegistroDetalle.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlRegistroDetalle.Location = new System.Drawing.Point(0, 0);
            this.PnlRegistroDetalle.Name = "PnlRegistroDetalle";
            this.PnlRegistroDetalle.Quality = 10;
            this.PnlRegistroDetalle.Size = new System.Drawing.Size(925, 611);
            this.PnlRegistroDetalle.TabIndex = 0;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(523, 321);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(89, 18);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Descripcion";
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtDetalle.Location = new System.Drawing.Point(649, 319);
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(100, 20);
            this.TxtDetalle.TabIndex = 27;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(523, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 18);
            this.bunifuCustomLabel3.TabIndex = 26;
            this.bunifuCustomLabel3.Text = "Gasto";
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
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.BtnGuardar.Location = new System.Drawing.Point(331, 386);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(120, 26);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.Text = "    GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.Black;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtTarifaGastos
            // 
            this.TxtTarifaGastos.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtTarifaGastos.Location = new System.Drawing.Point(649, 259);
            this.TxtTarifaGastos.Name = "TxtTarifaGastos";
            this.TxtTarifaGastos.Size = new System.Drawing.Size(100, 20);
            this.TxtTarifaGastos.TabIndex = 24;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(523, 258);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 18);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Tarifa ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(523, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Placa";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.BackColor = System.Drawing.Color.Silver;
            this.TxtPlaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtPlaca.BackgroundImage")));
            this.TxtPlaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtPlaca.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPlaca.Icon = ((System.Drawing.Image)(resources.GetObject("TxtPlaca.Icon")));
            this.TxtPlaca.Location = new System.Drawing.Point(649, 217);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(110, 18);
            this.TxtPlaca.TabIndex = 22;
            this.TxtPlaca.text = "";
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
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(106, 217);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(523, 132);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(141, 18);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Datos a guardar";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalendarFecha
            // 
            this.CalendarFecha.BackColor = System.Drawing.Color.Transparent;
            this.CalendarFecha.BorderRadius = 0;
            this.CalendarFecha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CalendarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CalendarFecha.FormatCustom = null;
            this.CalendarFecha.Location = new System.Drawing.Point(516, 376);
            this.CalendarFecha.Name = "CalendarFecha";
            this.CalendarFecha.Size = new System.Drawing.Size(303, 36);
            this.CalendarFecha.TabIndex = 2;
            this.CalendarFecha.Value = new System.DateTime(2021, 4, 23, 23, 33, 21, 664);
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
            this.REGISTRO.Size = new System.Drawing.Size(187, 38);
            this.REGISTRO.TabIndex = 0;
            this.REGISTRO.Text = "REGISTRO";
            this.REGISTRO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRegistrarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.PnlRegistroDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTarifaRegistrar";
            this.PnlRegistroDetalle.ResumeLayout(false);
            this.PnlRegistroDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlRegistroDetalle;
        private Bunifu.Framework.UI.BunifuCustomLabel REGISTRO;
        private Bunifu.Framework.UI.BunifuDatepicker CalendarFecha;
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVolver;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTextbox TxtPlaca;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtTarifaGastos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtDetalle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}