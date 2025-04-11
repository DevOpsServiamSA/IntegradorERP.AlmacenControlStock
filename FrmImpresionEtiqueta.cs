using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmImpresionEtiqueta : XtraForm
    {
        public DataTable dtInformacion;

        public FrmImpresionEtiqueta()
        {
            InitializeComponent();
        }

        private void FrmImpresionEtiqueta_Load(object sender, EventArgs e)
        {
            //CargarReporte();
        }

        public void CargarReporte()
        {
            XtraReportEtiquetaProductoProceso report = new XtraReportEtiquetaProductoProceso();
            report.CargarData(dtInformacion);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void bbiHandTool_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
