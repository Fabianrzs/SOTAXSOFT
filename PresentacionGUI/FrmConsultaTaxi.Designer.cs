
namespace PresentacionGUI
{
    partial class FrmConsultaTaxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaTaxi));
            this.PnlConsultaTaxi = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TxtIdentificacionPropietario = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChbIDPropietario = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtPlaca = new Bunifu.Framework.UI.BunifuTextbox();
            this.TxtIdentificacionConductor = new Bunifu.Framework.UI.BunifuTextbox();
            this.ChbIDConductor = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChbPlca = new Bunifu.Framework.UI.BunifuCheckbox();
            this.DtgTaxisRegistrados = new System.Windows.Forms.DataGridView();
            this.REGISTRO = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlConsultaTaxi.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTaxisRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlConsultaTaxi
            // 
            this.PnlConsultaTaxi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlConsultaTaxi.BackgroundImage")));
            this.PnlConsultaTaxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlConsultaTaxi.Controls.Add(this.bunifuCustomLabel7);
            this.PnlConsultaTaxi.Controls.Add(this.bunifuSeparator1);
            this.PnlConsultaTaxi.Controls.Add(this.bunifuSeparator2);
            this.PnlConsultaTaxi.Controls.Add(this.bunifuGradientPanel1);
            this.PnlConsultaTaxi.Controls.Add(this.DtgTaxisRegistrados);
            this.PnlConsultaTaxi.Controls.Add(this.REGISTRO);
            this.PnlConsultaTaxi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConsultaTaxi.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlConsultaTaxi.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlConsultaTaxi.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlConsultaTaxi.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlConsultaTaxi.Location = new System.Drawing.Point(0, 0);
            this.PnlConsultaTaxi.Name = "PnlConsultaTaxi";
            this.PnlConsultaTaxi.Quality = 10;
            this.PnlConsultaTaxi.Size = new System.Drawing.Size(1300, 700);
            this.PnlConsultaTaxi.TabIndex = 22;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AccessibleName = "";
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(368, 146);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 24);
            this.bunifuCustomLabel7.TabIndex = 47;
            this.bunifuCustomLabel7.Text = "Registros";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(304, 167);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(214, 10);
            this.bunifuSeparator1.TabIndex = 46;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(493, 95);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(290, 10);
            this.bunifuSeparator2.TabIndex = 45;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.TxtIdentificacionPropietario);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.BtnConsultar);
            this.bunifuGradientPanel1.Controls.Add(this.ChbIDPropietario);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.TxtPlaca);
            this.bunifuGradientPanel1.Controls.Add(this.TxtIdentificacionConductor);
            this.bunifuGradientPanel1.Controls.Add(this.ChbIDConductor);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.ChbPlca);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkSlateGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(858, 123);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(370, 444);
            this.bunifuGradientPanel1.TabIndex = 44;
            // 
            // TxtIdentificacionPropietario
            // 
            this.TxtIdentificacionPropietario.BackColor = System.Drawing.Color.White;
            this.TxtIdentificacionPropietario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionPropietario.BackgroundImage")));
            this.TxtIdentificacionPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacionPropietario.ForeColor = System.Drawing.Color.White;
            this.TxtIdentificacionPropietario.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionPropietario.Icon")));
            this.TxtIdentificacionPropietario.Location = new System.Drawing.Point(197, 187);
            this.TxtIdentificacionPropietario.Name = "TxtIdentificacionPropietario";
            this.TxtIdentificacionPropietario.Size = new System.Drawing.Size(130, 18);
            this.TxtIdentificacionPropietario.TabIndex = 36;
            this.TxtIdentificacionPropietario.text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID Propietario";
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
            this.BtnConsultar.Location = new System.Drawing.Point(122, 295);
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
            // ChbIDPropietario
            // 
            this.ChbIDPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbIDPropietario.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbIDPropietario.Checked = true;
            this.ChbIDPropietario.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbIDPropietario.ForeColor = System.Drawing.Color.White;
            this.ChbIDPropietario.Location = new System.Drawing.Point(53, 187);
            this.ChbIDPropietario.Name = "ChbIDPropietario";
            this.ChbIDPropietario.Size = new System.Drawing.Size(20, 20);
            this.ChbIDPropietario.TabIndex = 31;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AccessibleName = "";
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(114, 19);
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
            this.TxtPlaca.Location = new System.Drawing.Point(197, 83);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(130, 18);
            this.TxtPlaca.TabIndex = 22;
            this.TxtPlaca.text = "";
            // 
            // TxtIdentificacionConductor
            // 
            this.TxtIdentificacionConductor.BackColor = System.Drawing.Color.White;
            this.TxtIdentificacionConductor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.BackgroundImage")));
            this.TxtIdentificacionConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacionConductor.ForeColor = System.Drawing.Color.White;
            this.TxtIdentificacionConductor.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.Icon")));
            this.TxtIdentificacionConductor.Location = new System.Drawing.Point(197, 132);
            this.TxtIdentificacionConductor.Name = "TxtIdentificacionConductor";
            this.TxtIdentificacionConductor.Size = new System.Drawing.Size(130, 18);
            this.TxtIdentificacionConductor.TabIndex = 27;
            this.TxtIdentificacionConductor.text = "";
            // 
            // ChbIDConductor
            // 
            this.ChbIDConductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbIDConductor.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbIDConductor.Checked = true;
            this.ChbIDConductor.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbIDConductor.ForeColor = System.Drawing.Color.White;
            this.ChbIDConductor.Location = new System.Drawing.Point(53, 130);
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
            this.label3.Location = new System.Drawing.Point(146, 83);
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
            this.label5.Location = new System.Drawing.Point(84, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "ID Conductor ";
            // 
            // ChbPlca
            // 
            this.ChbPlca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbPlca.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChbPlca.Checked = true;
            this.ChbPlca.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChbPlca.ForeColor = System.Drawing.Color.White;
            this.ChbPlca.Location = new System.Drawing.Point(53, 83);
            this.ChbPlca.Name = "ChbPlca";
            this.ChbPlca.Size = new System.Drawing.Size(20, 20);
            this.ChbPlca.TabIndex = 28;
            // 
            // DtgTaxisRegistrados
            // 
            this.DtgTaxisRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.DtgTaxisRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTaxisRegistrados.Location = new System.Drawing.Point(22, 178);
            this.DtgTaxisRegistrados.Name = "DtgTaxisRegistrados";
            this.DtgTaxisRegistrados.Size = new System.Drawing.Size(770, 210);
            this.DtgTaxisRegistrados.TabIndex = 1;
            // 
            // REGISTRO
            // 
            this.REGISTRO.AccessibleName = "";
            this.REGISTRO.BackColor = System.Drawing.Color.Transparent;
            this.REGISTRO.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REGISTRO.Location = new System.Drawing.Point(542, 54);
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Size = new System.Drawing.Size(199, 38);
            this.REGISTRO.TabIndex = 0;
            this.REGISTRO.Text = "CONSULTA";
            this.REGISTRO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmConsultaTaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlConsultaTaxi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaTaxi";
            this.Text = "FrmConsultaTaxi";
            this.PnlConsultaTaxi.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTaxisRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlConsultaTaxi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultar;
        private Bunifu.Framework.UI.BunifuCheckbox ChbIDPropietario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTextbox TxtPlaca;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacionConductor;
        private Bunifu.Framework.UI.BunifuCheckbox ChbIDConductor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox ChbPlca;
        private System.Windows.Forms.DataGridView DtgTaxisRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel REGISTRO;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacionPropietario;
        private System.Windows.Forms.Label label1;
    }
}