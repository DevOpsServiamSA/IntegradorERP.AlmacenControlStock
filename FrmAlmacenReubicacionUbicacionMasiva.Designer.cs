
namespace AlmacenControlStock
{
    partial class FrmAlmacenReubicacionUbicacionMasiva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ucBusqueda.Global.Columna columna1 = new ucBusqueda.Global.Columna();
            ucBusqueda.Global.Columna columna2 = new ucBusqueda.Global.Columna();
            ucBusqueda.Global.EstadoControl estadoControl10 = new ucBusqueda.Global.EstadoControl();
            ucBusqueda.Global.EstadoControl estadoControl11 = new ucBusqueda.Global.EstadoControl();
            ucBusqueda.Global.EstadoControl estadoControl12 = new ucBusqueda.Global.EstadoControl();
            ucBusqueda.Global.ParametroBusqueda parametroBusqueda1 = new ucBusqueda.Global.ParametroBusqueda();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlmacenReubicacionUbicacionMasiva));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            ucTextBox.Global.EstadoControl estadoControl4 = new ucTextBox.Global.EstadoControl();
            ucTextBox.Global.EstadoControl estadoControl5 = new ucTextBox.Global.EstadoControl();
            ucTextBox.Global.EstadoControl estadoControl6 = new ucTextBox.Global.EstadoControl();
            ucDataGridView.Clases.Global.EstadoControl estadoControl7 = new ucDataGridView.Clases.Global.EstadoControl();
            ucDataGridView.Clases.Global.EstadoControl estadoControl8 = new ucDataGridView.Clases.Global.EstadoControl();
            ucDataGridView.Clases.Global.EstadoControl estadoControl9 = new ucDataGridView.Clases.Global.EstadoControl();
            this.txt_ubi_codigo = new UcBusqueda();
            this.txt_ubi_descripcion = new UcTextBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dgv_BultosSeleccionados = new UcDataGridView();
            this.grv_BultosSeleccionados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.articulo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nro_etiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombre_exactus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pmd_peso_neto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnl_Principal = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ubi_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ubi_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BultosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_BultosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Principal)).BeginInit();
            this.pnl_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ubi_codigo
            // 
            columna1.Caption = "Código";
            columna1.Control = this.txt_ubi_codigo;
            columna1.DataField = "ubi_codigo";
            columna1.OrdenFiltro = 1;
            columna2.Caption = "Descripción";
            columna2.Control = this.txt_ubi_descripcion;
            columna2.DataField = "ubi_descripcion";
            columna2.OrdenFiltro = 2;
            this.txt_ubi_codigo.Columnas = new ucBusqueda.Global.Columna[] {
        columna1,
        columna2};
            this.txt_ubi_codigo.EnterMoveNextControl = true;
            this.txt_ubi_codigo.Entidad = "Ubicaciones";
            this.txt_ubi_codigo.EstadoBuscar = estadoControl10;
            this.txt_ubi_codigo.EstadoEdicion = estadoControl11;
            this.txt_ubi_codigo.EstadoNuevo = estadoControl12;
            this.txt_ubi_codigo.Key = "ubi_codigo";
            this.txt_ubi_codigo.Location = new System.Drawing.Point(72, 7);
            this.txt_ubi_codigo.MensajeDatoObligatorio = "Seleccione una ubicación";
            this.txt_ubi_codigo.MetodoBusqueda = "RetornaAyudaUbicaciones";
            this.txt_ubi_codigo.Name = "txt_ubi_codigo";
            parametroBusqueda1.NombreParametro = "tar_codigo";
            parametroBusqueda1.TipoDato = ucBusqueda.Global.TipoDato.Cadena;
            parametroBusqueda1.TipoParametro = ucBusqueda.Global.TipoParametro.Variable;
            parametroBusqueda1.ValorConstante = null;
            this.txt_ubi_codigo.ParametrosDeBusqueda = new ucBusqueda.Global.ParametroBusqueda[] {
        parametroBusqueda1};
            this.txt_ubi_codigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_ubi_codigo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_ubi_codigo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txt_ubi_codigo.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txt_ubi_codigo.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.txt_ubi_codigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txt_ubi_codigo.Size = new System.Drawing.Size(83, 20);
            this.txt_ubi_codigo.StyleController = this.layoutControl1;
            this.txt_ubi_codigo.TabIndex = 0;
            // 
            // txt_ubi_descripcion
            // 
            this.txt_ubi_descripcion.ControlBusquedaFocus = this.txt_ubi_codigo;
            this.txt_ubi_descripcion.EnterMoveNextControl = true;
            this.txt_ubi_descripcion.EstadoBuscar = estadoControl4;
            this.txt_ubi_descripcion.EstadoEdicion = estadoControl5;
            this.txt_ubi_descripcion.EstadoNuevo = estadoControl6;
            this.txt_ubi_descripcion.Location = new System.Drawing.Point(159, 7);
            this.txt_ubi_descripcion.MensajeDatoObligatorio = "Seleccione una ubicación";
            this.txt_ubi_descripcion.Modificado = true;
            this.txt_ubi_descripcion.ModoLabel = true;
            this.txt_ubi_descripcion.Name = "txt_ubi_descripcion";
            this.txt_ubi_descripcion.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_ubi_descripcion.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_ubi_descripcion.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txt_ubi_descripcion.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txt_ubi_descripcion.Properties.ReadOnly = true;
            this.txt_ubi_descripcion.Size = new System.Drawing.Size(178, 20);
            this.txt_ubi_descripcion.StyleController = this.layoutControl1;
            this.txt_ubi_descripcion.TabIndex = 12;
            this.txt_ubi_descripcion.TabStop = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.dgv_BultosSeleccionados);
            this.layoutControl1.Controls.Add(this.txt_ubi_descripcion);
            this.layoutControl1.Controls.Add(this.txt_ubi_codigo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(794, 414);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dgv_BultosSeleccionados
            // 
            this.dgv_BultosSeleccionados.AparienciaDeSeleccion = UcDataGridView.AparienciaSeleccion.SinApariencia;
            this.dgv_BultosSeleccionados.CampoSQL = "";
            this.dgv_BultosSeleccionados.EstadoBuscar = estadoControl7;
            this.dgv_BultosSeleccionados.EstadoEdicion = estadoControl8;
            this.dgv_BultosSeleccionados.EstadoNuevo = estadoControl9;
            this.dgv_BultosSeleccionados.HabilitarFooter = true;
            this.dgv_BultosSeleccionados.Location = new System.Drawing.Point(13, 58);
            this.dgv_BultosSeleccionados.MainView = this.grv_BultosSeleccionados;
            this.dgv_BultosSeleccionados.MostrarPanelAgrupacion = false;
            this.dgv_BultosSeleccionados.Name = "dgv_BultosSeleccionados";
            this.dgv_BultosSeleccionados.Size = new System.Drawing.Size(768, 343);
            this.dgv_BultosSeleccionados.TabIndex = 13;
            this.dgv_BultosSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_BultosSeleccionados});
            // 
            // grv_BultosSeleccionados
            // 
            this.grv_BultosSeleccionados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.articulo,
            this.articulo_descripcion,
            this.nro_etiqueta,
            this.lote,
            this.col_nombre_exactus,
            this.pmd_peso_neto});
            this.grv_BultosSeleccionados.GridControl = this.dgv_BultosSeleccionados;
            this.grv_BultosSeleccionados.Name = "grv_BultosSeleccionados";
            this.grv_BultosSeleccionados.OptionsBehavior.Editable = false;
            this.grv_BultosSeleccionados.OptionsMenu.ShowFooterItem = true;
            this.grv_BultosSeleccionados.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grv_BultosSeleccionados.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grv_BultosSeleccionados.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grv_BultosSeleccionados.OptionsSelection.EnableAppearanceHideSelection = false;
            this.grv_BultosSeleccionados.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grv_BultosSeleccionados.OptionsView.ShowFooter = true;
            this.grv_BultosSeleccionados.OptionsView.ShowGroupPanel = false;
            // 
            // articulo
            // 
            this.articulo.Caption = "Código";
            this.articulo.FieldName = "articulo";
            this.articulo.Name = "articulo";
            this.articulo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "articulo", "Nro. {0}")});
            this.articulo.Visible = true;
            this.articulo.VisibleIndex = 0;
            // 
            // articulo_descripcion
            // 
            this.articulo_descripcion.Caption = "Descripción";
            this.articulo_descripcion.FieldName = "articulo_descripcion";
            this.articulo_descripcion.Name = "articulo_descripcion";
            this.articulo_descripcion.Visible = true;
            this.articulo_descripcion.VisibleIndex = 1;
            // 
            // nro_etiqueta
            // 
            this.nro_etiqueta.Caption = "Nro. etiqueta";
            this.nro_etiqueta.FieldName = "nro_etiqueta";
            this.nro_etiqueta.Name = "nro_etiqueta";
            this.nro_etiqueta.Visible = true;
            this.nro_etiqueta.VisibleIndex = 2;
            // 
            // lote
            // 
            this.lote.Caption = "Lote";
            this.lote.FieldName = "lote";
            this.lote.Name = "lote";
            this.lote.Visible = true;
            this.lote.VisibleIndex = 3;
            // 
            // col_nombre_exactus
            // 
            this.col_nombre_exactus.Caption = "Color";
            this.col_nombre_exactus.FieldName = "col_nombre_exactus";
            this.col_nombre_exactus.Name = "col_nombre_exactus";
            this.col_nombre_exactus.Visible = true;
            this.col_nombre_exactus.VisibleIndex = 4;
            // 
            // pmd_peso_neto
            // 
            this.pmd_peso_neto.Caption = "Peso neto";
            this.pmd_peso_neto.FieldName = "pmd_peso_neto";
            this.pmd_peso_neto.Name = "pmd_peso_neto";
            this.pmd_peso_neto.Visible = true;
            this.pmd_peso_neto.VisibleIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(794, 414);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_ubi_codigo;
            this.layoutControlItem8.CustomizationFormText = "Ubicación";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(152, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(152, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(152, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "Ubicación";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_ubi_descripcion;
            this.layoutControlItem3.Location = new System.Drawing.Point(152, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(182, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(182, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(182, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(334, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(450, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 380);
            this.layoutControlGroup1.Text = "Etiquetas seleccionadas";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv_BultosSeleccionados;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(772, 347);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Controls.Add(this.layoutControl1);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 25);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(798, 418);
            this.pnl_Principal.TabIndex = 2;
            // 
            // FrmAlmacenReubicacionUbicacionMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.botonGrabar.Texto = "Guardar cambios";
            this.botonGrabar.Visible = true;
            this.botonReporte.EnableModoBuscar = false;
            this.botonReporte.EnableModoNuevo = false;
            this.ClientSize = new System.Drawing.Size(798, 443);
            this.Controls.Add(this.pnl_Principal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlmacenReubicacionUbicacionMasiva";
            this.Text = "Asignación de ubicación";
            this.Activated += new System.EventHandler(this.Frm_Activated);
            this.Deactivate += new System.EventHandler(this.Frm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Controls.SetChildIndex(this.pnl_Principal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ubi_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ubi_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BultosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_BultosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Principal)).EndInit();
            this.pnl_Principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl_Principal;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UcTextBox txt_ubi_descripcion;
        private UcBusqueda txt_ubi_codigo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private UcDataGridView dgv_BultosSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_BultosSeleccionados;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn articulo;
        private DevExpress.XtraGrid.Columns.GridColumn articulo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn nro_etiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn pmd_peso_neto;
        private DevExpress.XtraGrid.Columns.GridColumn lote;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre_exactus;
    }
}