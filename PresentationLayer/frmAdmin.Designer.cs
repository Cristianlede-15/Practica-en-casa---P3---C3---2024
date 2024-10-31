namespace PresentationLayer
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.PanelFill = new System.Windows.Forms.Panel();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConsultaVisitas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Configuracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RegistrarVisita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFill
            // 
            this.PanelFill.BackgroundImage = global::PresentationLayer.Properties.Resources.Centro_Médico_Avanzado__1_;
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(322, 0);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Size = new System.Drawing.Size(1078, 900);
            this.PanelFill.TabIndex = 1;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = global::PresentationLayer.Properties.Resources.Diseño_sin_título__7_;
            this.panelIzquierdo.Controls.Add(this.pictureBox1);
            this.panelIzquierdo.Controls.Add(this.ConsultaVisitas);
            this.panelIzquierdo.Controls.Add(this.Configuracion);
            this.panelIzquierdo.Controls.Add(this.RegistrarVisita);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(322, 900);
            this.panelIzquierdo.TabIndex = 0;
            this.panelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierdo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.Diseño_sin_título__9_;
            this.pictureBox1.Location = new System.Drawing.Point(69, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaVisitas
            // 
            this.ConsultaVisitas.Activecolor = System.Drawing.Color.White;
            this.ConsultaVisitas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultaVisitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultaVisitas.BorderRadius = 0;
            this.ConsultaVisitas.ButtonText = "Consulta Visitas";
            this.ConsultaVisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultaVisitas.DisabledColor = System.Drawing.Color.Silver;
            this.ConsultaVisitas.ForeColor = System.Drawing.Color.White;
            this.ConsultaVisitas.Iconcolor = System.Drawing.Color.Transparent;
            this.ConsultaVisitas.Iconimage = ((System.Drawing.Image)(resources.GetObject("ConsultaVisitas.Iconimage")));
            this.ConsultaVisitas.Iconimage_right = null;
            this.ConsultaVisitas.Iconimage_right_Selected = null;
            this.ConsultaVisitas.Iconimage_Selected = null;
            this.ConsultaVisitas.IconMarginLeft = 0;
            this.ConsultaVisitas.IconMarginRight = 0;
            this.ConsultaVisitas.IconRightVisible = true;
            this.ConsultaVisitas.IconRightZoom = 0D;
            this.ConsultaVisitas.IconVisible = true;
            this.ConsultaVisitas.IconZoom = 90D;
            this.ConsultaVisitas.IsTab = false;
            this.ConsultaVisitas.Location = new System.Drawing.Point(4, 650);
            this.ConsultaVisitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConsultaVisitas.Name = "ConsultaVisitas";
            this.ConsultaVisitas.Normalcolor = System.Drawing.Color.Transparent;
            this.ConsultaVisitas.OnHovercolor = System.Drawing.Color.Silver;
            this.ConsultaVisitas.OnHoverTextColor = System.Drawing.Color.White;
            this.ConsultaVisitas.selected = false;
            this.ConsultaVisitas.Size = new System.Drawing.Size(318, 74);
            this.ConsultaVisitas.TabIndex = 2;
            this.ConsultaVisitas.Text = "Consulta Visitas";
            this.ConsultaVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConsultaVisitas.Textcolor = System.Drawing.Color.White;
            this.ConsultaVisitas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaVisitas.Click += new System.EventHandler(this.ConsultaVisitas_Click);
            // 
            // Configuracion
            // 
            this.Configuracion.Activecolor = System.Drawing.Color.White;
            this.Configuracion.BackColor = System.Drawing.Color.Transparent;
            this.Configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Configuracion.BorderRadius = 0;
            this.Configuracion.ButtonText = "Configuracion";
            this.Configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Configuracion.DisabledColor = System.Drawing.Color.Silver;
            this.Configuracion.ForeColor = System.Drawing.Color.White;
            this.Configuracion.Iconcolor = System.Drawing.Color.Transparent;
            this.Configuracion.Iconimage = ((System.Drawing.Image)(resources.GetObject("Configuracion.Iconimage")));
            this.Configuracion.Iconimage_right = null;
            this.Configuracion.Iconimage_right_Selected = null;
            this.Configuracion.Iconimage_Selected = null;
            this.Configuracion.IconMarginLeft = 0;
            this.Configuracion.IconMarginRight = 0;
            this.Configuracion.IconRightVisible = true;
            this.Configuracion.IconRightZoom = 0D;
            this.Configuracion.IconVisible = true;
            this.Configuracion.IconZoom = 90D;
            this.Configuracion.IsTab = false;
            this.Configuracion.Location = new System.Drawing.Point(4, 450);
            this.Configuracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Normalcolor = System.Drawing.Color.Transparent;
            this.Configuracion.OnHovercolor = System.Drawing.Color.Gray;
            this.Configuracion.OnHoverTextColor = System.Drawing.Color.White;
            this.Configuracion.selected = false;
            this.Configuracion.Size = new System.Drawing.Size(318, 74);
            this.Configuracion.TabIndex = 1;
            this.Configuracion.Text = "Configuracion";
            this.Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Configuracion.Textcolor = System.Drawing.Color.White;
            this.Configuracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configuracion.Click += new System.EventHandler(this.Configuracion_Click);
            // 
            // RegistrarVisita
            // 
            this.RegistrarVisita.Activecolor = System.Drawing.Color.White;
            this.RegistrarVisita.BackColor = System.Drawing.Color.Transparent;
            this.RegistrarVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegistrarVisita.BorderRadius = 0;
            this.RegistrarVisita.ButtonText = "Registrar Visita";
            this.RegistrarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrarVisita.DisabledColor = System.Drawing.Color.Silver;
            this.RegistrarVisita.ForeColor = System.Drawing.Color.White;
            this.RegistrarVisita.Iconcolor = System.Drawing.Color.Transparent;
            this.RegistrarVisita.Iconimage = ((System.Drawing.Image)(resources.GetObject("RegistrarVisita.Iconimage")));
            this.RegistrarVisita.Iconimage_right = null;
            this.RegistrarVisita.Iconimage_right_Selected = null;
            this.RegistrarVisita.Iconimage_Selected = null;
            this.RegistrarVisita.IconMarginLeft = 0;
            this.RegistrarVisita.IconMarginRight = 0;
            this.RegistrarVisita.IconRightVisible = true;
            this.RegistrarVisita.IconRightZoom = 0D;
            this.RegistrarVisita.IconVisible = true;
            this.RegistrarVisita.IconZoom = 90D;
            this.RegistrarVisita.IsTab = false;
            this.RegistrarVisita.Location = new System.Drawing.Point(4, 250);
            this.RegistrarVisita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegistrarVisita.Name = "RegistrarVisita";
            this.RegistrarVisita.Normalcolor = System.Drawing.Color.Transparent;
            this.RegistrarVisita.OnHovercolor = System.Drawing.Color.Gray;
            this.RegistrarVisita.OnHoverTextColor = System.Drawing.Color.White;
            this.RegistrarVisita.selected = false;
            this.RegistrarVisita.Size = new System.Drawing.Size(311, 74);
            this.RegistrarVisita.TabIndex = 0;
            this.RegistrarVisita.Text = "Registrar Visita";
            this.RegistrarVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistrarVisita.Textcolor = System.Drawing.Color.White;
            this.RegistrarVisita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarVisita.Click += new System.EventHandler(this.RegistrarVisita_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.panelIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.panelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel PanelFill;
        private Bunifu.Framework.UI.BunifuFlatButton ConsultaVisitas;
        private Bunifu.Framework.UI.BunifuFlatButton Configuracion;
        private Bunifu.Framework.UI.BunifuFlatButton RegistrarVisita;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}