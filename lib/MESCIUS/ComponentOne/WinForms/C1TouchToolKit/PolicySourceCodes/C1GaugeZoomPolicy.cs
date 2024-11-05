using System;
using System.Collections.Generic;
using System.Text;
using C1.Win.C1Gauge;
using GrapeCity.Win.MultiTouch;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class C1GaugeZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1Gauge); }
        }

        #region Zoom Bounds

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1Gauge gauge = control as C1Gauge;
            ZoomGaugeBaseViewport(infos, gauge.Viewport);
            ZoomGauges(infos, gauge.Gauges);
            ZoomFaceShapes(infos, gauge.FaceShapes);

            base.ZoomBounds(control, infos);
        }


        private static void ZoomFaceShapes(ZoomBoundsInfo infos, ShapeCollection shapes)
        {
            if (shapes == null)
            {
                return;
            }
            foreach (C1GaugeBaseShape shape in shapes)
            {
                ZoomGaugeBaseViewport(infos, shape.Viewport);
            }
        }

        private static void ZoomGauges(ZoomBoundsInfo infos, GaugeCollection gauges)
        {
            if (gauges == null)
            {
                return;
            }
            foreach (C1GaugeBase subGauge in gauges)
            {
                ZoomGaugeBaseViewport(infos, subGauge.Viewport);
                ZoomFaceShapes(infos, subGauge.FaceShapes);
            }
        }

        private static void ZoomGaugeBaseViewport(ZoomBoundsInfo infos, C1GaugeViewport viewport)
        {
            viewport.X = infos.Zoom(viewport.X);
            viewport.Y = infos.Zoom(viewport.Y);
            viewport.Width = infos.Zoom(viewport.Width);
            viewport.Height = infos.Zoom(viewport.Height);
            viewport.MarginX = infos.Zoom(viewport.MarginX);
            viewport.MarginY = infos.Zoom(viewport.MarginY);
        }

        #endregion

        #region Zoom Font

        public override void ZoomFont(System.Windows.Forms.Control control, ZoomFontInfo infos)
        {
            C1Gauge gauge = control as C1Gauge;
            ZoomGaugesFont(infos, gauge.Gauges);
            ZoomFaceShapesFont(infos, gauge.FaceShapes);

            base.ZoomFont(control, infos);
        }

        private void ZoomFaceShapesFont(ZoomFontInfo infos, ShapeCollection shapes)
        {
            if (shapes == null)
            {
                return;
            }
            foreach (C1GaugeBaseShape shape in shapes)
            {
                ZoomGaugeCaptionFont(infos, shape);
            }
        }

        private void ZoomGaugesFont(ZoomFontInfo infos, GaugeCollection gauges)
        {
            foreach (C1GaugeBase subGauge in gauges)
            {
                ZoomDecoratorsFont(infos, subGauge);
                ZoomFaceShapesFont(infos, subGauge.FaceShapes);
            }
        }

        private static void ZoomDecoratorsFont(ZoomFontInfo infos, C1GaugeBase subGauge)
        {
            foreach (C1GaugeDecorator decorator in subGauge.Decorators)
            {
                ZoomDecoratorLableFont(infos, decorator);
            }
        }

        private static void ZoomDecoratorLableFont(ZoomFontInfo infos, C1GaugeDecorator decorator)
        {
            C1GaugeSingleLabel lable = decorator as C1GaugeSingleLabel;
            if (lable != null)
            {
                lable.Font = infos.Zoom(lable.Font);
            }
        }

        private static void ZoomGaugeCaptionFont(ZoomFontInfo infos, C1GaugeBaseShape shape)
        {
            C1GaugeCaption caption = shape as C1GaugeCaption;
            if (caption == null)
            {
                return;
            }
            caption.Font = infos.Zoom(caption.Font);
        }

        #endregion
    }
}
