
namespace PresentacionGUI
{
    partial class FrmTarifaRegistrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarifaRegistrar));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_registroDetalle = new System.Windows.Forms.Panel();
            this.btnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnlimpiarCampos = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.pnl_registroDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(215, 191);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(464, 197);
            this.bunifuCustomDataGrid1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Consultar Gastos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(341, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar  Tarifa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_registroDetalle
            // 
            this.pnl_registroDetalle.BackColor = System.Drawing.Color.OldLace;
            this.pnl_registroDetalle.Controls.Add(this.btnVolver);
            this.pnl_registroDetalle.Controls.Add(this.label1);
            this.pnl_registroDetalle.Controls.Add(this.label2);
            this.pnl_registroDetalle.Controls.Add(this.bunifuTextbox1);
            this.pnl_registroDetalle.Controls.Add(this.label4);
            this.pnl_registroDetalle.Controls.Add(this.BtnlimpiarCampos);
            this.pnl_registroDetalle.Controls.Add(this.bunifuCustomDataGrid1);
            this.pnl_registroDetalle.Location = new System.Drawing.Point(0, -1);
            this.pnl_registroDetalle.Name = "pnl_registroDetalle";
            this.pnl_registroDetalle.Size = new System.Drawing.Size(926, 614);
            this.pnl_registroDetalle.TabIndex = 11;
            this.pnl_registroDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_registroDetalle_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Activecolor = System.Drawing.Color.DarkRed;
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.BorderRadius = 0;
            this.btnVolver.ButtonText = "    CERRAR";
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.DisabledColor = System.Drawing.Color.Gray;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVolver.Iconimage = global::PresentacionGUI.Properties.Resources.volver_flecha;
            this.btnVolver.Iconimage_right = null;
            this.btnVolver.Iconimage_right_Selected = null;
            this.btnVolver.Iconimage_Selected = null;
            this.btnVolver.IconMarginLeft = 0;
            this.btnVolver.IconMarginRight = 0;
            this.btnVolver.IconRightVisible = true;
            this.btnVolver.IconRightZoom = 0D;
            this.btnVolver.IconVisible = true;
            this.btnVolver.IconZoom = 50D;
            this.btnVolver.IsTab = false;
            this.btnVolver.Location = new System.Drawing.Point(119, 462);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnVolver.selected = false;
            this.btnVolver.Size = new System.Drawing.Size(120, 26);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "    CERRAR";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Textcolor = System.Drawing.Color.Black;
            this.btnVolver.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(448, 134);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(98, 18);
            this.bunifuTextbox1.TabIndex = 8;
            this.bunifuTextbox1.text = "";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // BtnlimpiarCampos
            // 
            this.BtnlimpiarCampos.Activecolor = System.Drawing.Color.DarkRed;
            this.BtnlimpiarCampos.BackColor = System.Drawing.Color.Transparent;
            this.BtnlimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnlimpiarCampos.BorderRadius = 0;
            this.BtnlimpiarCampos.ButtonText = " LIMPIAR CAMPOS";
            this.BtnlimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnlimpiarCampos.DisabledColor = System.Drawing.Color.Gray;
            this.BtnlimpiarCampos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnlimpiarCampos.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnlimpiarCampos.Iconimage = global::PresentacionGUI.Properties.Resources.limpiar11;
            this.BtnlimpiarCampos.Iconimage_right = null;
            this.BtnlimpiarCampos.Iconimage_right_Selected = null;
            this.BtnlimpiarCampos.Iconimage_Selected = null;
            this.BtnlimpiarCampos.IconMarginLeft = 0;
            this.BtnlimpiarCampos.IconMarginRight = 0;
            this.BtnlimpiarCampos.IconRightVisible = true;
            this.BtnlimpiarCampos.IconRightZoom = 0D;
            this.BtnlimpiarCampos.IconVisible = true;
            this.BtnlimpiarCampos.IconZoom = 50D;
            this.BtnlimpiarCampos.IsTab = false;
            this.BtnlimpiarCampos.Location = new System.Drawing.Point(732, 334);
            this.BtnlimpiarCampos.Name = "BtnlimpiarCampos";
            this.BtnlimpiarCampos.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnlimpiarCampos.OnHovercolor = System.Drawing.Color.Transparent;
            this.BtnlimpiarCampos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnlimpiarCampos.selected = false;
            this.BtnlimpiarCampos.Size = new System.Drawing.Size(181, 54);
            this.BtnlimpiarCampos.TabIndex = 13;
            this.BtnlimpiarCampos.Text = " LIMPIAR CAMPOS";
            this.BtnlimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnlimpiarCampos.Textcolor = System.Drawing.Color.Black;
            this.BtnlimpiarCampos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnlimpiarCampos.Click += new System.EventHandler(this.BtnTarifa_Click);
            // 
            // FrmTarifaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.pnl_registroDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTarifaRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTarifaRegistrar";
            this.Load += new System.EventHandler(this.FrmTarifaRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.pnl_registroDetalle.ResumeLayout(false);
            this.pnl_registroDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnlimpiarCampos;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnVolver;
        private System.Windows.Forms.Panel pnl_registroDetalle;
    }
}