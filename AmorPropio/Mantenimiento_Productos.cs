﻿using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmorPropio
{
    public partial class Mantenimiento_Productos : Form
    {
        public int Usuario { get; set; }
        public string Accion { get; set; }
        public int Id { get; set; }
        public Mantenimiento_Productos()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                NProductos NegociosTipoProducto = new NProductos();
                this.cbo_categorias.DisplayMember = "Text";
                this.cbo_categorias.ValueMember = "Value";
                var TipoProductoDataSource = NegociosTipoProducto.Mostrar().Select(x => new
                {
                    Text = x.Nombre,
                    Value = x.ID_Tipo_Producto.ToString()
                }
                );
                this.cbo_categorias.DataSource = TipoProductoDataSource.ToArray();
                if (Accion == "M" || Accion == "C")
                {
                    llenar();
                    if (Accion == "C")
                    {
                        this.Grp_Productos.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenar()
        {
            NProductos Negocios = new NProductos();
            EProductos Obj = new EProductos();
            Obj = Negocios.Mostrar().Where(x=>x.ID_Producto==Id).FirstOrDefault();
            this.txt_id.Text = Obj.ID_Producto.ToString();
            this.txt_nombre.Text = Obj.Nombre;
            this.txt_descripcion.Text = Obj.Descripcion;
            this.cbo_categorias.SelectedValue = Obj.ID_Tipo_Producto;
            this.txtPrecio.Text = Obj.Precio.ToString();
            this.txtCantidad.Text = Obj.Cantidad.ToString();
            byte[] imgData = Obj.Imagen;
            Image newImage = null;
            using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
            {
                ms.Write(imgData, 0, imgData.Length);
                newImage = Image.FromStream(ms, true);
            }
            ImgProducto.Image = newImage;
            newImage = null;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgImagen.ShowDialog();
            if (r == DialogResult.OK)
            {
                this.txtRutaImagen.Text = dlgImagen.FileName;
                ImgProducto.Load(this.txtRutaImagen.Text);
            }
        }
        private bool validar()
        {
            bool ok = false;
            try
            {
                if (this.txt_nombre.Text == "")
                {
                    errorProvider1.SetError(this.txt_nombre, "Debe ingresar el nombre");
                    ok = true;
                }
                if (this.txt_descripcion.Text == "")
                {
                    errorProvider1.SetError(this.txt_descripcion, "Debe ingresar la descripcion");
                    ok = true;
                }
                if (this.txtCantidad.Text == "")
                {
                    errorProvider1.SetError(this.txtCantidad, "Debe ingresar la cantidad");
                    ok = true;
                }
                if (this.txtPrecio.Text == "")
                {
                    errorProvider1.SetError(this.txtPrecio, "Debe ingresar el precio");
                    ok = true;
                }
                //
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ok;
        }
        private void borrar_error()
        {
            try
            {
                errorProvider1.SetError(txt_id, "");
                errorProvider1.SetError(txt_nombre, "");
                errorProvider1.SetError(txt_descripcion, "");
                errorProvider1.SetError(txtCantidad, "");
                errorProvider1.SetError(txtPrecio, "");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "C")
                {
                    this.Close();
                }
                borrar_error();
                if (!validar())
                {
                    if (Accion == "A" || Accion == "M")
                    {
                        NProductos Negocios = new NProductos();
                        EProductos Obj = new EProductos();
                        Obj.Nombre = this.txt_nombre.Text;
                        Obj.Descripcion = this.txt_descripcion.Text;
                        Obj.ID_Tipo_Producto = int.Parse(this.cbo_categorias.SelectedValue.ToString());
                        Obj.Cantidad = int.Parse(this.txtCantidad.Text);
                        Obj.Precio = int.Parse(this.txtPrecio.Text);
                        if (this.txtRutaImagen.Text != "")
                        {
                            byte[] data = System.IO.File.ReadAllBytes(txtRutaImagen.Text);
                            Obj.Imagen = data;
                        }
                        Int32 FilasAfectadas = 0;
                        #region Agregar
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.Agregar(Obj, Usuario);

                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Producto Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El Producto se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el Producto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion == "M")
                        {
                            Obj.ID_Producto = int.Parse(this.txt_id.Text);
                            FilasAfectadas = Negocios.Modificar(Obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Producto modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("EL Producto se ha modificado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar la Producto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
