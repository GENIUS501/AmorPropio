namespace AmorPropio
{
    partial class ProcesoDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoDevolucion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_id = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar_cedula = new System.Windows.Forms.MaskedTextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_Devolucion = new System.Windows.Forms.Button();
            this.dat_principal = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_buscar_cedula);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 139);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btn_buscar_id
            // 
            this.btn_buscar_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_id.BackgroundImage")));
            this.btn_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_id.Location = new System.Drawing.Point(115, 102);
            this.btn_buscar_id.Name = "btn_buscar_id";
            this.btn_buscar_id.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_id.TabIndex = 3;
            this.btn_buscar_id.UseVisualStyleBackColor = true;
            this.btn_buscar_id.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cedula del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Numero de factura";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(115, 48);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar_cedula
            // 
            this.txt_buscar_cedula.Location = new System.Drawing.Point(9, 48);
            this.txt_buscar_cedula.Mask = "000000000000";
            this.txt_buscar_cedula.Name = "txt_buscar_cedula";
            this.txt_buscar_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar_cedula.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(9, 102);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // btn_Devolucion
            // 
            this.btn_Devolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Devolucion.Location = new System.Drawing.Point(12, 157);
            this.btn_Devolucion.Name = "btn_Devolucion";
            this.btn_Devolucion.Size = new System.Drawing.Size(125, 41);
            this.btn_Devolucion.TabIndex = 75;
            this.btn_Devolucion.Text = "Realizar devolucion";
            this.btn_Devolucion.UseVisualStyleBackColor = true;
            this.btn_Devolucion.Click += new System.EventHandler(this.btn_Devolucion_Click);
            // 
            // dat_principal
            // 
            this.dat_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_principal.Location = new System.Drawing.Point(12, 204);
            this.dat_principal.Name = "dat_principal";
            this.dat_principal.Size = new System.Drawing.Size(739, 185);
            this.dat_principal.TabIndex = 73;
            this.dat_principal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_principal_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmorPropio.Properties.Resources.Logop;
            this.pictureBox1.Location = new System.Drawing.Point(530, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // ProcesoDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Devolucion);
            this.Controls.Add(this.dat_principal);
            this.Name = "ProcesoDevolucion";
            this.Text = "ProcesoDevolucion";
            this.Load += new System.EventHandler(this.ProcesoDevolucion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MaskedTextBox txt_buscar_cedula;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_Devolucion;
        private System.Windows.Forms.DataGridView dat_principal;
    }
}