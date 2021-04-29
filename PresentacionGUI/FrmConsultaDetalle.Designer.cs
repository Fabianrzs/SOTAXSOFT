
namespace PresentacionGUI
{
    partial class FrmConsultaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaDetalle));
            this.PnlConsultaDetalle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TxtIDConductor = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DtpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChbFecha = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPlaca = new Bunifu.Framework.UI.BunifuTextbox();
            this.ChbIDConductor = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChbPlaca = new Bunifu.Framework.UI.BunifuCheckbox();
            this.DtgDetallesRegistrados = new System.Windows.Forms.DataGridView();
            this.consultar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlConsultaDetalle.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlConsultaDetalle
            // 
            this.PnlConsultaDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlConsultaDetalle.BackgroundImage")));
            this.PnlConsultaDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlConsultaDetalle.Controls.Add(this.bunifuSeparator1);
            this.PnlConsultaDetalle.Controls.Add(this.bunifuCustomLabel7);
            this.PnlConsultaDetalle.Controls.Add(this.bunifuSeparator2);
            this.PnlConsultaDetalle.Controls.Add(this.bunifuGradientPanel1);
            this.PnlConsultaDetalle.Controls.Add(this.DtgDetallesRegistrados);
            this.PnlConsultaDetalle.Controls.Add(this.consultar);
            this.PnlConsultaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConsultaDetalle.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlConsultaDetalle.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlConsultaDetalle.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlConsultaDetalle.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlConsultaDetalle.Location = new System.Drawing.Point(0, 0);
            this.PnlConsultaDetalle.Name = "PnlConsultaDetalle";
            this.PnlConsultaDetalle.Quality = 10;
            this.PnlConsultaDetalle.Size = new System.Drawing.Size(1300, 700);
            this.PnlConsultaDetalle.TabIndex = 21;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(307, 172);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(227, 10);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AccessibleName = "";
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(377, 145);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 24);
            this.bunifuCustomLabel7.TabIndex = 47;
            this.bunifuCustomLabel7.Text = "Registros";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(471, 77);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(333, 10);
            this.bunifuSeparator2.TabIndex = 45;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.TxtIDConductor);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.DtpFecha);
            this.bunifuGradientPanel1.Controls.Add(this.BtnConsultar);
            this.bunifuGradientPanel1.Controls.Add(this.ChbFecha);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.TxtPlaca);
            this.bunifuGradientPanel1.Controls.Add(this.ChbIDConductor);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.ChbPlaca);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkSlateGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(843, 118);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(370, 450);
            this.bunifuGradientPanel1.TabIndex = 44;
            // 
            // TxtIDConductor
            // 
            this.TxtIDConductor.BackColor = System.Drawing.Color.White;
            this.TxtIDConductor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIDConductor.BackgroundImage")));
            this.TxtIDConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIDConductor.ForeColor = System.Drawing.Color.White;
            this.TxtIDConductor.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIDConductor.Icon")));
            this.TxtIDConductor.Location = new System.Drawing.Point(197, 135);
            this.TxtIDConductor.Name = "TxtIDConductor";
            this.TxtIDConductor.Size = new System.Drawing.Size(130, 18);
            this.TxtIDConductor.TabIndex = 36;
            this.TxtIDConductor.text = "";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Georgia", 12F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(79, 184);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 18);
            this.bunifuCustomLabel5.TabIndex = 35;
            this.bunifuCustomLabel5.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.DtpFecha.BorderRadius = 0;
            this.DtpFecha.ForeColor = System.Drawing.Color.White;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpFecha.FormatCustom = null;
            this.DtpFecha.Location = new System.Drawing.Point(53, 210);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(274, 20);
            this.DtpFecha.TabIndex = 30;
            this.DtpFecha.Value = new System.DateTime(2021, 4, 23, 23, 33, 21, 664);
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
            this.BtnConsultar.ForeColor = System.Drawing.Color.White;
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
            this.BtnConsultar.Location = new System.Drawing.Point(127, 306);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.selected = false;
            this.BtnConsultar.Size = new System.Drawing.Size(120, 26);
            this.BtnConsultar.TabIndex = 25;
            this.BtnConsultar.Text = "    CONSULTAR";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Textcolor = System.Drawing.Color.White;
            this.BtnConsultar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ChbFecha
            // 
            this.ChbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbFecha.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbFecha.Checked = true;
            this.ChbFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbFecha.ForeColor = System.Drawing.Color.White;
            this.ChbFecha.Location = new System.Drawing.Point(53, 184);
            this.ChbFecha.Name = "ChbFecha";
            this.ChbFecha.Size = new System.Drawing.Size(20, 20);
            this.ChbFecha.TabIndex = 31;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AccessibleName = "";
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(115, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(155, 18);
            this.bunifuCustomLabel2.TabIndex = 34;
            this.bunifuCustomLabel2.Text = "Datos a Consultar ";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.BackColor = System.Drawing.Color.White;
            this.TxtPlaca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtPlaca.BackgroundImage")));
            this.TxtPlaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtPlaca.ForeColor = System.Drawing.Color.White;
            this.TxtPlaca.Icon = ((System.Drawing.Image)(resources.GetObject("TxtPlaca.Icon")));
            this.TxtPlaca.Location = new System.Drawing.Point(197, 85);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(130, 18);
            this.TxtPlaca.TabIndex = 22;
            this.TxtPlaca.text = "";
            // 
            // ChbIDConductor
            // 
            this.ChbIDConductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbIDConductor.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbIDConductor.Checked = true;
            this.ChbIDConductor.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbIDConductor.ForeColor = System.Drawing.Color.White;
            this.ChbIDConductor.Location = new System.Drawing.Point(53, 133);
            this.ChbIDConductor.Name = "ChbIDConductor";
            this.ChbIDConductor.Size = new System.Drawing.Size(20, 20);
            this.ChbIDConductor.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID Conductor ";
            // 
            // ChbPlaca
            // 
            this.ChbPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbPlaca.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbPlaca.Checked = true;
            this.ChbPlaca.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbPlaca.ForeColor = System.Drawing.Color.White;
            this.ChbPlaca.Location = new System.Drawing.Point(53, 85);
            this.ChbPlaca.Name = "ChbPlaca";
            this.ChbPlaca.Size = new System.Drawing.Size(20, 20);
            this.ChbPlaca.TabIndex = 28;
            // 
            // DtgDetallesRegistrados
            // 
            this.DtgDetallesRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.DtgDetallesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(55, 184);
            this.DtgDetallesRegistrados.Name = "DtgDetallesRegistrados";
            this.DtgDetallesRegistrados.Size = new System.Drawing.Size(736, 250);
            this.DtgDetallesRegistrados.TabIndex = 1;
            // 
            // consultar
            // 
            this.consultar.AccessibleName = "";
            this.consultar.BackColor = System.Drawing.Color.Transparent;
            this.consultar.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultar.Location = new System.Drawing.Point(550, 36);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(199, 38);
            this.consultar.TabIndex = 0;
            this.consultar.Text = "CONSULTA";
            this.consultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmConsultaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlConsultaDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTarifaRegistrar";
            this.PnlConsultaDetalle.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlConsultaDetalle;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultar;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox TxtPlaca;
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel consultar;
        private Bunifu.Framework.UI.BunifuCheckbox ChbIDConductor;
        private Bunifu.Framework.UI.BunifuCheckbox ChbPlaca;
        private Bunifu.Framework.UI.BunifuCheckbox ChbFecha;
        private Bunifu.Framework.UI.BunifuDatepicker DtpFecha;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTextbox TxtIDConductor;
    }
}