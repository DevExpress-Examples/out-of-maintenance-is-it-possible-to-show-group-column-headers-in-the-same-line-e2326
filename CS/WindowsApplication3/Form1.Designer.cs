namespace WindowsApplication3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new WindowsApplication3.DataSet1();
            this.myGridControl1 = new WindowsApplication3.MyGridControl();
            this.myGridView1 = new WindowsApplication3.MyGridView();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "CustomerInfo";
            this.customerInfoBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.customerInfoBindingSource;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.LookAndFeel.SkinName = "Blue";
            this.myGridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(583, 444);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColumn1,
            this.colColumn2,
            this.colColumn3,
            this.colColumn4,
            this.colColumn5,
            this.colColumn6,
            this.colColumn7,
            this.colColumn8,
            this.colColumn9,
            this.colColumn10});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.GroupCount = 4;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colColumn3, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colColumn4, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colColumn5, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colColumn6, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colColumn1
            // 
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 0;
            this.colColumn1.Width = 96;
            // 
            // colColumn2
            // 
            this.colColumn2.FieldName = "Column2";
            this.colColumn2.Name = "colColumn2";
            this.colColumn2.Visible = true;
            this.colColumn2.VisibleIndex = 2;
            // 
            // colColumn3
            // 
            this.colColumn3.FieldName = "Column3";
            this.colColumn3.Name = "colColumn3";
            // 
            // colColumn4
            // 
            this.colColumn4.FieldName = "Column4";
            this.colColumn4.Name = "colColumn4";
            this.colColumn4.Visible = true;
            this.colColumn4.VisibleIndex = 1;
            // 
            // colColumn5
            // 
            this.colColumn5.FieldName = "Column5";
            this.colColumn5.Name = "colColumn5";
            this.colColumn5.Visible = true;
            this.colColumn5.VisibleIndex = 2;
            // 
            // colColumn6
            // 
            this.colColumn6.FieldName = "Column6";
            this.colColumn6.Name = "colColumn6";
            this.colColumn6.Visible = true;
            this.colColumn6.VisibleIndex = 3;
            // 
            // colColumn7
            // 
            this.colColumn7.FieldName = "Column7";
            this.colColumn7.Name = "colColumn7";
            this.colColumn7.Visible = true;
            this.colColumn7.VisibleIndex = 1;
            // 
            // colColumn8
            // 
            this.colColumn8.FieldName = "Column8";
            this.colColumn8.Name = "colColumn8";
            this.colColumn8.Visible = true;
            this.colColumn8.VisibleIndex = 3;
            // 
            // colColumn9
            // 
            this.colColumn9.FieldName = "Column9";
            this.colColumn9.Name = "colColumn9";
            this.colColumn9.Visible = true;
            this.colColumn9.VisibleIndex = 4;
            // 
            // colColumn10
            // 
            this.colColumn10.FieldName = "Column10";
            this.colColumn10.Name = "colColumn10";
            this.colColumn10.Visible = true;
            this.colColumn10.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 444);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private DataSet1 dataSet11;
        private MyGridControl myGridControl1;
        private MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn10;
    }
}

