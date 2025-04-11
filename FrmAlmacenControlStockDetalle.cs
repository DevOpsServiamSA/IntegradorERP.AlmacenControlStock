using HelperUtils;
using IntegralAPI;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmAlmacenControlStockDetalle : BaseDevForm, IBaseDevForm
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

        public string articulo;
        public string articulo_descripcion;
        public string alias_produccion;
        public string lote;
        public int col_codigo;
        public string col_nombre_exactus;
        public string bodega;
        public string bodega_nombre;
        public string cantidad_disponible;
        public string stock_ubicacion;
        public int tar_codigo;
        public string etiqueta_seleccionada;

        #endregion

        #region Constructores

        public FrmAlmacenControlStockDetalle()
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
            //if (dgv_Pesado.Fn_ObtenerNumeroFilas() == 0)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No ha realizado ninguna búsqueda. Por favor, verifique.");
            //    return;
            //}

            //int fila = grv_Pesado.FocusedRowHandle;
            //if (fila == -1)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No ha seleccionado ningún registro. Por favor, verifique.");
            //    return;
            //}

            //object[] parameters = {
            //    Parser.GetInt(dgv_Pesado.Fn_ObtenerValorFila(fila, "pea_anno")),
            //    Parser.GetInt(dgv_Pesado.Fn_ObtenerValorFila(fila, "pea_mes")),
            //    Parser.GetInt(dgv_Pesado.Fn_ObtenerValorFila(fila, "pea_codigo")),
            //    Parser.GetInt(dgv_Pesado.Fn_ObtenerValorFila(fila, "tar_codigo")),
            //    Parser.GetInt(dgv_Pesado.Fn_ObtenerValorFila(fila, "tmo_codigo")),
            //    ""
            //};

            ////PL_Ruta_Esamblados = @"C:\Users\usuarioserviam\Desktop\Proyecto\IntegradorERP\Fuentes\Proyectos\AlmacenPesadoArticuloDetalle\bin\Debug\";
            //Fn_AbrirFormulario("AlmacenPesadoArticuloDetalle", this, parameters, true, OrigenPermisos.FormPadre);
            //if (bModificado)
            //{
            //    PL_Buscar();
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
            //DataTable dt1 = new Principal().RetornaTipoArticulo(new object[] { 0 });
            //cbo_tar_codigo.Fn_CargarCombobox(dt1, "tar_codigo", "tar_descripcion", 0, UcCombobox.TipoDisplay.Seleccione);
            //cbo_nivel.Fn_CargarCombobox(new Principal().RetornaNiveles(), "codigo", "descripcion", 0);

            //DataTable dt2 = new Principal().RetornaTipoMovimiento(new object[] { 0, "" });
            //DataTable dt3 = new Principal().RetornaEstado(new object[] { 0 });
            //cbo_tar_codigo.Fn_CargarCombobox(new Principal().RetornaTipoArticulo(new object[] { 0 }), "tar_codigo", "tar_descripcion", 0);
            //cbo_tmo_codigo.Fn_CargarCombobox(new Principal().RetornaTipoMovimiento(new object[] { 0, "" }), "tmo_codigo", "tmo_descripcion", 0);
            //cbo_pes_codigo.Fn_CargarCombobox(new Principal().RetornaEstado(new object[] { 0 }), "pes_codigo", "pes_descripcion", 0);
            //cbo_tmo_codigo.Fn_CargarCombobox(dt2, "tmo_codigo", "tmo_descripcion", 0, UcCombobox.TipoDisplay.Todos);
            //txt_fechaini.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            //txt_fechafin.DateTime = DateTime.Today;
            //Modulo.Instance.EnfocarControl(txt_fechaini);
        }

        private void PrimeraActivacion()
        {
            Text = "Artículo: " + articulo + " | " + "Lote: " + lote;

            txt_codigo_articulo.Text = articulo;
            txt_articulo.Text = articulo_descripcion;
            txt_alias_produccion.Text = alias_produccion;
            txt_bodega.Text = bodega + " - " + bodega_nombre;
            txt_lote.Text = lote;
            txt_col_nombre_exactus.Text = col_nombre_exactus;
            txt_cantidad_disponible.Text = cantidad_disponible;
            txt_stock_ubicacion.Text = "";

            PL_Buscar();
        }

        private void Buscar()
        {
            try
            {
                if (PostBack)
                    Fn_MostrarCargando();

                object[] parameters = { PL_UsuarioE.PL_EmpresaCodigo, bodega, articulo, lote, col_codigo, chk_ver_etiquetas_consumidas.Checked };

                DataTable[] dtInformacion = new Principal().RetornaDetalleStockLote(parameters);

                if (dtInformacion != null)
                {
                    dgv_bultos.DataSource = dtInformacion[0];
                    dgv_kardex.DataSource = dtInformacion[1];
                }

                if (tar_codigo == 3) //Producto en proceso
                {
                    grv_bultos.Columns["eal_identificador"].Caption = "Nro. fardo";
                }
                else
                {
                    grv_bultos.Columns["eal_identificador"].Caption = "Identificador";
                }

                //Si desde la pantalla principal se eligió una etiqueta, se sitúa en la fila de la etiqueta:
                if (etiqueta_seleccionada != "")
                {
                    int rowHandle = grv_bultos.LocateByValue("nro_etiqueta", etiqueta_seleccionada);
                    if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        grv_bultos.FocusedRowHandle = rowHandle;

                    etiqueta_seleccionada = "";
                }

            }
            catch (Exception ex)
            {
                Dialog.MostrarMensajeErrorInesperado();
                Error.TomarFotoYEnviarEmailError(ex);
            }
            finally
            {
                Fn_OcultarCargando();

                //dgv_Existencia.Fn_OcultarCargando();
            }

            //if (dgv_Existencia.Fn_ObtenerNumeroFilas() == 0)
            //{
            //    Dialog.MostrarMensajeSinRegistros();
            //}
            //else if (dgv_Existencia.Fn_ObtenerNumeroFilas() == 1)
            //{
            //    Modulo.Instance.EnfocarControl(dgv_Existencia);
            //    dgv_Existencia.Fn_SituarFocoEnPrimeraFila();
            //    dgv_Existencia.Fn_CapturarRegistro();
            //}
            //else
            //{
            //    Modulo.Instance.EnfocarControl(dgv_Existencia);
            //    dgv_Existencia.Fn_SituarFocoEnPrimeraFila();
            //}

            //Se calcula el stock:
            if (dgv_bultos.Fn_ObtenerNumeroFilas() > 0)
            {
                DataTable dtBultos = (DataTable)dgv_bultos.DataSource;
                txt_stock_ubicacion.Text = 
                    (
                        Parser.GetDecimal(dtBultos.Compute("SUM(eal_cant_disponible)", "eal_cant_disponible > 0 AND disponible = 'S'"))
                        +
                        Parser.GetDecimal(dtBultos.Compute("SUM(eal_cant_reservada)", "eal_cant_reservada > 0 AND disponible = 'S'"))
                    ).ToString("N2");
            }
            else
            {
                txt_stock_ubicacion.Text = "0.00";
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

        #endregion

        #region Eventos

        #endregion

        private void dgv_Reporte_Click(object sender, EventArgs e)
        {

        }

        //private void FrmAlmacenPesadoProductoProceso_Click_Personalizado1(object sender, EventArgs e)
        //{
        //    AbrirMovimiento(1);
        //}

        //private void FrmAlmacenPesadoProductoProceso_Click_Personalizado2(object sender, EventArgs e)
        //{
        //    AbrirMovimiento(3);
        //}

        //private void AbrirMovimiento(int tmo_codigo)
        //{
        //    if (cbo_tar_codigo.EditValue.ToString() == "0")
        //    {
        //        Dialog.MostrarMensajeAdvertencia("Primero debe seleccionar un tipo de artículo");
        //        Modulo.Instance.EnfocarControl(cbo_tar_codigo);
        //        cbo_tar_codigo.ShowPopup();
        //        return;
        //    }

        //    //using (FrmAlmacenPesadoProductoProcesoBalanza frmBalanza = new FrmAlmacenPesadoProductoProcesoBalanza())
        //    //{
        //    //    frmBalanza.tmo_codigo = tmo_codigo;
        //    //    frmBalanza.Fn_AbrirFormulario(frmBalanza, this, true);

        //    //    if (frmBalanza.DialogResult == DialogResult.Yes)
        //    //    {
        //    //        using (FrmAlmacenPesadoProductoProcesoIngreso frmIngreso = new FrmAlmacenPesadoProductoProcesoIngreso())
        //    //        {
        //    //            frmIngreso.tmo_codigo = frmBalanza.tmo_codigo;
        //    //            frmIngreso.puerto = frmBalanza.puerto;
        //    //            frmIngreso.tar_codigo = Parser.GetInt(cbo_tar_codigo.EditValue.ToString());
        //    //            frmIngreso.Fn_AbrirFormulario(frmIngreso, this, true);

        //    //            if (frmIngreso.bModificado)
        //    //            {
        //    //                PL_Buscar();
        //    //            }
        //    //        }
        //    //    }
        //    //}
        //}

        private void dgv_Pesado_DoubleClick(object sender, EventArgs e)
        {
            //PL_Modificar();
        }

        private void dgv_Pesado_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    PL_Modificar();
            //}
        }

        private void FrmAlmacenGeneraDocumentoInventario_Click_Aceptar(object sender, EventArgs e)
        {
            //using (FrmAlmacenRegularizaIngresos frm = new FrmAlmacenRegularizaIngresos())
            //{
            //    frm.Fn_AbrirFormulario(frm, this, true);
            //}

            ////Se graban los cambios realizados a la grilla
            //grv_Pesado.PostEditor();
            //grv_Pesado.UpdateCurrentRow();

            //if (dgv_Pesado.Fn_ObtenerNumeroFilas() == 0)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No ha realizado ninguna búsqueda. Por favor, verifique.");
            //    return;
            //}

            //if (dgv_Pesado.Fn_ObtenerNumeroFilasSeleccionadas() == 0)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No ha seleccionado ningún registro. Por favor, verifique.");
            //    return;
            //}

            //DataTable dtSeleccionado = dgv_Pesado.Fn_ObtenerDatosFilasSeleccionadas();
            //DataView dv = new DataView(dtSeleccionado);

            //DataTable dtValidar = dv.ToTable(true, "tar_codigo", "tmo_codigo", "stm_codigo").Copy();

            //if (dtValidar.Rows.Count > 1)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No está permitido elegir distintos tipos de movimientos. Por favor, verifique.");
            //    return;
            //}

            //if (Dialog.MostrarMensajePregunta("¿Está seguro de generar el Parte de Producción y enviar a Almacén los pesados seleccionados?", Dialog.BotonPorDefecto.Si) != DialogResult.Yes)
            //{
            //    return;
            //}

            //DataTable dtEnviar = dv.ToTable(true, "pea_nro_control", "tar_codigo", "tmo_codigo", "stm_codigo").Copy();

            //object[] parameters = { dtEnviar, PL_UsuarioE.PL_UsuarioCodigo, "" };
            //string[] resultado = new Principal().RegistrarEnvioAlmacen(parameters);

            //if (resultado[0] == "0")
            //{
            //    Dialog.MostrarMensajeConfirmacionOperacion();
            //    PL_Buscar();
            //    return;
            //}
            //else
            //{
            //    Dialog.MostrarMensajeError(resultado[1].ToString());
            //    return;
            //}
        }

        private void cbo_tar_codigo_EditValueChanged(object sender, EventArgs e)
        {
            //txt_articulo.Text = "";
            //txt_descripcion.Text = "";
            //txt_bodega.Text = "";
            //txt_bodega_descripcion.Text = "";
        }

        private void tb_bultos_Click_Imprimir(object sender, EventArgs e)
        {
            //ImprimirEtiquetas("");
        }

        private void ImprimirEtiquetas(string nro_etiqueta)
        {
            //Lanzar a imprimir las etiquetas automaticamente
            try
            {
                //Fn_MostrarCargando("Imprimiendo etiquetas", "");

                if (tar_codigo == 3) /*Producto en proceso*/
                {
                    using (FrmImpresionEtiqueta frm = new FrmImpresionEtiqueta())
                    {
                        object[] parameters = { PL_UsuarioE.PL_EmpresaCodigo, articulo, lote, nro_etiqueta };
                        DataTable dtInformacion = new Principal().RetornaDetalleEtiquetasImpresion(parameters);

                        //Version 1
                        frm.dtInformacion = dtInformacion;
                        frm.CargarReporte();
                        frm.ShowDialog();

                        //Version 2
                        //XtraReportEtiquetaProductoProceso xtra = new XtraReportEtiquetaProductoProceso();
                        //xtra.DataSource = dtInformacion;
                        //xtra.FillDataSource();
                        //ReportPrintTool printTool = new ReportPrintTool(xtra);
                        //printTool.ShowPreviewDialog();
                    }
                }
                else
                {
                    //Fn_OcultarCargando();
                    Dialog.MostrarMensajeError("No se ha configurado la etiqueta del producto seleccionado. Por favor, contacte a Sistemas.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                Fn_OcultarCargando();
                Dialog.MostrarMensajeError("No se pudieron imprimir las etiquetas." + ex.Message);
            }
        }

        private void FrmAlmacenControlStockDetalle_Click_Enviar(object sender, EventArgs e)
        {

        }

        private void tb_bultos_Click_Personalizado3(object sender, EventArgs e)
        {
            
        }

        private void tb_bultos_Click_Personalizado4(object sender, EventArgs e)
        {
            if (dgv_bultos.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No se han encontrado etiquetas. Por favor, verifique.");
                return;
            }

            int fila = grv_bultos.FocusedRowHandle;
            if (fila == -1)
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna etiqueta. Por favor, verifique.");
                return;
            }

            if (dgv_bultos.Fn_ObtenerValorFila(fila, "tipo").ToString() == "Residuo")
            {
                Dialog.MostrarMensajeAdvertencia("No se permite imprimir la etiqueta de un residuo");
                return;
            }

            ImprimirEtiquetas(dgv_bultos.Fn_ObtenerValorFila(fila, "nro_etiqueta").ToString());
        }
        /*
            Cambios para poder reubicar etiquetas por artículo y lote
            pedido solicitado por B.A. y almacén Filasur
        */
        private void tb_bultos_Click_Reubicar_Bloque(object sender, EventArgs e)
        {
            
        }

        private void tb_bultos_Click_Procesar(object sender, EventArgs e)
        {
            if (dgv_bultos.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No se han encontrado etiquetas. Por favor, verifique.");
                return;
            }

            int fila = grv_bultos.FocusedRowHandle;
            if (fila == -1)
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna etiqueta. Por favor, verifique.");
                return;
            }

            if (dgv_bultos.Fn_ObtenerValorFilaSeleccionada("tipo").ToString() == "Residuo")
            {
                Dialog.MostrarMensajeAdvertencia("No puede partir ni reubicar un residuo. Por favor, verifique.");
                Modulo.Instance.EnfocarControl(dgv_bultos);
                dgv_bultos.Fn_SituarFocoEnPrimeraFila();
                return;
            }

            if (dgv_bultos.Fn_ObtenerValorFilaSeleccionada("disponible").ToString() == "N")
            {
                Dialog.MostrarMensajeAdvertencia("No puede partir ni reubicar esta etiqueta porque se encuentra " + dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eet_descripcion").ToString().ToUpper() + ". Por favor, verifique.");
                Modulo.Instance.EnfocarControl(dgv_bultos);
                dgv_bultos.Fn_SituarFocoEnPrimeraFila();
                return;
            }

            using (FrmAlmacenReubicacionTipo frm = new FrmAlmacenReubicacionTipo())
            {
                frm.Fn_AbrirFormulario(frm, this, true);
                if (frm.DialogResult == DialogResult.Yes)
                {
                    using (FrmAlmacenReubicacionStock frx = new FrmAlmacenReubicacionStock())
                    {
                        frx.modo = frm.modo;
                        frx.puerto = frm.puerto;

                        frx.articulo = articulo;
                        frx.descripcion = articulo_descripcion;
                        frx.lote = txt_lote.Text;
                        frx.col_codigo = col_codigo;
                        frx.col_descripcion = col_nombre_exactus;
                        frx.bodega = bodega;
                        frx.etiqueta = dgv_bultos.Fn_ObtenerValorFilaSeleccionada("nro_etiqueta").ToString();
                        frx.peso_neto = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgn"));
                        frx.peso_bruto = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgb"));
                        frx.peso_tara = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgt"));
                        frx.ubicacion = dgv_bultos.Fn_ObtenerValorFilaSeleccionada("ubi_descripcion").ToString();
                        frx.tar_codigo = tar_codigo;
                        frx.nro_fardo_disponible = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("tar_contador").ToString());
                        frx.lpr_codigo = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("lpr_codigo").ToString());
                        frx.identificador = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_identificador").ToString());

                        frx.Fn_AbrirFormulario(frx, this, true);
                        if (frx.DialogResult == DialogResult.Yes || frm.bModificado)
                        {
                            //Aqui debe cargar nuevamente los bultos
                            PL_Buscar();
                        }
                    }
                }
            }
        }

        private void tb_bultos_Click_Personalizado5(object sender, EventArgs e)
        {
            if (dgv_bultos.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No se han encontrado etiquetas. Por favor, verifique.");
                return;
            }

            ImprimirEtiquetas("");
        }

        private void tb_kardex_Click_Personalizado6(object sender, EventArgs e)
        {
            Dialog.MostrarMensajeOpcionNoImplementada();

            //Aqui debe abrir la fucionalidad de revertir el movimiento de kardex
        }

        private void tb_bultos_Click_Modificar(object sender, EventArgs e)
        {
            
        }

        //private void tb_bultos_Click_Enviar(object sender, EventArgs e)
        //{
            
        //}

        private void tb_bultos_Click_Importar(object sender, EventArgs e)
        {
            if (dgv_bultos.Fn_ObtenerNumeroFilasSeleccionadas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna etiqueta. Por favor, verifique.");
                return;
            }

            if (dgv_bultos.Fn_ObtenerValorFilaSeleccionada("disponible").ToString() == "N")
            {
                Dialog.MostrarMensajeAdvertencia("No puede realizar movimientos con esta etiqueta porque se encuentra " + dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eet_descripcion").ToString().ToUpper() + ". Por favor, verifique.");
                Modulo.Instance.EnfocarControl(dgv_bultos);
                dgv_bultos.Fn_SituarFocoEnPrimeraFila();
                return;
            }

            //object[] parameters = { tar_codigo, dgv_bultos.Fn_ObtenerValorFilaSeleccionada("nro_etiqueta"), PL_Sistema, PL_Item };
            object[] parameters = { tar_codigo, dgv_bultos.Fn_ObtenerValorFilaSeleccionada("nro_etiqueta"), 2, 6 };
            //PL_Ruta_Esamblados = @"C:\Users\usuarioserviam\Desktop\Proyecto\IntegradorERP\Fuentes\Proyectos\AlmacenControlStockMovimiento\bin\Debug\";
            Fn_AbrirFormulario("AlmacenControlStockMovimiento", this, parameters, true, OrigenPermisos.FormPadre);
            //PL_Ruta_Esamblados = PL_Ruta_Esamblados_Default;

            if (bModificado)
            {
                PL_Buscar();
            }
        }

        private void chk_ver_etiquetas_consumidas_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnReubicarBloque_Click(object sender, EventArgs e)
        {
            if (dgv_bultos.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No se han encontrado etiquetas. Por favor, verifique.");
                return;
            }

            int fila = grv_bultos.FocusedRowHandle;
            if (fila == -1)
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna etiqueta. Por favor, verifique.");
                return;
            }

            if (dgv_bultos.Fn_ObtenerValorFilaSeleccionada("tipo").ToString() == "Residuo")
            {
                Dialog.MostrarMensajeAdvertencia("No puede partir ni reubicar un residuo. Por favor, verifique.");
                Modulo.Instance.EnfocarControl(dgv_bultos);
                dgv_bultos.Fn_SituarFocoEnPrimeraFila();
                return;
            }

            if (dgv_bultos.Fn_ObtenerValorFilaSeleccionada("disponible").ToString() == "N")
            {
                Dialog.MostrarMensajeAdvertencia("No puede partir ni reubicar esta etiqueta porque se encuentra " + dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eet_descripcion").ToString().ToUpper() + ". Por favor, verifique.");
                Modulo.Instance.EnfocarControl(dgv_bultos);
                dgv_bultos.Fn_SituarFocoEnPrimeraFila();
                return;
            }

            using (FrmAlmacenReubicacionTipo frm = new FrmAlmacenReubicacionTipo())
            {
                frm.Fn_AbrirFormulario(frm, this, true);
                if (frm.DialogResult == DialogResult.Yes)
                {
                    using (FrmAlmacenReubicacionStockMasivo frx = new FrmAlmacenReubicacionStockMasivo())
                    {
                        frx.modo = frm.modo;
                        frx.puerto = frm.puerto;

                        frx.articulo = articulo;
                        frx.descripcion = articulo_descripcion;
                        frx.lote = txt_lote.Text;
                        frx.col_codigo = col_codigo;
                        frx.col_descripcion = col_nombre_exactus;
                        frx.bodega = bodega;
                        frx.etiqueta = dgv_bultos.Fn_ObtenerValorFilaSeleccionada("nro_etiqueta").ToString();
                        frx.peso_neto = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgn"));
                        frx.peso_bruto = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgb"));
                        frx.peso_tara = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgt"));
                        frx.ubicacion = dgv_bultos.Fn_ObtenerValorFilaSeleccionada("ubi_descripcion").ToString();
                        frx.tar_codigo = tar_codigo;
                        frx.nro_fardo_disponible = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("tar_contador").ToString());
                        frx.lpr_codigo = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("lpr_codigo").ToString());
                        frx.identificador = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_identificador").ToString());

                        frx.Fn_AbrirFormulario(frx, this, true);
                        if (frx.DialogResult == DialogResult.Yes || frm.bModificado)
                        {
                            //Aqui debe cargar nuevamente los bultos
                            PL_Buscar();
                        }
                    }
                }
            }
        }
    }
}
