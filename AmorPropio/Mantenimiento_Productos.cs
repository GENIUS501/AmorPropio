using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                NTipo_Producto NegociosTipoProducto = new NTipo_Producto();
                var TipoProductoDataSource = NegociosTipoProducto.Mostrar().Select(x => new
                {
                    Text = x.Nombre,
                    Value = x.ID_Tipo_Producto
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

        }
    }
}
