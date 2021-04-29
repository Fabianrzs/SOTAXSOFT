
namespace PresentacionGUI
{
    partial class FrmConsultaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPersona));
            this.PnlConsultaPersona = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TxtIdentificacion = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.PnlConsultaPersona.Controls.Add(this.bunifuSeparator1);
            this.PnlConsultaPersona.Controls.Add(this.bunifuSeparator2);
            this.PnlConsultaPersona.Controls.Add(this.TxtIdentificacion);
            this.PnlConsultaPersona.Controls.Add(this.BtnConsultar);
            this.PnlConsultaPersona.Controls.Add(this.label2);
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
            this.PnlConsultaPersona.Size = new System.Drawing.Size(1300, 700);
            this.PnlConsultaPersona.TabIndex = 2;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(493, 77);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(288, 13);
            this.bunifuSeparator1.TabIndex = 39;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(366, 192);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(561, 10);
            this.bunifuSeparator2.TabIndex = 38;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.White;
            this.TxtIdentificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacion.BackgroundImage")));
            this.TxtIdentificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.TxtIdentificacion.Icon = ((System.Drawing.Image)(resources.GetObject("TxtIdentificacion.Icon")));
            this.TxtIdentificacion.Location = new System.Drawing.Point(521, 171);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(231, 18);
            this.TxtIdentificacion.TabIndex = 36;
            this.TxtIdentificacion.text = "";
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
            this.BtnConsultar.Location = new System.Drawing.Point(797, 161);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnConsultar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.selected = false;
            this.BtnConsultar.Size = new System.Drawing.Size(120, 36);
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificacion";
            // 
            // DtgDetallesRegistrados
            // 
            this.DtgDetallesRegistrados.BackgroundColor = System.Drawing.Color.White;
            this.DtgDetallesRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetallesRegistrados.Location = new System.Drawing.Point(183, 223);
            this.DtgDetallesRegistrados.Name = "DtgDetallesRegistrados";
            this.DtgDetallesRegistrados.Size = new System.Drawing.Size(927, 286);
            this.DtgDetallesRegistrados.TabIndex = 1;
            // 
            // consulta
            // 
            this.consulta.AccessibleName = "";
            this.consulta.BackColor = System.Drawing.Color.Transparent;
            this.consulta.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consulta.Location = new System.Drawing.Point(545, 41);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(199, 38);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "CONSULTA";
            this.consulta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlConsultaPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaPersona";
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
        private System.Windows.Forms.DataGridView DtgDetallesRegistrados;
        private Bunifu.Framework.UI.BunifuCustomLabel consulta;
        private Bunifu.Framework.UI.BunifuTextbox TxtIdentificacion;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}