namespace PresentationLayer
{
    partial class frmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsultaVisitas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PresentationLayer.Properties.Resources.Centro_Médico_Avanzado__1_;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 900);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.Diseño_sin_título__7_;
            this.panel1.Controls.Add(this.ConsultaVisitas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 900);
            this.panel1.TabIndex = 0;
            // 
            // ConsultaVisitas
            // 
            this.ConsultaVisitas.Activecolor = System.Drawing.Color.White;
            this.ConsultaVisitas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultaVisitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultaVisitas.BorderRadius = 0;
            this.ConsultaVisitas.ButtonText = "Consultar Visitas";
            this.ConsultaVisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultaVisitas.DisabledColor = System.Drawing.Color.Gray;
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
            this.ConsultaVisitas.Location = new System.Drawing.Point(0, 364);
            this.ConsultaVisitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConsultaVisitas.Name = "ConsultaVisitas";
            this.ConsultaVisitas.Normalcolor = System.Drawing.Color.Transparent;
            this.ConsultaVisitas.OnHovercolor = System.Drawing.Color.Silver;
            this.ConsultaVisitas.OnHoverTextColor = System.Drawing.Color.White;
            this.ConsultaVisitas.selected = false;
            this.ConsultaVisitas.Size = new System.Drawing.Size(266, 74);
            this.ConsultaVisitas.TabIndex = 6;
            this.ConsultaVisitas.Text = "Consultar Visitas";
            this.ConsultaVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultaVisitas.Textcolor = System.Drawing.Color.White;
            this.ConsultaVisitas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaVisitas.Click += new System.EventHandler(this.ConsultaVisitas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.Diseño_sin_título__9_;
            this.pictureBox1.Location = new System.Drawing.Point(54, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGeneral";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton ConsultaVisitas;
    }
}