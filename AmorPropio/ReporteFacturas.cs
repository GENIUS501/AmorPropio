using Microsoft.Reporting.WinForms;
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
    public partial class ReporteFacturas : Form
    {
        public string Usuario { get; set; }
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                NVentas Negocios = new NVentas();
                NClientes NegociosClientes = new NClientes();
                var datasource = Negocios.Mostrar().Select(x => new
                {
                    x.Numero_factura,
                    Nombre = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Nombre,
                    PrimerApellido = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Primer_Apellido,
                    SegundoApellido = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Segundo_Apellido,
                    Cedula = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Identificacion,
                    Direccion = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Direccion,
                    Telefono = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Telefono,
                    Correo = NegociosClientes.Mostrar().Where(c => c.ID_Cliente == x.ID_Cliente).FirstOrDefault().Correo,
                    TipoVenta = x.Tipo_pago

                }).ToList();
                ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(Rds);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario);
                parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
