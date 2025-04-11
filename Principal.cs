using Entidades;
using IntegralAPI;
using Negocio;
using System.Data;

namespace AlmacenControlStock
{
    public class Principal : BasePrincipal
    {
        public override object Visualiza()
        {
            FrmAlmacenControlStock frm = new FrmAlmacenControlStock();
            return frm;
        }

        public string[] RegistrarUbicacionIngresoPendiente(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaArreglo("Alm_Pesado_Movimiento_Pendiente_Regularizacion_Pa_Ins", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public string[] RegistrarReubicacion(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaArreglo("Alm_Pesado_Movimiento_Reubicacion_Bulto_Pa_Ins", AppKey.BD_KEY_ALMACEN, parameters);
        }
        //REUBICACION POR BLOQUE DE ETIQUETAS
        public string[] RegistrarReubicacionEtiquetasBloque(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaArreglo("Alm_Reubicacion_Etiquetas_Bloque", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaTipoArticulo(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Tipo_Articulo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable VerificarReversionMovimientoIngreso(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Movimiento_Revertir_Verificar_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable VerificarUbicacionMovimientoIngreso(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Movimiento_Pendiente_Verificar_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaTipoMovimiento(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Tipo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaSubTipoMovimiento(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_SubTipo_Todo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaModulos()
        {
            DataTable dtModulos = new DataTable();
            dtModulos.Columns.Add("bpu_codigo", typeof(string));
            dtModulos.Columns.Add("bpu_descripcion", typeof(string));

            dtModulos.Rows.Add("P", "Producción");
            dtModulos.Rows.Add("A", "Almacén");
            dtModulos.Rows.Add("C", "Compras");
            
            return dtModulos;
        }

        public DataTable RetornaRegularizacionIngresos(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Movimiento_Pendiente_Regularizar_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaDetalleEtiquetasReversion(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Movimiento_Reversion_Detalle_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaAyudaUbicaciones(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Ubicacion_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaAyudaUbicacionesReub()
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Ubicacion_Pa_Bus_Reub", AppKey.BD_KEY_ALMACEN);
        }

        public DataTable RetornaNiveles()
        {
            DataTable dtNiveles = new DataTable();
            dtNiveles.Columns.Add("codigo", typeof(string));
            dtNiveles.Columns.Add("descripcion", typeof(string));

            dtNiveles.Rows.Add("1", "Lote");
            dtNiveles.Rows.Add("2", "Etiqueta");

            return dtNiveles;
        }

        public DataTable RetornaExistenciaArticulos(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Existencia_Articulo_Lote_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaUbicaciones(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Ubicacion_Tipo_Articulo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable[] RetornaDetalleStockLote(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaTablas("Alm_Existencia_Articulo_Lote_Detalle_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaDetalleEtiquetasImpresion(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Existencia_Articulo_Lote_Detalle_Etiqueta_Impresion_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaDetalleEtiquetasImpresionMovimiento(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Movimiento_Almacen_Detalle_Etiqueta_Impresion_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }

        public DataTable RetornaBusquedaArticulos(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Articulo_Pa_Ayu", AppKey.BD_KEY_ALMACEN, parameters);
        }

        // REUBICACIÓN MASIVA DE ETIQUETAS
        public DataTable RetornaBusquedaArticulosReubicacion()
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Articulo_Pa_Reub", AppKey.BD_KEY_ALMACEN);
        }
        public DataTable RetornaBusquedaEtiquetasReubicacion(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Etiquetas_Disponibles_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }
        //public DataTable[] RetornaPesadoPrincipal(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaTablas("Alm_Pesado_Movimiento_Envio_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable[] RetornaPesadoDetalle(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaTablas("Alm_Pesado_Movimiento_Detalle_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        public DataTable RetornaBusquedaArticulos()
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Articulo_Pa_Reub", AppKey.BD_KEY_ALMACEN);
        }

        //public DataTable RetornaTipoMovimiento(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Tipo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable RetornaEstado(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Estado_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable RetornaLineasProduccion(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Linea_Produccion_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        public DataTable RetornaBusquedaBodegas(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Bodega_Tipo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        }
        // Interface reubicar etiquetas por bloque
        public DataTable RetornaBusquedaBodegasReub()
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Bodega_Tipo_Pa_Reub", AppKey.BD_KEY_ALMACEN);
        }

        public string[] RegistrarReversionIngresoPendiente(object[] parameters)
        {
            using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
                return sqlDinamicoN.pl_RetornaArreglo("Alm_Pesado_Movimiento_Pendiente_Revertir_Pa_Ins", AppKey.BD_KEY_ALMACEN, parameters);
        }

        //public DataTable RetornaSubTipoMovimiento(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_SubTipo_Pa_Bus", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable RetornaBusquedaArticulos(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Articulo_Pa_Ayu", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable RetornaBusquedaContenedores(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Contenedor_Pa_Ayu", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable RetornaBusquedaColores(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaRegistros("Alm_Pesado_Color_Pa_Ayu", AppKey.BD_KEY_ALMACEN, parameters);
        //}

        //public DataTable[] RetornaTablas(object[] parameters)
        //{
        //    using (SqlDinamicoN sqlDinamicoN = new SqlDinamicoN())
        //        return sqlDinamicoN.pl_RetornaTablas("NombreSP", AppKey.BD_KEY_DEV, parameters);
        //}
    }
}