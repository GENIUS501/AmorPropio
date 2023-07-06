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
        public ProcesoDevolucion()
        {
            InitializeComponent();
        }

        private void ProcesoDevolucion_Load(object sender, EventArgs e)
        {
            try
            {
                NDevoluciones Negocios = new NDevoluciones();
                this.dat_principal.DataSource = Negocios.Mostrar();
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
                    valorcelda = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                    this.dat_principal.DataSource = Negocios.MostrarIdentificacion(this.txt_buscar_cedula.Text);
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
                    this.dat_principal.DataSource = Negocios.MostrarId(int.Parse(this.txt_id.Text));
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
