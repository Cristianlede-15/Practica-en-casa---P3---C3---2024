namespace PresentationLayer
{
    partial class frmConsultaVisitas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEdificio = new System.Windows.Forms.ComboBox();
            this.Edificio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtpFechaFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpFechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dgvVisitas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PresentationLayer.Properties.Resources.Diseño_sin_título__12_;
            this.panel2.Controls.Add(this.cmbEdificio);
            this.panel2.Controls.Add(this.Edificio);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.dtpFechaFin);
            this.panel2.Controls.Add(this.dtpFechaInicio);
            this.panel2.Controls.Add(this.dgvVisitas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 734);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbEdificio
            // 
            this.cmbEdificio.BackColor = System.Drawing.Color.LightGray;
            this.cmbEdificio.ForeColor = System.Drawing.Color.Navy;
            this.cmbEdificio.FormattingEnabled = true;
            this.cmbEdificio.Location = new System.Drawing.Point(155, 92);
            this.cmbEdificio.Name = "cmbEdificio";
            this.cmbEdificio.Size = new System.Drawing.Size(454, 28);
            this.cmbEdificio.TabIndex = 15;
            // 
            // Edificio
            // 
            this.Edificio.AutoSize = true;
            this.Edificio.BackColor = System.Drawing.Color.Transparent;
            this.Edificio.ForeColor = System.Drawing.Color.Navy;
            this.Edificio.Location = new System.Drawing.Point(174, 69);
            this.Edificio.Name = "Edificio";
            this.Edificio.Size = new System.Drawing.Size(60, 20);
            this.Edificio.TabIndex = 14;
            this.Edificio.Text = "Edificio";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(174, 317);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 20);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Hora Salida";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(174, 193);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 20);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Hora Entrada";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.BackgroundImage = global::PresentationLayer.Properties.Resources.Buscar;
            this.btnBuscar.ErrorImage = global::PresentationLayer.Properties.Resources.Buscar;
            this.btnBuscar.Image = global::PresentationLayer.Properties.Resources.Buscar;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(560, 574);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(280, 65);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.BackColor = System.Drawing.Color.LightGray;
            this.dtpFechaFin.BorderRadius = 0;
            this.dtpFechaFin.ForeColor = System.Drawing.Color.Navy;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaFin.FormatCustom = null;
            this.dtpFechaFin.Location = new System.Drawing.Point(155, 342);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(454, 55);
            this.dtpFechaFin.TabIndex = 3;
            this.dtpFechaFin.Value = new System.DateTime(2024, 7, 31, 23, 20, 50, 448);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BackColor = System.Drawing.Color.LightGray;
            this.dtpFechaInicio.BorderRadius = 0;
            this.dtpFechaInicio.ForeColor = System.Drawing.Color.Navy;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaInicio.FormatCustom = null;
            this.dtpFechaInicio.Location = new System.Drawing.Point(155, 218);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(454, 55);
            this.dtpFechaInicio.TabIndex = 2;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 7, 31, 23, 20, 27, 229);
            // 
            // dgvVisitas
            // 
            this.dgvVisitas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitas.Location = new System.Drawing.Point(770, 94);
            this.dgvVisitas.Name = "dgvVisitas";
            this.dgvVisitas.RowHeadersWidth = 62;
            this.dgvVisitas.RowTemplate.Height = 28;
            this.dgvVisitas.Size = new System.Drawing.Size(466, 303);
            this.dgvVisitas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.Registrar_Visita__1_;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 166);
            this.panel1.TabIndex = 0;
            // 
            // frmConsultaVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaVisitas";
            this.Load += new System.EventHandler(this.frmConsultaVisitas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVisitas;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFechaFin;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFechaInicio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Edificio;
        private System.Windows.Forms.ComboBox cmbEdificio;
    }
}