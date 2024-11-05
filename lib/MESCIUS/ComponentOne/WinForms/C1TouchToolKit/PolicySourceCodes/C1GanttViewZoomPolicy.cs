using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using C1.Win.C1GanttView;
using GrapeCity.Win.MultiTouch;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class C1GanttViewZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1.Win.C1GanttView.C1GanttView); }
        }

        private Dictionary<C1GanttView, int> _ganttViewGridWidthCache = new Dictionary<C1GanttView, int>();

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1GanttView ganttView = control as C1GanttView;
            SetGanttviewWidth(ganttView,infos.Zoom(GetGanttViewGridWidth(ganttView)));
            ganttView.Timescale.BottomTier.MinWidth = infos.Zoom(ganttView.Timescale.BottomTier.MinWidth);
            ganttView.Timescale.TopTier.MinWidth = infos.Zoom(ganttView.Timescale.TopTier.MinWidth);
            ganttView.Timescale.MiddleTier.MinWidth = infos.Zoom(ganttView.Timescale.MiddleTier.MinWidth);
            foreach (BaseColumn column in ganttView.Columns)
            {
                if (column.Width > 0)
                {
                    column.Width = infos.Zoom(column.Width);
                }
            }
            base.ZoomBounds(control, infos);
        }

        private void SetGanttviewWidth(C1GanttView ganttView, int value)
        {
            _ganttViewGridWidthCache[ganttView] = value;
            ganttView.GridWidth = value;
        }

        private int GetGanttViewGridWidth(C1GanttView ganttView)
        {
            int value;
            if (_ganttViewGridWidthCache.TryGetValue(ganttView, out value) && (value == ganttView.GridWidth || (value < 80 && ganttView.GridWidth == 80)))
            {
                return value;
            }
            else
            {
                _ganttViewGridWidthCache[ganttView] = ganttView.GridWidth;
                return ganttView.GridWidth;
            }
        }
    }
}
