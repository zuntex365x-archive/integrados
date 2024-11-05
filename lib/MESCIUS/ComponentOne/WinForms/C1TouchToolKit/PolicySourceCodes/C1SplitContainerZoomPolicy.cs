
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SplitContainer;
using GrapeCity.Win.MultiTouch;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class C1SplitContainerZoomPolicy : ZoomPolicy
    {
        Dictionary<C1SplitContainer, CacheValue> _originalValueCache = new Dictionary<C1SplitContainer, CacheValue>();

        public override Type TargetType
        {
            get { return typeof(C1SplitContainer); }
        }

        public override void Initialize(Control control)
        {
            control.SuspendLayout();
            base.Initialize(control);
        }

        public override void Terminate(Control control)
        {
            control.ResumeLayout(true);
            base.Terminate(control);
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1SplitContainer splitContainer = control as C1SplitContainer;
            // C1SplitContainerの一部のプロパティで一定以上に大きい値を設定することはできません。例えば、HeaderHeightプロパティの設定可能な最大値は100です。
            // HeaderHeightプロパティが30の場合、4倍にズームすると120になりますが、最大値の制限によって実際には100が設定されます。
            // その後、1/4のサイズにズームを戻すと、HeaderHeightプロパティは最初の30ではなく25に変更されます。
            if (infos.CurrentFactor == 1f)
            {
                CacheValue cacheValue = new CacheValue();
                cacheValue.HeaderHeight = splitContainer.HeaderHeight;
                cacheValue.SplitterWidth = splitContainer.SplitterWidth;
                cacheValue.FixedLineWidth = splitContainer.FixedLineWidth;
                cacheValue.HeaderTextOffset = splitContainer.HeaderTextOffset;
                cacheValue.HeaderLineWidth = splitContainer.HeaderLineWidth;

                _originalValueCache[splitContainer] = cacheValue;
            }

            if (_originalValueCache.ContainsKey(splitContainer))
            {
                CacheValue cacheValue = _originalValueCache[splitContainer];
                splitContainer.HeaderHeight = (int)Math.Round(cacheValue.HeaderHeight * infos.TargetFactor);
                splitContainer.SplitterWidth = (int)Math.Round(cacheValue.SplitterWidth * infos.TargetFactor);
                splitContainer.FixedLineWidth = (int)Math.Round(cacheValue.FixedLineWidth * infos.TargetFactor);
                splitContainer.HeaderTextOffset = (int)Math.Round(cacheValue.HeaderTextOffset * infos.TargetFactor);
                splitContainer.HeaderLineWidth = (int)Math.Round(cacheValue.HeaderLineWidth * infos.TargetFactor);
            }
            else
            {
                splitContainer.HeaderHeight = infos.Zoom(splitContainer.HeaderHeight);
                splitContainer.SplitterWidth = infos.Zoom(splitContainer.SplitterWidth);
                splitContainer.FixedLineWidth = infos.Zoom(splitContainer.FixedLineWidth);
                splitContainer.HeaderTextOffset = infos.Zoom(splitContainer.HeaderTextOffset);
                splitContainer.HeaderLineWidth = infos.Zoom(splitContainer.HeaderLineWidth);
            }


            base.ZoomBounds(control, infos);
        }

        private class CacheValue
        {
            public int HeaderHeight { get; set; }
            public int SplitterWidth { get; set; }
            public int FixedLineWidth { get; set; }
            public int HeaderTextOffset { get; set; }
            public int HeaderLineWidth { get; set; }
        }
    }

    public class C1SplitPanelZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1SplitterPanel); }
        }
        private class CacheValue
        {
            public Size SizeOffSet { get; set; }
            public bool Visible { get; set; }
        }
        private readonly Dictionary<C1SplitterPanel, CacheValue> sizeOffsetCache = new Dictionary<C1SplitterPanel, CacheValue>();
        public override void Initialize(Control control)
        {
            base.Initialize(control);
            C1SplitterPanel splitPanel = (C1SplitterPanel)control;
            var cache = new CacheValue();
            cache.SizeOffSet = new Size(splitPanel.Width - splitPanel.Bounds.Width, splitPanel.Height - splitPanel.Bounds.Height - (splitPanel.SplitContainer != null ? (splitPanel.SplitContainer).HeaderHeight : 0));
            cache.Visible = splitPanel.Visible;
            sizeOffsetCache[splitPanel] = cache;
            splitPanel.Visible = true;
        }

        public override void Terminate(Control control)
        {
            C1SplitterPanel splitPanel = (C1SplitterPanel)control;
            splitPanel.Visible = sizeOffsetCache[splitPanel].Visible;
            base.Terminate(control);
            sizeOffsetCache.Remove(splitPanel);
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {

            C1SplitterPanel splitPanel = (C1SplitterPanel)control;
            splitPanel.Width = infos.Zoom(infos.CurrentBounds).Width + sizeOffsetCache[splitPanel].SizeOffSet.Width;
            splitPanel.Height = infos.Zoom(infos.CurrentBounds).Height + sizeOffsetCache[splitPanel].SizeOffSet.Height + (splitPanel.SplitContainer != null ? (splitPanel.SplitContainer).HeaderHeight : 0);

        }

        public override void ZoomFont(Control control, ZoomFontInfo infos)
        {
            // block base logic
        }

        public override IEnumerable<Control> GetChildren(Control control)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in control.Controls)
            {
                if (child is C1SplitContainer)
                {
                    controls.AddRange(GetChildren(child));
                    continue;
                }
                controls.Add(child);
            }
            return controls;
        }
    }
}
