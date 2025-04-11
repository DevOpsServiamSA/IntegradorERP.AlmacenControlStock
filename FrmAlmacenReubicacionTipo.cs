using HelperUtils;
using IntegralAPI;
using System;
using System.Data;
using System.IO.Ports;
using System.Reflection;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmAlmacenReubicacionTipo : BaseDevForm, IBaseDevForm
    {
        #region Propiedades o Variables

        private Principal PL_Principal { get; set; }

        public bool PrivilegioLectura;
        public bool PrivilegioNuevo;
        public bool PrivilegioModificar;
        public bool PrivilegioEliminar;
        public bool PrivilegioImprimir;
        public bool PrivilegioAprobar;
        public bool PrivilegioDesaprobar;
        public bool PrivilegioAnular;
        public bool PrivilegioImportar;
        public bool PrivilegioExportar;
        public bool PrivilegioExcel;
        public bool PrivilegioPdf;
        public bool PrivilegioAceptar;
        public bool PrivilegioAgregar;
        public bool PrivilegioAdjuntar;
        public bool PrivilegioConfigurar;
        public bool PrivilegioProcesar;
        public bool PrivilegioEliminarTodo;
        public bool PrivilegioReporte;
        public bool PrivilegioDescargar;
        public bool PrivilegioEnviar;
        public bool PrivilegioPersonalizado1;
        public bool PrivilegioPersonalizado2;
        public bool PrivilegioPersonalizado3;
        public bool PrivilegioPersonalizado4;
        public bool PrivilegioPersonalizado5;
        public bool PrivilegioPersonalizado6;
        public bool PrivilegioPersonalizado7;
        public bool PrivilegioPersonalizado8;
        public bool PrivilegioPersonalizado9;
        public bool PrivilegioPersonalizado10;

        public bool bModificado;
        public object[] oInput;
        public object[] oOutput;

        public int modo = 0;
        public string puerto = "";

        //public int tar_codigo;
        //public int tmo_codigo;
        //public string puerto;
        //public bool bloquear;
        //public DataTable dtTipoArticulo;

        #endregion

        #region Constructores

        public FrmAlmacenReubicacionTipo()
        {
            InitializeComponent();
            PL_Forms = this;
            PL_Principal = new Principal();
        }

        //public FrmAlmacenReubicacionTipo(object[] parameters) : this()
        //{
        //    tar_codigo = Parser.GetInt(parameters[0]);
        //    tmo_codigo = Parser.GetInt(parameters[1]);
        //    puerto = Parser.GetString(parameters[2]);
        //    bloquear = Parser.GetBoolean(parameters[3]);
        //    dtTipoArticulo = (DataTable)parameters[4];
        //}

        #endregion

        #region Eventos y Métodos Base

        public void PL_Buscar()
        {
            Buscar();
        }

        public void PL_Limpiar()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();

            //Modulo.Instance.Limpiar(pnl_Principal);
            //if (Accion == ACCION_BUSCAR)
            //{
            //    Limpiar();
            //}
        }

        public void PL_Nuevo()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();

            //Modulo.Instance.Nuevo();
            //if (Accion == ACCION_NUEVO)
            //{
            //    Nuevo();
            //}
        }

        public void PL_Modificar()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        public void PL_Grabar()
        {
            Grabar();
        }

        public void PL_Eliminar()
        {
            Eliminar();
        }

        public void PL_Salir()
        {
            Close();
        }

        public void PL_Anular()
        {
            Anular();
        }

        public void PL_Imprimir()
        {
            Imprimir();
        }

        public void Frm_Load(object sender, EventArgs e)
        {
            Accion = int.Parse(Modulo.AccionEnt.get_PL_Buscar("")[0]);
            Modulo.Instance.ConfigurarFormulario(this);
            HabilitarObjetos();
            SetearPrivilegios();
            Inicializar();
        }

        public void Frm_Activated(object sender, EventArgs e)
        {
            ActivaFormulario();
        }

        public void Frm_Deactivate(object sender, EventArgs e)
        {
            Accion = PL_FrmMdi.PL_AccAct.PL_Accion;
        }

        public void HabilitarObjetos()
        {
            Modulo.Instance.HabilitarObjetos(Accion);
        }

        public void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PL_FrmMdi.PL_EliminaFormulario(this);
        }

        private void SetearPrivilegios()
        {
            PrivilegioLectura = PL_PrivilegioLectura;
            PrivilegioNuevo = PL_PrivilegioNuevo;
            PrivilegioModificar = PL_PrivilegioModificar;
            PrivilegioEliminar = PL_PrivilegioEliminar;
            PrivilegioExportar = PL_PrivilegioExportar;
            PrivilegioImprimir = PL_PrivilegioImprimir;
            PrivilegioAprobar = PL_PrivilegioAprobar;
            PrivilegioDesaprobar = PL_PrivilegioDesaprobar;
            PrivilegioAnular = PL_PrivilegioAnular;
            PrivilegioImportar = PL_PrivilegioImportar;
            PrivilegioExcel = PL_PrivilegioExcel;
            PrivilegioPdf = PL_PrivilegioPdf;
            PrivilegioAceptar = PL_PrivilegioAceptar;
            PrivilegioAgregar = PL_PrivilegioAgregar;
            PrivilegioAdjuntar = PL_PrivilegioAdjuntar;
            PrivilegioConfigurar = PL_PrivilegioConfigurar;
            PrivilegioProcesar = PL_PrivilegioProcesar;
            PrivilegioEliminarTodo = PL_PrivilegioEliminarTodo;
            PrivilegioReporte = PL_PrivilegioReporte;
            PrivilegioDescargar = PL_PrivilegioDescargar;
            PrivilegioEnviar = PL_PrivilegioEnviar;
            PrivilegioPersonalizado1 = PL_PrivilegioPersonalizado1;
            PrivilegioPersonalizado2 = PL_PrivilegioPersonalizado2;
            PrivilegioPersonalizado3 = PL_PrivilegioPersonalizado3;
            PrivilegioPersonalizado4 = PL_PrivilegioPersonalizado4;
            PrivilegioPersonalizado5 = PL_PrivilegioPersonalizado5;
            PrivilegioPersonalizado6 = PL_PrivilegioPersonalizado6;
            PrivilegioPersonalizado7 = PL_PrivilegioPersonalizado7;
            PrivilegioPersonalizado8 = PL_PrivilegioPersonalizado8;
            PrivilegioPersonalizado9 = PL_PrivilegioPersonalizado9;
            PrivilegioPersonalizado10 = PL_PrivilegioPersonalizado10;
        }

        public void ResetearPrivilegios()
        {
            PL_PrivilegioLectura = PrivilegioLectura;
            PL_PrivilegioNuevo = PrivilegioNuevo;
            PL_PrivilegioModificar = PrivilegioModificar;
            PL_PrivilegioEliminar = PrivilegioEliminar;
            PL_PrivilegioExportar = PrivilegioExportar;
            PL_PrivilegioImprimir = PrivilegioImprimir;
            PL_PrivilegioAprobar = PrivilegioAprobar;
            PL_PrivilegioDesaprobar = PrivilegioDesaprobar;
            PL_PrivilegioAnular = PrivilegioAnular;
            PL_PrivilegioImportar = PrivilegioImportar;
            PL_PrivilegioExcel = PrivilegioExcel;
            PL_PrivilegioPdf = PrivilegioPdf;
            PL_PrivilegioAceptar = PrivilegioAceptar;
            PL_PrivilegioAgregar = PrivilegioAgregar;
            PL_PrivilegioAdjuntar = PrivilegioAdjuntar;
            PL_PrivilegioConfigurar = PrivilegioConfigurar;
            PL_PrivilegioProcesar = PrivilegioProcesar;
            PL_PrivilegioEliminarTodo = PrivilegioEliminarTodo;
            PL_PrivilegioReporte = PrivilegioReporte;
            PL_PrivilegioDescargar = PrivilegioDescargar;
            PL_PrivilegioEnviar = PrivilegioEnviar;
            PL_PrivilegioPersonalizado1 = PrivilegioPersonalizado1;
            PL_PrivilegioPersonalizado2 = PrivilegioPersonalizado2;
            PL_PrivilegioPersonalizado3 = PrivilegioPersonalizado3;
            PL_PrivilegioPersonalizado4 = PrivilegioPersonalizado4;
            PL_PrivilegioPersonalizado5 = PrivilegioPersonalizado5;
            PL_PrivilegioPersonalizado6 = PrivilegioPersonalizado6;
            PL_PrivilegioPersonalizado7 = PrivilegioPersonalizado7;
            PL_PrivilegioPersonalizado8 = PrivilegioPersonalizado8;
            PL_PrivilegioPersonalizado9 = PrivilegioPersonalizado9;
            PL_PrivilegioPersonalizado10 = PrivilegioPersonalizado10;
        }

        public void ActivaFormulario()
        {
            PL_Forms = this;
            if (PostBack == false)
            {
                PL_FrmMdi.set_PL_SeteaAccion(this, Modulo.AccionEnt.get_PL_Buscar(""));
                PrimeraActivacion();
                PostBack = true;
            }
            Modulo.Instance.RecargarFormulario(this);
            PL_FrmMdi.PL_AccAct.PL_Accion = Accion;
            ResetearPrivilegios();
        }

        public DataTable InvocarMetodoDataTableBusqueda(string tipo, string metodo, object[] parametros)
        {
            Type clase = Type.GetType(tipo);
            object instancia = Activator.CreateInstance(clase);

            DataTable dt = (DataTable)clase.InvokeMember(metodo, BindingFlags.Default | BindingFlags.InvokeMethod, null, instancia, parametros);
            return dt;
        }

        private void SeteaNuevo()
        {
            Modulo.Instance.SetAccionNuevo();
            HabilitarObjetos();
        }

        private void SeteaEdicion()
        {
            Modulo.Instance.SetAccionEdicion();
            HabilitarObjetos();
        }

        private void SeteaBuscar()
        {
            Modulo.Instance.SetAccionBuscar();
            HabilitarObjetos();
        }

        #endregion

        #region Métodos base

        private void Inicializar()
        {
            DataTable dtTipoOperacion = new DataTable();
            dtTipoOperacion.Columns.Add("codigo", typeof(string));
            dtTipoOperacion.Columns.Add("descripcion", typeof(string));

            dtTipoOperacion.Rows.Add(1, "Sin balanza");
            dtTipoOperacion.Rows.Add(2, "Con balanza");

            cbo_modo.Fn_CargarCombobox(dtTipoOperacion.Copy(), "codigo", "descripcion", 0);
            cbo_modo.EditValue = "1";

            DataTable dtPuertos = new DataTable();
            dtPuertos.Columns.Add("PUERTO", typeof(string));
            dtPuertos.Columns.Add("NOMBRE", typeof(string));

            string[] puertos = SerialPort.GetPortNames();

            for (int i = 1; i <= puertos.Length; i++)
                dtPuertos.Rows.Add(puertos[i - 1], "BALANZA " + i.ToString() + ": " + puertos[i - 1]);

            if (dtPuertos.Rows.Count == 0)
            {
                dtPuertos.Rows.Add("COM1", "SIN BALANZA");
            }

            cbo_balanza.Fn_CargarCombobox(dtPuertos, "PUERTO", "NOMBRE", 0);

            if (cbo_balanza.Fn_ObtenerNroItems() == 2)
            {
                cbo_balanza.ItemIndex = 1;
            }
            //else
            //{
            //    if (puerto != "")
            //    {
            //        cbo_balanza.ItemIndex = cbo_modo.Properties.GetDataSourceRowIndex("PUERTO", puerto);
            //    }
            //}

            //if (cbo_modo.Fn_ObtenerNroItems() == 2)
            //{
            //    cbo_modo.ItemIndex = 1;
            //    Modulo.Instance.EnfocarControl(cbo_balanza);
            //}
            //else
            //{
            //    if (tar_codigo > 0)
            //    {
            //        cbo_modo.ItemIndex = cbo_modo.Properties.GetDataSourceRowIndex("tar_codigo", tar_codigo);
            //    }

            //    Modulo.Instance.EnfocarControl(cbo_modo);
            //}

            //if (bloquear)
            //{
            //    cbo_modo.Habilitado = false;
            //    Modulo.Instance.EnfocarControl(cbo_balanza);
            //}

            //Text = tmo_codigo == 1 ? "Nuevo ingreso" : "Nueva devolución";

        }

        private void PrimeraActivacion()
        {
            //SeteaEdicion();
        }

        private void Buscar()
        {   

        }

        private void Limpiar()
        {

        }

        private void Nuevo()
        {
            //Modulo.Instance.EnfocarControl(txt_Control);
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        private void Grabar()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        private void Eliminar()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        private void Anular()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        private void Imprimir()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        #endregion

        #region Eventos

        private void cbo_balanza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbo_modo.EditValue.ToString() == "0")
                {
                    Dialog.MostrarMensajeAdvertencia("Por favor, seleccione un modo");
                    Modulo.Instance.EnfocarControl(cbo_modo);
                    cbo_modo.ShowPopup();
                    return;
                }

                if (cbo_balanza.EditValue.ToString() == "0")
                {
                    Dialog.MostrarMensajeAdvertencia("Por favor, seleccione una balanza");
                    Modulo.Instance.EnfocarControl(cbo_balanza);
                    cbo_balanza.ShowPopup();
                    return;
                }

                modo = Parser.GetInt(cbo_modo.EditValue.ToString());
                puerto = cbo_balanza.EditValue.ToString();
                bModificado = true;

                DialogResult = DialogResult.Yes;
            }
        }

        private void FrmAlmacenPesadoProductoProcesoBalanza_Click_Aceptar(object sender, EventArgs e)
        {
            if (cbo_modo.EditValue.ToString() == "0")
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, seleccione un modo");
                Modulo.Instance.EnfocarControl(cbo_modo);
                cbo_modo.ShowPopup();
                return;
            }

            if (cbo_balanza.EditValue.ToString() == "0")
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, seleccione una balanza");
                Modulo.Instance.EnfocarControl(cbo_balanza);
                cbo_balanza.ShowPopup();
                return;
            }

            modo = Parser.GetInt(cbo_modo.EditValue.ToString());
            puerto = cbo_balanza.EditValue.ToString();
            bModificado = true;

            DialogResult = DialogResult.Yes;
        }

        #endregion

        private void cbo_modo_EditValueChanged(object sender, EventArgs e)
        {
            if (cbo_modo.EditValue.ToString() == "1")
            {
                lyt_balanza.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                lyt_balanza.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
    }
}
