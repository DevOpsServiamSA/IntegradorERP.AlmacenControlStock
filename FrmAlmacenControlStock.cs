using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using HelperUtils;
using IntegralAPI;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmAlmacenControlStock : BaseDevForm, IBaseDevForm
    {
        #region Propiedades o VariablesbotonPersonalizado1
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
        DataTable dtTipoArticulo;
        public string ultimo_puerto_seleccionado = "";
        public bool cargando = false;

        #endregion

        #region Constructores

        public FrmAlmacenControlStock()
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
            Modulo.Instance.Limpiar(pnl_Principal);
            if (Accion == ACCION_BUSCAR)
            {
                Limpiar();
            }
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
            if (cbo_tar_codigo.EditValue.ToString() != "3")
            {
                Dialog.MostrarMensajeAdvertencia("No se ha habilitado esta función para el tipo de artículo elegido");
                return;
            }

            if (dtTipoArticulo.Rows.Count == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                return;
            }

            if (dgv_Existencia.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No ha realizado ninguna búsqueda. Por favor, verifique.");
                return;
            }

            int fila = grv_Existencia.FocusedRowHandle;
            if (fila == -1)
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado ningún registro. Por favor, verifique.");
                return;
            }

            using (FrmAlmacenControlStockDetalle frm = new FrmAlmacenControlStockDetalle())
            {
                frm.articulo = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "articulo"));
                frm.articulo_descripcion = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "articulo_descripcion"));
                frm.alias_produccion = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "alias_produccion"));
                frm.lote = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "lote"));
                frm.col_codigo = Parser.GetInt(dgv_Existencia.Fn_ObtenerValorFila(fila, "col_codigo"));
                frm.col_nombre_exactus = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "col_nombre_exactus"));
                frm.bodega = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "bodega"));
                frm.bodega_nombre = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "bodega_nombre"));
                frm.cantidad_disponible = Parser.GetDecimal(dgv_Existencia.Fn_ObtenerValorFila(fila, "cant_disponible")).ToString("N2");
                frm.stock_ubicacion = Parser.GetDecimal(dgv_Existencia.Fn_ObtenerValorFila(fila, "stock_ubicaciones")).ToString("N2");
                frm.tar_codigo = Parser.GetInt(dgv_Existencia.Fn_ObtenerValorFila(fila, "tar_codigo"));
                frm.etiqueta_seleccionada = Parser.GetString(dgv_Existencia.Fn_ObtenerValorFila(fila, "nro_etiqueta"));

                frm.Fn_AbrirFormulario(frm, this, true);
                if (frm.bModificado)
                {
                    Modulo.Instance.InicializarEstadoControles(this);
                    PL_Buscar();
                }
            }

            ////PL_Ruta_Esamblados = @"C:\Users\usuarioserviam\Desktop\Proyecto\IntegradorERP\Fuentes\Proyectos\AlmacenPesadoArticuloDetalle\bin\Debug\";
            //Fn_AbrirFormulario("AlmacenPesadoArticuloDetalle", this, parameters, true, OrigenPermisos.FormPadre);
            //PL_Ruta_Esamblados = PL_Ruta_Esamblados_Default;
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
            dtTipoArticulo = new Principal().RetornaTipoArticulo(new object[] { 0, PL_Sistema, PL_Item, PL_UsuarioE.PL_UsuCodSis });
            cbo_tar_codigo.Fn_CargarCombobox(dtTipoArticulo.Copy(), "tar_codigo", "tar_descripcion", 0, UcCombobox.TipoDisplay.Seleccione);

            if (dtTipoArticulo.Rows.Count == 0)
            {
                cbo_tar_codigo.ItemIndex = 0;
                //Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
            }

            //if (dt1.Rows.Count == 0)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas. Esta ventana se cerrará automáticamente.");
            //}
            //else
            //{
            //    cbo_tar_codigo.EditValue = "0";
            //}

            cbo_nivel.Fn_CargarCombobox(new Principal().RetornaNiveles(), "codigo", "descripcion", 0);

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
            //SeteaEdicion();
        }

        private void Buscar()
        {
            try
            {
                if (dtTipoArticulo.Rows.Count == 0)
                {
                    Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                    return;
                }

                if (cbo_tar_codigo.EditValue.ToString() == "0")
                {
                    Dialog.MostrarMensajeAdvertencia("Seleccione un tipo de artículo");
                    Modulo.Instance.EnfocarControl(cbo_tar_codigo);
                    cbo_tar_codigo.ShowPopup();
                    return;
                }

                dgv_Existencia.Fn_MostrarCargando();

                object[] parametros = {
                    PL_UsuarioE.PL_EmpresaCodigo,
                    Parser.GetInt(cbo_tar_codigo.EditValue),
                    Parser.GetString(txt_articulo.Text),
                    Parser.GetString(txt_pea_lote.Text),
                    Parser.GetString(txt_pea_color.Text),
                    Parser.GetString(txt_ubi_descripcion.Text),
                    Parser.GetString(txt_bodega.Text),
                    cbo_nivel.EditValue.ToString(),
                    chk_sin_Stock.Checked,
                    chk_mostrar_stock_sin_coincidencia.Checked
                };

                DataTable dt = new Principal().RetornaExistenciaArticulos(parametros);
                dgv_Existencia.DataSource = dt;
                dgv_Existencia.NombreArchivoExportado = "Reporte de existencias";

                if (cbo_nivel.EditValue.ToString() == "1")
                {
                    grv_Existencia.Columns["ubi_descripcion"].Visible = false;
                    grv_Existencia.Columns["nro_etiqueta"].Visible = false;
                    grv_Existencia.Columns["identificador"].Visible = false;
                    grv_Existencia.Columns["NING"].Visible = false;
                    grv_Existencia.Columns["CAT"].Visible = false;
                    grv_Existencia.Columns["pea_documento_inv"].Visible = false;
                    grv_Existencia.Columns["pea_fecha_documento_inv"].Visible = false;

                    grv_Existencia.Columns["articulo"].VisibleIndex = 0;
                    grv_Existencia.Columns["alias_produccion"].VisibleIndex = 1;
                    grv_Existencia.Columns["articulo_descripcion"].VisibleIndex = 2;
                    grv_Existencia.Columns["lote"].VisibleIndex = 3;
                    grv_Existencia.Columns["col_nombre_exactus"].VisibleIndex = 4;
                    grv_Existencia.Columns["bodega"].VisibleIndex = 5;

                    grv_Existencia.Columns["KGN"].VisibleIndex = 6;
                    grv_Existencia.Columns["KGB"].VisibleIndex = 7;
                    grv_Existencia.Columns["KGT"].VisibleIndex = 8;

                    grv_Existencia.Columns["cant_disponible"].VisibleIndex = 9;
                    grv_Existencia.Columns["stock_ubicaciones"].VisibleIndex = 10;
                }
                else
                {
                    grv_Existencia.Columns["ubi_descripcion"].Visible = true;
                    grv_Existencia.Columns["nro_etiqueta"].Visible = true;
                    grv_Existencia.Columns["identificador"].Visible = true;
                    grv_Existencia.Columns["NING"].Visible = true;
                    grv_Existencia.Columns["CAT"].Visible = true;
                    grv_Existencia.Columns["pea_documento_inv"].Visible = true;
                    grv_Existencia.Columns["pea_fecha_documento_inv"].Visible = true;

                    grv_Existencia.Columns["articulo"].VisibleIndex = 0;
                    grv_Existencia.Columns["alias_produccion"].VisibleIndex = 1;
                    grv_Existencia.Columns["articulo_descripcion"].VisibleIndex = 2;
                    grv_Existencia.Columns["lote"].VisibleIndex = 3;
                    grv_Existencia.Columns["col_nombre_exactus"].VisibleIndex = 4;
                    grv_Existencia.Columns["bodega"].VisibleIndex = 5;
                    grv_Existencia.Columns["nro_etiqueta"].VisibleIndex = 6;
                    grv_Existencia.Columns["identificador"].VisibleIndex = 7;
                    grv_Existencia.Columns["NING"].VisibleIndex = 8;
                    grv_Existencia.Columns["CAT"].VisibleIndex = 9;
                    grv_Existencia.Columns["pea_documento_inv"].VisibleIndex = 10;
                    grv_Existencia.Columns["pea_fecha_documento_inv"].VisibleIndex = 11;

                    grv_Existencia.Columns["ubi_descripcion"].VisibleIndex = 12;

                    grv_Existencia.Columns["KGN"].VisibleIndex = 13;
                    grv_Existencia.Columns["KGB"].VisibleIndex = 14;
                    grv_Existencia.Columns["KGT"].VisibleIndex = 15;

                    grv_Existencia.Columns["cant_disponible"].VisibleIndex = 16;
                    grv_Existencia.Columns["stock_ubicaciones"].VisibleIndex = 17;

                    if (cbo_tar_codigo.EditValue.ToString() == "3")
                    {
                        grv_Existencia.Columns["identificador"].Caption = "Nro. fardo";
                    }
                }

                //Se crean los resumenes de acuerdo al tipo de consulta que se está realizando:

                //Se eliminan todas las sumatorias
                foreach (GridColumn column in grv_Existencia.Columns)
                {
                    GridSummaryItem item = column.SummaryItem;
                    if (item != null)
                        column.Summary.Remove(item);
                }

                //Se añaden las sumatorias de acuerdo al nivel
                if (cbo_nivel.EditValue.ToString() == "1")
                {
                    GridColumnSummaryItem can_disp = new GridColumnSummaryItem();
                    can_disp.SummaryType = SummaryItemType.Sum;
                    can_disp.FieldName = "cant_disponible";
                    can_disp.DisplayFormat = "{0:N2}";
                    grv_Existencia.Columns["cant_disponible"].Summary.Add(can_disp);

                    GridColumnSummaryItem stock_ubi = new GridColumnSummaryItem();
                    stock_ubi.SummaryType = SummaryItemType.Sum;
                    stock_ubi.FieldName = "stock_ubicaciones";
                    stock_ubi.DisplayFormat = "{0:N2}";
                    grv_Existencia.Columns["stock_ubicaciones"].Summary.Add(stock_ubi);
                }
                else 
                {
                    GridColumnSummaryItem stock_ubi = new GridColumnSummaryItem();
                    stock_ubi.SummaryType = SummaryItemType.Sum;
                    stock_ubi.FieldName = "stock_ubicaciones";
                    stock_ubi.DisplayFormat = "{0:N2}";
                    grv_Existencia.Columns["stock_ubicaciones"].Summary.Add(stock_ubi);
                }

                GridColumnSummaryItem stock_kgn = new GridColumnSummaryItem();
                stock_kgn.SummaryType = SummaryItemType.Sum;
                stock_kgn.FieldName = "KGN";
                stock_kgn.DisplayFormat = "{0:N2}";
                grv_Existencia.Columns["KGN"].Summary.Add(stock_kgn);

                GridColumnSummaryItem stock_kgb = new GridColumnSummaryItem();
                stock_kgb.SummaryType = SummaryItemType.Sum;
                stock_kgb.FieldName = "KGB";
                stock_kgb.DisplayFormat = "{0:N2}";
                grv_Existencia.Columns["KGB"].Summary.Add(stock_kgb);

                GridColumnSummaryItem stock_kgt = new GridColumnSummaryItem();
                stock_kgt.SummaryType = SummaryItemType.Sum;
                stock_kgt.FieldName = "KGT";
                stock_kgt.DisplayFormat = "{0:N2}";
                grv_Existencia.Columns["KGT"].Summary.Add(stock_kgt);

                GridColumnSummaryItem articulo_s = new GridColumnSummaryItem();
                articulo_s.SummaryType = SummaryItemType.Count;
                articulo_s.FieldName = "articulo";
                articulo_s.DisplayFormat = "{0:N0}";
                grv_Existencia.Columns["articulo"].Summary.Add(articulo_s);

            }
            catch (Exception ex)
            {
                Dialog.MostrarMensajeErrorInesperado();
                Error.TomarFotoYEnviarEmailError(ex);
            }
            finally
            {
                dgv_Existencia.Fn_OcultarCargando();
            }

            if (dgv_Existencia.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeSinRegistros();
            }
            else if (dgv_Existencia.Fn_ObtenerNumeroFilas() == 1)
            {
                Modulo.Instance.EnfocarControl(dgv_Existencia);
                dgv_Existencia.Fn_SituarFocoEnPrimeraFila();
                dgv_Existencia.Fn_CapturarRegistro();
            }
            else
            {
                Modulo.Instance.EnfocarControl(dgv_Existencia);
                dgv_Existencia.Fn_SituarFocoEnPrimeraFila();
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
            PL_Modificar();
        }

        private void dgv_Pesado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PL_Modificar();
            }
        }

        private void FrmAlmacenGeneraDocumentoInventario_Click_Aceptar(object sender, EventArgs e)
        {
            if (cbo_tar_codigo.Fn_ObtenerNroItems() == 1)
            {
                Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() == "0")
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado un tipo de artículo. Por favor, verifique.");
                cbo_tar_codigo.ShowPopup();
                Modulo.Instance.EnfocarControl(cbo_tar_codigo);
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() != "3")
            {
                Dialog.MostrarMensajeAdvertencia("No se ha habilitado esta función para el tipo de artículo elegido");
                return;
            }

            using (FrmAlmacenRegularizaIngresos frm = new FrmAlmacenRegularizaIngresos())
            {
                frm.sis_codigo = PL_Sistema;
                frm.sismen_item = PL_Item;
                frm.vg_tar_codigo = Parser.GetInt(cbo_tar_codigo.EditValue.ToString());
                frm.Fn_AbrirFormulario(frm, this, true);
            }

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
            txt_articulo.Text = "";
            txt_descripcion.Text = "";
            txt_bodega.Text = "";
            txt_bodega_descripcion.Text = "";

            if (PostBack)
                PL_Buscar();
        }

        private void dgv_Existencia_DoubleClick(object sender, EventArgs e)
        {
            PL_Modificar();
        }

        private void dgv_Existencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PL_Modificar();
            }
        }

        private void FrmAlmacenControlStock_Click_Procesar(object sender, EventArgs e)
        {
            if (cbo_tar_codigo.Fn_ObtenerNroItems() == 1)
            {
                Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                return;
            }

            RealizarMovimientoStock();
        }

        private void FrmAlmacenControlStock_Click_Enviar(object sender, EventArgs e)
        {
            if (cbo_tar_codigo.Fn_ObtenerNroItems() == 1)
            {
                Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() != "3")
            {
                Dialog.MostrarMensajeAdvertencia("No se ha habilitado esta función para el tipo de artículo elegido");
                return;
            }

            AtenderSolicitudes();
        }

        private void AtenderSolicitudes()
        {

        }
        /*ABRIR FORMULARIO DE CONTROL DE MOVIMIENTO*/
        private void RealizarMovimientoStock()
        {
            object[] parameters = { cbo_tar_codigo.EditValue, "", PL_Sistema, PL_Item };
            //PL_Ruta_Esamblados = @"C:\Users\usuarioserviam\Desktop\Proyecto\IntegradorERP\Fuentes\Proyectos\AlmacenControlStockMovimiento\bin\Debug\";
            PL_Ruta_Esamblados = @"C:\Marco\Backup JJ\Proyectos\AlmacenControlStockMovimiento\bin\Debug\";
            Fn_AbrirFormulario("AlmacenControlStockMovimiento", this, parameters, true, OrigenPermisos.FormPadre);
            //PL_Ruta_Esamblados = PL_Ruta_Esamblados_Default;

            if (bModificado)
            {
                PL_Buscar();
            }
        }

        private void NuevoMovimiento(int tmo_codigo)
        {
            if (cbo_tar_codigo.Fn_ObtenerNroItems() == 1)
            {
                Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() == "0")
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, primero seleccione un tipo de artículo.");
                cbo_tar_codigo.ShowPopup();
                Modulo.Instance.EnfocarControl(cbo_tar_codigo);
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() != "3")
            {
                Dialog.MostrarMensajeAdvertencia("No se ha habilitado esta función para el tipo de artículo elegido");
                return;
            }

            object[] param = {
                cbo_tar_codigo.EditValue,
                tmo_codigo,
                ultimo_puerto_seleccionado,
                false,
                dtTipoArticulo
            };

            //PL_Ruta_Esamblados = @"C:\Users\usuarioserviam\Desktop\Proyecto\IntegradorERP\Fuentes\Proyectos\AlmacenPesadoArticuloBalanza\bin\Debug\";
            Fn_AbrirFormulario("AlmacenPesadoArticuloBalanza", this, param, true, OrigenPermisos.FormPadre);
            //PL_Ruta_Esamblados = PL_Ruta_Esamblados_Default;
            if (bModificado)
            {
                ultimo_puerto_seleccionado = Parser.GetString(oInput[2].ToString());

                object[] parameters = {
                    0,
                    0,
                    0,
                    Parser.GetInt(oInput[0].ToString()),
                    Parser.GetInt(oInput[1].ToString()),
                    Parser.GetString(oInput[2].ToString()),
                    dtTipoArticulo,
                    2 //Tipo 2: Modulo Almacen
                };

                //PL_Ruta_Esamblados = @"C:\Marco\Backup JJ\Proyectos\Dev\AlmacenPesadoArticuloDetalle\bin\Debug";
                //Fn_AbrirFormulario("AlmacenPesadoArticuloDetalle", this, parameters, false, OrigenPermisos.FormPadre);
                Fn_AbrirFormulario("AlmacenPesadoArticuloDetalle", this, parameters, false, OrigenPermisos.FormPadre);
                PL_Ruta_Esamblados = PL_Ruta_Esamblados_Default;

                //if (bModificado)
                //{
                //    PL_Buscar();
                //}
            }
        }

        private void FrmAlmacenControlStock_Click_Personalizado1(object sender, EventArgs e)
        {
            NuevoMovimiento(1);

            //using (FrmAlmacenReubicacionTipo frm = new FrmAlmacenReubicacionTipo())
            //{
            //    frm.Fn_AbrirFormulario(frm, this, true);
            //    if (frm.DialogResult == DialogResult.Yes)
            //    {
            //        using (FrmAlmacenReubicacionStock frx = new FrmAlmacenReubicacionStock())
            //        {
            //            frx.modo = frm.modo;

            //            //frx.articulo = articulo;
            //            //frx.descripcion = articulo_descripcion;
            //            //frx.lote = txt_lote.Text;
            //            //frx.col_codigo = col_codigo;
            //            //frx.col_descripcion = col_nombre_exactus;
            //            //frx.bodega = bodega;
            //            //frx.etiqueta = dgv_bultos.Fn_ObtenerValorFilaSeleccionada("nro_etiqueta").ToString();
            //            //frx.peso_neto = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgn"));
            //            //frx.peso_bruto = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgb"));
            //            //frx.peso_tara = Parser.GetDecimal(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_kgt"));
            //            //frx.ubicacion = dgv_bultos.Fn_ObtenerValorFilaSeleccionada("ubi_descripcion").ToString();
            //            //frx.tar_codigo = tar_codigo;
            //            //frx.nro_fardo_disponible = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("tar_contador").ToString());
            //            //frx.lpr_codigo = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("lpr_codigo").ToString());
            //            //frx.identificador = Parser.GetInt(dgv_bultos.Fn_ObtenerValorFilaSeleccionada("eal_identificador").ToString());

            //            frx.Fn_AbrirFormulario(frx, this, true);
            //            if (frx.DialogResult == DialogResult.Yes || frm.bModificado)
            //            {
            //                //Aqui debe cargar nuevamente los bultos
            //                PL_Buscar();
            //            }
            //        }
            //    }
            //}
        }

        private void FrmAlmacenControlStock_Click_Personalizado2(object sender, EventArgs e)
        {
            if (cbo_tar_codigo.Fn_ObtenerNroItems() == 1)
            {
                Dialog.MostrarMensajeAdvertencia("No tiene asignado ningún tipo de artículo. Por favor, contacte con Sistemas.");
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() == "0")
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, primero seleccione un tipo de artículo.");
                cbo_tar_codigo.ShowPopup();
                Modulo.Instance.EnfocarControl(cbo_tar_codigo);
                return;
            }

            if (cbo_tar_codigo.EditValue.ToString() != "3")
            {
                Dialog.MostrarMensajeAdvertencia("No se ha habilitado esta función para el tipo de artículo elegido");
                return;
            }

            RealizarMovimientoStock();
        }

        private void FrmAlmacenControlStock_Click_Personalizado7(object sender, EventArgs e)
        {
            NuevoMovimiento(3);
        }

        private void cbo_nivel_EditValueChanged(object sender, EventArgs e)
        {
            if (PostBack)
            {
                cargando = true;

                PL_Buscar();

                if (cbo_nivel.EditValue.ToString() == "1")
                {
                    chk_sin_Stock.Habilitado = true;
                }
                else
                {
                    chk_sin_Stock.Checked = false;
                    chk_sin_Stock.Habilitado = false;
                }
                
                cargando = false;
            }
                
        }

        private void grv_Existencia_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column == cant_disponible)
            {
                string articulo1 = view.GetRowCellDisplayText(e.RowHandle1, articulo);
                string articulo2 = view.GetRowCellDisplayText(e.RowHandle2, articulo);

                string lote1 = view.GetRowCellDisplayText(e.RowHandle1, lote);
                string lote2 = view.GetRowCellDisplayText(e.RowHandle2, lote);

                string bodega1 = view.GetRowCellDisplayText(e.RowHandle1, bodega);
                string bodega2 = view.GetRowCellDisplayText(e.RowHandle2, bodega);

                e.Merge = (articulo1 == articulo2 && lote1 == lote2 && bodega1 == bodega2);
                e.Handled = true;
            }
        }

        private void chk_mostrar_stock_sin_coincidencia_CheckedChanged(object sender, EventArgs e)
        {
            if (PostBack)
                PL_Buscar();
        }

        private void txt_articulo_LimpiezaFinalizada(object sender, EventArgs e)
        {
            dgv_Existencia.Fn_LimpiarGrilla();
        }

        private void txt_articulo_CapturaFinalizada(object sender, EventArgs e)
        {
            PL_Buscar();
        }

        private void txt_bodega_CapturaFinalizada(object sender, EventArgs e)
        {
            PL_Buscar();
        }

        private void txt_bodega_LimpiezaFinalizada(object sender, EventArgs e)
        {
            dgv_Existencia.Fn_LimpiarGrilla();
        }

        private void chk_sin_Stock_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargando)
            {
                if (PostBack)
                    PL_Buscar();
            }
        }
    }
}
