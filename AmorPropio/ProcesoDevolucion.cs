using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmorPropio
{
    public partial class ProcesoDevolucion : Form
    {
        public int Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        int valorcelda { get; set; }
        int ID_Cliente { get; set; }
        int Cantidad_Producto { get; set; }
        public ProcesoDevolucion()
        {
            InitializeComponent();
        }

        private void ProcesoDevolucion_Load(object sender, EventArgs e)
        {
            try
            {
                NDevoluciones Negocios = new NDevoluciones();
                var Datasource = Negocios.Mostrar().Select(Item => new
                {
                    CantidadProducto = Item.CantidadProducto,
                    ID_Cliente = Item.ID_Cliente,
                    Total = "₡"+Item.Total,
                    ID_Usuario = Item.ID_Usuario,
                    Tipo_pago = Item.Tipo_pago,
                    Fecha_venta = Item.Fecha_venta,
                    Numero_factura = Item.Numero_factura
                }).ToList();
                this.dat_principal.DataSource = Datasource;
                valorcelda = -1;
                ID_Cliente = -1;
                Cantidad_Producto = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dat_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    ProcesoDevolucion_Load(null, null);
                }
                else
                {
                    valorcelda = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[3].Value.ToString());
                    ID_Cliente = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Cantidad_Producto = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Devolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorcelda > 0)
                {
                    DialogResult dr = MessageBox.Show("Realmente desea realizar la devolución?", "Realizar devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        NDevoluciones Negocios = new NDevoluciones();
                        EDevoluciones Entidad = new EDevoluciones();
                        Entidad.IdVenta = valorcelda;
                        Entidad.IdUsuario = Usuario;
                        Entidad.IDCliente = ID_Cliente;
                        Entidad.CantidadProducto = Cantidad_Producto;
                        int FilasAfectadas = 0;
                        FilasAfectadas = Negocios.Agregar(Entidad, Usuario);
                        if (FilasAfectadas > 0)
                        {
                            MessageBox.Show("Devolución realizada exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al generar la devolucion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ProcesoDevolucion_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar_cedula.Text != "")
                {
                    NDevoluciones Negocios = new NDevoluciones();
                    var Datasource = Negocios.MostrarIdentificacion(this.txt_buscar_cedula.Text).Select(Item => new {
                        CantidadProducto = Item.CantidadProducto,
                        ID_Cliente = Item.ID_Cliente,
                        Total = "₡" + Item.Total,
                        ID_Usuario = Item.ID_Usuario,
                        Tipo_pago = Item.Tipo_pago,
                        Fecha_venta = Item.Fecha_venta,
                        Numero_factura = Item.Numero_factura
                    }).ToList();
                    this.dat_principal.DataSource = Datasource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_id.Text != "")
                {
                    NDevoluciones Negocios = new NDevoluciones();
                    var Data = Negocios.MostrarId(int.Parse(this.txt_id.Text)).Select(Item => new
                    {
                        CantidadProducto = Item.CantidadProducto,
                        ID_Cliente = Item.ID_Cliente,
                        Total = "₡" + Item.Total,
                        ID_Usuario = Item.ID_Usuario,
                        Tipo_pago = Item.Tipo_pago,
                        Fecha_venta = Item.Fecha_venta,
                        Numero_factura = Item.Numero_factura
                    }).ToList();
                    this.dat_principal.DataSource = Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
