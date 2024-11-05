using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using GrapeCity.Win.MultiTouch;
using System.Windows;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class WPF_ElementHostZoomPolicy : NoZoomFontZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(ElementHost); }
        }

        public override bool CanZoomChildren(System.Windows.Forms.Control control)
        {
            return false;
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            ElementHost host = control as ElementHost;
            if (host.Child is FrameworkElement)
            {
                (host.Child as FrameworkElement).LayoutTransform = new ScaleTransform(infos.TargetFactor, infos.TargetFactor);
            }
            base.ZoomBounds(control, infos);
        }
    }
}

