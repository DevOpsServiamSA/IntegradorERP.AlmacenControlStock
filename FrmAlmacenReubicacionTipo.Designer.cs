
namespace AlmacenControlStock
{
    partial class FrmAlmacenReubicacionTipo
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
            ucCombobox.Global.EstadoControl estadoControl1 = new ucCombobox.Global.EstadoControl();
            ucCombobox.Global.EstadoControl estadoControl2 = new ucCombobox.Global.EstadoControl();
            ucCombobox.Global.EstadoControl estadoControl3 = new ucCombobox.Global.EstadoControl();
            ucCombobox.Global.EstadoControl estadoControl4 = new ucCombobox.Global.EstadoControl();
            ucCombobox.Global.EstadoControl estadoControl5 = new ucCombobox.Global.EstadoControl();
            ucCombobox.Global.EstadoControl estadoControl6 = new ucCombobox.Global.EstadoControl();
            this.pnl_Principal = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cbo_modo = new UcCombobox();
            this.cbo_balanza = new UcCombobox();
            this.lyt_balanza = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Principal)).BeginInit();
            this.pnl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_modo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_balanza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyt_balanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Controls.Add(this.layoutControl1);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 25);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(328, 62);
            this.pnl_Principal.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.cbo_modo);
            this.layoutControl1.Controls.Add(this.cbo_balanza);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(790, 264, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(324, 58);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyt_balanza,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.Root.Size = new System.Drawing.Size(324, 58);
            this.Root.TextVisible = false;
            // 
            // cbo_modo
            // 
            this.cbo_modo.EnterMoveNextControl = true;
            this.cbo_modo.EstadoBuscar = estadoControl1;
            this.cbo_modo.EstadoEdicion = estadoControl2;
            this.cbo_modo.EstadoNuevo = estadoControl3;
            this.cbo_modo.Location = new System.Drawing.Point(72, 7);
            this.cbo_modo.Name = "cbo_modo";
            this.cbo_modo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbo_modo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbo_modo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbo_modo.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.cbo_modo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbo_modo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_modo.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F1);
            this.cbo_modo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion")});
            this.cbo_modo.Properties.NullText = "";
            this.cbo_modo.Properties.ShowFooter = false;
            this.cbo_modo.Properties.ShowHeader = false;
            this.cbo_modo.Size = new System.Drawing.Size(245, 20);
            this.cbo_modo.StyleController = this.layoutControl1;
            this.cbo_modo.TabIndex = 0;
            this.cbo_modo.EditValueChanged += new System.EventHandler(this.cbo_modo_EditValueChanged);
            // 
            // cbo_balanza
            // 
            this.cbo_balanza.EnterMoveNextControl = true;
            this.cbo_balanza.EstadoBuscar = estadoControl4;
            this.cbo_balanza.EstadoEdicion = estadoControl5;
            this.cbo_balanza.EstadoNuevo = estadoControl6;
            this.cbo_balanza.Location = new System.Drawing.Point(72, 31);
            this.cbo_balanza.Name = "cbo_balanza";
            this.cbo_balanza.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Cornsilk;
            this.cbo_balanza.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbo_balanza.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbo_balanza.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.cbo_balanza.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbo_balanza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_balanza.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F1);
            this.cbo_balanza.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PUERTO", "PUERTO", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "NOMBRE")});
            this.cbo_balanza.Properties.NullText = "";
            this.cbo_balanza.Properties.ShowFooter = false;
            this.cbo_balanza.Properties.ShowHeader = false;
            this.cbo_balanza.Size = new System.Drawing.Size(245, 20);
            this.cbo_balanza.StyleController = this.layoutControl1;
            this.cbo_balanza.TabIndex = 1;
            this.cbo_balanza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_balanza_KeyDown);
            // 
            // lyt_balanza
            // 
            this.lyt_balanza.Control = this.cbo_balanza;
            this.lyt_balanza.Location = new System.Drawing.Point(0, 24);
            this.lyt_balanza.MaxSize = new System.Drawing.Size(0, 24);
            this.lyt_balanza.MinSize = new System.Drawing.Size(96, 24);
            this.lyt_balanza.Name = "lyt_balanza";
            this.lyt_balanza.Size = new System.Drawing.Size(314, 24);
            this.lyt_balanza.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lyt_balanza.Text = "Balanza";
            this.lyt_balanza.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lyt_balanza.TextSize = new System.Drawing.Size(60, 13);
            this.lyt_balanza.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbo_modo;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 24);
            this.layoutControlItem2.Text = "Modo";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 20);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // FrmAlmacenReubicacionTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.botonAceptar.Visible = true;
            this.botonEliminar.Texto = "";
            this.botonReporte.EnableModoBuscar = false;
            this.botonReporte.EnableModoNuevo = false;
            this.ClientSize = new System.Drawing.Size(328, 87);
            this.Controls.Add(this.pnl_Principal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MostrarEstadoFormulario = false;
            this.Name = "FrmAlmacenReubicacionTipo";
            this.Text = "Seleccione un modo";
            this.Click_Aceptar += new System.EventHandler(this.FrmAlmacenPesadoProductoProcesoBalanza_Click_Aceptar);
            this.Activated += new System.EventHandler(this.Frm_Activated);
            this.Deactivate += new System.EventHandler(this.Frm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.Controls.SetChildIndex(this.pnl_Principal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Principal)).EndInit();
            this.pnl_Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_modo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_balanza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyt_balanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnl_Principal;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UcCombobox cbo_balanza;
        private DevExpress.XtraLayout.LayoutControlItem lyt_balanza;
        private UcCombobox cbo_modo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}