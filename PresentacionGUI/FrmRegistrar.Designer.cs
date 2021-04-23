
namespace PresentacionGUI
{
    partial class FrmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pnl_registroDetalle = new System.Windows.Forms.Panel();
            this.btnVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_registrarGastos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_registarTarifa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnlimpiarCampos = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.pnl_registroDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar Tarifa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(98, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(250, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarifa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(101, 216);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(464, 197);
            this.bunifuCustomDataGrid1.TabIndex = 9;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(253, 159);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(100, 20);
            this.bunifuCustomTextbox1.TabIndex = 10;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // pnl_registroDetalle
            // 
            this.pnl_registroDetalle.BackColor = System.Drawing.Color.OldLace;
            this.pnl_registroDetalle.Controls.Add(this.btnVolver);
            this.pnl_registroDetalle.Controls.Add(this.label1);
            this.pnl_registroDetalle.Controls.Add(this.bunifuDatepicker1);
            this.pnl_registroDetalle.Controls.Add(this.label2);
            this.pnl_registroDetalle.Controls.Add(this.bunifuTextbox1);
            this.pnl_registroDetalle.Controls.Add(this.bunifuCustomTextbox2);
            this.pnl_registroDetalle.Controls.Add(this.label6);
            this.pnl_registroDetalle.Controls.Add(this.bunifuCustomTextbox1);
            this.pnl_registroDetalle.Controls.Add(this.label3);
            this.pnl_registroDetalle.Controls.Add(this.label5);
            this.pnl_registroDetalle.Controls.Add(this.label4);
            this.pnl_registroDetalle.Controls.Add(this.Btn_registrarGastos);
            this.pnl_registroDetalle.Controls.Add(this.Btn_registarTarifa);
            this.pnl_registroDetalle.Controls.Add(this.BtnlimpiarCampos);
            this.pnl_registroDetalle.Controls.Add(this.bunifuCustomDataGrid1);
            this.pnl_registroDetalle.Location = new System.Drawing.Point(-3, -1);
            this.pnl_registroDetalle.Name = "pnl_registroDetalle";
            this.pnl_registroDetalle.Size = new System.Drawing.Size(930, 612);
            this.pnl_registroDetalle.TabIndex = 11;
            this.pnl_registroDetalle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_registroDetalle_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Activecolor = System.Drawing.Color.DarkRed;
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.BorderRadius = 0;
            this.btnVolver.ButtonText = "        CERRAR";
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
            this.btnVolver.Location = new System.Drawing.Point(101, 467);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnVolver.selected = false;
            this.btnVolver.Size = new System.Drawing.Size(181, 54);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "        CERRAR";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Textcolor = System.Drawing.Color.Black;
            this.btnVolver.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(586, 103);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(264, 36);
            this.bunifuDatepicker1.TabIndex = 12;
            this.bunifuDatepicker1.Value = new System.DateTime(2021, 4, 23, 12, 16, 55, 656);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(101, 159);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(100, 20);
            this.bunifuTextbox1.TabIndex = 8;
            this.bunifuTextbox1.text = "";
            this.bunifuTextbox1.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(431, 159);
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(100, 20);
            this.bunifuCustomTextbox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(428, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(300, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gasto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registrar Gastos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Btn_registrarGastos
            // 
            this.Btn_registrarGastos.Activecolor = System.Drawing.Color.DarkRed;
            this.Btn_registrarGastos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_registrarGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_registrarGastos.BorderRadius = 0;
            this.Btn_registrarGastos.ButtonText = "REGISTRAR GASTO";
            this.Btn_registrarGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_registrarGastos.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_registrarGastos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_registrarGastos.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_registrarGastos.Iconimage = global::PresentacionGUI.Properties.Resources.verificar;
            this.Btn_registrarGastos.Iconimage_right = null;
            this.Btn_registrarGastos.Iconimage_right_Selected = null;
            this.Btn_registrarGastos.Iconimage_Selected = null;
            this.Btn_registrarGastos.IconMarginLeft = 0;
            this.Btn_registrarGastos.IconMarginRight = 0;
            this.Btn_registrarGastos.IconRightVisible = true;
            this.Btn_registrarGastos.IconRightZoom = 0D;
            this.Btn_registrarGastos.IconVisible = true;
            this.Btn_registrarGastos.IconZoom = 50D;
            this.Btn_registrarGastos.IsTab = false;
            this.Btn_registrarGastos.Location = new System.Drawing.Point(654, 487);
            this.Btn_registrarGastos.Name = "Btn_registrarGastos";
            this.Btn_registrarGastos.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_registrarGastos.OnHovercolor = System.Drawing.Color.Transparent;
            this.Btn_registrarGastos.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_registrarGastos.selected = false;
            this.Btn_registrarGastos.Size = new System.Drawing.Size(181, 54);
            this.Btn_registrarGastos.TabIndex = 15;
            this.Btn_registrarGastos.Text = "REGISTRAR GASTO";
            this.Btn_registrarGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_registrarGastos.Textcolor = System.Drawing.Color.Black;
            this.Btn_registrarGastos.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_registarTarifa
            // 
            this.Btn_registarTarifa.Activecolor = System.Drawing.Color.DarkRed;
            this.Btn_registarTarifa.BackColor = System.Drawing.Color.Transparent;
            this.Btn_registarTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_registarTarifa.BorderRadius = 0;
            this.Btn_registarTarifa.ButtonText = "REGISTRAR TARIFA";
            this.Btn_registarTarifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_registarTarifa.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_registarTarifa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_registarTarifa.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_registarTarifa.Iconimage = global::PresentacionGUI.Properties.Resources.verificar;
            this.Btn_registarTarifa.Iconimage_right = null;
            this.Btn_registarTarifa.Iconimage_right_Selected = null;
            this.Btn_registarTarifa.Iconimage_Selected = null;
            this.Btn_registarTarifa.IconMarginLeft = 0;
            this.Btn_registarTarifa.IconMarginRight = 0;
            this.Btn_registarTarifa.IconRightVisible = true;
            this.Btn_registarTarifa.IconRightZoom = 0D;
            this.Btn_registarTarifa.IconVisible = true;
            this.Btn_registarTarifa.IconZoom = 50D;
            this.Btn_registarTarifa.IsTab = false;
            this.Btn_registarTarifa.Location = new System.Drawing.Point(467, 487);
            this.Btn_registarTarifa.Name = "Btn_registarTarifa";
            this.Btn_registarTarifa.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_registarTarifa.OnHovercolor = System.Drawing.Color.Transparent;
            this.Btn_registarTarifa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_registarTarifa.selected = false;
            this.Btn_registarTarifa.Size = new System.Drawing.Size(181, 54);
            this.Btn_registarTarifa.TabIndex = 14;
            this.Btn_registarTarifa.Text = "REGISTRAR TARIFA";
            this.Btn_registarTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_registarTarifa.Textcolor = System.Drawing.Color.Black;
            this.Btn_registarTarifa.TextFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnlimpiarCampos.Location = new System.Drawing.Point(717, 359);
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
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 611);
            this.Controls.Add(this.pnl_registroDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTarifaRegistrar";
            this.Load += new System.EventHandler(this.FrmTarifaRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.pnl_registroDetalle.ResumeLayout(false);
            this.pnl_registroDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.Panel pnl_registroDetalle;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnlimpiarCampos;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_registarTarifa;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_registrarGastos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btnVolver;
    }
}