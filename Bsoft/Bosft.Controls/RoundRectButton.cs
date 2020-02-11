using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Controls
{
    public partial class RoundRectButton : Button
    {
        public RoundRectButton()
        {
            InitializeComponent();
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize =0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        Image _BackgroundImage, _ButtonDisabledImage, _ButtonFocusImage;
        Image _ButtonHoverImage, _ButtonPressedImage;
        Color _DashLineColor, _DisableForeColor;
        int _DashLineWidth, _WidthEllipse, _HeightEllipse;
       

        protected override void OnMouseEnter(EventArgs e)
        {
            BackgroundImage = _ButtonHoverImage;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackgroundImage = _BackgroundImage ;
            base.OnMouseLeave(e);
        }
        public Image ButtonImage { get { return _BackgroundImage; } set { _BackgroundImage = value; BackgroundImage = value; } }
        public Image ButtonDisabledImage { get { return _ButtonDisabledImage; } set { _ButtonDisabledImage = value; } }
        public Image ButtonFocusImage { get { return _ButtonFocusImage; } set { _ButtonFocusImage = value; } }
        public Image ButtonHoverImage { get { return _ButtonHoverImage; } set { _ButtonHoverImage = value; } }
        public Image ButtonPressedImage { get { return _ButtonPressedImage; } set { _ButtonPressedImage = value; } }
        
        public Color DashLineColor { get { return _DashLineColor; } set { _DashLineColor = value; } }
        public int DashLineWidth { get { return _DashLineWidth; } set { _DashLineWidth = value; } }
        public Color DisableForeColor { get { return _DisableForeColor; } set { _DisableForeColor = value; } }
        public int HeightEllipse { get { return _HeightEllipse; } set { _HeightEllipse = value; } }
        //  protected override bool ShowFocusCues { get{} }
        public int WidthEllipse { get { return _WidthEllipse; } set { _WidthEllipse = value; } }
    }
}
