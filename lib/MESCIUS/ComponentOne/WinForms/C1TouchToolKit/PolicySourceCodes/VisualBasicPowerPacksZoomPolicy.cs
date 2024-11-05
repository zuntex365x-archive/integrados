using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GrapeCity.Win.MultiTouch;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class ShapeContainerZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(ShapeContainer); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            ShapeContainer shapeContainer = control as ShapeContainer;
            foreach (Shape shape in shapeContainer.Shapes)
            {
                if (shape is SimpleShape)
                {
                    SimpleShape simpleShape = shape as SimpleShape;
                    simpleShape.Bounds = infos.Zoom(simpleShape.Bounds);
                }
                else if (shape is LineShape)
                {
                    LineShape lineShape = shape as LineShape;
                    lineShape.StartPoint = infos.Zoom(lineShape.StartPoint);
                    lineShape.EndPoint = infos.Zoom(lineShape.EndPoint);
                }
            }
            base.ZoomBounds(control, infos);
        }
    }
}
