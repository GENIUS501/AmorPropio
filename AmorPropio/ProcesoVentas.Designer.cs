namespace AmorPropio
{
    partial class ProcesoVentas
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoVentas));
            this.grp_venta = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.btn_add_cliente = new System.Windows.Forms.Button();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_productos = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dat_resultado = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_impuesto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btn_buscar_nombre = new System.Windows.Forms.Button();
            this.btn_buscar_codigo = new System.Windows.Forms.Button();
            this.grp_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_venta
            // 
            this.grp_venta.Controls.Add(this.label8);
            this.grp_venta.Controls.Add(this.txt_cedula);
            this.grp_venta.Controls.Add(this.btn_add_cliente);
            this.grp_venta.Controls.Add(this.lbl_cliente);
            this.grp_venta.Controls.Add(this.label2);
            this.grp_venta.Controls.Add(this.btn_buscar_nombre);
            this.grp_venta.Controls.Add(this.btn_buscar_codigo);
            this.grp_venta.Controls.Add(this.label5);
            this.grp_venta.Controls.Add(this.label1);
            this.grp_venta.Controls.Add(this.lst_productos);
            this.grp_venta.Controls.Add(this.dat_resultado);
            this.grp_venta.Controls.Add(this.label6);
            this.grp_venta.Controls.Add(this.txt_nombre_producto);
            this.grp_venta.Controls.Add(this.label7);
            this.grp_venta.Controls.Add(this.txt_codigo);
            this.grp_venta.Controls.Add(this.label4);
            this.grp_venta.Controls.Add(this.txt_total);
            this.grp_venta.Controls.Add(this.label3);
            this.grp_venta.Controls.Add(this.txt_impuesto);
            this.grp_venta.Location = new System.Drawing.Point(12, 12);
            this.grp_venta.Name = "grp_venta";
            this.grp_venta.Size = new System.Drawing.Size(559, 415);
            this.grp_venta.TabIndex = 45;
            this.grp_venta.TabStop = false;
            this.grp_venta.Text = "Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "%";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(385, 31);
            this.txt_cedula.Mask = "000000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(124, 20);
            this.txt_cedula.TabIndex = 5;
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_cliente.Location = new System.Drawing.Point(515, 31);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(28, 21);
            this.btn_add_cliente.TabIndex = 6;
            this.btn_add_cliente.UseVisualStyleBackColor = true;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(306, 72);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(0, 13);
            this.lbl_cliente.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cedula del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Lista de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Resultado Busqueda";
            // 
            // lst_productos
            // 
            this.lst_productos.CheckBoxes = true;
            this.lst_productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader8});
            this.lst_productos.FullRowSelect = true;
            this.lst_productos.GridLines = true;
            this.lst_productos.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lst_productos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lst_productos.Location = new System.Drawing.Point(6, 221);
            this.lst_productos.Name = "lst_productos";
            this.lst_productos.Size = new System.Drawing.Size(547, 136);
            this.lst_productos.TabIndex = 49;
            this.lst_productos.UseCompatibleStateImageBehavior = false;
            this.lst_productos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 3;
            this.columnHeader9.Text = "Eliminar";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 1;
            this.columnHeader6.Text = "Nombre";
            this.columnHeader6.Width = 187;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 2;
            this.columnHeader8.Text = "Precio";
            this.columnHeader8.Width = 220;
            // 
            // dat_resultado
            // 
            this.dat_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_resultado.Location = new System.Drawing.Point(6, 88);
            this.dat_resultado.Name = "dat_resultado";
            this.dat_resultado.Size = new System.Drawing.Size(546, 103);
            this.dat_resultado.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nombre del producto";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Location = new System.Drawing.Point(176, 32);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(124, 20);
            this.txt_nombre_producto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Codigo del producto";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 32);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(124, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(453, 385);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Impuesto";
            // 
            // txt_impuesto
            // 
            this.txt_impuesto.Location = new System.Drawing.Point(6, 376);
            this.txt_impuesto.Name = "txt_impuesto";
            this.txt_impuesto.Size = new System.Drawing.Size(47, 20);
            this.txt_impuesto.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(304, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(188, 446);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 23);
            this.btnAceptar.TabIndex = 46;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_nombre
            // 
            this.btn_buscar_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_nombre.BackgroundImage")));
            this.btn_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_nombre.Location = new System.Drawing.Point(309, 32);
            this.btn_buscar_nombre.Name = "btn_buscar_nombre";
            this.btn_buscar_nombre.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_nombre.TabIndex = 4;
            this.btn_buscar_nombre.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_codigo
            // 
            this.btn_buscar_codigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_codigo.BackgroundImage")));
            this.btn_buscar_codigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_codigo.Location = new System.Drawing.Point(136, 31);
            this.btn_buscar_codigo.Name = "btn_buscar_codigo";
            this.btn_buscar_codigo.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_codigo.TabIndex = 2;
            this.btn_buscar_codigo.UseVisualStyleBackColor = true;
            // 
            // ProcesoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 481);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grp_venta);
            this.Name = "ProcesoVentas";
            this.Text = "ProcesoVentas";
            this.grp_venta.ResumeLayout(false);
            this.grp_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_venta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.Button btn_add_cliente;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar_nombre;
        private System.Windows.Forms.Button btn_buscar_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_productos;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DataGridView dat_resultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_impuesto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}