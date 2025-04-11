
namespace AlmacenControlStock
{
    partial class FrmAlmacenRevertirIngreso
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
            ucTextBox.Global.EstadoControl estadoControl1 = new ucTextBox.Global.EstadoControl();
            ucTextBox.Global.EstadoControl estadoControl2 = new ucTextBox.Global.EstadoControl();
            ucTextBox.Global.EstadoControl estadoControl3 = new ucTextBox.Global.EstadoControl();
            ucDataGridView.Clases.Global.EstadoControl estadoControl4 = new ucDataGridView.Clases.Global.EstadoControl();
            ucDataGridView.Clases.Global.EstadoControl estadoControl5 = new ucDataGridView.Clases.Global.EstadoControl();
            ucDataGridView.Clases.Global.EstadoControl estadoControl6 = new ucDataGridView.Clases.Global.EstadoControl();
            this.pnl_Principal = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_documento_inventario = new UcTextBox();
            this.dgv_Pesado = new UcDataGridView();
            this.grv_Pesado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bpu_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.articulo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nombre_exactus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pmd_peso_neto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pmd_nro_pieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pmd_peso_bruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pmd_peso_tara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pea_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lote_crudo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pea_produccion_nro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pea_nro_control = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pea_referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tar_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pea_documento_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pea_fecha_documento_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tmo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tmo_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tar_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nro_etiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.b = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MIC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NFRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_ubicacion = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Principal)).BeginInit();
            this.pnl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_documento_inventario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pesado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Pesado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Controls.Add(this.layoutControl1);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 25);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(974, 443);
            this.pnl_Principal.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.txt_documento_inventario);
            this.layoutControl1.Controls.Add(this.dgv_Pesado);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(790, 264, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(970, 439);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_documento_inventario
            // 
            this.txt_documento_inventario.EnterMoveNextControl = true;
            this.txt_documento_inventario.EstadoBuscar = estadoControl1;
            this.txt_documento_inventario.EstadoEdicion = estadoControl2;
            this.txt_documento_inventario.EstadoNuevo = estadoControl3;
            this.txt_documento_inventario.Location = new System.Drawing.Point(187, 7);
            this.txt_documento_inventario.Modificado = true;
            this.txt_documento_inventario.ModoLabel = true;
            this.txt_documento_inventario.Name = "txt_documento_inventario";
            this.txt_documento_inventario.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.txt_documento_inventario.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_documento_inventario.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txt_documento_inventario.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.txt_documento_inventario.Properties.ReadOnly = true;
            this.txt_documento_inventario.Size = new System.Drawing.Size(146, 20);
            this.txt_documento_inventario.StyleController = this.layoutControl1;
            this.txt_documento_inventario.TabIndex = 5;
            this.txt_documento_inventario.TabStop = false;
            // 
            // dgv_Pesado
            // 
            this.dgv_Pesado.AparienciaDeSeleccion = UcDataGridView.AparienciaSeleccion.Fila;
            this.dgv_Pesado.CampoSQL = "";
            this.dgv_Pesado.EstadoBuscar = estadoControl4;
            this.dgv_Pesado.EstadoEdicion = estadoControl5;
            this.dgv_Pesado.EstadoNuevo = estadoControl6;
            this.dgv_Pesado.HabilitarFooter = true;
            this.dgv_Pesado.Location = new System.Drawing.Point(7, 31);
            this.dgv_Pesado.MainView = this.grv_Pesado;
            this.dgv_Pesado.MostrarPanelAgrupacion = false;
            this.dgv_Pesado.Name = "dgv_Pesado";
            this.dgv_Pesado.NombreGrilla = "Pesados pendientes de enviar a Almacén";
            this.dgv_Pesado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbo_ubicacion});
            this.dgv_Pesado.Size = new System.Drawing.Size(956, 401);
            this.dgv_Pesado.TabIndex = 4;
            this.dgv_Pesado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Pesado});
            // 
            // grv_Pesado
            // 
            this.grv_Pesado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bpu_codigo,
            this.articulo,
            this.articulo_descripcion,
            this.lote,
            this.col_nombre_exactus,
            this.pmd_peso_neto,
            this.pmd_nro_pieza,
            this.pmd_peso_bruto,
            this.pmd_peso_tara,
            this.pea_fecha,
            this.lote_crudo,
            this.pea_produccion_nro,
            this.pea_nro_control,
            this.pea_referencia,
            this.tar_descripcion,
            this.pea_documento_inv,
            this.pea_fecha_documento_inv,
            this.tmo_descripcion,
            this.stm_descripcion,
            this.tmo_codigo,
            this.tar_codigo,
            this.nro_etiqueta,
            this.b,
            this.CAT,
            this.GPT,
            this.GR,
            this.LEN,
            this.LF,
            this.MIC,
            this.NFRD,
            this.NING,
            this.RD,
            this.ST,
            this.UNIF});
            this.grv_Pesado.GridControl = this.dgv_Pesado;
            this.grv_Pesado.Name = "grv_Pesado";
            this.grv_Pesado.OptionsBehavior.Editable = false;
            this.grv_Pesado.OptionsMenu.ShowFooterItem = true;
            this.grv_Pesado.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grv_Pesado.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grv_Pesado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grv_Pesado.OptionsSelection.MultiSelect = true;
            this.grv_Pesado.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grv_Pesado.OptionsView.ShowFooter = true;
            this.grv_Pesado.OptionsView.ShowGroupPanel = false;
            // 
            // bpu_codigo
            // 
            this.bpu_codigo.Caption = "bpu_codigo";
            this.bpu_codigo.FieldName = "bpu_codigo";
            this.bpu_codigo.Name = "bpu_codigo";
            this.bpu_codigo.OptionsColumn.ShowInCustomizationForm = false;
            this.bpu_codigo.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // articulo
            // 
            this.articulo.Caption = "Artículo";
            this.articulo.FieldName = "articulo";
            this.articulo.Name = "articulo";
            this.articulo.OptionsColumn.ReadOnly = true;
            this.articulo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "articulo", "Nro. {0}")});
            this.articulo.Visible = true;
            this.articulo.VisibleIndex = 0;
            // 
            // articulo_descripcion
            // 
            this.articulo_descripcion.Caption = "Descripción del artículo";
            this.articulo_descripcion.FieldName = "articulo_descripcion";
            this.articulo_descripcion.Name = "articulo_descripcion";
            this.articulo_descripcion.OptionsColumn.ReadOnly = true;
            this.articulo_descripcion.Visible = true;
            this.articulo_descripcion.VisibleIndex = 1;
            // 
            // lote
            // 
            this.lote.Caption = "Lote";
            this.lote.FieldName = "lote";
            this.lote.Name = "lote";
            this.lote.OptionsColumn.ReadOnly = true;
            this.lote.Visible = true;
            this.lote.VisibleIndex = 2;
            // 
            // col_nombre_exactus
            // 
            this.col_nombre_exactus.Caption = "Color";
            this.col_nombre_exactus.FieldName = "col_nombre_exactus";
            this.col_nombre_exactus.Name = "col_nombre_exactus";
            this.col_nombre_exactus.OptionsColumn.ReadOnly = true;
            this.col_nombre_exactus.Visible = true;
            this.col_nombre_exactus.VisibleIndex = 3;
            // 
            // pmd_peso_neto
            // 
            this.pmd_peso_neto.Caption = "Peso neto";
            this.pmd_peso_neto.FieldName = "pmd_peso_neto";
            this.pmd_peso_neto.Name = "pmd_peso_neto";
            this.pmd_peso_neto.OptionsColumn.ReadOnly = true;
            this.pmd_peso_neto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pmd_peso_neto", "{0:n2}")});
            this.pmd_peso_neto.Visible = true;
            this.pmd_peso_neto.VisibleIndex = 4;
            // 
            // pmd_nro_pieza
            // 
            this.pmd_nro_pieza.Caption = "Nro. bulto";
            this.pmd_nro_pieza.FieldName = "pmd_nro_pieza";
            this.pmd_nro_pieza.Name = "pmd_nro_pieza";
            this.pmd_nro_pieza.OptionsColumn.ReadOnly = true;
            this.pmd_nro_pieza.Visible = true;
            this.pmd_nro_pieza.VisibleIndex = 5;
            // 
            // pmd_peso_bruto
            // 
            this.pmd_peso_bruto.Caption = "Peso bruto";
            this.pmd_peso_bruto.FieldName = "pmd_peso_bruto";
            this.pmd_peso_bruto.Name = "pmd_peso_bruto";
            this.pmd_peso_bruto.OptionsColumn.ReadOnly = true;
            this.pmd_peso_bruto.Visible = true;
            this.pmd_peso_bruto.VisibleIndex = 6;
            // 
            // pmd_peso_tara
            // 
            this.pmd_peso_tara.Caption = "Tara";
            this.pmd_peso_tara.FieldName = "pmd_peso_tara";
            this.pmd_peso_tara.Name = "pmd_peso_tara";
            this.pmd_peso_tara.OptionsColumn.ReadOnly = true;
            this.pmd_peso_tara.Visible = true;
            this.pmd_peso_tara.VisibleIndex = 7;
            // 
            // pea_fecha
            // 
            this.pea_fecha.Caption = "Fecha";
            this.pea_fecha.FieldName = "pea_fecha";
            this.pea_fecha.Name = "pea_fecha";
            this.pea_fecha.OptionsColumn.ReadOnly = true;
            this.pea_fecha.Visible = true;
            this.pea_fecha.VisibleIndex = 8;
            // 
            // lote_crudo
            // 
            this.lote_crudo.Caption = "Lote crudo";
            this.lote_crudo.FieldName = "lote_crudo";
            this.lote_crudo.Name = "lote_crudo";
            this.lote_crudo.OptionsColumn.ReadOnly = true;
            this.lote_crudo.Visible = true;
            this.lote_crudo.VisibleIndex = 9;
            // 
            // pea_produccion_nro
            // 
            this.pea_produccion_nro.Caption = "Nro. producción";
            this.pea_produccion_nro.FieldName = "pea_produccion_nro";
            this.pea_produccion_nro.Name = "pea_produccion_nro";
            this.pea_produccion_nro.OptionsColumn.ReadOnly = true;
            this.pea_produccion_nro.Visible = true;
            this.pea_produccion_nro.VisibleIndex = 10;
            // 
            // pea_nro_control
            // 
            this.pea_nro_control.Caption = "Nro. control";
            this.pea_nro_control.FieldName = "pea_nro_control";
            this.pea_nro_control.Name = "pea_nro_control";
            this.pea_nro_control.OptionsColumn.ReadOnly = true;
            this.pea_nro_control.Visible = true;
            this.pea_nro_control.VisibleIndex = 11;
            // 
            // pea_referencia
            // 
            this.pea_referencia.Caption = "Referencia";
            this.pea_referencia.FieldName = "pea_referencia";
            this.pea_referencia.Name = "pea_referencia";
            this.pea_referencia.OptionsColumn.ReadOnly = true;
            this.pea_referencia.Visible = true;
            this.pea_referencia.VisibleIndex = 12;
            // 
            // tar_descripcion
            // 
            this.tar_descripcion.Caption = "Tipo";
            this.tar_descripcion.FieldName = "tar_descripcion";
            this.tar_descripcion.Name = "tar_descripcion";
            this.tar_descripcion.OptionsColumn.ReadOnly = true;
            this.tar_descripcion.Visible = true;
            this.tar_descripcion.VisibleIndex = 13;
            // 
            // pea_documento_inv
            // 
            this.pea_documento_inv.Caption = "Documento inv.";
            this.pea_documento_inv.FieldName = "pea_documento_inv";
            this.pea_documento_inv.Name = "pea_documento_inv";
            this.pea_documento_inv.OptionsColumn.ReadOnly = true;
            this.pea_documento_inv.Visible = true;
            this.pea_documento_inv.VisibleIndex = 14;
            // 
            // pea_fecha_documento_inv
            // 
            this.pea_fecha_documento_inv.Caption = "Fecha doc. inv.";
            this.pea_fecha_documento_inv.FieldName = "pea_fecha_documento_inv";
            this.pea_fecha_documento_inv.Name = "pea_fecha_documento_inv";
            this.pea_fecha_documento_inv.OptionsColumn.ReadOnly = true;
            this.pea_fecha_documento_inv.Visible = true;
            this.pea_fecha_documento_inv.VisibleIndex = 15;
            // 
            // tmo_descripcion
            // 
            this.tmo_descripcion.Caption = "Movimiento";
            this.tmo_descripcion.FieldName = "tmo_descripcion";
            this.tmo_descripcion.Name = "tmo_descripcion";
            this.tmo_descripcion.OptionsColumn.ReadOnly = true;
            this.tmo_descripcion.Visible = true;
            this.tmo_descripcion.VisibleIndex = 16;
            // 
            // stm_descripcion
            // 
            this.stm_descripcion.Caption = "Subtipo movimiento";
            this.stm_descripcion.FieldName = "stm_descripcion";
            this.stm_descripcion.Name = "stm_descripcion";
            this.stm_descripcion.OptionsColumn.ReadOnly = true;
            this.stm_descripcion.Visible = true;
            this.stm_descripcion.VisibleIndex = 17;
            // 
            // tmo_codigo
            // 
            this.tmo_codigo.Caption = "tmo_codigo";
            this.tmo_codigo.FieldName = "tmo_codigo";
            this.tmo_codigo.Name = "tmo_codigo";
            this.tmo_codigo.OptionsColumn.ReadOnly = true;
            this.tmo_codigo.OptionsColumn.ShowInCustomizationForm = false;
            this.tmo_codigo.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // tar_codigo
            // 
            this.tar_codigo.Caption = "tar_codigo";
            this.tar_codigo.FieldName = "tar_codigo";
            this.tar_codigo.Name = "tar_codigo";
            this.tar_codigo.OptionsColumn.ReadOnly = true;
            this.tar_codigo.OptionsColumn.ShowInCustomizationForm = false;
            this.tar_codigo.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // nro_etiqueta
            // 
            this.nro_etiqueta.Caption = "Nro. etiqueta";
            this.nro_etiqueta.FieldName = "nro_etiqueta";
            this.nro_etiqueta.Name = "nro_etiqueta";
            this.nro_etiqueta.OptionsColumn.ReadOnly = true;
            this.nro_etiqueta.Visible = true;
            this.nro_etiqueta.VisibleIndex = 18;
            // 
            // b
            // 
            this.b.Caption = "b+";
            this.b.FieldName = "b";
            this.b.Name = "b";
            this.b.Visible = true;
            this.b.VisibleIndex = 19;
            // 
            // CAT
            // 
            this.CAT.Caption = "CAT";
            this.CAT.FieldName = "CAT";
            this.CAT.Name = "CAT";
            this.CAT.Visible = true;
            this.CAT.VisibleIndex = 20;
            // 
            // GPT
            // 
            this.GPT.Caption = "GPT";
            this.GPT.FieldName = "GPT";
            this.GPT.Name = "GPT";
            this.GPT.Visible = true;
            this.GPT.VisibleIndex = 21;
            // 
            // GR
            // 
            this.GR.Caption = "GR";
            this.GR.FieldName = "GR";
            this.GR.Name = "GR";
            this.GR.Visible = true;
            this.GR.VisibleIndex = 22;
            // 
            // LEN
            // 
            this.LEN.Caption = "LEN";
            this.LEN.FieldName = "LEN";
            this.LEN.Name = "LEN";
            this.LEN.Visible = true;
            this.LEN.VisibleIndex = 23;
            // 
            // LF
            // 
            this.LF.Caption = "LF";
            this.LF.FieldName = "LF";
            this.LF.Name = "LF";
            this.LF.Visible = true;
            this.LF.VisibleIndex = 24;
            // 
            // MIC
            // 
            this.MIC.Caption = "MIC";
            this.MIC.FieldName = "MIC";
            this.MIC.Name = "MIC";
            this.MIC.Visible = true;
            this.MIC.VisibleIndex = 25;
            // 
            // NFRD
            // 
            this.NFRD.Caption = "NFRD";
            this.NFRD.FieldName = "NFRD";
            this.NFRD.Name = "NFRD";
            this.NFRD.Visible = true;
            this.NFRD.VisibleIndex = 26;
            // 
            // NING
            // 
            this.NING.Caption = "NING";
            this.NING.FieldName = "NING";
            this.NING.Name = "NING";
            this.NING.Visible = true;
            this.NING.VisibleIndex = 27;
            // 
            // RD
            // 
            this.RD.Caption = "RD";
            this.RD.FieldName = "RD";
            this.RD.Name = "RD";
            this.RD.Visible = true;
            this.RD.VisibleIndex = 28;
            // 
            // ST
            // 
            this.ST.Caption = "ST";
            this.ST.FieldName = "ST";
            this.ST.Name = "ST";
            this.ST.Visible = true;
            this.ST.VisibleIndex = 29;
            // 
            // UNIF
            // 
            this.UNIF.Caption = "UNIF";
            this.UNIF.FieldName = "UNIF";
            this.UNIF.Name = "UNIF";
            this.UNIF.Visible = true;
            this.UNIF.VisibleIndex = 30;
            // 
            // cbo_ubicacion
            // 
            this.cbo_ubicacion.AutoHeight = false;
            this.cbo_ubicacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_ubicacion.Name = "cbo_ubicacion";
            this.cbo_ubicacion.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(970, 439);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dgv_Pesado;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(960, 405);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_documento_inventario;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(330, 24);
            this.layoutControlItem2.Text = "Documento de inventario a revertir";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(168, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(330, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(630, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmAlmacenRevertirIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.botonAceptar.Texto = "";
            this.botonBuscar.Texto = "Actualizar";
            this.botonBuscar.Visible = true;
            this.botonExportar.Visible = true;
            this.botonPersonalizado1.Texto = "Nuevo ingreso";
            this.botonPersonalizado10.Imagen = global::AlmacenControlStock.Properties.Resources._35690___anticlockwise_arrow_rotate;
            this.botonPersonalizado10.Texto = "Revertir movimiento";
            this.botonPersonalizado10.Visible = true;
            this.botonReporte.EnableModoBuscar = false;
            this.botonReporte.EnableModoNuevo = false;
            this.ClientSize = new System.Drawing.Size(974, 468);
            this.Controls.Add(this.pnl_Principal);
            this.KeyPreview = true;
            this.MostrarEstadoFormulario = false;
            this.Name = "FrmAlmacenRevertirIngreso";
            this.Text = "Revertir movimiento de ingreso";
            this.Click_Personalizado10 += new System.EventHandler(this.FrmAlmacenRevertirIngreso_Click_Personalizado10);
            this.Activated += new System.EventHandler(this.Frm_Activated);
            this.Deactivate += new System.EventHandler(this.Frm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Controls.SetChildIndex(this.pnl_Principal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Principal)).EndInit();
            this.pnl_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_documento_inventario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Pesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl_Principal;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UcDataGridView dgv_Pesado;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Pesado;
        private DevExpress.XtraGrid.Columns.GridColumn pea_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn tar_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn tmo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn articulo;
        private DevExpress.XtraGrid.Columns.GridColumn stm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn articulo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn lote;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre_exactus;
        private DevExpress.XtraGrid.Columns.GridColumn pmd_peso_bruto;
        private DevExpress.XtraGrid.Columns.GridColumn pmd_peso_neto;
        private DevExpress.XtraGrid.Columns.GridColumn pmd_peso_tara;
        private DevExpress.XtraGrid.Columns.GridColumn pea_nro_control;
        private DevExpress.XtraGrid.Columns.GridColumn pea_produccion_nro;
        private DevExpress.XtraGrid.Columns.GridColumn pea_referencia;
        private DevExpress.XtraGrid.Columns.GridColumn tmo_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn tar_codigo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn pmd_nro_pieza;
        private DevExpress.XtraGrid.Columns.GridColumn lote_crudo;
        private DevExpress.XtraGrid.Columns.GridColumn pea_documento_inv;
        private DevExpress.XtraGrid.Columns.GridColumn pea_fecha_documento_inv;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbo_ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn b;
        private DevExpress.XtraGrid.Columns.GridColumn CAT;
        private DevExpress.XtraGrid.Columns.GridColumn GPT;
        private DevExpress.XtraGrid.Columns.GridColumn GR;
        private DevExpress.XtraGrid.Columns.GridColumn LEN;
        private DevExpress.XtraGrid.Columns.GridColumn LF;
        private DevExpress.XtraGrid.Columns.GridColumn MIC;
        private DevExpress.XtraGrid.Columns.GridColumn NFRD;
        private DevExpress.XtraGrid.Columns.GridColumn NING;
        private DevExpress.XtraGrid.Columns.GridColumn RD;
        private DevExpress.XtraGrid.Columns.GridColumn ST;
        private DevExpress.XtraGrid.Columns.GridColumn UNIF;
        private DevExpress.XtraGrid.Columns.GridColumn bpu_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn nro_etiqueta;
        private UcTextBox txt_documento_inventario;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}