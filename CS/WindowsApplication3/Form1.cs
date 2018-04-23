using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;


namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0;i < 5;i++) {
                dataSet11.Tables[0].Rows.Add(new object[] { i, i, i, i, i, i, i, i, i ,i});
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
        }
    }

    public class MyGridControl: GridControl {
        protected override BaseView CreateDefaultView() {
            return CreateView("MyGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridView: GridView {
        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }
        protected override string ViewName { get { return "MyGridView"; } }
    }

    public class MyGridViewInfo: GridViewInfo {
        public MyGridViewInfo(GridView gridView) : base(gridView) { }

        protected override GroupPanelRow CalcGroupPanelRowDrawInfo(Rectangle bounds, bool showCaption, bool lineStyle) {
            GroupPanelRow groupPanelRow = base.CalcGroupPanelRowDrawInfo(bounds, showCaption, lineStyle);
            if(groupPanelRow.ColumnsInfo.Count > 1) {
                int y = groupPanelRow.ColumnsInfo[0].Bounds.Y;
                foreach(GridColumnInfoArgs args in groupPanelRow.ColumnsInfo) {
                    args.Bounds = new Rectangle(args.Bounds.X, y, args.Bounds.Width, args.Bounds.Height);
                }
            }
            return groupPanelRow;
        }

        protected override int CalcGroupPanelHeight() {
            base.CalcGroupPanelHeight();
            return GroupLineDY * 2 + ColumnRowHeight;
        }
    }

    public class MyGridViewInfoRegistrator: GridInfoRegistrator {
        public override string ViewName { get { return "MyGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyGridViewInfo(view as MyGridView); }
    }
}
