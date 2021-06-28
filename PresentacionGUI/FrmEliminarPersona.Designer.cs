
namespace PresentacionGUI
{
    partial class FrmEliminarPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarPersona));
            this.PnlEliminarPersona = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtConfirmarID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TxtIdentificacion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnConsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgPersonaRegistrada = new System.Windows.Forms.DataGridView();
            this.consulta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlEliminarPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersonaRegistrada)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlEliminarPersona
            // 
            this.PnlEliminarPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlEliminarPersona.BackgroundImage")));
            this.PnlEliminarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlEliminarPersona.Controls.Add(this.BtnEliminar);
            this.PnlEliminarPersona.Controls.Add(this.TxtConfirmarID);
            this.PnlEliminarPersona.Controls.Add(this.TxtIdentificacion);
            this.PnlEliminarPersona.Controls.Add(this.bunifuSeparator3);
            this.PnlEliminarPersona.Controls.Add(this.label1);
            this.PnlEliminarPersona.Controls.Add(this.bunifuSeparator1);
            this.PnlEliminarPersona.Controls.Add(this.bunifuSeparator2);
            this.PnlEliminarPersona.Controls.Add(this.BtnConsultar);
            this.PnlEliminarPersona.Controls.Add(this.label2);
            this.PnlEliminarPersona.Controls.Add(this.DtgPersonaRegistrada);
            this.PnlEliminarPersona.Controls.Add(this.consulta);
            this.PnlEliminarPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEliminarPersona.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.PnlEliminarPersona.GradientBottomRight = System.Drawing.Color.Honeydew;
            this.PnlEliminarPersona.GradientTopLeft = System.Drawing.Color.Maroon;
            this.PnlEliminarPersona.GradientTopRight = System.Drawing.Color.MistyRose;
            this.PnlEliminarPersona.Location = new System.Drawing.Point(0, 0);
            this.PnlEliminarPersona.Name = "PnlEliminarPersona";
            this.PnlEliminarPersona.Quality = 10;
            this.PnlEliminarPersona.Size = new System.Drawing.Size(1300, 700);
            this.PnlEliminarPersona.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 0;
            this.BtnEliminar.ButtonText = "    ELIMINAR";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Iconimage")));
            this.BtnEliminar.Iconimage_right = null;
            this.BtnEliminar.Iconimage_right_Selected = null;
            this.BtnEliminar.Iconimage_Selected = null;
            this.BtnEliminar.IconMarginLeft = 0;
            this.BtnEliminar.IconMarginRight = 0;
            this.BtnEliminar.IconRightVisible = true;
            this.BtnEliminar.IconRightZoom = 0D;
            this.BtnEliminar.IconVisible = true;
            this.BtnEliminar.IconZoom = 50D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(870, 478);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(120, 26);
            this.BtnEliminar.TabIndex = 45;
            this.BtnEliminar.Text = "    ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtConfirmarID
            // 
            this.TxtConfirmarID.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtConfirmarID.Location = new System.Drawing.Point(634, 484);
            this.TxtConfirmarID.Name = "TxtConfirmarID";
            this.TxtConfirmarID.Size = new System.Drawing.Size(158, 20);
            this.TxtConfirmarID.TabIndex = 44;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BorderColor = System.Drawing.Color.SeaGreen;
            this.TxtIdentificacion.Location = new System.Drawing.Point(523, 142);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(158, 20);
            this.TxtIdentificacion.TabIndex = 43;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(409, 511);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(402, 13);
            this.bunifuSeparator3.TabIndex = 42;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(427, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Confirmar Identificacion";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(469, 79);
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
            this.bunifuSeparator2.Location = new System.Drawing.Point(337, 169);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(561, 10);
            this.bunifuSeparator2.TabIndex = 38;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
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
            this.BtnConsultar.Location = new System.Drawing.Point(766, 141);
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
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificacion";
            // 
            // DtgPersonaRegistrada
            // 
            this.DtgPersonaRegistrada.BackgroundColor = System.Drawing.Color.White;
            this.DtgPersonaRegistrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPersonaRegistrada.Location = new System.Drawing.Point(98, 194);
            this.DtgPersonaRegistrada.Name = "DtgPersonaRegistrada";
            this.DtgPersonaRegistrada.Size = new System.Drawing.Size(1061, 255);
            this.DtgPersonaRegistrada.TabIndex = 1;
            this.DtgPersonaRegistrada.DoubleClick += new System.EventHandler(this.DtgPersonaRegistrada_DoubleClick);
            // 
            // consulta
            // 
            this.consulta.AccessibleName = "";
            this.consulta.BackColor = System.Drawing.Color.Transparent;
            this.consulta.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consulta.Location = new System.Drawing.Point(527, 38);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(181, 38);
            this.consulta.TabIndex = 0;
            this.consulta.Text = "ELIMINAR";
            this.consulta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmEliminarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PnlEliminarPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarPersona";
            this.Text = "FrmEliminarPersona";
            this.PnlEliminarPersona.ResumeLayout(false);
            this.PnlEliminarPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPersonaRegistrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PnlEliminarPersona;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtgPersonaRegistrada;
        private Bunifu.Framework.UI.BunifuCustomLabel consulta;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtConfirmarID;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TxtIdentificacion;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
    }
}