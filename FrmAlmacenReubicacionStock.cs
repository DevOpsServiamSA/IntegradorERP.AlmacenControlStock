using DevExpress.XtraLayout.Utils;
using HelperUtils;
using IntegralAPI;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace AlmacenControlStock
{
    public partial class FrmAlmacenReubicacionStock : BaseDevForm, IBaseDevForm
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
        public string descripcion;
        public string lote;
        public int col_codigo;
        public string col_descripcion;
        public string bodega;
        public string etiqueta;
        public decimal peso_neto;
        public decimal peso_bruto;
        public decimal peso_tara;
        public string ubicacion;
        public int tar_codigo;

        DataTable dtMovimientoDetalle;

        int tmo_codigo = 4; //Tipo de movimiento: 4 = Movimientos internos de almacen

        public int nro_fardo_disponible = 0;
        public int identificador = 0;
        public int lpr_codigo = 0;

        public string puerto;
        public string nPeso;
        public int modo;

        public bool cargando_cambio = false;

        #endregion

        #region Constructores

        public FrmAlmacenReubicacionStock()
        {
            InitializeComponent();
            PL_Forms = this;
            PL_Principal = new Principal();
        }

        public FrmAlmacenReubicacionStock(object[] parameters) : this()
        {
            //pea_anno = Parser.GetInt(parameters[0]);
            //pea_mes = Parser.GetInt(parameters[1]);
            //pea_codigo = Parser.GetInt(parameters[2]);
            //tar_codigo = Parser.GetInt(parameters[3]);
            //tmo_codigo = Parser.GetInt(parameters[4]);
            //puerto = parameters[5].ToString();
            //dtTipoArticulo = (DataTable)parameters[6];
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

        private void InicializarDataTables()
        {
            dtMovimientoDetalle = new DataTable();

            dtMovimientoDetalle.Columns.Add("nro", typeof(int));
            dtMovimientoDetalle.Columns.Add("tmo_codigo", typeof(int));
            dtMovimientoDetalle.Columns.Add("stm_codigo", typeof(int));
            dtMovimientoDetalle.Columns.Add("stm_descripcion", typeof(string));
            dtMovimientoDetalle.Columns.Add("documento_referencia", typeof(string));
            dtMovimientoDetalle.Columns.Add("referencia", typeof(string));
            dtMovimientoDetalle.Columns.Add("peso_neto", typeof(decimal));
            dtMovimientoDetalle.Columns.Add("peso_bruto", typeof(decimal));
            dtMovimientoDetalle.Columns.Add("peso_tara", typeof(decimal));
            dtMovimientoDetalle.Columns.Add("con_codigo", typeof(int));
            dtMovimientoDetalle.Columns.Add("identificador", typeof(int));
            dtMovimientoDetalle.Columns.Add("ubi_codigo", typeof(int));
            dtMovimientoDetalle.Columns.Add("ubi_descripcion", typeof(string));
            dtMovimientoDetalle.Columns.Add("residuo", typeof(bool));

            dgv_Detalle.DataSource = dtMovimientoDetalle;
        }

        private void Inicializar()
        {
            lyt_excedente.Visibility = LayoutVisibility.Never;

            try
            {
                InicializarDataTables();
            }
            catch (Exception ex)
            {
                Dialog.MostrarMensajeError(ex.Message);
            }
        }

        private void InicializarBalanza()
        {
            try
            {
                if (puerto != "")
                {
                    //if (Environment.MachineName == "FILDMJ0APCJ6")
                    //{
                    //    SerialPortExt.BaudRate = 9600;
                    //    SerialPortExt.Parity = Parity.Even;
                    //    SerialPortExt.DataBits = 7;
                    //}

                    if (!SerialPortExt.IsOpen)
                    {
                        txt_puerto_com.Text = puerto;
                        SerialPortExt.PortName = puerto;
                        SerialPortExt.Open();
                    }
                }
                //else
                //{
                //    object[] param = {
                //        tar_codigo,
                //        tmo_codigo,
                //        "",
                //        true
                //    };

                //    //PL_Ruta_Esamblados = @"C:\Users\usuarioserviam\Desktop\Proyecto\IntegradorERP\Fuentes\Proyectos\AlmacenPesadoArticuloBalanza\bin\Debug\";
                //    Fn_AbrirFormulario("AlmacenPesadoArticuloBalanza", this, param, true, OrigenPermisos.FormPadre);

                //    if (bModificado)
                //    {
                //        puerto = Parser.GetString(oInput[2].ToString());
                //        InicializarBalanza();
                //    }
                //    else
                //    {
                //        Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna balanza. Se ha cancelado la operación.");
                //        DialogResult = DialogResult.No;
                //    }
                //}
            }
            catch (Exception ex)
            {
                //Dialog.MostrarMensajeError("No se pudo conectar a la balanza. Verifique que el puerto: " + txt_puerto_com.Text + " se encuentre conectado correctamente.");
            }


            //        If Puerto<> "" Then

            //            'PUESTO POR MIENTRAS: HABLAR CON JORGE LUDEÑA PARA QUE TODAS LAS BALANZAS TENGAN LA MISMA CONFIGURACION
            //            If(Environment.MachineName = "FILDMJ0APCJ6") Then
            //                SerialPortExt.BaudRate = 9600
            //                SerialPortExt.Parity = Parity.Even
            //                SerialPortExt.DataBits = 7
            //            End If

            //            lbl_PUERTO.Text = Puerto  'ConfigurationManager.AppSettings("PORT_NAME_INGRESO").ToString()
            //            SerialPortExt.PortName = Puerto 'ConfigurationManager.AppSettings("PORT_NAME_INGRESO").ToString()
            //            SerialPortExt.Open()

            //        Else

            //            lbl_PUERTO.Text = ""
            //            Label13.Text = ""

            //        End If

            //    Catch ex As Exception
            //        MessageBox.Show("Error: No se pudo conectar a la balanza. Verifique que el puerto: " + lbl_PUERTO.Text + " se encuentre conectado correctamente.", "Menú de aplicaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            //    End Try   
        }

        private void PrimeraActivacion()
        {
            //Aca debe verificar si se trata de un nuevo pesado o se esta revisando un pesado previamente registrado
            //if (pea_codigo > 0 && pea_anno > 0 && pea_mes > 0)
            //{
            //    lyt_auditoria.Visibility = LayoutVisibility.Always;
            //    lyt_pesado_manual.Visibility = LayoutVisibility.Never;
            //    lyt_pesado_manual.Visibility = LayoutVisibility.Never;
            //    lyt_puerto.Visibility = LayoutVisibility.Never;
            //    lyt_peso_actual.Visibility = LayoutVisibility.Never;
            //    lyt_puerto_seleccionado.Visibility = LayoutVisibility.Never;
            //    lyt_estado.Visibility = LayoutVisibility.Always;

            //    SeteaEdicion();
            //    txt_puerto_com.Text = puerto;
            //    CargarCombos();

            //    CargarPesado(pea_anno, pea_mes, pea_codigo);
            //}
            //else
            //{

            SeteaNuevo();

            if (modo == 1)
            {
                lyt_pesado_manual.Visibility = LayoutVisibility.Never;
                lyt_puerto.Visibility = LayoutVisibility.Never;
                lyt_peso_actual.Visibility = LayoutVisibility.Never;
                lyt_puerto_seleccionado.Visibility = LayoutVisibility.Never;

                txt_peso_bruto.Habilitado = true;
            }
            else
            {
                lyt_pesado_manual.Visibility = LayoutVisibility.Always;
                lyt_puerto.Visibility = LayoutVisibility.Always;
                lyt_peso_actual.Visibility = LayoutVisibility.Always;
                lyt_puerto_seleccionado.Visibility = LayoutVisibility.Always;

                txt_peso_bruto.Habilitado = false;

                txt_puerto_com.Text = puerto;
                InicializarBalanza();
            }

            CargarCombos();

            //Se carga la informacion del bulto original
            txt_articulo.Text = articulo;
            txt_descripcion.Text = descripcion;
            txt_lote.Text = lote;
            txt_col_descripcion.Text = col_descripcion;
            txt_bodega.Text = bodega;
            txt_peso_bruto_original.Text = peso_bruto.ToString("N2");
            txt_peso_neto_original.Text = peso_neto.ToString("N2");
            txt_ubicacion.Text = ubicacion;
            txt_identificador.Text = identificador.ToString();
            txt_etiqueta.Text = etiqueta.ToString();

            txt_stock_por_reubicar.Text = peso_neto.ToString("N2");
            txt_stock_reubicado.Text = "0.00";

            txt_documento_referencia.Text = "REUBICACIÓN PARTICIÓN";
            txt_referencia.Text = "REUBICACIÓN PARTICIÓN ETQ";

            if (modo == 1)
            {
                //Por defecto se indica que se migrará todo:
                txt_peso_bruto.Text = peso_bruto.ToString("N2");
                txt_peso_neto.Text = peso_neto.ToString("N2");
                txt_tara.Text = peso_tara.ToString("N2");
            }
            else
            {
                txt_peso_bruto.Text = "0.00";
                txt_peso_neto.Text = "0.00";
                txt_tara.Text = "0.00";
            }

            Modulo.Instance.EnfocarControl(txt_ubi_codigo);

            //Cargar la configuracion de busquedas de colores
            //if (tar_codigo == 3) //Para el tipo de articulo PRODUCTO EN PROCESO, se ocultan las columnas de ACATEX
            //{
            //    txt_col_codigo.Columnas[0].Visible = true;
            //    txt_col_codigo.Columnas[1].Visible = true;
            //    txt_col_codigo.Columnas[2].Visible = false;
            //    txt_col_codigo.Columnas[3].Visible = false;

            //    txt_col_codigo.Columnas[1].Caption = "Nombre";

            //    //Además, el color por defecto es "CRUDO"
            //    txt_col_codigo.Text = "6";
            //    txt_col_codigo.Fn_EjecutarBusqueda();
            //}
            //else
            //{
            //    txt_col_codigo.Columnas[0].Visible = true;
            //    txt_col_codigo.Columnas[1].Visible = true;
            //    txt_col_codigo.Columnas[2].Visible = true;
            //    txt_col_codigo.Columnas[3].Visible = true;
            //}
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
            SeteaNuevo();
            txt_puerto_com.Text = puerto;
            InicializarBalanza();
            InicializarDataTables();
            CargarCombos();

            //cbo_lpr_codigo.Habilitado = true;
            cbo_stm_codigo.Habilitado = true;
            //txt_articulo.Habilitado = true;
            //txt_pea_lote.Habilitado = true;
            //txt_col_codigo.Habilitado = true;
            //cbo_bodega.Habilitado = true;
            txt_peso_neto_original.Habilitado = true;

            Modulo.Instance.EnfocarControl(cbo_stm_codigo);

            lyt_tab_detalle.Visibility = LayoutVisibility.Always;
            lyt_pesado_manual.Visibility = LayoutVisibility.Always;
            lyt_puerto.Visibility = LayoutVisibility.Always;
            lyt_peso_actual.Visibility = LayoutVisibility.Always;
            lyt_puerto_seleccionado.Visibility = LayoutVisibility.Always;

            //dgv_Reporte.Fn_LimpiarGrilla(false);
            //Modulo.Instance.EnfocarControl(txt_Control);
        }

        private void Nuevo()
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

            if (dgv_Detalle.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No ha ingresado ninguna etiqueta. Por favor, verifique.");
                return;
            }

            //Se verifica que no haya stock por reubicar:
            if (Parser.GetDecimal(txt_stock_por_reubicar.Text) > 0)
            {
                Dialog.MostrarMensajeAdvertencia("Existe stock que no ha sido ubicado. Por favor, verifique.");
                txt_stock_por_reubicar.Text = Parser.GetDecimal(txt_stock_por_reubicar.Text).ToString();
                txt_stock_por_reubicar.Focus();
                return;
            }

            if (Dialog.MostrarMensajePregunta("¿Está seguro de generar estas nuevas etiquetas?", Dialog.BotonPorDefecto.Si) != DialogResult.Yes)
                return;

            try
            {
                Fn_MostrarGrabando();

                DataTable dtBultos = (DataTable)dgv_Detalle.DataSource;
                DataView dv = new DataView(dtBultos);
                dtBultos = dv.ToTable(true, "nro", "tmo_codigo", "stm_codigo", "documento_referencia",
                    "referencia", "peso_neto", "peso_bruto", "peso_tara", "con_codigo", "identificador", "ubi_codigo", "residuo");

                object[] parameters = {
                    tar_codigo,
                    etiqueta,
                    dtBultos,
                    0,
                    0,
                    0,
                    PL_UsuarioE.PL_UsuarioCodigo,
                    ""
                };

                string[] resultado = new Principal().RegistrarReubicacion(parameters);

                if (resultado[0] == "0")
                {
                    Fn_OcultarCargando();

                    Dialog.MostrarMensajeConfirmacionOperacion();
                    bModificado = true;
                    Modulo.Instance.InicializarEstadoControles(this);

                    //Aquí se debe bloquear toda la pantalla y solo se debe abrir la impresion de etiquetas:
                    ImprimirEtiquetas(Parser.GetInt(resultado[1]), Parser.GetInt(resultado[2]), Parser.GetInt(resultado[3]));
                    //DialogResult = DialogResult.Yes;

                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    Dialog.MostrarMensajeError(resultado[4]);
                }

                //FALTA PROGRAMAR ESTE EVENTO: (SE DEBE ENVIAR LOS CODIGOS DE MOVIMIENTO:


                //Aquí se vuelve a inicializar:

                //PL_Limpiar();

                //DialogResult = DialogResult.Yes;

                //cbo_stm_codigo.ItemIndex = cbo_stm_codigo.Properties.GetDataSourceRowIndex("stm_codigo", sub_tipo_movimiento);
                //cbo_lpr_codigo.ItemIndex = cbo_lpr_codigo.Properties.GetDataSourceRowIndex("lpr_codigo", linea_produccion);
            }
            catch (Exception ex)
            {
                Fn_OcultarCargando();
                Dialog.MostrarMensajeError(ex.Message);
            }
        }

        private void Eliminar()
        {
            Dialog.MostrarMensajeOperacionNoPermitida();
        }

        private void Anular()
        {

        }

        private void Imprimir()
        {

        }

        #endregion

        #region Eventos
        private void chk_pesado_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pesado_manual.Checked)
            {
                txt_peso_actual.ModoLabel = false;
                txt_peso_actual.TabStop = true;
                Modulo.Instance.EnfocarControl(txt_peso_actual);
            }
            else
            {
                txt_peso_actual.ModoLabel = true;
                txt_peso_actual.TabStop = false;
            }
        }

        private void cbo_stm_codigo_EditValueChanged(object sender, EventArgs e)
        {
            CargarBodegas();
        }

        //private void txt_pea_lote_EditValueChanged(object sender, EventArgs e)
        //{
        //    txt_pmd_lote_abreviado.Text = txt_pea_lote.Text;
        //}

        private void SerialPortExt_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (SerialPortExt.BytesToRead >= 0)
            {
                string valory = "";

                //Método 1 para pesado de balanza (Modelo de balanza 1)
                try
                {
                    if (!chk_pesado_manual.Checked)
                    {
                        valory = SerialPortExt.ReadLine();
                        //txt_peso_actual.Text = valory.Replace("ST,NT,+", "").Replace("US,NT,+", "").Replace("kg", "").Replace("Kg", "").Replace("KG", "").Replace("wn", "").Replace("WN", "").Replace("+WN", "").Replace("+wn", "").ToString();
                        //txt_peso_actual.Text = Convert.ToDecimal(valory.Replace("ST,NT,+", "").Replace("US,NT,+", "").Replace("kg", "").Replace("Kg", "").Replace("KG", "").Replace("wn", "").Replace("WN", "").Replace("+WN", "").Replace("+wn", "").ToString()).ToString("N2");

                        //Para pruebas:
                        //txt_peso_actual.Text = valory.Replace("ST,NT,+", "").Replace("US,NT,+", "").Replace("kg", "").Replace("Kg", "").Replace("KG", "").Replace("wn", "").Replace("WN", "").Replace("+WN", "").Replace("+wn", "").Replace("WW", "").Replace("ww", "").Replace("k.g.", "").Replace("kg.", "").Replace("Kg.", "").Replace("KG.", "");
                        txt_peso_actual.Text = Convert.ToDecimal(valory.Replace("ST,NT,+", "").Replace("US,NT,+", "").Replace("kg", "").Replace("Kg", "").Replace("KG", "").Replace("wn", "").Replace("WN", "").Replace("+WN", "").Replace("+wn", "").Replace("WW", "").Replace("ww", "").Replace("k.g.", "").Replace("kg.", "").Replace("Kg.", "").Replace("KG.", "")).ToString("N2");
                    }
                }
                catch (Exception ex)
                {
                    string msj_error = ex.Message;
                    txt_peso_actual.Text = msj_error;
                    return;
                }

                ////Método 2 para pesado de balanza (Modelo de balanza 2)
                //string valorx = "";
                //int ini;
                //int fin;
                //try
                //{
                //    valorx = SerialPortExt.ReadExisting();
                //    //Se evalúa que lo obtenido tenga los caracteres "=" al principio y al final:
                //    ini = valorx.Trim().IndexOf("=", 0);
                //    fin = valorx.Trim().IndexOf("=", ini + 1);

                //    if (ini < fin)
                //    {
                //        txt_peso_actual.Text = Convert.ToDecimal(valorx.Substring(ini + 2, 6)).ToString("N2");
                //        return;
                //    }

                //}
                //catch (Exception ex)
                //{
                //    string msj_error2 = ex.Message;
                //    return;
                //}
            }
        }

        private void SerialPortExt_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            nPeso = "Error";
            txt_peso_actual.Text = nPeso;
        }

        private void btn_captura_peso_Click(object sender, EventArgs e)
        {
            Valida = true;
            if (!Modulo.Instance.ValidarControlesMasivo(this, true))
                return;

            //if (txt_pea_lote.Text.Length < 6)
            //{
            //    Dialog.MostrarMensajeAdvertencia("El lote ingresado tiene una longitud menor a 6 dígitos y no es válido. Por favor, verifique.");
            //    return;
            //}

            if (chk_pesado_manual.Checked)
            {
                if (Parser.GetDecimal(txt_peso_actual.Text) <= 0)
                {
                    Dialog.MostrarMensajeAdvertencia("Ingrese un peso válido");
                    txt_peso_actual.Focus();
                    return;
                }
            }
            else
            {
                if (Parser.GetDecimal(txt_peso_actual.Text) <= 0)
                {
                    Dialog.MostrarMensajeAdvertencia("No se ha detectado un peso válido. Por favor, verifique la balanza o habilite el pesado manual.");
                    return;
                }
                nPeso = txt_peso_actual.Text;
            }

            CapturarPeso();

        }

        private void tb_Detalle_Click_Eliminar(object sender, EventArgs e)
        {
            if (dgv_Detalle.Fn_ObtenerNumeroFilas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No existen etiquetas para eliminar. Por favor, verifique.");
                return;
            }

            if (dgv_Detalle.Fn_ObtenerNumeroFilasSeleccionadas() == 0)
            {
                Dialog.MostrarMensajeAdvertencia("No ha seleccionado ninguna etiqueta para eliminar. Por favor, verifique.");
                return;
            }

            if (HayResiduo())
            {
                //Se verifica que la etiqueta a eliminar sea un residuo:
                if (!Parser.GetBoolean(dgv_Detalle.Fn_ObtenerValorFilaSeleccionada("residuo")))
                {
                    Dialog.MostrarMensajeAdvertencia("No se puede eliminar ninguna etiqueta debido a que ya ha ingresado un residuo. Elimine el residuo y vuelva a intentarlo.");
                    return;
                }
            }

            for (int i = 0; i < dtMovimientoDetalle.Rows.Count; i++)
            {
                if (dgv_Detalle.Fn_ObtenerValorFila(i, "nro").ToString() == dgv_Detalle.Fn_ObtenerValorFilaSeleccionada("nro").ToString())
                {
                    dtMovimientoDetalle.Rows[i].Delete();
                    dtMovimientoDetalle.AcceptChanges();
                    break;
                }
            }

            //Reordenamiento de pesos:
            for (int i = 0; i < dtMovimientoDetalle.Rows.Count; i++)
                dtMovimientoDetalle.Rows[i]["nro"] = i + 1;

            //for (int i = 0; i < dtMovimientoDetalle.Rows.Count; i++)
            //    dtMovimientoDetalle.Rows[i]["nro"] = nro_fardo_disponible + i + 1;

            dgv_Detalle.DataSource = dtMovimientoDetalle;

            //Modulo.Instance.EnfocarControl(btn_captura_peso);

            CalcularTotalStock();
            SugerirPesoBultos();
        }

        private void cbo_lpr_codigo_EditValueChanged(object sender, EventArgs e)
        {
            //DataTable dtLineas = ((DataTable)cbo_lpr_codigo.Properties.DataSource).Copy();

            //foreach (DataRow dr in dtLineas.Rows)
            //{
            //    if (dr["lpr_codigo"].ToString() == cbo_lpr_codigo.EditValue.ToString())
            //    {
            //        nro_fardo_disponible = Parser.GetInt(dr["tar_contador"]);

            //        //Si tiene un contenedor por defecto, se lo asigna automaticamente
            //        if (Parser.GetInt(dr["con_codigo"]) > 0)
            //        {
            //            txt_con_codigo.Text = dr["con_codigo"].ToString();
            //            txt_con_codigo.Fn_EjecutarBusqueda();

            //            txt_con_codigo.Habilitado = false;
            //        }

            //        //Si la prensa es de devolucion
            //        if (dr["lpr_codigo"].ToString() == "4")
            //        {
            //            CalcularTaraPrensaDevolucion();
            //        }
            //        break;
            //    }
            //}
        }

        private void FrmAlmacenPesadoProductoProcesoIngreso_Click_Imprimir(object sender, EventArgs e)
        {
            //if (pes_codigo == 3)
            //{
            //    Dialog.MostrarMensajeAdvertencia("No puede imprimir las etiquetas de un pesado anulado.");
            //    return;
            //}

            //if (Dialog.MostrarMensajePregunta("¿Está seguro de imprimir todas las etiquetas de este pesado?", Dialog.BotonPorDefecto.Si) == DialogResult.Yes)
            //{
            //try
            //{
            //    //Fn_MostrarCargando("Imprimiendo etiquetas", "");
            //    ImprimirEtiquetas();
            //    //Fn_OcultarCargando();
            //}
            //catch (Exception ex)
            //{
            //    //Fn_OcultarCargando();
            //    Dialog.MostrarMensajeError(ex.Message);
            //}
            //}
        }

        private void txt_peso_actual_EditValueChanged(object sender, EventArgs e)
        {
            txt_peso_bruto.Text = Parser.GetDecimal(txt_peso_actual.Text).ToString("N2");

            //CalcularTaraPrensaDevolucion();
        }

        private void txt_peso_actual_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    btn_captura_peso.PerformClick();
            //    e.SuppressKeyPress = true;
            //}
        }

        private void Reubicar(bool residuo)
        {
            if (HayResiduo())
            {
                Dialog.MostrarMensajeAdvertencia("Ya ingresó un bulto de residuo. No puede ingresar más pesos. Por favor, verifique.");
                return;
            }

            //Se verifica que exista stock por reubicar
            if (Parser.GetDecimal(txt_stock_por_reubicar.Text) == 0 && !chk_habilitar_excedente_stock.Checked)
            {
                Dialog.MostrarMensajeAdvertencia("No existe stock por ubicar. Por favor, verifique o habilite el excedente de stock.");
                return;
            }

            //Se verifica que se haya seleccionado un ALMACEN:
            if (txt_ubi_codigo.Text.Trim().ToString() == "" || txt_ubi_descripcion.Text.Trim() == "")
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, seleccione una ubicación.");
                Modulo.Instance.EnfocarControl(txt_ubi_codigo);
                return;
            }

            //Se verifica el peso ingresado
            if (Parser.GetDecimal(txt_peso_neto.Text) <= 0)
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, ingrese un peso neto válido.");
                Modulo.Instance.EnfocarControl(txt_peso_bruto);
                return;
            }

            //Se verifica el peso ingresado
            if (Parser.GetDecimal(txt_peso_bruto.Text) <= 0)
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, ingrese un peso bruto válido");
                Modulo.Instance.EnfocarControl(txt_peso_bruto);
                return;
            }

            if (Parser.GetDecimal(txt_peso_bruto.Text) < Parser.GetDecimal(txt_peso_neto.Text))
            {
                Dialog.MostrarMensajeAdvertencia("El peso neto no debe ser mayor al peso bruto. Por favor, verifique.");
                Modulo.Instance.EnfocarControl(txt_peso_neto);
                return;
            }

            //Se valida que la cantidad a mover no sea mayor a la que se puede mover
            if (Parser.GetDecimal(txt_peso_neto.Text) > Parser.GetDecimal(txt_stock_por_reubicar.Text))
            {
                if (chk_habilitar_excedente_stock.Checked)
                {
                    decimal excedente = Parser.GetDecimal(txt_peso_neto.Text) - Parser.GetDecimal(txt_stock_por_reubicar.Text);
                    if (Dialog.MostrarMensajePregunta("Se detectó un excedente de " + excedente.ToString("N2") + " kg. netos " + ". Esto generará un nuevo documento de inventario PENDIENTE DE APLICAR en EXACTUS con esos kilos. ¿Está seguro de continuar con operación?", Dialog.BotonPorDefecto.Si) != DialogResult.Yes)
                    {
                        Modulo.Instance.EnfocarControl(txt_peso_neto);
                        return;
                    }
                }
                else
                {
                    Dialog.MostrarMensajeAdvertencia("La cantidad total a mover no puede ser mayor al total. Por favor, verifique. Stock por ubicar (" + txt_stock_por_reubicar.Text + ") o habilite el excedente de stock");
                    Modulo.Instance.EnfocarControl(txt_peso_neto);
                    return;
                }
            }

            //Se verifica que la ubicacion no exista previamente en el listado:
            //Si existe la ubicacion, la acumula:
            DataTable dtStockReubicado = ((DataTable)dgv_Detalle.DataSource).Copy();

            int nro_filas;
            nro_filas = dtStockReubicado.Rows.Count;

            dtStockReubicado.Rows.Add(
                nro_filas + 1,
                tmo_codigo,
                cbo_stm_codigo.EditValue.ToString(),
                cbo_stm_codigo.Text.ToString(),
                txt_documento_referencia.Text.Trim(),
                txt_referencia.Text,
                Parser.GetDecimal(txt_peso_neto.Text),
                Parser.GetDecimal(txt_peso_bruto.Text),
                (Parser.GetDecimal(txt_peso_bruto.Text) - Parser.GetDecimal(txt_peso_neto.Text)),
                lpr_codigo,
                identificador,
                txt_ubi_codigo.Text,
                txt_ubi_descripcion.Text,
                residuo
            );

            dgv_Detalle.DataSource = dtStockReubicado;

            CalcularTotalStock();

            //Se limpia la cantidad ingresada y la ubicacion seleccionada
            SugerirPesoBultos();

            dtMovimientoDetalle = (DataTable)dgv_Detalle.DataSource;

            Modulo.Instance.EnfocarControl(txt_peso_bruto);
        }

        private void btn_reubicar_Click(object sender, EventArgs e)
        {
            Reubicar(false);
        }

        #endregion

        #region Metodos

        private void ImprimirEtiquetas(int mov_anno, int mov_mes, int mov_codigo)
        {
            //Lanzar a imprimir las etiquetas automaticamente
            try
            {
                //Fn_MostrarCargando("Imprimiendo etiquetas", "");

                if (tar_codigo == 3) /*Producto en proceso*/
                {
                    using (FrmImpresionEtiqueta frm = new FrmImpresionEtiqueta())
                    {
                        object[] parameters = { PL_UsuarioE.PL_EmpresaCodigo, mov_anno, mov_mes, mov_codigo };
                        DataTable dtInformacion = new Principal().RetornaDetalleEtiquetasImpresionMovimiento(parameters);

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

                //Assembly lobj_AsmForm;
                //dynamic lobj_InsForm;
                //dynamic lobj_ObjForm;

                //string lstrRuta = PL_Ruta_Esamblados;

                //Impersonate.IniciarImpersonate();

                //lstrRuta = @"C:\Users\usuarioserviam\Desktop\Proyecto\Menu Aplicaciones\Menu\Filasur.Reporte\Filasur.Reporte\bin\Debug\";

                //byte[] bytes = File.ReadAllBytes(lstrRuta + "Filasur.Reporte.dll");
                //lobj_AsmForm = Assembly.Load(bytes);

                //lobj_InsForm = lobj_AsmForm.CreateInstance("Filasur.Reporte.Principal");
                //lobj_ObjForm = lobj_InsForm.Visualiza();
                //lobj_ObjForm.PL_Tipo_Impresion = "E";
                //lobj_ObjForm.PL_Ruta_Reportes = PL_Reporte_Repositorio;
                //lobj_ObjForm.PL_Ruta_Ensamblados = PL_Ruta_Esamblados;

                //if (tar_codigo == 3) //Producto en proceso
                //{
                //    if (tmo_codigo == 3) //Si es devolucion
                //    {
                //        lobj_ObjForm.PL_NombreReportePrincipal = "Rpt_AP_Bulto_ProductoProceso.rpt";
                //    }
                //    else //Si es ingreso
                //    {
                //        lobj_ObjForm.PL_NombreReportePrincipal = "Rpt_AP_Bulto_ProductoProceso.rpt";
                //    }
                //}

                ////object[] parameters = { PL_UsuarioE.PL_EmpresaCodigo, pea_anno, pea_mes, pea_codigo };
                ////lobj_ObjForm.PL_ReportePrincipalDataTable = new Principal().RetornaDetalleEtiquetas(parameters);

                //lobj_ObjForm.Show();
                //lobj_ObjForm.Close();

                //Impersonate.FinalizarImpersonate();

                //lobj_AsmForm = null;
                //lobj_InsForm = null;
                //lobj_ObjForm = null;
            }
            catch (Exception ex)
            {
                Fn_OcultarCargando();
                Dialog.MostrarMensajeError("No se pudieron imprimir las etiquetas." + ex.Message);
            }
        }

        private void CargarCombos()
        {
            object[] parameters1 = { 4 };
            cbo_stm_codigo.Fn_CargarCombobox(new Principal().RetornaSubTipoMovimiento(parameters1), "stm_codigo", "stm_descripcion", 0, UcCombobox.TipoDisplay.Seleccione);

            //object[] parameters2 = { tar_codigo, 0, tmo_codigo };
            //dtLineasProducion = new Principal().RetornaLineasProduccion(parameters2);
            //cbo_lpr_codigo.Fn_CargarCombobox(dtLineasProducion, "lpr_codigo", "lpr_descripcion", 0, UcCombobox.TipoDisplay.Seleccione);
        }

        private void CargarBodegas()
        {
            //object[] parameters3 = { tar_codigo, tmo_codigo, cbo_stm_codigo.EditValue };
            //cbo_bodega.Fn_CargarCombobox(new Principal().RetornaBodegas(parameters3), "bodega", "descripcion", 0, UcCombobox.TipoDisplay.Seleccione);
        }

        private void CapturarPeso()
        {
            //DataRow lobj_dr;
            decimal xPesoBruto;

            xPesoBruto = Convert.ToDecimal(txt_peso_actual.Text);

            if (ValidarDatos())
            {

                //int nro_filas;
                //nro_filas = dtMovimientoDetalle.Rows.Count;

                //lobj_dr = dtMovimientoDetalle.NewRow();
                //lobj_dr["pmd_item"] = nro_filas + 1;
                //lobj_dr["pmd_nro_pieza"] = 1;
                //lobj_dr["pmd_nro_pieza_original"] = 0;
                //lobj_dr["pmd_peso_crudo"] = 0;
                //lobj_dr["pmd_peso_bruto"] = xPesoBruto;
                //lobj_dr["pmd_peso_tara"] = Parser.GetDecimal(txt_con_tara.Text);
                //lobj_dr["pmd_peso_neto"] = (xPesoBruto - Parser.GetDecimal(txt_con_tara.Text));
                //lobj_dr["pmd_lote_abreviado"] = txt_pmd_lote_abreviado.Text;
                //lobj_dr["pmd_identificador"] = nro_fardo_disponible + nro_filas + 1;
                //lobj_dr["con_codigo"] = Parser.GetInt(txt_con_codigo.EditValue);

                //dtMovimientoDetalle.Rows.Add(lobj_dr);

                //dgv_Detalle.DataSource = dtMovimientoDetalle;
                //dgv_Detalle.Fn_SituarFocoEnUltimaFila();

                //Modulo.Instance.EnfocarControl(btn_captura_peso);

                //if (dgv_Detalle.Fn_ObtenerNumeroFilas() > 0)
                //{
                //    cbo_lpr_codigo.Habilitado = false;
                //    cbo_stm_codigo.Habilitado = false;
                //    txt_articulo.Habilitado = false;
                //    txt_pea_lote.Habilitado = false;
                //    txt_col_codigo.Habilitado = false;
                //    cbo_bodega.Habilitado = false;
                //    txt_op_tarjeta_tendida.Habilitado = false;
                //}

                ////Si el pesado es manual, se borra el peso y se posiciona nuevamente en el siguiente peso
                //if (chk_pesado_manual.Checked)
                //{
                //    txt_peso_actual.Text = "";
                //    Modulo.Instance.EnfocarControl(txt_peso_actual);
                //}
            }
        }

        private bool ValidarDatos()
        {
            //if (txt_con_codigo.EditValue.ToString().Trim() == "")
            //{
            //    /*Si se trata de producto en proceso y el movimiento es de devolucion*/
            //    /*Entonces no se valida el contenedor*/
            //    if (tar_codigo == 3 && tmo_codigo == 3)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        Dialog.MostrarMensajeAdvertencia("Seleccione un contenedor");
            //        Modulo.Instance.EnfocarControl(txt_con_codigo);
            //        return false;
            //    }
            //}

            return true;
        }

        private void CalcularTotalStock()
        {
            DataTable dtStockReubicado = (DataTable)dgv_Detalle.DataSource;

            if (dtStockReubicado is null)
            {
                txt_stock_reubicado.Text = "0.00";
                txt_stock_por_reubicar.Text = Parser.GetDecimal(txt_peso_neto_original.Text).ToString();
                txt_excedente.Text = "0.00";
            }
            else if (dtStockReubicado.Rows.Count == 0)
            {
                txt_stock_reubicado.Text = "0.00";
                txt_stock_por_reubicar.Text = Parser.GetDecimal(txt_peso_neto_original.Text).ToString();
                txt_excedente.Text = "0.00";
            }
            else
            {
                txt_stock_reubicado.Text = Convert.ToDecimal(dtStockReubicado.Compute("SUM(peso_neto)", "peso_neto > 0")).ToString("N2");

                txt_stock_por_reubicar.Text = (
                    Parser.GetDecimal(txt_peso_neto_original.Text) - Parser.GetDecimal(txt_stock_reubicado.Text) >= 0 ?
                    Parser.GetDecimal(txt_peso_neto_original.Text) - Parser.GetDecimal(txt_stock_reubicado.Text) : 0).ToString("N2");

                txt_excedente.Text = (
                    Parser.GetDecimal(txt_peso_neto_original.Text) - Parser.GetDecimal(txt_stock_reubicado.Text) < 0 ?
                    Math.Abs(Parser.GetDecimal(txt_peso_neto_original.Text) - Parser.GetDecimal(txt_stock_reubicado.Text)) : 0
                    ).ToString("N2");

            }
        }

        #endregion

        private void txt_peso_neto_EditValueChanged(object sender, EventArgs e)
        {
            //txt_peso_bruto.Text = txt_peso_neto.Text;
        }

        private void txt_peso_bruto_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_peso_bruto.Text == "")
            {
                txt_peso_neto.Text = "0.00";
            }
            else
            {
                txt_peso_neto.Text = (Parser.GetDecimal(txt_peso_bruto.Text) - Parser.GetDecimal(txt_tara.Text)).ToString("N2");
            }
        }

        private void txt_tara_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_peso_bruto.Text == "")
            {
                txt_peso_neto.Text = "0.00";
            }
            else
            {
                txt_peso_neto.Text = (Parser.GetDecimal(txt_peso_bruto.Text) - Parser.GetDecimal(txt_tara.Text)).ToString("N2");
            }
        }

        private void SugerirPesoBultos()
        {
            if (modo == 1)
            {
                txt_peso_neto.Text = Parser.GetDecimal(txt_stock_por_reubicar.Text).ToString("N2");
                txt_peso_bruto.Text = (Parser.GetDecimal(txt_stock_por_reubicar.Text) + Parser.GetDecimal(txt_tara.Text)).ToString("N2");
                //txt_tara.Text = "0.00"; //Se debe respetar la misma tara ingresada anteriormente
            }
        }

        private void btn_capturar_peso_Click(object sender, EventArgs e)
        {

        }

        private void btn_GenerarResiduo_Click(object sender, EventArgs e)
        {
            if (Parser.GetDecimal(txt_stock_por_reubicar.Text) <= 0)
            {
                Dialog.MostrarMensajeAdvertencia("Para generar un residuo, la cantidad pendiente de reubicar debe ser mayor a cero (0). Por favor, verifique.");
                Modulo.Instance.EnfocarControl(txt_peso_bruto);
                return;
            }

            if (Parser.GetDecimal(txt_excedente.Text) > 0)
            {
                Dialog.MostrarMensajeAdvertencia("Ya existe un excedente, no puede añadir un residuo. Por favor, verifique.");
                return;
            }

            if (Parser.GetDecimal(txt_peso_neto.Text) <= 0)
            {
                Dialog.MostrarMensajeAdvertencia("Por favor, ingrese un peso neto válido.");
                Modulo.Instance.EnfocarControl(txt_peso_bruto);
                return;
            }

            if (txt_ubi_codigo.Text == "" || txt_ubi_descripcion.Text == "")
            {
                Dialog.MostrarMensajeAdvertencia("No ha ingresado una ubicación de referencia. Por favor, verifique.");
                Modulo.Instance.EnfocarControl(txt_ubi_codigo);
                return;
            }

            decimal peso_residuo;
            peso_residuo = Parser.GetDecimal(txt_stock_por_reubicar.Text);

            if (Dialog.MostrarMensajePregunta("Se generará una etiqueta residuo con peso neto: " + peso_residuo.ToString("N2") + " ¿Está seguro de añadirlo?", Dialog.BotonPorDefecto.Si) != DialogResult.Yes)
                return;

            txt_peso_bruto.Text = (peso_residuo + Parser.GetDecimal(txt_tara.Text)).ToString();
            Reubicar(true);

            chk_habilitar_excedente_stock.Checked = false;
        }

        private void chk_habilitar_excedente_stock_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargando_cambio)
            {
                if (chk_habilitar_excedente_stock.Checked)
                {
                    //Se verifica si hay residuo. Si hay residuo no puede habilita el excedente
                    if (HayResiduo())
                    {
                        cargando_cambio = true;
                        chk_habilitar_excedente_stock.Checked = false;
                        cargando_cambio = false;
                        Dialog.MostrarMensajeAdvertencia("Ya tiene asociado un residuo, no puede habilitar un excedente. Por favor, verifique.");
                        return;
                    }

                    lyt_excedente.Visibility = LayoutVisibility.Always;
                    txt_excedente.Text = "0.00";
                }
                else
                {
                    //Se verifica que no haya excente:
                    //Si hay excedente, no permite deshabilitar la opción
                    if (Parser.GetDecimal(txt_excedente.Text) > 0)
                    {
                        cargando_cambio = true;
                        chk_habilitar_excedente_stock.Checked = true;
                        cargando_cambio = false;
                        Dialog.MostrarMensajeAdvertencia("No puedes deshabilitar esta función debido a que ya existe un excedente. Elimina la etiqueta excedente y vuelve a intentarlo.");
                        return;
                    }

                    lyt_excedente.Visibility = LayoutVisibility.Never;
                }
            }
        }

        private bool HayResiduo()
        {
            bool hay_residuo = false;

            if (dgv_Detalle.Fn_ObtenerNumeroFilas() > 0)
            {
                int nro_filas_residuo = Parser.GetInt(((DataTable)dgv_Detalle.DataSource).Compute("COUNT(residuo)", "residuo = true").ToString());
                if (nro_filas_residuo > 0)
                    hay_residuo = true;
            }

            return hay_residuo;
        }

        private void chk_habilitar_excedente_stock_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }
    }
}