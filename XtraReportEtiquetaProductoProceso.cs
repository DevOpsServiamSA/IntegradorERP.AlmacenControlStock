using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace AlmacenControlStock
{
    public partial class XtraReportEtiquetaProductoProceso : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportEtiquetaProductoProceso()
        {
            InitializeComponent();
        }

        public void CargarData(DataTable dtReporte)
        {
            DataSource = dtReporte;
            FillDataSource();
        }
    }
}
