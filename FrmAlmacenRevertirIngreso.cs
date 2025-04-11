using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using HelperUtils;
using IntegralAPI;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmAlmacenRevertirIngreso : BaseDevForm, IBaseDevForm
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

        public string documento_inventario = "";

        //public int sis_codigo = 0;
        //public int sismen_item = 0;

        #endregion

        #region Constructores

        public FrmAlmacenRevertirIngreso()
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

            //if (dgv_Pesado.Fn_ObtenerNumeroFilasSeleccionadas() == 0)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna etiqueta. Por favor, verifique.");
            //    return;
            //}

            //using (FrmAlmacenReubicacionUbicacionMasiva frm = new FrmAlmacenReubicacionUbicacionMasiva())
            //{
            //    DataTable dt = dgv_Pesado.Fn_ObtenerDatosFilasSeleccionadas().Copy();
            //    //DataTable dtFinal = ((DataTable)dgv_Pesado.DataSource);

            //    DataView dv = new DataView(dt);
            //    dt = dv.ToTable(false, "articulo", "articulo_descripcion", "nro_etiqueta", "lote", "col_nombre_exactus", "pmd_peso_neto");
            //    frm.dtBultos = dt;
            //    frm.tar_codigo = cbo_tar_codigo.EditValue.ToString();

            //    frm.Fn_AbrirFormulario(frm, this, true);
            //    if (frm.DialogResult == DialogResult.Yes)
            //    {
            //        //Se reemplazan las ubicaciones de los bultos:
            //        foreach (DataRow dr in frm.dtBultos.Rows)
            //        {
            //            for (int i = 0; i < dgv_Pesado.Fn_ObtenerNumeroFilas(); i++)
            //            {
            //                if (dr["nro_etiqueta"] == dgv_Pesado.Fn_ObtenerValorFila(i, "nro_etiqueta"))
            //                {
            //                    grv_Pesado.SetRowCellValue(i, "ubi_codigo", frm.ubi_descripcion);
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
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
            //Inicializar();
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
            //PL_Sistema = sis_codigo;
            //PL_Item = sismen_item;

            //DataTable dt1 = new Principal().RetornaTipoArticulo(new object[] { 0, PL_Sistema, PL_Item, PL_UsuarioE.PL_UsuCodSis });
            //cbo_tar_codigo.Fn_CargarCombobox(dt1, "tar_codigo", "tar_descripcion", 0, UcCombobox.TipoDisplay.Seleccione);

            //if (dt1.Rows.Count == 1)
            //{
            //    cbo_tar_codigo.ItemIndex = 0;
            //    Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
            //}

            //DataTable dt2 = new Principal().RetornaTipoMovimiento(new object[] { 0, "I" });
            //cbo_tmo_codigo.Fn_CargarCombobox(dt2, "tmo_codigo", "tmo_descripcion", 0, UcCombobox.TipoDisplay.Todos);

            //DataTable dt3 = new Principal().RetornaModulos();
            //cbo_bpu_modulo.Fn_CargarCombobox(dt3, "bpu_codigo", "bpu_descripcion", 0, UcCombobox.TipoDisplay.Todos);

            txt_documento_inventario.Text = documento_inventario;

            Buscar();
        }

        private void PrimeraActivacion()
        {
            Inicializar();
            //SeteaEdicion();
        }

        private void Buscar()
        {
            try
            {
                //if (cbo_tar_codigo.EditValue.ToString() == "0")
                //{
                //    if (PostBack)
                //    {
                //        Dialog.MostrarMensajeAdvertencia("Seleccione un tipo de artículo");
                //        Modulo.Instance.EnfocarControl(cbo_tar_codigo);
                //        cbo_tar_codigo.ShowPopup();
                //        return;
                //    }
                //    else
                //    {
                //        return;
                //    }
                //}

                if (PostBack)
                    dgv_Pesado.Fn_MostrarCargando();

                object[] parametros = {
                    documento_inventario
                };

                dgv_Pesado.Fn_LimpiarGrilla();
                DataTable dt = new Principal().RetornaDetalleEtiquetasReversion(parametros);
                dgv_Pesado.DataSource = dt;

                //object[] param = { cbo_tar_codigo.EditValue.ToString() };
                //DataTable dtUbicaciones = new Principal().RetornaUbicaciones(param);

                //foreach (DataRow dr in dtUbicaciones.Rows)
                //{
                //    cbo_ubicacion.Items.Add(dr["ubi_descripcion"].ToString());
                //}

                //ubi_codigo.Caption = "Ubicación";
                //ubi_codigo.FieldName = "ubi_codigo";

                dgv_Pesado.NombreArchivoExportado = "Detalle de etiquetas que se eliminarán con esta reversión de ingreso";
            }
            catch (Exception ex)
            {
                Dialog.MostrarMensajeErrorInesperado();
                Error.TomarFotoYEnviarEmailError(ex);
            }
            finally
            {
                dgv_Pesado.Fn_OcultarCargando();
            }

            if (dgv_Pesado.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeSinRegistros();
            }
            else if (dgv_Pesado.Fn_ObtenerNumeroFilas() == 1)
            {
                Modulo.Instance.EnfocarControl(dgv_Pesado);
                dgv_Pesado.Fn_SituarFocoEnPrimeraFila();
                dgv_Pesado.Fn_CapturarRegistro();
            }
            else
            {
                Modulo.Instance.EnfocarControl(dgv_Pesado);
                dgv_Pesado.Fn_SituarFocoEnPrimeraFila();
            }
            Modulo.Instance.InicializarEstadoControles(this);
        }

        private void Limpiar()
        {
            //dgv_Pesado.Fn_LimpiarGrilla(false);
            //txt_fechaini.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            //txt_fechafin.DateTime = DateTime.Today;

            //Modulo.Instance.EnfocarControl(txt_fechaini);
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

        private void FrmAlmacenRevertirIngreso_Click_Personalizado10(object sender, EventArgs e)
        {
            object[] parameters = { documento_inventario };
            DataTable dtvalida = new Principal().VerificarReversionMovimientoIngreso(parameters);

            if (dtvalida != null && dtvalida.Rows.Count > 0)
            {
                if (!Parser.GetBoolean(dtvalida.Rows[0]["valida"]))
                {
                    Dialog.MostrarMensajeAdvertencia(dtvalida.Rows[0]["mensaje"].ToString());
                    return;
                }
            }

            if (Dialog.MostrarMensajePregunta("¿Está seguro de revertir este movimiento de ingreso?", Dialog.BotonPorDefecto.Si) == DialogResult.No)
            {
                return;
            }

            object[] parameters2 = { documento_inventario, PL_UsuarioE.PL_UsuarioCodigo, "" };
            string[] resultado = new Principal().RegistrarReversionIngresoPendiente(parameters2);
            if (resultado[0] == "0")
            {
                Dialog.MostrarMensajeConfirmacionOperacion();
                DialogResult = DialogResult.Yes;
            }
            else
            {
                Dialog.MostrarMensajeError(resultado[1]);
            }
        }

        #endregion

        #region Eventos

        #endregion

        //private void dgv_Reporte_Click(object sender, EventArgs e)
        //{

        //}

        //private void dgv_Pesado_DoubleClick(object sender, EventArgs e)
        //{
        //    //PL_Modificar();
        //}

        //private void dgv_Pesado_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void FrmAlmacenGeneraDocumentoInventario_Click_Aceptar(object sender, EventArgs e)
        //{
        //    //Se graban los cambios realizados a la grilla
        //    grv_Pesado.PostEditor();
        //    grv_Pesado.UpdateCurrentRow();

        //    if (dgv_Pesado.Fn_ObtenerNumeroFilas() == 0)
        //    {
        //        Dialog.MostrarMensajeAdvertencia("No ha realizado ninguna búsqueda. Por favor, verifique.");
        //        return;
        //    }

        //    //if (dgv_Pesado.Fn_ObtenerNumeroFilasSeleccionadas() == 0)
        //    //{
        //    //    Dialog.MostrarMensajeAdvertencia("No ha seleccionado ningún registro. Por favor, verifique.");
        //    //    return;
        //    //}

        //    DataTable dtUbicacion = (DataTable)dgv_Pesado.DataSource;

        //    //Se verifica que todos los bultos de un lote tengan ubicacion asignada
        //    foreach (DataRow dr in dtUbicacion.Rows)
        //    {
        //        if (Parser.GetString(dr["ubi_codigo"].ToString()) != "SELECCIONE")
        //        {
        //            foreach (DataRow dx in dtUbicacion.Rows)
        //            {
        //                if (dx["articulo"] == dr["articulo"] && dx["lote"].ToString() == dr["lote"].ToString() && Parser.GetString(dx["ubi_codigo"].ToString()) == "SELECCIONE")
        //                {
        //                    Dialog.MostrarMensajeAdvertencia("El lote " + dr["lote"].ToString() + " no tiene completadas todas las ubicaciones. Por favor, verifique.");
        //                    return;
        //                }
        //            }
        //        }
        //    }

        //    //Se verifica que al menos un lote tenga ubicacion asignada
        //    if (Convert.ToInt32(dtUbicacion.Compute("COUNT(lote)", "ubi_codigo <> 'SELECCIONE'")) == 0)
        //    {
        //        Dialog.MostrarMensajeAdvertencia("No ha completado ninguna ubicación. Por favor, verifique.");
        //        return;
        //    }

        //    if (Dialog.MostrarMensajePregunta("¿Está seguro de GUARDAR los cambios de ubicación de los movimientos?", Dialog.BotonPorDefecto.Si) == DialogResult.Yes)
        //    {
        //        DataTable dtUbicacionPendiente = (DataTable)dgv_Pesado.DataSource;
        //        DataView dv = new DataView(dtUbicacionPendiente);
        //        dtUbicacionPendiente = dv.ToTable(true, "bpu_codigo", "ubi_codigo");

        //        string[] resultado = new Principal().RegistrarUbicacionIngresoPendiente(new object[] { dtUbicacionPendiente, PL_UsuarioE.PL_UsuarioCodigo, "" });

        //        if (resultado[0] == "0")
        //        {
        //            Dialog.MostrarMensajeConfirmacionOperacion();
        //            PL_Buscar();
        //            return;
        //        }
        //        else
        //        {
        //            Dialog.MostrarMensajeError(resultado[1].ToString());
        //            return;
        //        }
        //    }
        //}

        //private void grv_Pesado_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    if (e.Column.ColumnEdit != null && e.Column.Name == "ubi_codigo")
        //    {
        //        grv_Pesado.ShowEditor();
        //        (grv_Pesado.ActiveEditor as ComboBoxEdit).ShowPopup();
        //    }
        //}

        //private void grv_Pesado_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void cbo_ubicacion_Enter(object sender, EventArgs e)
        //{
        //    //ComboBoxEdit edit = sender as ComboBoxEdit;
        //    //BeginInvoke(new Action(() => {
        //    //    edit.ShowPopup();
        //    //}));
        //}

        //private void cbo_ubicacion_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Space || e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2)
        //    {
        //        ComboBoxEdit edit = sender as ComboBoxEdit;
        //        BeginInvoke(new Action(() =>
        //        {
        //            edit.ShowPopup();
        //        }));

        //        //e.Handled = true;
        //        //e.SuppressKeyPress = true;
        //    }
        //}

        //private void cbo_tar_codigo_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (PostBack)
        //        Buscar();
        //}

        //private void cbo_tmo_codigo_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (PostBack)
        //        Buscar();
        //}

        //private void cbo_bpu_modulo_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (PostBack)
        //        Buscar();
        //}
    }
}
