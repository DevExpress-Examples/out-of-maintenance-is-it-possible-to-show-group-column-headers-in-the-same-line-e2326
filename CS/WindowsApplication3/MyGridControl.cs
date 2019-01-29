using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Drawing;
using System.Linq;

namespace WindowsApplication3
{
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridView : GridView
    {
        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

        protected override string ViewName { get { return "MyGridView"; } }
    }

    public class MyGridViewInfo : GridViewInfo
    {
        public MyGridViewInfo(GridView gridView) : base(gridView) { }

        protected override int CalcGroupPanelHeight()
        {
            base.CalcGroupPanelHeight();
            return GroupLineDY * 2 + ColumnRowHeight;
        }

        protected override GroupPanelRow CalcGroupPanelRowDrawInfo(Rectangle bounds, bool showCaption, bool lineStyle)
        {
            GroupPanelRow groupPanelRow = base.CalcGroupPanelRowDrawInfo(bounds, showCaption, lineStyle);
            if (groupPanelRow.ColumnsInfo.Count > 1)
            {
                int y = groupPanelRow.ColumnsInfo[0].Bounds.Y;
                foreach (GridColumnInfoArgs args in groupPanelRow.ColumnsInfo)
                {
                    args.Bounds = new Rectangle(args.Bounds.X, y, args.Bounds.Width, args.Bounds.Height);
                }
            }
            return groupPanelRow;
        }
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyGridViewInfo(view as MyGridView); }

        public override string ViewName { get { return "MyGridView"; } }
    }
}
