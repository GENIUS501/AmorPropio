namespace AmorPropio
{
    partial class Mantenimiento_Productos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Productos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Grp_Productos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgProducto = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_tipo_productos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dlgImagen = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.Grp_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(210, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 78;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Grp_Productos
            // 
            this.Grp_Productos.Controls.Add(this.label6);
            this.Grp_Productos.Controls.Add(this.txtPrecio);
            this.Grp_Productos.Controls.Add(this.label4);
            this.Grp_Productos.Controls.Add(this.txtCantidad);
            this.Grp_Productos.Controls.Add(this.label3);
            this.Grp_Productos.Controls.Add(this.ImgProducto);
            this.Grp_Productos.Controls.Add(this.btnCargarImagen);
            this.Grp_Productos.Controls.Add(this.label1);
            this.Grp_Productos.Controls.Add(this.txtRutaImagen);
            this.Grp_Productos.Controls.Add(this.label7);
            this.Grp_Productos.Controls.Add(this.cbo_tipo_productos);
            this.Grp_Productos.Controls.Add(this.pictureBox1);
            this.Grp_Productos.Controls.Add(this.lbl_id);
            this.Grp_Productos.Controls.Add(this.txt_descripcion);
            this.Grp_Productos.Controls.Add(this.txt_id);
            this.Grp_Productos.Controls.Add(this.label5);
            this.Grp_Productos.Controls.Add(this.txt_nombre);
            this.Grp_Productos.Controls.Add(this.label2);
            this.Grp_Productos.Location = new System.Drawing.Point(12, 12);
            this.Grp_Productos.Name = "Grp_Productos";
            this.Grp_Productos.Size = new System.Drawing.Size(361, 418);
            this.Grp_Productos.TabIndex = 76;
            this.Grp_Productos.TabStop = false;
            this.Grp_Productos.Text = "Datos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(34, 146);
            this.txtPrecio.Mask = "00000000";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(141, 20);
            this.txtPrecio.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(191, 146);
            this.txtCantidad.Mask = "00000000";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(164, 20);
            this.txtCantidad.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Cantidad";
            // 
            // ImgProducto
            // 
            this.ImgProducto.Location = new System.Drawing.Point(9, 215);
            this.ImgProducto.Name = "ImgProducto";
            this.ImgProducto.Size = new System.Drawing.Size(119, 79);
            this.ImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgProducto.TabIndex = 79;
            this.ImgProducto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(181, 189);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(28, 21);
            this.btnCargarImagen.TabIndex = 78;
            this.btnCargarImagen.Text = "...";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ruta de la imagen del producto";
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Enabled = false;
            this.txtRutaImagen.Location = new System.Drawing.Point(9, 189);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(166, 20);
            this.txtRutaImagen.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Tipo de producto";
            // 
            // cbo_tipo_productos
            // 
            this.cbo_tipo_productos.DisplayMember = "NombresCategoria";
            this.cbo_tipo_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_productos.FormattingEnabled = true;
            this.cbo_tipo_productos.Location = new System.Drawing.Point(9, 99);
            this.cbo_tipo_productos.Name = "cbo_tipo_productos";
            this.cbo_tipo_productos.Size = new System.Drawing.Size(166, 21);
            this.cbo_tipo_productos.TabIndex = 74;
            this.cbo_tipo_productos.ValueMember = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AmorPropio.Properties.Resources.Logop;
            this.pictureBox1.Location = new System.Drawing.Point(226, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(6, 28);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "ID";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(9, 313);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(291, 92);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(9, 44);
            this.txt_id.Mask = "000000000000";
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(78, 20);
            this.txt_id.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descripcion";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(109, 44);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(104, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(94, 470);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // dlgImagen
            // 
            this.dlgImagen.FileName = "Imagen";
            this.dlgImagen.Filter = "Archivos de imágenes |*.jpg;*.jpeg;*.bmp";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "₡";
            // 
            // Mantenimiento_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 505);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Grp_Productos);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "Mantenimiento_Productos";
            this.Text = "MantenimientoProductos";
            this.Load += new System.EventHandler(this.Mantenimiento_Productos_Load);
            this.Grp_Productos.ResumeLayout(false);
            this.Grp_Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox Grp_Productos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.MaskedTextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_tipo_productos;
        private System.Windows.Forms.PictureBox ImgProducto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.OpenFileDialog dlgImagen;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
    }
}