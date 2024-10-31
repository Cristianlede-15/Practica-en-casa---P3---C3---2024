namespace PresentationLayer
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnGuardarUsuario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoUsuario = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtNombreUsuario = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstAulas = new System.Windows.Forms.ListBox();
            this.lstEdificios = new System.Windows.Forms.ListBox();
            this.btnGuardarEdificio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardarAula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNumeroAula = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtNombreEdificio = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PresentationLayer.Properties.Resources.Configuracion_de_sala_por_edificio__1_;
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.bunifuCustomLabel2);
            this.panel4.Controls.Add(this.bunifuCustomLabel1);
            this.panel4.Controls.Add(this.btnGuardarUsuario);
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.cmbTipoUsuario);
            this.panel4.Controls.Add(this.dtpFechaNacimiento);
            this.panel4.Controls.Add(this.txtApellidoUsuario);
            this.panel4.Controls.Add(this.txtNombreUsuario);
            this.panel4.Controls.Add(this.dgvUsuarios);
            this.panel4.Location = new System.Drawing.Point(0, 482);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1400, 419);
            this.panel4.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPassword.ForeColor = System.Drawing.Color.Navy;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Location = new System.Drawing.Point(770, 304);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(293, 65);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.text = "Contraseña";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(784, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(120, 20);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Tipo de Usuario";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(784, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(159, 20);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Fecha de Nacimiento";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Activecolor = System.Drawing.Color.White;
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarUsuario.BorderRadius = 0;
            this.btnGuardarUsuario.ButtonText = "Guardar";
            this.btnGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUsuario.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUsuario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarUsuario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarUsuario.Iconimage")));
            this.btnGuardarUsuario.Iconimage_right = null;
            this.btnGuardarUsuario.Iconimage_right_Selected = null;
            this.btnGuardarUsuario.Iconimage_Selected = null;
            this.btnGuardarUsuario.IconMarginLeft = 0;
            this.btnGuardarUsuario.IconMarginRight = 0;
            this.btnGuardarUsuario.IconRightVisible = true;
            this.btnGuardarUsuario.IconRightZoom = 0D;
            this.btnGuardarUsuario.IconVisible = true;
            this.btnGuardarUsuario.IconZoom = 90D;
            this.btnGuardarUsuario.IsTab = false;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(1109, 176);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Normalcolor = System.Drawing.Color.Silver;
            this.btnGuardarUsuario.OnHovercolor = System.Drawing.Color.Gray;
            this.btnGuardarUsuario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarUsuario.selected = false;
            this.btnGuardarUsuario.Size = new System.Drawing.Size(151, 65);
            this.btnGuardarUsuario.TabIndex = 6;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.Textcolor = System.Drawing.Color.Navy;
            this.btnGuardarUsuario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsuario.BackgroundImage")));
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUsuario.ForeColor = System.Drawing.Color.Navy;
            this.txtUsuario.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsuario.Icon")));
            this.txtUsuario.Location = new System.Drawing.Point(770, 220);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(293, 65);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.text = "Usuario";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "General"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(770, 135);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(293, 28);
            this.cmbTipoUsuario.TabIndex = 4;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(770, 50);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(293, 26);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtApellidoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtApellidoUsuario.BackgroundImage")));
            this.txtApellidoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtApellidoUsuario.ForeColor = System.Drawing.Color.Navy;
            this.txtApellidoUsuario.Icon = ((System.Drawing.Image)(resources.GetObject("txtApellidoUsuario.Icon")));
            this.txtApellidoUsuario.Location = new System.Drawing.Point(140, 304);
            this.txtApellidoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(493, 65);
            this.txtApellidoUsuario.TabIndex = 2;
            this.txtApellidoUsuario.text = "Apellido";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtNombreUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreUsuario.BackgroundImage")));
            this.txtNombreUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Navy;
            this.txtNombreUsuario.Icon = ((System.Drawing.Image)(resources.GetObject("txtNombreUsuario.Icon")));
            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 220);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(493, 65);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.text = "Nombre";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.Color.White;
            this.dgvUsuarios.Location = new System.Drawing.Point(140, 21);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(490, 174);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PresentationLayer.Properties.Resources.Configuracion_de_sala_por_edificio__1_;
            this.panel3.Controls.Add(this.lstAulas);
            this.panel3.Controls.Add(this.lstEdificios);
            this.panel3.Controls.Add(this.btnGuardarEdificio);
            this.panel3.Controls.Add(this.btnGuardarAula);
            this.panel3.Controls.Add(this.txtNumeroAula);
            this.panel3.Controls.Add(this.txtNombreEdificio);
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 326);
            this.panel3.TabIndex = 2;
            // 
            // lstAulas
            // 
            this.lstAulas.BackColor = System.Drawing.Color.LightGray;
            this.lstAulas.ForeColor = System.Drawing.Color.Navy;
            this.lstAulas.FormattingEnabled = true;
            this.lstAulas.ItemHeight = 20;
            this.lstAulas.Location = new System.Drawing.Point(770, 21);
            this.lstAulas.Name = "lstAulas";
            this.lstAulas.Size = new System.Drawing.Size(490, 104);
            this.lstAulas.TabIndex = 9;
            // 
            // lstEdificios
            // 
            this.lstEdificios.BackColor = System.Drawing.Color.LightGray;
            this.lstEdificios.ForeColor = System.Drawing.Color.Navy;
            this.lstEdificios.FormattingEnabled = true;
            this.lstEdificios.ItemHeight = 20;
            this.lstEdificios.Location = new System.Drawing.Point(140, 21);
            this.lstEdificios.Name = "lstEdificios";
            this.lstEdificios.Size = new System.Drawing.Size(490, 104);
            this.lstEdificios.TabIndex = 8;
            this.lstEdificios.Click += new System.EventHandler(this.lstEdificios_Click);
            // 
            // btnGuardarEdificio
            // 
            this.btnGuardarEdificio.Activecolor = System.Drawing.Color.White;
            this.btnGuardarEdificio.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardarEdificio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarEdificio.BorderRadius = 0;
            this.btnGuardarEdificio.ButtonText = "Guardar";
            this.btnGuardarEdificio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEdificio.DisabledColor = System.Drawing.Color.Silver;
            this.btnGuardarEdificio.ForeColor = System.Drawing.Color.Silver;
            this.btnGuardarEdificio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarEdificio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEdificio.Iconimage")));
            this.btnGuardarEdificio.Iconimage_right = null;
            this.btnGuardarEdificio.Iconimage_right_Selected = null;
            this.btnGuardarEdificio.Iconimage_Selected = null;
            this.btnGuardarEdificio.IconMarginLeft = 0;
            this.btnGuardarEdificio.IconMarginRight = 0;
            this.btnGuardarEdificio.IconRightVisible = true;
            this.btnGuardarEdificio.IconRightZoom = 0D;
            this.btnGuardarEdificio.IconVisible = true;
            this.btnGuardarEdificio.IconZoom = 90D;
            this.btnGuardarEdificio.IsTab = false;
            this.btnGuardarEdificio.Location = new System.Drawing.Point(210, 215);
            this.btnGuardarEdificio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarEdificio.Name = "btnGuardarEdificio";
            this.btnGuardarEdificio.Normalcolor = System.Drawing.Color.Silver;
            this.btnGuardarEdificio.OnHovercolor = System.Drawing.Color.Gray;
            this.btnGuardarEdificio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarEdificio.selected = false;
            this.btnGuardarEdificio.Size = new System.Drawing.Size(350, 65);
            this.btnGuardarEdificio.TabIndex = 7;
            this.btnGuardarEdificio.Text = "Guardar";
            this.btnGuardarEdificio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarEdificio.Textcolor = System.Drawing.Color.Navy;
            this.btnGuardarEdificio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEdificio.Click += new System.EventHandler(this.btnGuardarEdificio_Click);
            // 
            // btnGuardarAula
            // 
            this.btnGuardarAula.Activecolor = System.Drawing.Color.White;
            this.btnGuardarAula.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardarAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarAula.BorderRadius = 0;
            this.btnGuardarAula.ButtonText = "Guardar";
            this.btnGuardarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAula.DisabledColor = System.Drawing.Color.Silver;
            this.btnGuardarAula.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAula.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarAula.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardarAula.Iconimage")));
            this.btnGuardarAula.Iconimage_right = null;
            this.btnGuardarAula.Iconimage_right_Selected = null;
            this.btnGuardarAula.Iconimage_Selected = null;
            this.btnGuardarAula.IconMarginLeft = 0;
            this.btnGuardarAula.IconMarginRight = 0;
            this.btnGuardarAula.IconRightVisible = true;
            this.btnGuardarAula.IconRightZoom = 0D;
            this.btnGuardarAula.IconVisible = true;
            this.btnGuardarAula.IconZoom = 90D;
            this.btnGuardarAula.IsTab = false;
            this.btnGuardarAula.Location = new System.Drawing.Point(840, 215);
            this.btnGuardarAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAula.Name = "btnGuardarAula";
            this.btnGuardarAula.Normalcolor = System.Drawing.Color.Silver;
            this.btnGuardarAula.OnHovercolor = System.Drawing.Color.Gray;
            this.btnGuardarAula.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarAula.selected = false;
            this.btnGuardarAula.Size = new System.Drawing.Size(350, 65);
            this.btnGuardarAula.TabIndex = 6;
            this.btnGuardarAula.Text = "Guardar";
            this.btnGuardarAula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarAula.Textcolor = System.Drawing.Color.Navy;
            this.btnGuardarAula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAula.Click += new System.EventHandler(this.btnGuardarAula_Click);
            // 
            // txtNumeroAula
            // 
            this.txtNumeroAula.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroAula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNumeroAula.BackgroundImage")));
            this.txtNumeroAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNumeroAula.ForeColor = System.Drawing.Color.Navy;
            this.txtNumeroAula.Icon = ((System.Drawing.Image)(resources.GetObject("txtNumeroAula.Icon")));
            this.txtNumeroAula.Location = new System.Drawing.Point(770, 133);
            this.txtNumeroAula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroAula.Name = "txtNumeroAula";
            this.txtNumeroAula.Size = new System.Drawing.Size(493, 65);
            this.txtNumeroAula.TabIndex = 4;
            this.txtNumeroAula.text = "Sala por Edificios";
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.BackColor = System.Drawing.Color.LightGray;
            this.txtNombreEdificio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreEdificio.BackgroundImage")));
            this.txtNombreEdificio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNombreEdificio.ForeColor = System.Drawing.Color.Navy;
            this.txtNombreEdificio.Icon = ((System.Drawing.Image)(resources.GetObject("txtNombreEdificio.Icon")));
            this.txtNombreEdificio.Location = new System.Drawing.Point(140, 133);
            this.txtNombreEdificio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(493, 65);
            this.txtNombreEdificio.TabIndex = 3;
            this.txtNombreEdificio.text = "Nombre del Edificio";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PresentationLayer.Properties.Resources.Configuracion_de_entrada_a_los_Edificios__1_;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 83);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.Configuracion_de_entrada_a_los_Edificios;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 83);
            this.panel1.TabIndex = 0;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfiguracion";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarAula;
        private Bunifu.Framework.UI.BunifuTextbox txtNumeroAula;
        private Bunifu.Framework.UI.BunifuTextbox txtNombreEdificio;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarEdificio;
        private System.Windows.Forms.ListBox lstEdificios;
        private System.Windows.Forms.ListBox lstAulas;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private Bunifu.Framework.UI.BunifuTextbox txtApellidoUsuario;
        private Bunifu.Framework.UI.BunifuTextbox txtNombreUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardarUsuario;
        private Bunifu.Framework.UI.BunifuTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuTextbox txtPassword;
    }
}