
namespace PresentacionGUI
{
    partial class x
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(x));
            this.PnlConsultaPersona = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TxtIdentificacionConductor = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtgDetallesRegistrados = new System.Windows.Forms.DataGridView();
            this.consulta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlConsultaPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlConsultaPersona
            // 
            this.PnlConsultaPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlConsultaPersona.BackgroundImage")));
            this.PnlConsultaPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlConsultaPersona.Controls.Add(this.TxtIdentificacionConductor);
            this.PnlConsultaPersona.Controls.Add(this.BtnConsultar);
            this.PnlConsultaPersona.Controls.Add(this.label2);
            this.PnlConsultaPersona.Controls.Add(this.BtnVolver);
            this.PnlConsultaPersona.Controls.Add(this.DtgDetallesRegistrados);
            this.PnlConsultaPersona.Controls.Add(this.consulta);
            this.PnlConsultaPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConsultaPersona.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlConsultaPersona.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlConsultaPersona.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlConsultaPersona.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlConsultaPersona.Location = new System.Drawing.Point(0, 0);
            this.PnlConsultaPersona.Name = "PnlConsultaPersona";
            this.PnlConsultaPersona.Quality = 10;
            this.PnlConsultaPersona.Size = new System.Drawing.Size(925, 611);
            this.PnlConsultaPersona.TabIndex = 2;
            // 
            // TxtIdentificacionConductor
            // 
            this.TxtIdentificacionConductor.BackColor = System.Drawing.Color.Silver;
            this.TxtIdentificacionConductor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.BackgroundImage")));
            this.TxtIdentificacionConductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacionConductor.ForeColor = System.Drawing.Color.DimGray;
            this.TxtIdentificacionConductor.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacionConductor.Icon")));
            this.TxtIdentificacionConductor.Location = new System.Drawing.Point(322, 167);
            this.TxtIdentificacionConductor.Name = "TxtIdentificacionConductor";
            this.TxtIdentificacionConductor.Size = new System.Drawing.Size(231, 18);
            this.TxtIdentificacionConductor.TabIndex = 36;
            this.TxtIdentificacionConductor.text = "";
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
            this.BtnConsultar.Location = new System.Drawing.Point(610, 167);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.selected = false;
            this.BtnConsultar.Size = new System.Drawing.Size(120, 26);
            this.BtnConsultar.TabIndex = 25;
            this.BtnConsultar.Text = "    CONSULTAR";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Textcolor = System.Drawing.Color.Black;
            this.BtnConsultar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(187, 167);
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
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(137, 233);
            this.DtgDetallesRegistrados.Name = "DtgDetallesRegistrados";
            this.DtgDetallesRegistrados.Size = new System.Drawing.Size(615, 246);
            this.DtgDetallesRegistrados.TabIndex = 1;
            // 
            // consulta
            // 
            this.consulta.AccessibleName = "";
            this.consulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.consulta.AutoSize = true;
            this.consulta.BackColor = System.Drawing.Color.Transparent;
            this.consulta.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consulta.Location = new System.Drawing.Point(354, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(199, 38);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "CONSULTA";
            this.consulta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.PnlConsultaPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "x";
            this.Text = "FrmConsultarPersona";
            this.PnlConsultaPersona.ResumeLayout(false);
            this.PnlConsultaPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetallesRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlConsultaPersona;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVolver;
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel consulta;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacionConductor;
    }
}