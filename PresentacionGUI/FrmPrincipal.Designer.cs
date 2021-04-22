
namespace PresentacionGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PctRestaurar = new System.Windows.Forms.PictureBox();
            this.PctMinimizar = new System.Windows.Forms.PictureBox();
            this.PctMaximizar = new System.Windows.Forms.PictureBox();
            this.PctSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PctMenu = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.PnlCentral = new System.Windows.Forms.Panel();
            this.BnfMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.BnfSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMenu)).BeginInit();
            this.PnlIzquierdo.SuspendLayout();
            this.BnfMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlTitulo.Controls.Add(this.PctRestaurar);
            this.PnlTitulo.Controls.Add(this.PctMinimizar);
            this.PnlTitulo.Controls.Add(this.PctMaximizar);
            this.PnlTitulo.Controls.Add(this.PctSalir);
            this.PnlTitulo.Controls.Add(this.label1);
            this.PnlTitulo.Controls.Add(this.PctMenu);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1175, 40);
            this.PnlTitulo.TabIndex = 0;
            // 
            // PctRestaurar
            // 
            this.PctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctRestaurar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.PctRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PctRestaurar.Image")));
            this.PctRestaurar.Location = new System.Drawing.Point(1113, 9);
            this.PctRestaurar.Name = "PctRestaurar";
            this.PctRestaurar.Size = new System.Drawing.Size(22, 22);
            this.PctRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctRestaurar.TabIndex = 4;
            this.PctRestaurar.TabStop = false;
            this.PctRestaurar.Visible = false;
            this.PctRestaurar.Click += new System.EventHandler(this.PctRestaurar_Click);
            // 
            // PctMinimizar
            // 
            this.PctMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMinimizar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.PctMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMinimizar.Image")));
            this.PctMinimizar.Location = new System.Drawing.Point(1085, 9);
            this.PctMinimizar.Name = "PctMinimizar";
            this.PctMinimizar.Size = new System.Drawing.Size(22, 22);
            this.PctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMinimizar.TabIndex = 3;
            this.PctMinimizar.TabStop = false;
            this.PctMinimizar.Click += new System.EventHandler(this.PctMinimizar_Click);
            // 
            // PctMaximizar
            // 
            this.PctMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMaximizar.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.PctMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMaximizar.Image")));
            this.PctMaximizar.Location = new System.Drawing.Point(1113, 9);
            this.PctMaximizar.Name = "PctMaximizar";
            this.PctMaximizar.Size = new System.Drawing.Size(22, 22);
            this.PctMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMaximizar.TabIndex = 2;
            this.PctMaximizar.TabStop = false;
            this.PctMaximizar.Click += new System.EventHandler(this.PctMaximizar_Click);
            // 
            // PctSalir
            // 
            this.PctSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctSalir.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.PctSalir.Image = ((System.Drawing.Image)(resources.GetObject("PctSalir.Image")));
            this.PctSalir.Location = new System.Drawing.Point(1141, 9);
            this.PctSalir.Name = "PctSalir";
            this.PctSalir.Size = new System.Drawing.Size(22, 22);
            this.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSalir.TabIndex = 1;
            this.PctSalir.TabStop = false;
            this.PctSalir.Click += new System.EventHandler(this.PctSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // PctMenu
            // 
            this.PctMenu.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.PctMenu.Image = ((System.Drawing.Image)(resources.GetObject("PctMenu.Image")));
            this.PctMenu.Location = new System.Drawing.Point(12, 9);
            this.PctMenu.Name = "PctMenu";
            this.PctMenu.Size = new System.Drawing.Size(22, 22);
            this.PctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMenu.TabIndex = 0;
            this.PctMenu.TabStop = false;
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlIzquierdo.Controls.Add(this.BnfMenu);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 40);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(250, 553);
            this.PnlIzquierdo.TabIndex = 1;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BackColor = System.Drawing.Color.FloralWhite;
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(250, 40);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(925, 553);
            this.PnlCentral.TabIndex = 2;
            // 
            // BnfMenu
            // 
            this.BnfMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BnfMenu.BackgroundImage")));
            this.BnfMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BnfMenu.Controls.Add(this.bunifuFlatButton1);
            this.BnfMenu.Controls.Add(this.BnfSeparator);
            this.BnfMenu.Controls.Add(this.label2);
            this.BnfMenu.Controls.Add(this.PctLogo);
            this.BnfMenu.GradientBottomLeft = System.Drawing.Color.DarkSlateGray;
            this.BnfMenu.GradientBottomRight = System.Drawing.Color.Maroon;
            this.BnfMenu.GradientTopLeft = System.Drawing.Color.Teal;
            this.BnfMenu.GradientTopRight = System.Drawing.Color.Maroon;
            this.BnfMenu.Location = new System.Drawing.Point(12, 19);
            this.BnfMenu.Name = "BnfMenu";
            this.BnfMenu.Quality = 10;
            this.BnfMenu.Size = new System.Drawing.Size(220, 522);
            this.BnfMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOTAXSOFT";
            // 
            // PctLogo
            // 
            this.PctLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PctLogo.BackColor = System.Drawing.Color.Transparent;
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(4, 11);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(49, 48);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogo.TabIndex = 0;
            this.PctLogo.TabStop = false;
            // 
            // BnfSeparator
            // 
            this.BnfSeparator.BackColor = System.Drawing.Color.Transparent;
            this.BnfSeparator.LineColor = System.Drawing.Color.DimGray;
            this.BnfSeparator.LineThickness = 1;
            this.BnfSeparator.Location = new System.Drawing.Point(14, 65);
            this.BnfSeparator.Name = "BnfSeparator";
            this.BnfSeparator.Size = new System.Drawing.Size(200, 1);
            this.BnfSeparator.TabIndex = 0;
            this.BnfSeparator.Transparency = 255;
            this.BnfSeparator.Vertical = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(14, 81);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 48);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 593);
            this.Controls.Add(this.PnlCentral);
            this.Controls.Add(this.PnlIzquierdo);
            this.Controls.Add(this.PnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMenu)).EndInit();
            this.PnlIzquierdo.ResumeLayout(false);
            this.BnfMenu.ResumeLayout(false);
            this.BnfMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PctMenu;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Panel PnlCentral;
        private System.Windows.Forms.PictureBox PctSalir;
        private System.Windows.Forms.PictureBox PctRestaurar;
        private System.Windows.Forms.PictureBox PctMinimizar;
        private System.Windows.Forms.PictureBox PctMaximizar;
        private Bunifu.Framework.UI.BunifuGradientPanel BnfMenu;
        private Bunifu.Framework.UI.BunifuSeparator BnfSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PctLogo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

