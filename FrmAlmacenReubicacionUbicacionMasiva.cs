using HelperUtils;
using IntegralAPI;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmAlmacenReubicacionUbicacionMasiva : BaseDevForm, IBaseDevForm
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

        public string tar_codigo;
        public DataTable dtBultos;
        public int ubi_codigo;
        public string ubi_descripcion;

        #endregion

        #region Constructores

        public FrmAlmacenReubicacionUbicacionMasiva()
        {
            InitializeComponent();
            PL_Forms = this;
            PL_Principal = new Principal();
        }

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
            //if (Accion == int.Parse(Modulo.AccionEnt.get_PL_Buscar("")[0]))
            //{
            //    Limpiar();
            //}
        }

        public void PL_Nuevo()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
            //Modulo.Instance.Nuevo();
            //Nuevo();
        }

        public void PL_Modificar()
        {
            Modificar();
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
            //Modulo.Instance.EnfocarControl(txt_Control);
        }

        private void PrimeraActivacion()
        {
            //if (linea == 0)
            //{
            //    SeteaNuevo();
            //    Modulo.Instance.EnfocarControl(txt_ubi_codigo);
            //}
            //else
            //{


            SeteaEdicion();

            dgv_BultosSeleccionados.DataSource = dtBultos;
            Modulo.Instance.EnfocarControl(txt_ubi_codigo);

            //}

            //Modulo.Instance.SetAccionEdicion();
            //HabilitarObjetos();
        }

        private void Buscar()
        {
            try
            {
                //dgv_Reporte.Fn_MostrarCargando();
                //object[] parametros = { txt_fechaini.Text, txt_fechafin.Text };
                //dgv_Reporte.DataSource = new Principal().RetornaRegistros(parametros);
                //dgv_Reporte.NombreArchivoExportado = "Reporte del " + txt_fechaini.Text.Replace("/", "") + " al " + txt_fechafin.Text.Replace("/", "");
            }
            catch (Exception ex)
            {
                Dialog.MostrarMensajeErrorInesperado();
                Error.TomarFotoYEnviarEmailError(ex);
            }
            finally
            {
                //dgv_Reporte.Fn_OcultarCargando();
            }

            //if (dgv_Reporte.Fn_ObtenerNumeroFilas() == 0)
            //{
            //    Dialog.MostrarMensajeSinRegistros();
            //    Modulo.Instance.EnfocarControl(txt_fechaini);
            //}
            //else
            //{
            //    dgv_Reporte.Fn_SituarFocoEnPrimeraFila();
            //}
        }

        private void Limpiar()
        {
            //dgv_Reporte.Fn_LimpiarGrilla(false);
            //Modulo.Instance.EnfocarControl(txt_Control);
        }

        private void Nuevo()
        {
            //Modulo.Instance.EnfocarControl(txt_Control);
        }

        private void Modificar()
        {
            //Modulo.Instance.EnfocarControl(txt_Control);
        }

        private void Grabar()
        {
            Valida = true;
            if (!Modulo.Instance.ValidarControlesMasivo(this, true))
                return;

            if (!Modulo.Instance.VerificarModificados(this))
                return;

            dtBultos = ((DataTable)dgv_BultosSeleccionados.DataSource).Copy();
            ubi_codigo = Parser.GetInt(txt_ubi_codigo.Text);
            ubi_descripcion = Parser.GetString(txt_ubi_descripcion.Text);
            DialogResult = DialogResult.Yes;
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
            Dialog.MostrarMensajeOpcionNoImplementada();
        }

        #endregion

        #region Eventos

        #endregion
    }
}