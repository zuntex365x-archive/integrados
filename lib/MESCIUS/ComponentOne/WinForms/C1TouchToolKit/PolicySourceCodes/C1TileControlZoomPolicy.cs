using System;
using System.Collections.Generic;
using System.Windows.Forms;
using C1.Win.C1Tile;
using GrapeCity.Win.MultiTouch;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class C1TileControlZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1TileControl); }
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1TileControl tileControl = control as C1TileControl;
            tileControl.CellWidth = infos.Zoom(tileControl.CellWidth);
            tileControl.CellHeight = infos.Zoom(tileControl.CellHeight);
            tileControl.CellSpacing = infos.Zoom(tileControl.CellSpacing);

            tileControl.Padding = ZoomPadding(tileControl.Padding, infos);
            tileControl.GroupPadding = ZoomPadding(tileControl.GroupPadding, infos);

            foreach (Template template in tileControl.Templates)
            {
                ElementCollection elements = template.Elements;
                foreach (BaseElement templateElement in GetTemplateElements(elements))
                {
                    templateElement.FixedWidth = infos.Zoom(templateElement.FixedWidth);
                    templateElement.FixedHeight = infos.Zoom(templateElement.FixedHeight);
                    templateElement.Margin = new Padding(
                        infos.Zoom(templateElement.Margin.Left),
                        infos.Zoom(templateElement.Margin.Top),
                        infos.Zoom(templateElement.Margin.Right),
                        infos.Zoom(templateElement.Margin.Bottom));
                }
            }
            base.ZoomBounds(control, infos);
        }

        private Padding ZoomPadding(Padding padding, ZoomBoundsInfo infos)
        {
            if (padding.All != -1)
            {
                return new Padding(infos.Zoom(padding.All));
            }
            else
            {
                return new Padding(
                    infos.Zoom(padding.Left),
                    infos.Zoom(padding.Top),
                    infos.Zoom(padding.Right),
                    infos.Zoom(padding.Bottom));
            }
        }

        public IEnumerable<BaseElement> GetTemplateElements(ElementCollection elements)
        {
            List<BaseElement> list = new List<BaseElement>();
            foreach (BaseElement element in elements)
            {
                list.Add(element);
                PanelElement panelElement = element as PanelElement;
                if (panelElement != null)
                {
                    list.AddRange(GetTemplateElements(panelElement.Children));
                }
            }
            return list;
        }

        public override void ZoomFont(Control control, ZoomFontInfo infos)
        {
            C1TileControl tileControl = control as C1TileControl;
            foreach (Template template in tileControl.Templates)
            {
                ElementCollection elements = template.Elements;
                foreach (BaseElement templateElement in GetTemplateElements(elements))
                {
                    TextElement textElement = templateElement as TextElement;
                    if (textElement != null) textElement.FontSize = textElement.FontSize * infos.DeltaFactor;
                }

            }
            tileControl.TextSize = tileControl.TextSize * infos.DeltaFactor;
            tileControl.GroupTextSize = tileControl.GroupTextSize * infos.DeltaFactor;
            base.ZoomFont(control, infos);
        }
    }
}
