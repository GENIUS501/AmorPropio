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
    public partial class ReporteProductos : Form
    {
        public string Usuario { get; set; }
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            try
            {
                NProductos Negocios = new NProductos();
                var datasource = Negocios.Mostrar().Select(x => new
                {
                    x.ID_Producto,
                    x.Cantidad,
                    x.ID_Tipo_Producto,
                    x.Precio,
                    x.Descripcion,
                    x.Nombre,
                    Imagen = Convert.ToBase64String(x.Imagen)
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar_codigo.Text != "")
                {
                    NProductos Negocios = new NProductos();
                    var datasource = Negocios.Mostrar().Where(x => x.ID_Producto == int.Parse(this.txt_buscar_codigo.Text)).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuario);
                    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text != "")
                {
                    NProductos Negocios = new NProductos();
                    var datasource = Negocios.Mostrar().Where(x => x.Nombre.Contains(this.txt_nombre.Text)).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuario);
                    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
