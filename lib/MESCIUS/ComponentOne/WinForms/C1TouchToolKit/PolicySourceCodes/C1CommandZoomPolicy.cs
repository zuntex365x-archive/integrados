using C1.Win.C1Command;
using GrapeCity.Win.MultiTouch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrapeCity.Win.MultiTouch.ZoomPolicys
{
    public class C1MainMenuZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1MainMenu); }
        }
        
        public override IEnumerable<Control> GetChildren(Control control)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in control.Controls)
            {
                controls.Add(child);
            }
            C1MainMenu menu = control as C1MainMenu;
            AddChildren(controls, menu.CommandLinks);
            return controls;
        }

        private void AddChildren(List<Control> controls, C1CommandLinks commandLinks)
        {
            foreach (C1CommandLink commandLink in commandLinks)
            {
                if (commandLink.Command is C1CommandMenu)
                {
                    C1CommandMenu commandMenu = commandLink.Command as C1CommandMenu;
                    AddChildren(controls, commandMenu.CommandLinks);
                    continue;
                }
                else if (commandLink.Command is C1CommandControl)
                {
                    C1CommandControl commandControl = commandLink.Command as C1CommandControl;
                    if (commandControl.Control != null && !controls.Contains(commandControl.Control))
                    {
                        controls.Add(commandControl.Control);
                    }
                }
            }
        }

        
        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            C1MainMenu menu = control as C1MainMenu;
            ZoomCommandLinksBounds(infos, menu.CommandLinks);
        }

        public override void ZoomFont(Control control, ZoomFontInfo infos)
        {
            control.Font = infos.Zoom(control.Font);
            C1MainMenu menu = control as C1MainMenu;
            ZoomCommandLinksFont(infos, menu.CommandLinks);
        }


        private void ZoomCommandLinksFont(ZoomFontInfo infos, C1CommandLinks commandLinks)
        {
            foreach (C1CommandLink commandLink in commandLinks)
            {
                if (commandLink.Command is C1CommandMenu)
                {
                    C1CommandMenu commandMenu = commandLink.Command as C1CommandMenu;
                    if (!SystemInformation.MenuFont.Equals(commandMenu.Font))
                    {
                        commandMenu.Font = infos.Zoom(commandMenu.Font);
                    }
                    ZoomCommandLinksFont(infos, commandMenu.CommandLinks);
                    continue;
                }
            }
        }

        private void ZoomCommandLinksBounds(ZoomBoundsInfo infos, C1CommandLinks commandLinks)
        {
            foreach (C1CommandLink commandLink in commandLinks)
            {
                if (commandLink.Command is C1CommandMenu)
                {
                    C1CommandMenu commandMenu = commandLink.Command as C1CommandMenu;
                    ZoomCommandLinksBounds(infos, commandMenu.CommandLinks);
                    return;
                }
            }
        }

    }

    public class C1DockingTabZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1DockingTab); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            base.ZoomBounds(control, infos);
            C1DockingTab dockingTab = control as C1DockingTab;
            try
            {
                dockingTab.ItemSize = infos.Zoom(dockingTab.ItemSize);
            }
            catch (Exception)
            {

                // ドッキングタブが閉じている場合、ItemSizeプロパティの設定で例外が発生する場合があります。
                // 例外が発生する場合は、ItemSize プロパティにSize.Emptyを設定することで問題を回避できます。
                dockingTab.ItemSize = Size.Empty;
            }
            dockingTab.SplitterWidth = infos.Zoom(dockingTab.SplitterWidth);
            dockingTab.TabsSpacing = infos.Zoom(dockingTab.TabsSpacing);
            dockingTab.TabAreaSpacing = infos.Zoom(dockingTab.TabAreaSpacing);
        }
        
    }
    
    public class C1NavBarZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1NavBar); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            base.ZoomBounds(control, infos);
            C1NavBar navBar = control as C1NavBar;
            if (navBar.ButtonHeight > 0)
            {
                navBar.ButtonHeight = infos.Zoom(navBar.ButtonHeight);
            }
            if (navBar.ImageIndent > 0)
            {
                navBar.ImageIndent = infos.Zoom(navBar.ImageIndent);
            }
            if (navBar.PanelHeaderHeight > 0)
            {
                navBar.PanelHeaderHeight = infos.Zoom(navBar.PanelHeaderHeight);
            }
            if (navBar.SectionHeaderHeight > 0)
            {
                navBar.SectionHeaderHeight = infos.Zoom(navBar.SectionHeaderHeight);
            }
            if (navBar.SectionHeaderIndent > 0)
            {
                navBar.SectionHeaderIndent = infos.Zoom(navBar.SectionHeaderIndent);
            }
            if (navBar.StripHeight > 0)
            {
                navBar.StripHeight = infos.Zoom(navBar.StripHeight);
            }


            if (!navBar.ImageScalingSize.IsEmpty)
            {
                navBar.ImageScalingSize = infos.Zoom(navBar.ImageScalingSize);
            }
        }

        public override void ZoomFont(Control control, ZoomFontInfo infos)
        {
            base.ZoomFont(control, infos);

            C1NavBar navBar = control as C1NavBar;
            if (navBar.ButtonFont != null)
            {
                navBar.ButtonFont = infos.Zoom(navBar.ButtonFont);
            }
            if (navBar.PanelHeaderFont != null)
            {
                navBar.PanelHeaderFont = infos.Zoom(navBar.PanelHeaderFont);
            }
            if (navBar.SectionHeaderFont != null)
            {
                navBar.SectionHeaderFont = infos.Zoom(navBar.SectionHeaderFont);
            }
        }
    }

    public class C1OutBarZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1OutBar); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            C1OutBar outBar = control as C1OutBar;
            outBar.PageTitleHeight = infos.Zoom(outBar.PageTitleHeight);
            base.ZoomBounds(control, infos);
        }
    }

}
