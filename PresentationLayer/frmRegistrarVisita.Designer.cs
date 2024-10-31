namespace PresentationLayer
{
    partial class frmRegistrarVisita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarVisita));
            this.panel2 = new System.Windows.Forms.Panel();
            this.aulas = new System.Windows.Forms.ComboBox();
            this.cmbEdificio = new System.Windows.Forms.ComboBox();
            this.dtpHoraEntrada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtNombre = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Edificio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtpHoraSalida = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtMotivoVisita = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtCarrera = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PresentationLayer.Properties.Resources.Centro_Médico_Avanzado__2_;
            this.panel2.Controls.Add(this.aulas);
            this.panel2.Controls.Add(this.cmbEdificio);
            this.panel2.Controls.Add(this.dtpHoraEntrada);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.Edificio);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.dtpHoraSalida);
            this.panel2.Controls.Add(this.txtMotivoVisita);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtCarrera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 734);
            this.panel2.TabIndex = 1;
            // 
            // cmbAulaDestino
            // 
            this.aulas.BackColor = System.Drawing.Color.LightGray;
            this.aulas.ForeColor = System.Drawing.Color.Navy;
            this.aulas.FormattingEnabled = true;
            this.aulas.Location = new System.Drawing.Point(777, 425);
            this.aulas.Name = "cmbAulaDestino";
            this.aulas.Size = new System.Drawing.Size(466, 28);
            this.aulas.TabIndex = 24;
            this.aulas.SelectedIndexChanged += new System.EventHandler(this.cmbAulaDestino_SelectedIndexChanged);
            // 
            // cmbEdificio
            // 
            this.cmbEdificio.BackColor = System.Drawing.Color.LightGray;
            this.cmbEdificio.ForeColor = System.Drawing.Color.Navy;
            this.cmbEdificio.FormattingEnabled = true;
            this.cmbEdificio.Location = new System.Drawing.Point(777, 300);
            this.cmbEdificio.Name = "cmbEdificio";
            this.cmbEdificio.Size = new System.Drawing.Size(466, 28);
            this.cmbEdificio.TabIndex = 23;
            this.cmbEdificio.SelectedIndexChanged += new System.EventHandler(this.cmbEdificio_SelectedIndexChanged);
            this.cmbEdificio.TextChanged += new System.EventHandler(this.cmbEdificio_TextChanged);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.BackColor = System.Drawing.Color.LightGray;
            this.dtpHoraEntrada.BorderRadius = 0;
            this.dtpHoraEntrada.ForeColor = System.Drawing.Color.Navy;
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHoraEntrada.FormatCustom = null;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(777, 50);
            this.dtpHoraEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(466, 65);
            this.dtpHoraEntrada.TabIndex = 22;
            this.dtpHoraEntrada.Value = new System.DateTime(2024, 7, 31, 18, 12, 2, 351);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightGray;
            this.txtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombre.BackgroundImage")));
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNombre.ForeColor = System.Drawing.Color.Navy;
            this.txtNombre.Icon = ((System.Drawing.Image)(resources.GetObject("txtNombre.Icon")));
            this.txtNombre.Location = new System.Drawing.Point(155, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(466, 65);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.LightGray;
            this.txtApellido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtApellido.BackgroundImage")));
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtApellido.ForeColor = System.Drawing.Color.Navy;
            this.txtApellido.Icon = ((System.Drawing.Image)(resources.GetObject("txtApellido.Icon")));
            this.txtApellido.Location = new System.Drawing.Point(155, 144);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(466, 65);
            this.txtApellido.TabIndex = 20;
            this.txtApellido.text = "Apellido";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.BackgroundImage = global::PresentationLayer.Properties.Resources.Buscar__1_2;
            this.btnRegistrar.ErrorImage = global::PresentationLayer.Properties.Resources.Buscar__1_2;
            this.btnRegistrar.Image = global::PresentationLayer.Properties.Resources.Buscar__1_2;
            this.btnRegistrar.ImageActive = null;
            this.btnRegistrar.InitialImage = null;
            this.btnRegistrar.Location = new System.Drawing.Point(560, 574);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(280, 65);
            this.btnRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Zoom = 10;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(792, 400);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(100, 20);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Sala Destino";
            // 
            // Edificio
            // 
            this.Edificio.AutoSize = true;
            this.Edificio.BackColor = System.Drawing.Color.Transparent;
            this.Edificio.ForeColor = System.Drawing.Color.Navy;
            this.Edificio.Location = new System.Drawing.Point(792, 275);
            this.Edificio.Name = "Edificio";
            this.Edificio.Size = new System.Drawing.Size(60, 20);
            this.Edificio.TabIndex = 13;
            this.Edificio.Text = "Edificio";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(792, 150);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 20);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Hora Salida";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(792, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 20);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Hora Entrada";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.BackColor = System.Drawing.Color.LightGray;
            this.dtpHoraSalida.BorderRadius = 0;
            this.dtpHoraSalida.ForeColor = System.Drawing.Color.Navy;
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHoraSalida.FormatCustom = null;
            this.dtpHoraSalida.Location = new System.Drawing.Point(777, 175);
            this.dtpHoraSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(466, 65);
            this.dtpHoraSalida.TabIndex = 7;
            this.dtpHoraSalida.Value = new System.DateTime(2024, 7, 31, 18, 12, 2, 351);
            // 
            // txtMotivoVisita
            // 
            this.txtMotivoVisita.BackColor = System.Drawing.Color.LightGray;
            this.txtMotivoVisita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMotivoVisita.BackgroundImage")));
            this.txtMotivoVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMotivoVisita.ForeColor = System.Drawing.Color.Navy;
            this.txtMotivoVisita.Icon = ((System.Drawing.Image)(resources.GetObject("txtMotivoVisita.Icon")));
            this.txtMotivoVisita.Location = new System.Drawing.Point(155, 420);
            this.txtMotivoVisita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotivoVisita.Name = "txtMotivoVisita";
            this.txtMotivoVisita.Size = new System.Drawing.Size(466, 65);
            this.txtMotivoVisita.TabIndex = 4;
            this.txtMotivoVisita.text = "MotivoVisita";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.LightGray;
            this.txtCorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCorreo.BackgroundImage")));
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCorreo.ForeColor = System.Drawing.Color.Navy;
            this.txtCorreo.Icon = ((System.Drawing.Image)(resources.GetObject("txtCorreo.Icon")));
            this.txtCorreo.Location = new System.Drawing.Point(155, 328);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(466, 65);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.text = "Correo";
            this.txtCorreo.OnTextChange += new System.EventHandler(this.txtCorreo_OnTextChange);
            // 
            // txtCarrera
            // 
            this.txtCarrera.BackColor = System.Drawing.Color.LightGray;
            this.txtCarrera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCarrera.BackgroundImage")));
            this.txtCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCarrera.ForeColor = System.Drawing.Color.Navy;
            this.txtCarrera.Icon = ((System.Drawing.Image)(resources.GetObject("txtCarrera.Icon")));
            this.txtCarrera.Location = new System.Drawing.Point(155, 236);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(466, 65);
            this.txtCarrera.TabIndex = 2;
            this.txtCarrera.text = "Profecion";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.Registrar_Visita;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 166);
            this.panel1.TabIndex = 0;
            // 
            // frmRegistrarVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarVisita";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTextbox txtMotivoVisita;
        private Bunifu.Framework.UI.BunifuTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuTextbox txtCarrera;
        private Bunifu.Framework.UI.BunifuDatepicker dtpHoraSalida;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Edificio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton btnRegistrar;
        private Bunifu.Framework.UI.BunifuTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuDatepicker dtpHoraEntrada;
        private System.Windows.Forms.ComboBox cmbEdificio;
        private System.Windows.Forms.ComboBox aulas;
    }
}